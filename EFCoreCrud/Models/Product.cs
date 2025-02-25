public class Product
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public decimal Price { get; set; }
  public int Quantity { get; set; }
  public DateTime RegisterDate { get; set; } = DateTime.UtcNow;
  public bool Active { get; set; } = true;
}