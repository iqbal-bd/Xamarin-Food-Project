namespace FoodApp.Model
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUri { get; set; }
        public double Price { get; set; }
        public bool IsPopular { get; set; }
        
    }
}
