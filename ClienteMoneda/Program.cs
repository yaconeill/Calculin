using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteMoneda.MonedaReference;

namespace ClienteMoneda
{
	class Program
	{
		static void Main(string[] args)
		{
			MonedaReference.MonedaServiceClient proxy = 
				new MonedaReference.MonedaServiceClient();
			try
			{
				List<Moneda> listmoneda = proxy.GetMonedas();
				List<Historial> listaHistorials = proxy.GetHistoriales();
				foreach (var m in listmoneda)
				{
					Console.WriteLine($"Moneda: {m.IdentificadorMoneda}\tNombre: {m.Nombre}");
				}
				Console.WriteLine("\n");
				foreach (var h in listaHistorials)
				{
					Console.WriteLine($"Id: {h.Id}\n" +
				   $"idUsuario: {h.IdUsuario}\n" +
				   $"Moneda Origen: {h.IdOrigen}\n" +
				   $"Moneda Destino: {h.IdDestino}\n" +
				   $"Fecha: { h.Fecha }\n" +
				   $"Cantidad: {h.Cantidad}\n" +
				   $"Factor de cambio: { h.Factor }\n" +
				   $"Resultado: {h.Resultado}\n");
				}

				//Moneda moneda = proxy.GetMoneda(3);
				//Console.WriteLine(moneda.IdentificadorMoneda);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			finally
			{
				proxy.Close();
			}
			Console.WriteLine("\nPulsar cualquier tecla para salir");
			Console.ReadKey();
		}
	}
}
