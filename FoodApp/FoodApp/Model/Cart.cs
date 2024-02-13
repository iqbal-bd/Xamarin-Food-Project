namespace FoodApp.Model
{
    public class Cart
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotlaAmount { get; set; }
        
    }
}
