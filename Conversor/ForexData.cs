namespace Conversor
{
	public class ForexData
	{
		public ForexData()
		{
		}

		public ForexData(string symbol, decimal bid, decimal ask, decimal price, int timestamp)
		{
			Symbol = symbol;
			Bid = bid;
			Ask = ask;
			Price = price;
			Timestamp = timestamp;
		}

		public string Symbol { get; set; }

		public decimal Bid { get; set; }

		public decimal Ask { get; set; }

		public decimal Price { get; set; }

		public int Timestamp { get; set; }
	}
}