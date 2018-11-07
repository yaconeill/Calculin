using System.Collections.Generic;

namespace Conversor
{
	public interface IForex
	{
		List<ForexData> getFactors(string pairs);
		List<string> getCurrencies();
	}
}