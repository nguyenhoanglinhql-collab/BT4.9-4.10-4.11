using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace _4._9
{
    public static class AppointmentStatuses
    {
        public const string Waiting = "Chờ khám";
        public const string InProgress = "Đang khám";
        public const string Completed = "Hoàn tất";
        public const string Cancelled = "Đã hủy";

        public static readonly string[] All =
        [
            Waiting,
            InProgress,
            Completed,
            Cancelled
        ];
    }

    public sealed class Appointment : INotifyPropertyChanged
    {
        private string _appointmentId = string.Empty;
        private string _patientName = string.Empty;
        private string _phoneNumber = string.Empty;
        private DateTime _appointmentDateTime;
        private string _doctor = string.Empty;
        private string _reason = string.Empty;
        private string _status = AppointmentStatuses.Waiting;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string AppointmentId
        {
            get => _appointmentId;
            set => SetField(ref _appointmentId, value);
        }

        public string PatientName
        {
            get => _patientName;
            set => SetField(ref _patientName, value);
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set => SetField(ref _phoneNumber, value);
        }

        public DateTime AppointmentDateTime
        {
            get => _appointmentDateTime;
            set => SetField(ref _appointmentDateTime, value);
        }

        public string Doctor
        {
            get => _doctor;
            set => SetField(ref _doctor, value);
        }

        public string Reason
        {
            get => _reason;
            set => SetField(ref _reason, value);
        }

        public string Status
        {
            get => _status;
            set => SetField(ref _status, value);
        }

        private void SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return;
            }

            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
