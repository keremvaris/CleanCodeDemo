namespace CleanCodeDemo
{
  public interface IPerson
  {
     int Id { get; set; }
     string Name { get; set; }
    decimal Price(Product product);
  }
}
