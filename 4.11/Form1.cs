using System.ComponentModel;
using System.Globalization;

namespace _4._11
{
    public partial class Form1 : Form
    {
        private readonly BindingList<RepairOrder> _orders = [];
        private readonly BindingList<RepairOrder> _visibleOrders = [];
        private RepairOrder? _selectedOrder;
        private string? _selectedImagePath;
        private bool _isRefreshing;

        public Form1()
        {
            InitializeComponent();
            _bindingSource.DataSource = _visibleOrders;
            _ordersGrid.DataSource = _bindingSource;
            WireEvents();
            UpdateStatusStrip();
        }

        private void WireEvents()
        {
            _exportMenuItem.Click += ExportCsv;
            _exitMenuItem.Click += (_, _) => Close();
            _addButton.Click += AddOrder;
            _updateButton.Click += UpdateOrder;
            _deleteButton.Click += DeleteOrder;
            _clearButton.Click += (_, _) => ClearForm();
            _chooseImageButton.Click += ChooseImage;
            _searchTextBox.TextChanged += (_, _) => RefreshVisibleOrders();
            _statusFilterComboBox.SelectedIndexChanged += (_, _) => RefreshVisibleOrders();
            _ordersGrid.SelectionChanged += (_, _) =>
            {
                if (!_isRefreshing && _ordersGrid.SelectedRows.Count > 0 && _ordersGrid.CurrentRow?.DataBoundItem is RepairOrder order)
                {
                    LoadOrderIntoForm(order);
                }
            };
        }

        private void AddOrder(object? sender, EventArgs e)
        {
            if (!TryReadForm(out var order))
            {
                return;
            }

            if (_orders.Any(existing => string.Equals(existing.OrderId, order.OrderId, StringComparison.OrdinalIgnoreCase)))
            {
                _errorProvider.SetError(_orderIdTextBox, "Mã đơn đã tồn tại.");
                _orderIdTextBox.Focus();
                return;
            }

            _orders.Add(order);
            RefreshVisibleOrders(order);
        }

