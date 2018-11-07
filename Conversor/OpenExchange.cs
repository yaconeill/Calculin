using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Conversor
{
	public class OpenExchange : IOpenExchange
	{
		public Dictionary<string, string> Divisas { get; set; }
		private const string url = "https://openexchangerates.org/api/currencies.json";

		public Dictionary<string, string> ObtenerDivisas()
		{
			try
			{
				using (var webClient = new System.Net.WebClient())
				{
					var json = webClient.DownloadString(url);
					var lista = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
					Divisas = lista;
				}

				return Divisas;
			}
			catch (Exception e)
			{
				Console.WriteLine("Error en la llamada");
			}

			return null;
		}
	}
}
