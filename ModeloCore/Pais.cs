using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModeloCore
{
	public class Pais
	{
		[Key]
		public int Id { get; set; }
		public string Nombre { get; set; }
		//public List<Usuario> Usuarios { get; set; }
	}
}