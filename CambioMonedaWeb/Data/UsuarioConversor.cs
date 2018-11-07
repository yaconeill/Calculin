using System;
using Microsoft.AspNetCore.Identity;

namespace CambioMonedaWeb.Data
{
    public class UsuarioConversor : IdentityUser
    {
        public DateTime FechaNacimiento { get; set; }
        public int IdPais { get; set; }
    }
}