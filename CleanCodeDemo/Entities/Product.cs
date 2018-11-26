namespace CleanCodeDemo
{
  public class Product : IEntity
  {
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
  }
}
