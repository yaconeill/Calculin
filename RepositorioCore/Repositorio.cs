using System;
using System.Collections.Generic;
using System.Linq;
using ContextoCore;
using ModeloCore;

namespace RepositorioCore
{
	public class Repositorio : IRepositorio
	{
		private readonly MonedaDb _contexto;
		public Repositorio(MonedaDb contexto)
		{
			_contexto = contexto;
			ListaMonedas = new List<Moneda>();
			ListaFactores = new List<FactorConversion>();
			ListaHistoriales = new List<Historial>();
			ListaPaises = new List<Pais>();
		}
		public List<Moneda> ListaMonedas { get; set; }
		public List<FactorConversion> ListaFactores { get; set; }
		public List<Historial> ListaHistoriales { get; set; }
		public List<Pais> ListaPaises { get; set; }

		#region Datos de DB

		//public void InsertarMoneda(Moneda moneda)
		//{
		//	var busqueda = BuscarMoneda(moneda);
		//	using (var contexto = _contexto)
		//	{
		//		if (busqueda == null)
		//		{
		//			contexto.Monedas.Add(moneda);
		//			contexto.SaveChanges();
		//		}

		//	}
		//}

		//public void ActualizarMoneda(Moneda moneda)
		//{
		//	var busqueda = BuscarMoneda(moneda);
		//	using (var contexto = _contexto)
		//	{
		//		if (busqueda != null)
		//		{
		//			busqueda.IdentificadorMoneda = moneda.IdentificadorMoneda;
		//			busqueda.Nombre = moneda.Nombre;
		//			contexto.SaveChanges();
		//		}

		//	}
		//}

		//public Moneda BuscarMoneda(Moneda moneda)
		//{
		//	using (var contexto = _contexto)
		//	{
		//		return contexto.Monedas.FirstOrDefault(m => m.IdentificadorMoneda == moneda.IdentificadorMoneda);
		//	}
		//}

		#endregion
		//---------------------------------------------------------------------------------
		#region Moneda CRUD

		/// <summary>
		/// RETRIEVE CURRENCY BY ID
		/// </summary>
		/// <param name="idMoneda"></param>
		/// <param name="contexto"></param>
		/// <returns></returns>
		public Moneda BuscarMonedaPorId(int idMoneda)
		{
			Moneda buscarMoneda = null;
			try
			{
				buscarMoneda = _contexto.Monedas.FirstOrDefault(p => p.Id == idMoneda);

			}
			catch (System.Exception e)
			{
				Console.WriteLine(e);
			}

			return buscarMoneda;
		}

		public Moneda BuscarMonedaPorIdentificador(string idMoneda)
		{
			Moneda buscarMoneda = null;
			try
			{
				buscarMoneda = _contexto.Monedas.FirstOrDefault(m => m.IdentificadorMoneda == idMoneda);
			}
			catch (System.Exception e)
			{
				Console.WriteLine(e);
			}

			return buscarMoneda;
		}

		/// <summary>
		/// CREATE CURRENCY
		/// </summary>
		/// <param name="moneda"></param>
		public void CrearMoneda(Moneda moneda)
		{
			var buscarMoneda = BuscarMonedaPorIdentificador(moneda.IdentificadorMoneda);
			//var buscarMoneda = BuscarMonedaPorId(moneda.Id);
			if (buscarMoneda == null)
			{
				_contexto.Monedas.Add(moneda);
				_contexto.SaveChanges();
			}
			else
				ActualizarMoneda(moneda);
		}

		/// <summary>
		/// RETRIEVE ALL CURRENCIES
		/// </summary>
		/// <returns></returns>
		public List<Moneda> ObtenerMonedas()
		{
			try
			{
				ListaMonedas = _contexto.Monedas.ToList();
			}
			catch (System.Exception e)
			{
				Console.WriteLine(e);
			}

			return ListaMonedas;
		}

		/// <summary>
		/// UPDATE CURRENCY
		/// </summary>
		/// <param name="moneda"></param>
		public void ActualizarMoneda(Moneda moneda)
		{
			var buscarMoneda = BuscarMonedaPorIdentificador(moneda.IdentificadorMoneda);
			if (buscarMoneda != null)
			{
				buscarMoneda.IdentificadorMoneda = moneda.IdentificadorMoneda;
				buscarMoneda.Nombre = moneda.Nombre;
				_contexto.SaveChanges();
			}
			else
				CrearMoneda(moneda);
		}

