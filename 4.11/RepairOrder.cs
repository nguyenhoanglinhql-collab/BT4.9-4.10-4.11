namespace _4._11
{
    public sealed class RepairOrder
    {
        public static IReadOnlyList<string> DeviceTypes { get; } = ["Điện thoại", "Máy tính", "Máy tính bảng", "Thiết bị gia dụng", "Khác"];
        public static IReadOnlyList<string> Statuses { get; } = ["Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy"];

        public string OrderId { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string DeviceType { get; set; } = string.Empty;
        public string FaultDescription { get; set; } = string.Empty;
        public DateTime ReceivedDate { get; set; } = DateTime.Today;
        public decimal EstimatedCost { get; set; }
        public string Status { get; set; } = "Mới tiếp nhận";
        public string? ImagePath { get; set; }
    }
}
