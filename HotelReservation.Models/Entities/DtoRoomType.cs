namespace HotelReservation.Models.Entities
{
    public class DtoRoomType : BaseEntity
    {
        public string Description { get; set; }
        public double Rate { get; set; }
        public double DepositFeePercentage { get; set; }
        public int CancellationFeeNightsCount { get; set; }
    }
}
