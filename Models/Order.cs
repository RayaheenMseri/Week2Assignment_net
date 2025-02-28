namespace AmazonOrderSystem.Models{
    public enum OrderStatus
    {
        PENDING, SHIPPED, DELIVERED,CANCELED
    }

    public class Order
    {
    public int OrderID {get; set;}

    public int UserID {get; set;}

    public DateTime OrderDate {get; set;} = DateTime.Now;

    public OrderStatus Status {get; set;} = OrderStatus.PENDING;

    public List<OrderDetails> OrderList {get; set;} = new List<OrderDetails>();
    }
}