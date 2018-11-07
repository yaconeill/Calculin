using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositorioCore;

namespace CambioMonedaWeb.Controllers
{
    [Route("api/historiales")]
    [ApiController]
    public class ApiController : ControllerBase
    {
		private readonly IRepositorio _repositorio;

	    public ApiController(IRepositorio repositorio)
	    {
			_repositorio = repositorio;

		}

		[HttpGet("{id}")]
	    public IActionResult GetHistorial(int id)
		{
		    var buscarHistorial = _repositorio.BuscarHistorialPorId(id);
            if(buscarHistorial == null)
                return NotFound();

            return Ok(buscarHistorial);
		}
    }
}