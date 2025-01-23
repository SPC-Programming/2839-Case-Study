namespace SportsPro.Models;

public class ProductsList{

    public ICollection<Product> ProductList { get; set; } = new List<Product>();
}