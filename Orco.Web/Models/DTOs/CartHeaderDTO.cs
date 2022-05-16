namespace Orco.Web.Models.DTOs
{
    public class CartHeaderDTO
    {
        public int CartHeaderId { get; set; }
        public string UserId { get; set; }
        public string CouponCode { get; set; }
        public double OrderTotal { get; set; }
    }
}
