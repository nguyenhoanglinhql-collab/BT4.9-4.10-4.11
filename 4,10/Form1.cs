using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace _4_10
{
    public partial class Form1 : Form
    {
        private readonly BindingList<CheckoutRecord> _records = [];
        private readonly BindingList<CheckoutRecord> _visibleRecords = [];
        private readonly BindingSource _bindingSource = new();
        private ErrorProvider _errorProvider = null!;
        private TextBox _receiptIdTextBox = null!;
        private TextBox _studentIdTextBox = null!;
        private TextBox _studentNameTextBox = null!;
        private ComboBox _equipmentComboBox = null!;
        private NumericUpDown _quantityNumeric = null!;
        private DateTimePicker _checkoutDatePicker = null!;
        private DateTimePicker _dueDatePicker = null!;
        private DateTimePicker _returnDatePicker = null!;
        private Label _statusValueLabel = null!;
        private TextBox _searchTextBox = null!;
        private ComboBox _statusFilterComboBox = null!;
        private DataGridView _recordsGrid = null!;
        private ToolStripStatusLabel _summaryLabel = null!;
        private Button _addButton = null!;
        private Button _updateButton = null!;
        private Button _deleteButton = null!;
        private Button _markReturnedButton = null!;
        private Button _clearButton = null!;
        private Button _exportButton = null!;
        private readonly System.Windows.Forms.Timer _refreshTimer = new() { Interval = 60_000 };

        public Form1()
        {
            InitializeComponent();
            _bindingSource.DataSource = _visibleRecords;
            _recordsGrid.DataSource = _bindingSource;
            WireEvents();
            ApplyFilters();
            ClearEntry();
            _refreshTimer.Tick += (_, _) =>
            {
                ApplyFilters();
            };
            _refreshTimer.Start();
        }

        private void WireEvents()
        {
            _addButton.Click += (_, _) => AddRecord();
            _updateButton.Click += (_, _) => UpdateRecord();
            _deleteButton.Click += (_, _) => DeleteRecord();
            _markReturnedButton.Click += (_, _) => MarkSelectedAsReturned();
            _clearButton.Click += (_, _) => ClearEntry();
            _exportButton.Click += (_, _) => ExportCsv();
            _searchTextBox.TextChanged += (_, _) => ApplyFilters();
            _statusFilterComboBox.SelectedIndexChanged += (_, _) => ApplyFilters();
            _recordsGrid.SelectionChanged += (_, _) => LoadSelectedRecord();
            _checkoutDatePicker.ValueChanged += (_, _) => UpdateStatusPreview();
            _dueDatePicker.ValueChanged += (_, _) => UpdateStatusPreview();
            _returnDatePicker.ValueChanged += (_, _) => UpdateStatusPreview();
            _returnDatePicker.Click += (_, _) => UpdateStatusPreview();
            FormClosed += (_, _) => _refreshTimer.Stop();
        }

        private void AddRecord()
        {
            if (!TryBuildRecord(null, out var record))
            {
                return;
            }

            _records.Add(record);
            ApplyFilters(record);
            ClearEntry();
        }

        private void UpdateRecord()
        {
            var selected = GetSelectedRecord();
            if (selected is null)
            {
                MessageBox.Show(this, "Vui lòng chọn phiếu cần cập nhật.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!TryBuildRecord(selected, out var updated))
            {
                return;
            }

            selected.ReceiptId = updated.ReceiptId;
            selected.StudentId = updated.StudentId;
            selected.StudentName = updated.StudentName;
            selected.EquipmentName = updated.EquipmentName;
            selected.Quantity = updated.Quantity;
            selected.CheckoutDate = updated.CheckoutDate;
            selected.DueDate = updated.DueDate;
            selected.ActualReturnDate = updated.ActualReturnDate;
            ApplyFilters(selected);
        }

        private void DeleteRecord()
        {
            var selected = GetSelectedRecord();
            if (selected is null)
            {
                MessageBox.Show(this, "Vui lòng chọn phiếu cần xóa.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmation = MessageBox.Show(this, $"Bạn có chắc muốn xóa phiếu {selected.ReceiptId}?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            _records.Remove(selected);
            ApplyFilters();
            ClearEntry();
        }

        private void MarkSelectedAsReturned()
        {
            var selected = GetSelectedRecord();
            if (selected is null)
            {
                MessageBox.Show(this, "Vui lòng chọn phiếu cần đánh dấu đã trả.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (selected.ActualReturnDate is not null)
            {
                MessageBox.Show(this, "Phiếu này đã được trả.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            selected.ActualReturnDate = DateTime.Today;
            ApplyFilters(selected);
        }

        private bool TryBuildRecord(CheckoutRecord? existing, out CheckoutRecord record)
        {
            record = new CheckoutRecord();
            _errorProvider.Clear();
            var hasError = false;

            var receiptId = _receiptIdTextBox.Text.Trim();
            var studentId = _studentIdTextBox.Text.Trim();
            var equipment = _equipmentComboBox.SelectedItem as string;
            var actualReturnDate = _returnDatePicker.Checked ? _returnDatePicker.Value.Date : (DateTime?)null;

            if (string.IsNullOrWhiteSpace(receiptId))
            {
                SetValidationError(_receiptIdTextBox, "Mã phiếu không được để trống.", ref hasError);
            }
            else if (_records.Any(item => !ReferenceEquals(item, existing) && string.Equals(item.ReceiptId, receiptId, StringComparison.OrdinalIgnoreCase)))
            {
                SetValidationError(_receiptIdTextBox, "Mã phiếu đã tồn tại.", ref hasError);
            }

            if (string.IsNullOrWhiteSpace(studentId))
            {
                SetValidationError(_studentIdTextBox, "Mã sinh viên không được để trống.", ref hasError);
            }

            if (string.IsNullOrWhiteSpace(equipment))
            {
                SetValidationError(_equipmentComboBox, "Vui lòng chọn thiết bị.", ref hasError);
            }

            if (_dueDatePicker.Value.Date < _checkoutDatePicker.Value.Date)
            {
                SetValidationError(_dueDatePicker, "Hạn trả không được trước ngày mượn.", ref hasError);
            }

            if (actualReturnDate is not null && actualReturnDate.Value < _checkoutDatePicker.Value.Date)
            {
                SetValidationError(_returnDatePicker, "Ngày trả thực tế không được trước ngày mượn.", ref hasError);
            }

            if (hasError)
            {
                return false;
            }

            record.ReceiptId = receiptId;
            record.StudentId = studentId;
            record.StudentName = _studentNameTextBox.Text.Trim();
            record.EquipmentName = equipment!;
            record.Quantity = decimal.ToInt32(_quantityNumeric.Value);
            record.CheckoutDate = _checkoutDatePicker.Value.Date;
            record.DueDate = _dueDatePicker.Value.Date;
            record.ActualReturnDate = actualReturnDate;
            return true;
        }

        private void SetValidationError(Control control, string message, ref bool hasError)
        {
            _errorProvider.SetError(control, message);
            hasError = true;
        }

        private void ApplyFilters(CheckoutRecord? selectAfterFiltering = null)
        {
            var query = _searchTextBox.Text.Trim();
            var selectedStatus = _statusFilterComboBox.SelectedItem as string ?? "Tất cả";
            var filteredRecords = _records.Where(record =>
                (query.Length == 0 || record.StudentId.Contains(query, StringComparison.CurrentCultureIgnoreCase) || record.EquipmentName.Contains(query, StringComparison.CurrentCultureIgnoreCase)) &&
                (selectedStatus == "Tất cả" || record.Status == selectedStatus)).ToList();

            _visibleRecords.RaiseListChangedEvents = false;
            _visibleRecords.Clear();
            foreach (var record in filteredRecords)
            {
                _visibleRecords.Add(record);
            }
            _visibleRecords.RaiseListChangedEvents = true;
            _visibleRecords.ResetBindings();

            if (selectAfterFiltering is not null)
            {
                var index = _visibleRecords.IndexOf(selectAfterFiltering);
                if (index >= 0)
                {
                    _recordsGrid.ClearSelection();
                    _recordsGrid.Rows[index].Selected = true;
                    _recordsGrid.CurrentCell = _recordsGrid.Rows[index].Cells[0];
                }
            }

            UpdateSummary();
        }

        private void UpdateSummary()
        {
            _summaryLabel.Text = $"Tổng số phiếu: {_records.Count}    |    Số phiếu quá hạn: {_records.Count(record => record.IsOverdue)}    |    Đang hiển thị: {_visibleRecords.Count}";
        }

        private CheckoutRecord? GetSelectedRecord() => _recordsGrid.CurrentRow?.DataBoundItem as CheckoutRecord;

        private void LoadSelectedRecord()
        {
            var selected = GetSelectedRecord();
            if (selected is null)
            {
                return;
            }

            _receiptIdTextBox.Text = selected.ReceiptId;
            _studentIdTextBox.Text = selected.StudentId;
            _studentNameTextBox.Text = selected.StudentName;
            _equipmentComboBox.SelectedItem = selected.EquipmentName;
            _quantityNumeric.Value = Math.Clamp(selected.Quantity, decimal.ToInt32(_quantityNumeric.Minimum), decimal.ToInt32(_quantityNumeric.Maximum));
            _checkoutDatePicker.Value = selected.CheckoutDate;
            _dueDatePicker.Value = selected.DueDate;
            _returnDatePicker.Enabled = true;
            _returnDatePicker.Checked = selected.ActualReturnDate is not null;
            _returnDatePicker.Value = selected.ActualReturnDate ?? DateTime.Today;
            _returnDatePicker.Enabled = true;
            UpdateStatusPreview();
            _errorProvider.Clear();
        }

        private void ClearEntry()
        {
            _errorProvider.Clear();
            _recordsGrid.ClearSelection();
            _recordsGrid.CurrentCell = null;
            _receiptIdTextBox.Clear();
            _studentIdTextBox.Clear();
            _studentNameTextBox.Clear();
            _equipmentComboBox.SelectedIndex = -1;
            _quantityNumeric.Value = 1;
            _checkoutDatePicker.Value = DateTime.Today;
            _dueDatePicker.Value = DateTime.Today;
            _returnDatePicker.Value = DateTime.Today;
            _returnDatePicker.Checked = false;
            _returnDatePicker.Enabled = true;
            UpdateStatusPreview();
        }

        private void UpdateStatusPreview()
        {
            var hasReturnDate = _returnDatePicker.Checked;
            _statusValueLabel.Text = hasReturnDate
                ? "Đã trả"
                : _dueDatePicker.Value.Date < DateTime.Today ? "Quá hạn" : "Đang mượn";
        }

        private void ExportCsv()
        {
            using var dialog = new SaveFileDialog
            {
                Title = "Xuất danh sách phiếu mượn",
                Filter = "CSV files (*.csv)|*.csv",
                DefaultExt = "csv",
                AddExtension = true,
                FileName = "lab-equipment-checkouts.csv"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                using var writer = new StreamWriter(dialog.FileName, false, new UTF8Encoding(true));
                writer.WriteLine("Mã phiếu,Mã sinh viên,Họ tên sinh viên,Thiết bị,Số lượng,Ngày mượn,Hạn trả,Ngày trả thực tế,Tình trạng");
                foreach (var record in _visibleRecords)
                {
                    var values = new[]
                    {
                        record.ReceiptId,
                        record.StudentId,
                        record.StudentName,
                        record.EquipmentName,
                        record.Quantity.ToString(CultureInfo.InvariantCulture),
                        record.CheckoutDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                        record.DueDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                        record.ActualReturnDate?.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) ?? string.Empty,
                        record.Status
                    };
                    writer.WriteLine(string.Join(",", values.Select(EscapeCsv)));
                }
            }
            catch (IOException exception)
            {
                MessageBox.Show(this, $"Không thể xuất tệp CSV: {exception.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException exception)
            {
                MessageBox.Show(this, $"Không có quyền ghi tệp CSV: {exception.Message}", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string EscapeCsv(string value) => $"\"{value.Replace("\"", "\"\"", StringComparison.Ordinal)}\"";
    }
}
