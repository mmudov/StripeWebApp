namespace StripeWebApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
        public string PriceID { get; set; } = String.Empty;
    }
}
