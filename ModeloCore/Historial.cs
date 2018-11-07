using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloCore
{
	public class Historial
	{
		[Key]
		public int Id { get; set; }
		public string IdUsuario { get; set; }
		public string IdOrigen { get; set; }
		public string IdDestino { get; set; }
		public DateTime Fecha { get; set; }
		public decimal Cantidad { get; set; }
		public decimal Factor { get; set; }
		public decimal Resultado { get; set; }

		public override string ToString()
		{
			return $"Id: {Id}\n" +
				   $"idUsuario: {IdUsuario}\n" +
				   $"Moneda Origen: {IdOrigen}\n" +
				   $"Moneda Destino: {IdDestino}\n" +
				   $"Fecha: { Fecha }\n" +
				   $"Cantidad: {Cantidad}\n" +
				   $"Factor de cambio: { Factor }\n" +
				   $"Resultado: {Resultado}\n";
		}
	}
}
