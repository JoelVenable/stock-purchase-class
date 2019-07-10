using System;

namespace stock_purchase_class
{
  class Program
  {
    // static string CommissionCost {get; set; }

    static void Main(string[] args)
    {
      // GetCommissionCost();
      Ticker AAPL = new Ticker("AAPL");

      AAPL.BuyShares(55, 309.14);

      AAPL.BuyShares(20, 305.11);

      AAPL.SellShares(10, 298.55);

      AAPL.PrintHistory();
    }


    // static void GetCommissionCost()
    // {
    //   Console.WriteLine("What is the commission cost (dollars and cents)?");
    //   Program.CommissionCost = Console.ReadLine();
    // }



  }
}
