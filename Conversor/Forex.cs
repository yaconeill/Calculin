using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Internal;
using Newtonsoft.Json;

namespace Conversor
{
	public class Forex : IForex
	{
		private const string apiKey = "CLgVZ2SmUW1P0EEa2ryKYZf7yeXRUL58";
		public List<ForexData> getFactors(string pairs)
		{
			try
			{
				string url = $"https://forex.1forge.com/1.0.3/quotes?pairs={pairs}&api_key={apiKey}";
				using (var webClient = new System.Net.WebClient())
				{
					var json = webClient.DownloadString(url);
					var lista = JsonConvert.DeserializeObject<List<ForexData>>(json);
					return lista;
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Error en la llamada", e);
			}

			return null;
		}
		public List<string> getCurrencies()
		{
			try
			{
				string url = $"https://forex.1forge.com/1.0.3/symbols?api_key={apiKey}";
				using (var webClient = new System.Net.WebClient())
				{
					var json = webClient.DownloadString(url);
					var data = JsonConvert.DeserializeObject<List<string>>(json);
					return DeleteDuplicates(data);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Error en la llamada", e);
			}

			return null;
		}

		private static List<string> DeleteDuplicates(List<string> data)
		{
			List<string> lista = new List<string>();
			foreach (var divisa in data)
				lista.Add(divisa.Substring(0, 3));
			return lista.Distinct().ToList();
		}
	}
}
