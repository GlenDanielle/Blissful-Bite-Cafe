namespace BackEnd.Entity;

public class Order
{
    public int Id { get; set; }
    public required string CustomerId { get; set; }
    public DateOnly DateOrder { get; set; }
    public double TotalPrice { get; set; }
    public int OrderId { get; set; }
    public OrderInfo? OrderInfo { get; set; }

}
