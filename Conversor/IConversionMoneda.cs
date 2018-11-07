using System.Collections.Generic;
using ForexQuotes;
using ModeloCore;

namespace Conversor
{
	public interface IConversionMoneda
	{
		ForexDataClient _client { get; set; }
		List<FactorConversion> ListaFactores { get; set; }
		decimal RealizarCambio(string idOrigen, string idDestino, decimal valor);
		void LoadConversionList();
		void ActualizarNombres();
		void LoadCurrencies();
		void GenerateFatorConversion();
	}
}