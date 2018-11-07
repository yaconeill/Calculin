using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloCore;

namespace CambioMonedaWeb
{
    public class ConversionViewModel
    {
		public List<Moneda> ListaMonedas { get; set; }

		public string IdOrigen { get; set; }

		public string IdDestino { get; set; }

		public List<string> MonedasSeleccionadas { get; set; }

		public decimal Cantidad { get; set; }

		public decimal Resultado { get; set; }

		public string ErrorMsg { get; set; }

	}
}
