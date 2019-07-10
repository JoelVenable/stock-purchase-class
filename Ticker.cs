using System;
using System.Collections.Generic;

namespace stock_purchase_class
{
  class Ticker
  {
    public string TickerSymbol { get; private set; }
    public double NumberOfShares { get; private set; }
    public double MoneyInvested { get; private set; }



    private List<StockTrade> ListOfTrades = new List<StockTrade>();
    public Ticker(string tickerSymbol)
    {
      TickerSymbol = tickerSymbol;
      NumberOfShares = 0;
      MoneyInvested = 0;
      // CommissionCost = commissionCost;
    }



    public void BuyShares(int numShares, double sharePrice)
    {
      NumberOfShares += numShares;
      MoneyInvested += numShares * sharePrice;
      ListOfTrades.Add(new StockTrade(
        DateTime.Now, //  now ??
        numShares,
        sharePrice,
        true,
        TickerSymbol
      ));
    }



    public void SellShares(int numShares, double sharePrice)
    {
      NumberOfShares -= numShares;
      MoneyInvested -= numShares * sharePrice;
      ListOfTrades.Add(new StockTrade(
        DateTime.Now, //  now ??
        numShares,
        sharePrice,
        false,
        TickerSymbol
      ));
    }


    public void PrintHistory()
    {
      ListOfTrades.ForEach(trade =>
      {
        trade.PrintTrade();
      });
    }


    public double GetBasisPerShare()
    {
      return MoneyInvested / NumberOfShares;
    }





  }
}