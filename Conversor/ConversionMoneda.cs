using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloCore;
using RepositorioCore;
using ForexQuotes;

namespace Conversor
{
	public class ConversionMoneda : IConversionMoneda
	{
		private readonly IRepositorio _repositorio;
		private readonly IForex _forex;
		private readonly IOpenExchange _openExchange;
		public ForexDataClient _client { get; set; }
		public List<FactorConversion> ListaFactores { get; set; }

		public ConversionMoneda(IRepositorio repositorio, IForex forex, IOpenExchange openExchange)
		{
			_repositorio = repositorio;
			_forex = forex;
			_openExchange = openExchange;
			ListaFactores = new List<FactorConversion>();
			_client = new ForexDataClient("CLgVZ2SmUW1P0EEa2ryKYZf7yeXRUL58");

		}

		public decimal RealizarCambio(string idOrigen, string idDestino, decimal valor)
		{
			ListaFactores = _repositorio.ObtenerFactores();
			var origen = _repositorio.BuscarMonedaPorIdentificador(idOrigen);
			var destino = _repositorio.BuscarMonedaPorIdentificador(idDestino);
			var busqueda = ListaFactores.FirstOrDefault(
				f => f.IdMonedaOrigen == origen.Id &&
					 f.IdMonedaDestino == destino.Id);
			if (busqueda != null)
				return valor * busqueda.Factor;
			return -1;
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

			ActualizarNombres();
		}

		public void ActualizarNombres()
		{
			var listaNombres = _openExchange.ObtenerDivisas();
			var monedas = _repositorio.ObtenerMonedas();
			foreach (var nombre in listaNombres)
				foreach (var moneda in monedas)
					if (moneda.IdentificadorMoneda == nombre.Key)
					{
						moneda.Nombre = nombre.Value;
						_repositorio.ActualizarMoneda(moneda);
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


		//public void LoadConversionList()
		//{
		//	//GenerateFatorConversion();
		//	string simbolos = "";
		//	var factores = _repositorio.ObtenerFactores();

		//	foreach (var f in factores)
		//	{
		//		Moneda origen = _repositorio.BuscarMonedaPorId(f.IdMonedaOrigen);
		//		Moneda destino = _repositorio.BuscarMonedaPorId(f.IdMonedaDestino);
		//		simbolos += $"{origen.IdentificadorMoneda}{destino.IdentificadorMoneda},";
		//	}

		//	simbolos = simbolos.Substring(0, simbolos.Length - 1);
		//	var data = _forex.getFactors(simbolos);

		//	foreach (var forexData in data)
		//	{
		//		var simboloOrigen = forexData.Symbol.Substring(0, 3);
		//		var simboloDestino = forexData.Symbol.Substring(3, 3);
		//		var monedaOrigen = _repositorio.BuscarMonedaPorIdentificador(simboloOrigen);
		//		var monedaDestino = _repositorio.BuscarMonedaPorIdentificador(simboloDestino);
		//		var factorMoneda = _repositorio.BuscarFactorPorOrigenDestino(monedaOrigen.Id, monedaDestino.Id);
		//		factorMoneda.Factor = forexData.Price;
		//		_repositorio.ActualizarFactores(factorMoneda);
		//	}
		//}

		//public void LoadCurrencies()
		//{
		//	var divisas = _forex.getCurrencies();
		//	var nombresDivisas = _openExchange.ObtenerDivisas();
		//	foreach (var divisa in divisas)
		//		foreach (var nombre in nombresDivisas)
		//			if (nombre.Key == divisa)
		//				_repositorio.CrearMoneda(new Moneda
		//				{
		//					IdentificadorMoneda = divisa,
		//					Nombre = nombre.Value
		//				});
		//}

		//public void GenerateFatorConversion()
		//{
		//	var monedasOrigen = _repositorio.ObtenerMonedas();
		//	var monedasDestino = _repositorio.ObtenerMonedas();

		//	foreach (var origen in monedasOrigen)
		//		foreach (var destino in monedasDestino)
		//			if (origen.Id != destino.Id)
		//				_repositorio.CrearFactores(new FactorConversion
		//				{
		//					IdMonedaOrigen = origen.Id,
		//					IdMonedaDestino = destino.Id,
		//				});

		//}
	}
}
