using CleanCodeDemo.Entities;
using CleanCodeDemo.Interfaces;

namespace CleanCodeDemo.BankServices
{
  public class CentralBankService
  {
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
      return currencyRate.Price / (decimal)5.28;
    }
  }

  public class CentralBankServiceAdapter : IBankService
  {
    public decimal ConvertRate(CurrencyRate currencyRate)
    {
      CentralBankService centralBankService=new CentralBankService();
      return centralBankService.ConvertRate(currencyRate);
    }
  }

  
}