		/// <summary>
		/// DELETE CURRENCY
		/// </summary>
		/// <param name="moneda"></param>
		public void BorrarMoneda(Moneda moneda)
		{
			var buscarMoneda = BuscarMonedaPorId(moneda.Id);
			if (buscarMoneda == null) return;
			_contexto.Monedas.Remove(buscarMoneda);
			_contexto.SaveChanges();
		}

		#endregion
		//---------------------------------------------------------------------------------
		#region Factores CRUD

		/// <summary>
		/// RETRIEVE BY IDORIGEN && IDDESTINO
		/// </summary>
		/// <param name="idOrigen"></param>
		/// <param name="idDestino"></param>
		/// <returns></returns>
		public FactorConversion BuscarFactorPorOrigenDestino(int idOrigen, int idDestino)
		{
			return _contexto.FactoresConversion.FirstOrDefault(
				f => f.IdMonedaOrigen == idOrigen &&
					 f.IdMonedaDestino == idDestino);
		}

		/// <summary>
		/// RETRIEVE FACTOR BY ID
		/// </summary>
		/// <param name="idFactor"></param>
		/// <param name="contexto"></param>
		/// <returns></returns>
		public FactorConversion BuscarFactorPorId(int idFactor)
		{
			return _contexto.FactoresConversion.FirstOrDefault(
				p => p.Id == idFactor);
		}

		/// <summary>
		/// CREATE FACTOR
		/// </summary>
		/// <param name="factor"></param>
		public void CrearFactores(FactorConversion factor)
		{
			var buscarFactor = BuscarFactorPorOrigenDestino(factor.IdMonedaOrigen, factor.IdMonedaDestino);
			if (buscarFactor != null) return;
			_contexto.FactoresConversion.Add(factor);
			_contexto.SaveChanges();
			//else
			//{
			//	factor.Id = buscarFactor.Id;
			//	ActualizarFactores(factor);
			//}
		}

		/// <summary>
		/// RETRIEVE ALL FACTORS
		/// </summary>
		/// <returns></returns>
		public List<FactorConversion> ObtenerFactores()
		{
			ListaFactores = _contexto.FactoresConversion.ToList();
			//ListaFactores = Seed.CrearListaFactores();
			return ListaFactores;
		}

		/// <summary>
		/// UPDATE FACTOR
		/// </summary>
		/// <param name="factor"></param>
		public void ActualizarFactores(FactorConversion factor)
		{
			var buscarFactor = BuscarFactorPorOrigenDestino(factor.IdMonedaOrigen, factor.IdMonedaDestino);
			if (buscarFactor == null) return;
			buscarFactor.IdMonedaOrigen = factor.IdMonedaOrigen;
			buscarFactor.IdMonedaDestino = factor.IdMonedaDestino;
			buscarFactor.Factor = factor.Factor;
			_contexto.SaveChanges();
			//}
			//else
			//	CrearFactores(factor);
		}

		/// <summary>
		/// DELETE FACTOR
		/// </summary>
		/// <param name="factor"></param>
		public void BorrarFactor(FactorConversion factor)
		{
			var buscarFactor = BuscarFactorPorId(factor.Id);
			if (buscarFactor == null) return;
			_contexto.FactoresConversion.Remove(buscarFactor);
			_contexto.SaveChanges();
		}

		#endregion
		//---------------------------------------------------------------------------------
		#region Historial CRUD

		/// <summary>
		/// RETRIEVE N NUMBER OF RECORDS
		/// </summary>
		/// <param name="desde"></param>
		/// <param name="hasta"></param>
		/// <returns></returns>
		public List<Historial> BuscarNHistoriales(int desde, int hasta, string idUsuario)
		{
			return _contexto.Historiales.Where(h => h.IdUsuario == idUsuario).OrderByDescending(h => h.Id).Skip(desde).Take(hasta).ToList();
		}

