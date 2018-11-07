using System.Collections.Generic;

namespace Conversor
{
	public interface IOpenExchange
	{
		Dictionary<string, string> Divisas { get; set; }
		Dictionary<string, string> ObtenerDivisas();
	}
}