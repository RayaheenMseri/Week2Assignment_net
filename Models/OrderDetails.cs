using System.ComponentModel.DataAnnotations;

namespace AmazonOrderSystem.Models{
    public class OrderDetails
    {
    public int OrderDetailID {get; set;}

    [Required(ErrorMessage = "User ID is required.")]
    public int OrderID {get; set;}

    [Required(ErrorMessage = "Please select at least one product.")]
    public int ProductID {get; set;}


    [Range(1, 100, ErrorMessage = "Order quantity must be between 1 and 100.")]
    public int Quantity {get; set;}

    public double SubTotal {get; set;}
    }
}
