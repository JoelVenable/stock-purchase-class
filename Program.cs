using System;
using System.Collections.Generic;

namespace stock_purchase_class
{
  class Program
  {
    // static string CommissionCost {get; set; }

    static public Dictionary<string, Ticker> StockList { get; set; }

    static void Main(string[] args)
    {
      SelectOption();

    }


    private static void SelectOption()
    {
      var doOver = false;

      do
      {
        Console.WriteLine("Make a choice:  (A)dd a ticker, (B)uy stock, (S)ell stock, (P)rint Report...");
        var response = Console.ReadLine();
        switch (response)
        {
          case "A":
            AddStock();
            break;
          case "B":
            Console.WriteLine("Buy Stock");
            break;
          case "S":
            Console.WriteLine("Sell Stock");
            break;
          case "P":
            Console.WriteLine("Print Report");
            break;
          default:
            Console.WriteLine("Invalid response...");
            doOver = true;
            break;
        }


      } while (doOver);
    }

    static void AddStock()
    {
      Console.WriteLine("Enter a ticker symbol:");
      string response = Console.ReadLine();
      if (Program.StockList.ContainsKey(response))
      {
        Console.WriteLine("Already exists!!");
        AddStock();
      }
      else
      {
        Program.StockList[response] = new Ticker(response);
      }

    }

    static Boolean CheckExisting(string tickerSymbol)
    {
      return false;
    }



    // static void GetCommissionCost()
    // {
    //   Console.WriteLine("What is the commission cost (dollars and cents)?");
    //   Program.CommissionCost = Console.ReadLine();
    // }



  }
}
