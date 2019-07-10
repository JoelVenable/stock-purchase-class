using System;

namespace stock_purchase_class
{
  class Ticker
  {
    public string TickerSymbol { get; }
    public double NumberOfShares { get; }
    public double MoneyInvested {get; }
    public Ticker(string tickerSymbol)
    {
      TickerSymbol = tickerSymbol;
      NumberOfShares = 0;
      MoneyInvested = 0;
    }

    

    public void BuyShares(double numShares, double sharePrice)
    {
      NumberOfShares += numShares;
      MoneyInvested += numShares * sharePrice;
    }




  }
}