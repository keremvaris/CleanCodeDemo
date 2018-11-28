using CleanCodeDemo.Entities;
using CleanCodeDemo.Interfaces;

namespace CleanCodeDemo.BankServices
{
  public class FakeBankService : IBankService
  {
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
      return currencyRate.Price / (decimal)5.30;
    }
  }
}
