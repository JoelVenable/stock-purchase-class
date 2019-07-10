using System;

namespace stock_purchase_class
{

  class StockTrade
  {
    public DateTime TradeDate { get; }
    public int NumberOfShares { get; }
    public string TickerSymbol { get; }
    public double PricePerShare { get; }

    public Boolean IsPurchase { get; }

    public StockTrade(
      DateTime tradeDate,
      int numShares,
      double pricePerShare,
      Boolean isPurchase,
      string tickerSymbol
    )
    {
      TradeDate = tradeDate;
      NumberOfShares = numShares;
      PricePerShare = pricePerShare;
      IsPurchase = isPurchase;
      TickerSymbol = tickerSymbol;
    }

    public void PrintTrade()
    {
      Console.WriteLine(
        $"{(IsPurchase ? "Bought" : "Sold")} {NumberOfShares} shares of {TickerSymbol}" +
        $" on {TradeDate}.  PPS: {PricePerShare}, {GetInvested()}");
    }


    private string GetInvested()
    {
      double dollars = NumberOfShares * PricePerShare;
      return IsPurchase ? $"Invested: ${dollars}" : $"Received: ${dollars}";
    }
  }
}