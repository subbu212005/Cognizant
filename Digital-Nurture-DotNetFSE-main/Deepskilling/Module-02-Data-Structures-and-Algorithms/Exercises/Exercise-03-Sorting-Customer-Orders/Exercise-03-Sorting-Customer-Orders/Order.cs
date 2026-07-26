namespace SortingCustomerOrders;
public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalPrice { get; set; }

    public Order(int id,string name,double price)
    {
        OrderId=id; CustomerName=name; TotalPrice=price;
    }

    public override string ToString() =>
        $"Order ID: {OrderId}, Customer: {CustomerName}, Total: ₹{TotalPrice}";
}
