using CleanCodeDemo.Entities;

namespace CleanCodeDemo.Interfaces
{
  public interface IBankService
  {
    decimal ConvertRate(CurrencyRate currencyRate);
  }
}
