using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._9
{
    public partial class Form1 : Form
    {
        private readonly BindingList<Appointment> _appointments = [];
        private readonly BindingList<Appointment> _visibleAppointments = [];
        private readonly BindingSource _appointmentSource = new();
        private readonly ErrorProvider _errorProvider = new();

        public Form1()
        {
            InitializeComponent();
            components?.Add(_errorProvider);
            _errorProvider.ContainerControl = this;
            _addButton.Click += (_, _) => AddAppointment();
            _updateButton.Click += (_, _) => UpdateAppointment();
            _deleteButton.Click += (_, _) => DeleteAppointment();
            _clearButton.Click += (_, _) => ClearEditor();
            _exportMenuItem.Click += (_, _) => ExportVisibleAppointments();
            _searchTextBox.TextChanged += (_, _) => ApplyFilters();
            _dateFilterCheckBox.CheckedChanged += (_, _) => ApplyFilters();
            _filterDatePicker.ValueChanged += (_, _) => ApplyFilters();
            _filterStatusComboBox.SelectedIndexChanged += (_, _) => ApplyFilters();
            _appointmentsGrid.SelectionChanged += (_, _) => LoadSelectedAppointment();
            _appointmentSource.DataSource = _visibleAppointments;
            _appointmentsGrid.DataSource = _appointmentSource;
            ApplyFilters();
        }

        private void AddAppointment()
        {
            if (!TryReadAppointment(out var appointment))
            {
                return;
            }

            if (_appointments.Any(item => string.Equals(item.AppointmentId, appointment.AppointmentId, StringComparison.OrdinalIgnoreCase)))
            {
                SetValidationError(_appointmentIdTextBox, "Mã lịch hẹn đã tồn tại.");
                return;
            }

            if (MessageBox.Show(this, "Bạn có chắc muốn thêm lịch hẹn này?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            _appointments.Add(appointment);
            ApplyFilters();
            var visibleIndex = _appointmentSource.IndexOf(appointment);
            if (visibleIndex >= 0)
            {
                _appointmentSource.Position = visibleIndex;
            }
        }

        private void UpdateAppointment()
        {
            if (_appointmentSource.Current is not Appointment selected)
            {
                MessageBox.Show(this, "Vui lòng chọn lịch hẹn cần cập nhật.", "Chưa chọn lịch hẹn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!TryReadAppointment(out var updatedAppointment, selected))
            {
                return;
            }

            if (MessageBox.Show(this, "Bạn có chắc muốn cập nhật lịch hẹn này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            selected.AppointmentId = updatedAppointment.AppointmentId;
            selected.PatientName = updatedAppointment.PatientName;
            selected.PhoneNumber = updatedAppointment.PhoneNumber;
            selected.AppointmentDateTime = updatedAppointment.AppointmentDateTime;
            selected.Doctor = updatedAppointment.Doctor;
            selected.Reason = updatedAppointment.Reason;
            selected.Status = updatedAppointment.Status;
            _appointmentSource.ResetCurrentItem();
            ApplyFilters();
        }

        private void DeleteAppointment()
        {
            if (_appointmentSource.Current is not Appointment selected)
            {
                MessageBox.Show(this, "Vui lòng chọn lịch hẹn cần xóa.", "Chưa chọn lịch hẹn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show(this, $"Bạn có chắc muốn xóa lịch hẹn {selected.AppointmentId}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            _appointments.Remove(selected);
            ClearEditor();
            ApplyFilters();
        }

        private bool TryReadAppointment(out Appointment appointment, Appointment? existingAppointment = null)
        {
            ClearValidationErrors();
            var isValid = true;
            var id = _appointmentIdTextBox.Text.Trim();
            var patientName = _patientNameTextBox.Text.Trim();
            var phoneNumber = _phoneNumberTextBox.Text.Trim();
            var reason = _reasonTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(id))
            {
                SetValidationError(_appointmentIdTextBox, "Vui lòng nhập mã lịch hẹn.");
                isValid = false;
            }
            else if (_appointments.Any(item => !ReferenceEquals(item, existingAppointment) && string.Equals(item.AppointmentId, id, StringComparison.OrdinalIgnoreCase)))
            {
                SetValidationError(_appointmentIdTextBox, "Mã lịch hẹn đã tồn tại.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(patientName))
            {
                SetValidationError(_patientNameTextBox, "Vui lòng nhập họ tên bệnh nhân.");
                isValid = false;
            }

            var normalizedPhone = Regex.Replace(phoneNumber, @"[\s-]", string.Empty);
            if (!Regex.IsMatch(normalizedPhone, @"^(?:\+84|0)\d{9}$"))
            {
                SetValidationError(_phoneNumberTextBox, "Số điện thoại không hợp lệ.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(reason))
            {
                SetValidationError(_reasonTextBox, "Vui lòng nhập lý do khám.");
                isValid = false;
            }

            if (_appointmentDateTimePicker.Value < DateTime.Now)
            {
                SetValidationError(_appointmentDateTimePicker, "Ngày giờ hẹn không được nằm trong quá khứ.");
                isValid = false;
            }

            appointment = new Appointment
            {
                AppointmentId = id,
                PatientName = patientName,
                PhoneNumber = phoneNumber,
                AppointmentDateTime = _appointmentDateTimePicker.Value,
                Doctor = _doctorComboBox.SelectedItem?.ToString() ?? string.Empty,
                Reason = reason,
                Status = _statusComboBox.SelectedItem?.ToString() ?? AppointmentStatuses.Waiting
            };
            return isValid;
        }

        private void LoadSelectedAppointment()
        {
            if (_appointmentSource.Current is not Appointment selected)
            {
                return;
            }

            _appointmentIdTextBox.Text = selected.AppointmentId;
            _patientNameTextBox.Text = selected.PatientName;
            _phoneNumberTextBox.Text = selected.PhoneNumber;
            _appointmentDateTimePicker.Value = selected.AppointmentDateTime;
            _doctorComboBox.SelectedItem = selected.Doctor;
            _reasonTextBox.Text = selected.Reason;
            _statusComboBox.SelectedItem = selected.Status;
            ClearValidationErrors();
        }

        private void ClearEditor()
        {
            _appointmentSource.Position = -1;
            _appointmentIdTextBox.Clear();
            _patientNameTextBox.Clear();
            _phoneNumberTextBox.Clear();
            _reasonTextBox.Clear();
            _appointmentDateTimePicker.Value = DateTime.Now.AddMinutes(5);
            _doctorComboBox.SelectedIndex = _doctorComboBox.Items.Count > 0 ? 0 : -1;
            _statusComboBox.SelectedItem = AppointmentStatuses.Waiting;
            _appointmentsGrid.ClearSelection();
            ClearValidationErrors();
        }

        private void SetValidationError(Control control, string message)
        {
            _errorProvider.SetError(control, message);
        }

        private void ClearValidationErrors()
        {
            _errorProvider.Clear();
        }

        private void UpdateAppointmentCount()
        {
            _appointmentCountLabel.Text = $"Số lịch hẹn: {_appointmentSource.Count}";
        }

        private void ApplyFilters()
        {
            var search = _searchTextBox.Text.Trim();
            var selectedStatus = _filterStatusComboBox.SelectedItem?.ToString();
            var selectedDate = _filterDatePicker.Value.Date;

            _visibleAppointments.RaiseListChangedEvents = false;
            _visibleAppointments.Clear();
            foreach (var appointment in _appointments)
            {
                var matchesSearch = search.Length == 0
                    || appointment.PatientName.Contains(search, StringComparison.OrdinalIgnoreCase)
                    || appointment.PhoneNumber.Contains(search, StringComparison.OrdinalIgnoreCase);
                var matchesDate = !_dateFilterCheckBox.Checked || appointment.AppointmentDateTime.Date == selectedDate;
                var matchesStatus = string.IsNullOrEmpty(selectedStatus)
                    || selectedStatus == "Tất cả"
                    || appointment.Status == selectedStatus;

                if (matchesSearch && matchesDate && matchesStatus)
                {
                    _visibleAppointments.Add(appointment);
                }
            }

            _visibleAppointments.RaiseListChangedEvents = true;
            _visibleAppointments.ResetBindings();
            UpdateAppointmentCount();
        }

        private void ExportVisibleAppointments()
        {
            using var dialog = new SaveFileDialog
            {
                Title = "Xuất danh sách lịch hẹn",
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                DefaultExt = "csv",
                AddExtension = true,
                FileName = "lich-hen.csv"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            var lines = new List<string>
            {
                CsvRow("Mã lịch hẹn", "Họ tên bệnh nhân", "Số điện thoại", "Ngày giờ hẹn", "Bác sĩ", "Lý do khám", "Trạng thái")
            };
            lines.AddRange(_visibleAppointments.Select(appointment => CsvRow(
                appointment.AppointmentId,
                appointment.PatientName,
                appointment.PhoneNumber,
                appointment.AppointmentDateTime.ToString("dd/MM/yyyy HH:mm"),
                appointment.Doctor,
                appointment.Reason,
                appointment.Status)));

            try
            {
                File.WriteAllLines(dialog.FileName, lines, new UTF8Encoding(true));
                MessageBox.Show(this, "Đã xuất danh sách lịch hẹn.", "Xuất CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (IOException exception)
            {
                MessageBox.Show(this, $"Không thể xuất tệp: {exception.Message}", "Lỗi xuất CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException exception)
            {
                MessageBox.Show(this, $"Không thể ghi tệp: {exception.Message}", "Lỗi xuất CSV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string CsvRow(params string[] values)
        {
            return string.Join(",", values.Select(value => $"\"{value.Replace("\"", "\"\"")}\""));
        }
    }
}