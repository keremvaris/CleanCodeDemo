using CleanCodeDemo.Entities;
using CleanCodeDemo.Interfaces;

namespace CleanCodeDemo.BankServices
{
  public class IsBankService
  {
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
      return currencyRate.Price / (decimal)5.25;
    }
  }
  public class IsBankServiceAdapter : IBankService
  {
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
      IsBankService centralBankService = new IsBankService();
      return centralBankService.ConvertRate(currencyRate);
    }
  }
}
