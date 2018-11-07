using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModeloCore
{
    public class Moneda
    {
		[Key]
        public int Id { get; set; }
        public string IdentificadorMoneda { get; set; } // EUR
        public string Nombre { get; set; } // EUROS
	    //public List<FactorConversion> Origen { get; set; }
	    //public List<FactorConversion> Destino { get; set; }
    }
}