		/// <summary>
		/// RETRIEVE RECORDS BY ID
		/// </summary>
		/// <param name="idHistorial"></param>
		/// <param name="contexto"></param>
		/// <returns></returns>
		public Historial BuscarHistorialPorId(int idHistorial)
		{
			return _contexto.Historiales.FirstOrDefault(
				p => p.Id == idHistorial);
		}

		/// <summary>
		/// CREATE RECORD
		/// </summary>
		/// <param name="historial"></param>
		public void CrearHistorial(Historial historial)
		{
			var buscarHistorial = BuscarHistorialPorId(historial.Id);
			if (buscarHistorial == null)
			{
				_contexto.Historiales.Add(historial);
				_contexto.SaveChanges();
			}
			else
				ActualizarHistorial(historial);
		}

		/// <summary>
		/// RETRIEVE ALL RECORDS
		/// </summary>
		/// <returns></returns>
		public List<Historial> ObtenerHistoriales()
		{
			ListaHistoriales = _contexto.Historiales.ToList();
			return ListaHistoriales;
			//ListaUsuarios = Seed.CrearListaUsuarios();
		}

		/// <summary>
		/// UPDATE RECORD
		/// </summary>
		/// <param name="historial"></param>
		public void ActualizarHistorial(Historial historial)
		{
			var buscarHistorial = BuscarHistorialPorId(historial.Id);
			if (buscarHistorial != null)
			{
				buscarHistorial.IdOrigen = historial.IdOrigen;
				buscarHistorial.IdDestino = historial.IdDestino;
				buscarHistorial.Factor = historial.Factor;
				buscarHistorial.Cantidad = historial.Cantidad;
				buscarHistorial.Resultado = historial.Resultado;
				buscarHistorial.IdUsuario = historial.IdUsuario;
				buscarHistorial.Fecha = historial.Fecha;
				_contexto.SaveChanges();
			}
			else
				CrearHistorial(historial);
		}

		/// <summary>
		/// DELETE RECORD
		/// </summary>
		/// <param name="historial"></param>
		public void BorrarHistorial(Historial historial)
		{
			var buscarHistorial = BuscarHistorialPorId(historial.Id);
			if (buscarHistorial == null) return;
			_contexto.Historiales.Remove(buscarHistorial);
			_contexto.SaveChanges();
		}

		#endregion
		//---------------------------------------------------------------------------------
		#region Pais CRUD

		public Pais BuscarPais(string pais)
		{
			return _contexto.Paises.FirstOrDefault(p => p.Nombre.Contains(pais));
		}

		/// <summary>
		/// RETRIEVE COUNTRY BY ID
		/// </summary>
		/// <param name="idPais"></param>
		/// <param name="contexto"></param>
		/// <returns></returns>
		public Pais BuscarPaisPorId(int idPais)
		{
			return _contexto.Paises.FirstOrDefault(
			p => p.Id == idPais);
		}

		/// <summary>
		/// CREATE COUNTRY
		/// </summary>
		/// <param name="pais"></param>
		public void CrearPais(Pais pais)
		{
			var buscarPais = BuscarPaisPorId(pais.Id);
			if (buscarPais == null)
			{
				_contexto.Paises.Add(pais);
				_contexto.SaveChanges();
			}
			else
				ActualizarPais(pais);
		}

		/// <summary>
		/// RETRIEVE ALL COUNTRIES
		/// </summary>
		/// <returns></returns>
		public List<Pais> ObtenerPaises()
		{
			ListaPaises = _contexto.Paises.ToList();
			return ListaPaises;
			//ListaUsuarios = Seed.CrearListaUsuarios();
		}

		/// <summary>
		/// UPDATE COUNTRY
		/// </summary>
		/// <param name="pais"></param>
		public void ActualizarPais(Pais pais)
		{
			var buscarPais = BuscarPaisPorId(pais.Id);
			if (buscarPais != null)
			{
				buscarPais.Nombre = pais.Nombre;
				_contexto.SaveChanges();
			}
			else
				CrearPais(pais);
		}

		/// <summary>
		/// DELETE COUNTRY
		/// </summary>
		/// <param name="pais"></param>
		public void BorrarPais(Pais pais)
		{
			var buscarPais = BuscarPaisPorId(pais.Id);
			if (buscarPais == null) return;
			_contexto.Paises.Remove(buscarPais);
			_contexto.SaveChanges();
		}

		#endregion
	}
}
