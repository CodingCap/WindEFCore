namespace WindEFCore.Models
{
    public class TripOrders
    {
        public int TripId { get; set; }
        public virtual Trip Trip { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
