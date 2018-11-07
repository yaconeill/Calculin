using System.Collections.Generic;
using System.Linq;
using ContextoCore;
using ModeloCore;

namespace RepositorioCore
{
	public class RepositorioFalso : IRepositorio
	{
		public RepositorioFalso()
		{
			ListaMonedas = new List<Moneda>();
			ListaFactores = new List<FactorConversion>();
			ListaHistoriales = new List<Historial>();
			ListaPaises = new List<Pais>();
		}
		public List<Moneda> ListaMonedas { get; set; }
		public List<FactorConversion> ListaFactores { get; set; }
		public List<Historial> ListaHistoriales { get; set; }
		public List<Pais> ListaPaises { get; set; }

		//---------------------------------------------------------------------------------
		#region Moneda CRUD

		/// <summary>
		/// RETRIEVE CURRENCY BY ID
		/// </summary>
		/// <param name="idMoneda"></param>
		/// <param name="ctx"></param>
		/// <returns></returns>
		public Moneda BuscarMonedaPorId(int idMoneda) => new Moneda();

		public Moneda BuscarMonedaPorIdentificador(string idMoneda) => new Moneda();

		/// <summary>
		/// CREATE CURRENCY
		/// </summary>
		/// <param name="moneda"></param>
		public void CrearMoneda(Moneda moneda) { }

		/// <summary>
		/// RETRIEVE ALL CURRENCIES
		/// </summary>
		/// <returns></returns>
		public List<Moneda> ObtenerMonedas() => ListaMonedas;

		/// <summary>
		/// UPDATE CURRENCY
		/// </summary>
		/// <param name="moneda"></param>
		public void ActualizarMoneda(Moneda moneda) { }

		/// <summary>
		/// DELETE CURRENCY
		/// </summary>
		/// <param name="moneda"></param>
		public void BorrarMoneda(Moneda moneda) { }
		#endregion
		//---------------------------------------------------------------------------------
		#region Factores CRUD

		/// <summary>
		/// RETRIEVE BY IDORIGEN && IDDESTINO
		/// </summary>
		/// <param name="idOrigen"></param>
		/// <param name="idDestino"></param>
		/// <returns></returns>
		public FactorConversion BuscarFactorPorOrigenDestino(int idOrigen, int idDestino) => new FactorConversion();

		/// <summary>
		/// RETRIEVE FACTOR BY ID
		/// </summary>
		/// <param name="idFactor"></param>
		/// <param name="ctx"></param>
		/// <returns></returns>
		public FactorConversion BuscarFactorPorId(int idFactor) => new FactorConversion();

		/// <summary>
		/// CREATE FACTOR
		/// </summary>
		/// <param name="factor"></param>
		public void CrearFactores(FactorConversion factor) { }

		/// <summary>
		/// RETRIEVE ALL FACTORS
		/// </summary>
		/// <returns></returns>
		public List<FactorConversion> ObtenerFactores() => ListaFactores;

		/// <summary>
		/// UPDATE FACTOR
		/// </summary>
		/// <param name="factor"></param>
		public void ActualizarFactores(FactorConversion factor) { }

		/// <summary>
		/// DELETE FACTOR
		/// </summary>
		/// <param name="factor"></param>
		public void BorrarFactor(FactorConversion factor) { }

		#endregion
		//---------------------------------------------------------------------------------
		#region Historial CRUD

		/// <summary>
		/// RETRIEVE N NUMBER OF RECORDS
		/// </summary>
		/// <param name="desde"></param>
		/// <param name="hasta"></param>
		/// <returns></returns>
		public List<Historial> BuscarNHistoriales(int desde, int hasta, string idUsuario) => ListaHistoriales;

		/// <summary>
		/// RETRIEVE RECORDS BY ID
		/// </summary>
		/// <param name="idHistorial"></param>
		/// <param name="ctx"></param>
		/// <returns></returns>
		public Historial BuscarHistorialPorId(int idHistorial) => new Historial();

		/// <summary>
		/// CREATE RECORD
		/// </summary>
		/// <param name="historial"></param>
		public void CrearHistorial(Historial historial) { }

		/// <summary>
		/// RETRIEVE ALL RECORDS
		/// </summary>
		/// <returns></returns>
		public List<Historial> ObtenerHistoriales() => ListaHistoriales;

		/// <summary>
		/// UPDATE RECORD
		/// </summary>
		/// <param name="historial"></param>
		public void ActualizarHistorial(Historial historial) { }

		/// <summary>
		/// DELETE RECORD
		/// </summary>
		/// <param name="historial"></param>
		public void BorrarHistorial(Historial historial) { }

		#endregion
		//---------------------------------------------------------------------------------
		#region Pais CRUD

		public Pais BuscarPais(string pais) => new Pais();

		/// <summary>
		/// RETRIEVE COUNTRY BY ID
		/// </summary>
		/// <param name="idPais"></param>
		/// <param name="ctx"></param>
		/// <returns></returns>
		public Pais BuscarPaisPorId(int idPais) => new Pais();

		/// <summary>
		/// CREATE COUNTRY
		/// </summary>
		/// <param name="pais"></param>
		public void CrearPais(Pais pais) { }

		/// <summary>
		/// RETRIEVE ALL COUNTRIES
		/// </summary>
		/// <returns></returns>
		public List<Pais> ObtenerPaises() => ListaPaises;

		/// <summary>
		/// UPDATE COUNTRY
		/// </summary>
		/// <param name="pais"></param>
		public void ActualizarPais(Pais pais) { }

		/// <summary>
		/// DELETE COUNTRY
		/// </summary>
		/// <param name="pais"></param>
		public void BorrarPais(Pais pais) { }

		#endregion
	}
}