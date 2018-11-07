using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloCore
{
	public class FactorConversion
	{
		[Key]
		public int Id { get; set; }
		public decimal Factor { get; set; }

		public int IdMonedaOrigen { get; set; }
		public int IdMonedaDestino { get; set; }

		/// <summary>
		/// Propiedades de navegación
		/// </summary>
		//[ForeignKey(nameof(IdMonedaOrigen))]
		//public Moneda MonedaOrigen { get; set; }

		//[ForeignKey(nameof(IdMonedaDestino))]
		//public Moneda MonedaDestino { get; set; }

	}
}
