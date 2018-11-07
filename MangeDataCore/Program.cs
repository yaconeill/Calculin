using System;
using System.Collections.Generic;
using System.Linq;
using ForexQuotes;
using ModeloCore;
using RepositorioCore;

namespace MangeDataCore
{
	class Program
	{
		static void Main(string[] args)
		{
			var iniciar = new App();
			iniciar.LoadConversionList();
		}
	}
	public class App
	{
		public Repositorio _repositorio { get; set; }
		public ForexDataClient _client { get; set; }

		public App()
		{
			_client = new ForexDataClient("CLgVZ2SmUW1P0EEa2ryKYZf7yeXRUL58");
		}

		public void LoadConversionList()
		{
			LoadCurrencies();
			GenerateFatorConversion();

			var factores = _repositorio.ObtenerFactores();
			string[] simbolos = new string[factores.Count];

			//foreach (var f in factores)
			//{
			//	Moneda origen = _repositorio.BuscarMonedaPorId(f.IdMonedaOrigen);
			//	Moneda destino = _repositorio.BuscarMonedaPorId(f.IdMonedaDestino);
			//	simbolos.Append($"{origen.IdentificadorMoneda}{destino.IdentificadorMoneda},");
			//}

			//simbolos = simbolos.Substring(0, simbolos.Length - 1);
			var data = _client.GetQuotes(simbolos);

			foreach (var forexData in data)
			{
				var simboloOrigen = forexData.symbol.Substring(0, 3);
				var simboloDestino = forexData.symbol.Substring(3, 3);
				var monedaOrigen = _repositorio.BuscarMonedaPorIdentificador(simboloOrigen);
				var monedaDestino = _repositorio.BuscarMonedaPorIdentificador(simboloDestino);
				var factorMoneda = _repositorio.BuscarFactorPorOrigenDestino(monedaOrigen.Id, monedaDestino.Id);
				factorMoneda.Factor = (decimal)forexData.price;
				_repositorio.ActualizarFactores(factorMoneda);
			}
		}

		public void LoadCurrencies()
		{
			var divisas = _client.GetSymbols();

			foreach (var divisa in DeleteDuplicates(divisas))
						_repositorio.CrearMoneda(new Moneda
						{
							IdentificadorMoneda = divisa,
							Nombre = divisa
						});
		}

		public void GenerateFatorConversion()
		{
			var monedasOrigen = _repositorio.ObtenerMonedas();
			var monedasDestino = _repositorio.ObtenerMonedas();

			foreach (var origen in monedasOrigen)
				foreach (var destino in monedasDestino)
					if (origen.Id != destino.Id)
						_repositorio.CrearFactores(new FactorConversion
						{
							IdMonedaOrigen = origen.Id,
							IdMonedaDestino = destino.Id,
						});

		}

		private static string[] DeleteDuplicates(string[] data)
		{
			List<string> lista = new List<string>();
			foreach (var divisa in data)
				lista.Add(divisa.Substring(0, 3));
			return lista.Distinct().ToArray();
		}

	}

}
