using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositorioCore;

namespace CambioMonedaWeb.Controllers
{
    [Route("api/monedas")]
    [ApiController]
    public class ApiController : ControllerBase
    {
		private readonly IRepositorio _repositorio;

	    public ApiController(IRepositorio repositorio)
	    {
			_repositorio = repositorio;

		}

		[HttpGet()]
	    public IActionResult GetMonedas()
		{
			return Ok(_repositorio.ObtenerMonedas());
		}
    }
}