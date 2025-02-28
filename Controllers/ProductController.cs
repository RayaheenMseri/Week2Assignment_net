using Microsoft.AspNetCore.Mvc;
using AmazonOrderSystem.Models;

public class ProductController : Controller
{
    public static List<Product> products = new List<Product>
    {               
        new Product {ProductID = 1, Name = "Laptop", Category = "Electronics", Price = 2800.0, StockQuantity = 10},
        new Product {ProductID = 3, Name = "Smartphone", Category = "Electronics", Price = 6000.0, StockQuantity = 19},
        new Product {ProductID = 4, Name = "Lip Stick", Category = "Beauty", Price = 60.0, StockQuantity = 50},
        new Product {ProductID = 5, Name = "Tablet", Category = "Electronics", Price = 2000.0, StockQuantity = 20},
        new Product {ProductID = 6, Name = "Headphones", Category = "Electronics", Price = 300.0, StockQuantity = 10},
        new Product {ProductID = 8, Name = "Foundation", Category = "Beauty", Price = 150.0, StockQuantity = 150},
        new Product {ProductID = 9, Name = "Gaming Console", Category = "Electronics", Price = 500.0, StockQuantity = 60},
        new Product {ProductID = 21, Name = "Keyboard", Category = "Electronics", Price = 1200.0, StockQuantity = 56},
        new Product {ProductID = 22, Name = "Fitness Tracker", Category = "Electronics", Price = 150.0, StockQuantity = 15},
        new Product {ProductID = 23, Name = "Face Cream", Category = "Beauty", Price = 30.0, StockQuantity = 40},
        new Product {ProductID = 24, Name = "Sofa Set", Category = "Furniture", Price = 850.0, StockQuantity = 2},
        new Product {ProductID = 25, Name = "Dining Table", Category = "Furniture", Price = 620.0, StockQuantity = 9},
        new Product {ProductID = 26, Name = "Office Chair", Category = "Furniture", Price = 400.0, StockQuantity = 23},
        new Product {ProductID = 31, Name = "Gaming Chair", Category = "Furniture", Price = 600.0, StockQuantity = 12},
        new Product {ProductID = 32, Name = "Smartwatch", Category = "Electronics", Price = 199.0, StockQuantity = 76},
        new Product {ProductID = 41, Name = "Bookshelf", Category = "Furniture", Price = 125.0, StockQuantity = 34},
        new Product {ProductID = 42, Name = "Makeup Kit", Category = "Beauty", Price = 90.0, StockQuantity = 25},
        new Product {ProductID = 43, Name = "VR Headset", Category = "Electronics", Price = 3000.0, StockQuantity = 16},
        new Product {ProductID = 45, Name = "Hair Dryer", Category = "Beauty", Price = 230.0, StockQuantity = 38}
    };

    [HttpGet("/Products")]
    public IActionResult Index()
    {
        return View(products);
    }
}
