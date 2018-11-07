using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModeloCore;
using RepositorioCore;

namespace ApiWeb.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MonedasController : ControllerBase
	{
		private readonly IRepositorio _repositorio;
		private ILogger<MonedasController> _logger;

		public MonedasController(IRepositorio repositorio, ILogger<MonedasController> logger)
		{
			_repositorio = repositorio;
			_logger = logger;
		}

		[HttpGet()]
		public IActionResult GetMoneda()
		{
			var monedas = _repositorio.ObtenerMonedas();

			if (monedas == null)
				return NotFound();
			return Ok(monedas);
		}

		[HttpGet("{id}", Name = "GetMonedas")]
		public IActionResult GetMonedas(int id)
		{
			var monedaBuscar = _repositorio.BuscarMonedaPorId(id);

			if (monedaBuscar == null)
			{
				var msg = $"La moneda con el id {id} no se ha encontrado";
				_logger.LogInformation(msg);
				return NotFound(msg);
			}

			return Ok(monedaBuscar);
		}

		[HttpPost()]
		public IActionResult PostMoneda([FromBody]Moneda moneda)
		{
			_repositorio.CrearMoneda(moneda);
			var newMoneda = _repositorio.BuscarMonedaPorId(moneda.Id);

			return CreatedAtRoute("GetMonedas", new
			{ id = newMoneda.Id }, newMoneda);
		}

		[HttpPut("{id}")]
		public IActionResult PutMoneda(int id, [FromBody]Moneda moneda)
		{
			var monedaBuscar = _repositorio.BuscarMonedaPorId(id);

			if (monedaBuscar == null)
				return NotFound();
			monedaBuscar.IdentificadorMoneda = moneda.IdentificadorMoneda;
			monedaBuscar.Nombre = moneda.Nombre;
			_repositorio.ActualizarMoneda(monedaBuscar);

			return CreatedAtRoute("GetMonedas", new
			{ id = monedaBuscar.Id }, monedaBuscar);
		}

		[HttpPatch("{id}")]
		public IActionResult PatchMoneda(int id, [FromBody] JsonPatchDocument<Moneda> patchDoc)
		{
			if (patchDoc == null)
			{
				return BadRequest();
			}
			var monedaBuscar = _repositorio.BuscarMonedaPorId(id);

			if (monedaBuscar == null)
				return NotFound();

			var monedaToPatch = new Moneda
			{
				IdentificadorMoneda = monedaBuscar.IdentificadorMoneda,
				Nombre = monedaBuscar.Nombre
			};

			patchDoc.ApplyTo(monedaToPatch, ModelState);

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (monedaToPatch.IdentificadorMoneda == monedaToPatch.Nombre)
			{
				ModelState.AddModelError("IdentificadorMoneda", "El identificador debe ser distinto del nombre.");
			}

			TryValidateModel(monedaToPatch);

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			monedaBuscar.IdentificadorMoneda = monedaToPatch.IdentificadorMoneda;
			monedaBuscar.Nombre = monedaToPatch.Nombre;
			_repositorio.ActualizarMoneda(monedaBuscar);
			return CreatedAtRoute("GetMonedas", new
			{ id = monedaBuscar.Id }, monedaBuscar);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteMoneda(int id)
		{
			var monedaBuscar = _repositorio.BuscarMonedaPorId(id);

			if (monedaBuscar == null)
				return NotFound();
			_repositorio.BorrarMoneda(monedaBuscar);

			return NoContent();
		}
	}
}