using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AmazonOrderSystem.Models;
public class OrderController : Controller
{
    public static List<Order> orders = new List<Order>
    {
        new Order { OrderID = 1, UserID = 2, OrderDate = DateTime.Now, Status = OrderStatus.SHIPPED },
        new Order { OrderID = 2, UserID = 3, OrderDate = DateTime.Now, Status = OrderStatus.DELIVERED },
        new Order { OrderID = 3, UserID = 3, OrderDate = DateTime.Now, Status = OrderStatus.CANCELED },
        new Order { OrderID = 4, UserID = 3, OrderDate = DateTime.Now, Status = OrderStatus.PENDING },
    };

    [HttpGet("Orders/{userId?}")]
    public IActionResult Index(int userId = 3)
    {
        var userOrders = orders.Where(o => o.UserID == userId).ToList();
        return View(userOrders);
    }

    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Products = new SelectList(ProductController.products, "ProductID", "Name");
        return View();
    }

    [HttpPost]
    public IActionResult Create(int userId, int productId, int quantity)
    {
        var product = ProductController.products.FirstOrDefault(p => p.ProductID == productId);

        if (product == null || product.StockQuantity < quantity)
        {
            ModelState.AddModelError("StockError", "Product unavailable.");
            ViewBag.Products = new SelectList(ProductController.products, "ProductID", "Name");
            return View();
        }

        var newOrder = new Order
        {
            OrderID = orders.Count > 0 ? orders.Max(o => o.OrderID) + 1 : 1, 
            UserID = userId,
            OrderDate = DateTime.Now,
            Status = OrderStatus.PENDING
        };

        var orderDetail = new OrderDetails
        {
            ProductID = productId,
            Quantity = quantity,
            SubTotal = product.Price * quantity
        };

        newOrder.OrderList.Add(orderDetail);
        orders.Add(newOrder);
        product.StockQuantity -= quantity;

        return RedirectToAction("Index", "Order");
    }
}
