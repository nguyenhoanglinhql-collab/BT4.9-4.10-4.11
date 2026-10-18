using System.ComponentModel;

namespace _4_10
{
    public sealed class CheckoutRecord : INotifyPropertyChanged
    {
        private string _receiptId = string.Empty;
        private string _studentId = string.Empty;
        private string _studentName = string.Empty;
        private string _equipmentName = string.Empty;
        private int _quantity = 1;
        private DateTime _checkoutDate = DateTime.Today;
        private DateTime _dueDate = DateTime.Today;
        private DateTime? _actualReturnDate;

        public string ReceiptId
        {
            get => _receiptId;
            set => SetProperty(ref _receiptId, value);
        }

        public string StudentId
        {
            get => _studentId;
            set => SetProperty(ref _studentId, value);
        }

        public string StudentName
        {
            get => _studentName;
            set => SetProperty(ref _studentName, value);
        }

        public string EquipmentName
        {
            get => _equipmentName;
            set => SetProperty(ref _equipmentName, value);
        }

        public int Quantity
        {
            get => _quantity;
            set => SetProperty(ref _quantity, value);
        }

        public DateTime CheckoutDate
        {
            get => _checkoutDate;
            set => SetProperty(ref _checkoutDate, value.Date);
        }

        public DateTime DueDate
        {
            get => _dueDate;
            set => SetProperty(ref _dueDate, value.Date);
        }

        public DateTime? ActualReturnDate
        {
            get => _actualReturnDate;
            set => SetProperty(ref _actualReturnDate, value?.Date);
        }

        public bool IsOverdue => ActualReturnDate is null && DueDate.Date < DateTime.Today;

        public string Status => ActualReturnDate is not null
            ? "Đã trả"
            : IsOverdue ? "Quá hạn" : "Đang mượn";

        public event PropertyChangedEventHandler? PropertyChanged;

        private void SetProperty<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return;
            }

            field = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if (propertyName is nameof(DueDate) or nameof(ActualReturnDate))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsOverdue)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Status)));
            }
        }
    }
}
