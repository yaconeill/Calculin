using System.Collections.Generic;
using ContextoCore;
using ModeloCore;

namespace RepositorioCore
{
	public interface IRepositorio
	{
		List<Moneda> ListaMonedas { get; set; }
		List<FactorConversion> ListaFactores { get; set; }
		List<Historial> ListaHistoriales { get; set; }
		List<Pais> ListaPaises { get; set; }

		/// <summary>
		/// RETRIEVE CURRENCY BY ID
		/// </summary>
		/// <param name="idMoneda"></param>
		/// <param name="ctx"></param>
		/// <returns></returns>
		Moneda BuscarMonedaPorId(int idMoneda);

		/// <summary>
		/// RETRIEVE CURRENCY BY SYMBOL
		/// </summary>
		/// <param name="idMoneda"></param>
		/// <returns></returns>
		Moneda BuscarMonedaPorIdentificador(string idMoneda);

		/// <summary>
		/// CREATE CURRENCY
		/// </summary>
		/// <param name="moneda"></param>
		void CrearMoneda(Moneda moneda);

		/// <summary>
		/// RETRIEVE ALL CURRENCIES
		/// </summary>
		/// <returns></returns>
		List<Moneda> ObtenerMonedas();

		/// <summary>
		/// UPDATE CURRENCY
		/// </summary>
		/// <param name="moneda"></param>
		void ActualizarMoneda(Moneda moneda);

		/// <summary>
		/// DELETE CURRENCY
		/// </summary>
		/// <param name="moneda"></param>
		void BorrarMoneda(Moneda moneda);

		/// <summary>
		/// RETRIEVE BY IDORIGEN && IDDESTINO
		/// </summary>
		/// <param name="idOrigen"></param>
		/// <param name="idDestino"></param>
		/// <returns></returns>
		FactorConversion BuscarFactorPorOrigenDestino(int idOrigen, int idDestino);

		/// <summary>
		/// RETRIEVE FACTOR BY ID
		/// </summary>
		/// <param name="idFactor"></param>
		/// <param name="ctx"></param>
		/// <returns></returns>
		FactorConversion BuscarFactorPorId(int idFactor);

		/// <summary>
		/// CREATE FACTOR
		/// </summary>
		/// <param name="factor"></param>
		void CrearFactores(FactorConversion factor);

		/// <summary>
		/// RETRIEVE ALL FACTORS
		/// </summary>
		/// <returns></returns>
		List<FactorConversion> ObtenerFactores();

		/// <summary>
		/// UPDATE FACTOR
		/// </summary>
		/// <param name="factor"></param>
		void ActualizarFactores(FactorConversion factor);

		/// <summary>
		/// DELETE FACTOR
		/// </summary>
		/// <param name="factor"></param>
		void BorrarFactor(FactorConversion factor);

		/// <summary>
		/// RETRIEVE N NUMBER OF RECORDS
		/// </summary>
		/// <param name="desde"></param>
		/// <param name="hasta"></param>
		/// <returns></returns>
		List<Historial> BuscarNHistoriales(int desde, int hasta);

		/// <summary>
		/// RETRIEVE RECORDS BY ID
		/// </summary>
		/// <param name="idHistorial"></param>
		/// <param name="ctx"></param>
		/// <returns></returns>
		Historial BuscarHistorialPorId(int idHistorial);

		/// <summary>
		/// CREATE RECORD
		/// </summary>
		/// <param name="historial"></param>
		void CrearHistorial(Historial historial);

		/// <summary>
		/// RETRIEVE ALL RECORDS
		/// </summary>
		/// <returns></returns>
		List<Historial> ObtenerHistoriales();

		/// <summary>
		/// UPDATE RECORD
		/// </summary>
		/// <param name="historial"></param>
		void ActualizarHistorial(Historial historial);

		/// <summary>
		/// DELETE RECORD
		/// </summary>
		/// <param name="historial"></param>
		void BorrarHistorial(Historial historial);

		Pais BuscarPais(string pais);

		/// <summary>
		/// RETRIEVE COUNTRY BY ID
		/// </summary>
		/// <param name="idPais"></param>
		/// <param name="ctx"></param>
		/// <returns></returns>
		Pais BuscarPaisPorId(int idPais);

		/// <summary>
		/// CREATE COUNTRY
		/// </summary>
		/// <param name="pais"></param>
		void CrearPais(Pais pais);

		/// <summary>
		/// RETRIEVE ALL COUNTRIES
		/// </summary>
		/// <returns></returns>
		List<Pais> ObtenerPaises();

		/// <summary>
		/// UPDATE COUNTRY
		/// </summary>
		/// <param name="pais"></param>
		void ActualizarPais(Pais pais);

		/// <summary>
		/// DELETE COUNTRY
		/// </summary>
		/// <param name="pais"></param>
		void BorrarPais(Pais pais);
	}
}