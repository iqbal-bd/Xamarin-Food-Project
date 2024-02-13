namespace FoodApp.Model
{
    public class Category
    {
        public  int id { get; set; }
        public string Title { get; set; }
        public string ImageUri { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