        private void UpdateOrder(object? sender, EventArgs e)
        {
            if (_selectedOrder is null)
            {
                MessageBox.Show(this, "Vui lòng chọn đơn cần cập nhật.", "Chưa chọn đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!TryReadForm(out var updatedOrder))
            {
                return;
            }

            if (_orders.Any(existing => !ReferenceEquals(existing, _selectedOrder)
                && string.Equals(existing.OrderId, updatedOrder.OrderId, StringComparison.OrdinalIgnoreCase)))
            {
                _errorProvider.SetError(_orderIdTextBox, "Mã đơn đã tồn tại.");
                _orderIdTextBox.Focus();
                return;
            }

            _selectedOrder.OrderId = updatedOrder.OrderId;
            _selectedOrder.CustomerName = updatedOrder.CustomerName;
            _selectedOrder.PhoneNumber = updatedOrder.PhoneNumber;
            _selectedOrder.DeviceType = updatedOrder.DeviceType;
            _selectedOrder.FaultDescription = updatedOrder.FaultDescription;
            _selectedOrder.ReceivedDate = updatedOrder.ReceivedDate;
            _selectedOrder.EstimatedCost = updatedOrder.EstimatedCost;
            _selectedOrder.Status = updatedOrder.Status;
            _selectedOrder.ImagePath = updatedOrder.ImagePath;
            RefreshVisibleOrders(_selectedOrder);
        }

        private void DeleteOrder(object? sender, EventArgs e)
        {
            if (_selectedOrder is null)
            {
                MessageBox.Show(this, "Vui lòng chọn đơn cần xóa.", "Chưa chọn đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var answer = MessageBox.Show(this, $"Bạn có chắc muốn xóa đơn '{_selectedOrder.OrderId}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer != DialogResult.Yes)
            {
                return;
            }

            _orders.Remove(_selectedOrder);
            ClearForm();
            RefreshVisibleOrders();
        }

        private bool TryReadForm(out RepairOrder order)
        {
            _errorProvider.Clear();
            var orderId = _orderIdTextBox.Text.Trim();
            var customerName = _customerNameTextBox.Text.Trim();
            var phoneNumber = _phoneTextBox.Text.Trim();
            var faultDescription = _faultDescriptionTextBox.Text.Trim();
            var valid = true;

            if (string.IsNullOrWhiteSpace(orderId))
            {
                _errorProvider.SetError(_orderIdTextBox, "Vui lòng nhập mã đơn.");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(customerName))
            {
                _errorProvider.SetError(_customerNameTextBox, "Vui lòng nhập tên khách hàng.");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                _errorProvider.SetError(_phoneTextBox, "Vui lòng nhập số điện thoại.");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(faultDescription))
            {
                _errorProvider.SetError(_faultDescriptionTextBox, "Vui lòng mô tả lỗi thiết bị.");
                valid = false;
            }

            if (!decimal.TryParse(_estimatedCostTextBox.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out var estimatedCost)
                || estimatedCost < 0)
            {
                _errorProvider.SetError(_estimatedCostTextBox, "Chi phí phải là số không âm.");
                valid = false;
            }

            if (!valid)
            {
                order = new RepairOrder();
                return false;
            }

            order = new RepairOrder
            {
                OrderId = orderId,
                CustomerName = customerName,
                PhoneNumber = phoneNumber,
                DeviceType = _deviceTypeComboBox.SelectedItem?.ToString() ?? RepairOrder.DeviceTypes[0],
                FaultDescription = faultDescription,
                ReceivedDate = _receivedDatePicker.Value.Date,
                EstimatedCost = estimatedCost,
                Status = _statusComboBox.SelectedItem?.ToString() ?? RepairOrder.Statuses[0],
                ImagePath = _selectedImagePath
            };
            return true;
        }

        private void RefreshVisibleOrders(RepairOrder? orderToSelect = null)
        {
            var search = _searchTextBox.Text.Trim();
            var selectedStatus = _statusFilterComboBox.SelectedItem?.ToString();
            var filteredOrders = _orders.Where(order =>
                    (selectedStatus == "Tất cả trạng thái" || string.Equals(order.Status, selectedStatus, StringComparison.Ordinal))
                    && (search.Length == 0
                        || order.OrderId.Contains(search, StringComparison.CurrentCultureIgnoreCase)
                        || order.CustomerName.Contains(search, StringComparison.CurrentCultureIgnoreCase)
                        || order.PhoneNumber.Contains(search, StringComparison.CurrentCultureIgnoreCase)))
                .ToList();

            _isRefreshing = true;
            try
            {
                _visibleOrders.Clear();
                foreach (var order in filteredOrders)
                {
                    _visibleOrders.Add(order);
                }
                _bindingSource.ResetBindings(false);

                if (orderToSelect is not null)
                {
                    var row = _ordersGrid.Rows.Cast<DataGridViewRow>()
                        .FirstOrDefault(candidate => ReferenceEquals(candidate.DataBoundItem, orderToSelect));
                    if (row is not null)
                    {
                        row.Selected = true;
                        _ordersGrid.CurrentCell = row.Cells[0];
                        LoadOrderIntoForm(orderToSelect);
                    }
                }
            }
            finally
            {
                _isRefreshing = false;
            }

            UpdateStatusStrip();
        }

        private void LoadOrderIntoForm(RepairOrder order)
        {
            _selectedOrder = order;
            _orderIdTextBox.Text = order.OrderId;
            _customerNameTextBox.Text = order.CustomerName;
            _phoneTextBox.Text = order.PhoneNumber;
            _deviceTypeComboBox.SelectedItem = order.DeviceType;
            _faultDescriptionTextBox.Text = order.FaultDescription;
            _receivedDatePicker.Value = order.ReceivedDate;
            _estimatedCostTextBox.Text = order.EstimatedCost.ToString("N0", CultureInfo.CurrentCulture);
            _statusComboBox.SelectedItem = order.Status;
            _selectedImagePath = order.ImagePath;
            SetDeviceImage(_selectedImagePath);
            _errorProvider.Clear();
        }

        private void ClearForm()
        {
            _selectedOrder = null;
            _selectedImagePath = null;
            _errorProvider.Clear();
            _orderIdTextBox.Clear();
            _customerNameTextBox.Clear();
            _phoneTextBox.Clear();
            _deviceTypeComboBox.SelectedIndex = 0;
            _faultDescriptionTextBox.Clear();
            _receivedDatePicker.Value = DateTime.Today;
            _estimatedCostTextBox.Text = "0";
            _statusComboBox.SelectedIndex = 0;
            SetDeviceImage(null);
            _ordersGrid.ClearSelection();
        }

        private void ChooseImage(object? sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Title = "Chọn ảnh thiết bị",
                Filter = "Tệp hình ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Tất cả tệp|*.*",
                CheckFileExists = true
            };
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                _selectedImagePath = dialog.FileName;
                SetDeviceImage(_selectedImagePath);
            }
        }

        private void SetDeviceImage(string? imagePath)
        {
            var previousImage = _devicePictureBox.Image;
            _devicePictureBox.Image = null;
            previousImage?.Dispose();

            if (imagePath is not null && File.Exists(imagePath))
            {
                using var source = Image.FromFile(imagePath);
                _devicePictureBox.Image = new Bitmap(source);
            }
        }

        private void ExportCsv(object? sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                Title = "Xuất danh sách đơn sửa chữa",
                Filter = "Tệp CSV (*.csv)|*.csv",
                DefaultExt = "csv",
                AddExtension = true,
                FileName = "danh-sach-don-sua-chua.csv"
            };
            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            using var writer = new StreamWriter(dialog.FileName, false, new System.Text.UTF8Encoding(true));
            writer.WriteLine("Mã đơn,Tên khách hàng,Số điện thoại,Loại thiết bị,Mô tả lỗi,Ngày tiếp nhận,Chi phí dự kiến,Trạng thái");
            foreach (var order in _visibleOrders)
            {
                var fields = new[]
                {
                    order.OrderId,
                    order.CustomerName,
                    order.PhoneNumber,
                    order.DeviceType,
                    order.FaultDescription,
                    order.ReceivedDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                    order.EstimatedCost.ToString("N0", CultureInfo.CurrentCulture),
                    order.Status
                };
                writer.WriteLine(string.Join(',', fields.Select(EscapeCsvField)));
            }
        }

        private static string EscapeCsvField(string value)
        {
            return $"\"{value.Replace("\"", "\"\"")}\"";
        }

        private void UpdateStatusStrip()
        {
            _orderCountLabel.Text = $"Số đơn đang hiển thị: {_visibleOrders.Count}";
            var unfinishedTotal = _orders
                .Where(order => order.Status != "Hoàn tất")
                .Sum(order => order.EstimatedCost);
            _estimatedTotalLabel.Text = $"Tổng dự kiến chưa hoàn tất: {unfinishedTotal:N0}";
        }
    }
}