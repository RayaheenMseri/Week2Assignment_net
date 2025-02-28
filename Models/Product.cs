using System.ComponentModel.DataAnnotations;

namespace AmazonOrderSystem.Models{
    public class Product
    {
    public int ProductID {get; set;}


    public required string Name {get; set;}

    public required string Category {get; set;}

    public double Price {get; set;}

    public int StockQuantity {get; set;}
    }
}