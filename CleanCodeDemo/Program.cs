using System;
using CleanCodeDemo.BankServices;
using CleanCodeDemo.Entities;
using CleanCodeDemo.Interfaces;
using static CleanCodeDemo.Business.ProductManager;

namespace CleanCodeDemo
{
  class Program
  {
    protected Program()
    {
    }
    static void Main(string[] args)
    {
      CustomerSell();
      StudentSell();
      OfficerSell();
      Console.ReadLine();
    }

   
    
  }
}
