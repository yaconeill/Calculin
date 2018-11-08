using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ModeloCore;

namespace CambioMonedaWeb
{
	public class HomeViewModel
	{
		public List<Moneda> ListaMonedas { get; set; }

		public List<FactorConversion> ListaConversiones { get; set; }

		public string Titulo { get; set; }

		[Required]
		public string IdOrigen { get; set; }

		[Required]
		public string IdDestino{ get; set; }
		
		[Required]
		[Range(0.0005, Double.MaxValue, ErrorMessage = "El valor {0} debe ser mayor a 0")]
		public decimal Cantidad { get; set; }
	}
}
