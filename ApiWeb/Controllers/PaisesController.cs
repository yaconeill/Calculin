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
    public class PaisesController : ControllerBase
    {
		private readonly IRepositorio _repositorio;
		private ILogger<PaisesController> _logger;


		public PaisesController(IRepositorio repositorio, ILogger<PaisesController> logger)
		{
			_repositorio = repositorio;
			_logger = logger;
		}

		[HttpGet()]
		public IActionResult GetPaises()
		{
			var paises = _repositorio.ObtenerPaises();

			if (paises == null)
				return NotFound();
			return Ok(paises);
		}

		[HttpGet("{id}", Name = "GetPaises")]
		public IActionResult GetPais(int id)
		{
			var buscarPais = _repositorio.BuscarPaisPorId(id);

			if (buscarPais == null)
				return NotFound();

			return Ok(buscarPais);
		}

		[HttpPost()]
		public IActionResult PostPais([FromBody]Pais pais)
		{
			_repositorio.CrearPais(pais);
			var newPais = _repositorio.BuscarPaisPorId(pais.Id);

			return CreatedAtRoute("GetPaises", new
			{ id = newPais.Id }, newPais);
		}

		[HttpPut("{id}")]
		public IActionResult PutPais(int id, [FromBody]Pais pais)
		{
			var buscarPais = _repositorio.BuscarPaisPorId(id);

			if (buscarPais == null)
				return NotFound();
			buscarPais.Nombre = pais.Nombre;
			_repositorio.ActualizarPais(buscarPais);

			return CreatedAtRoute("GetPaises", new
			{ id = buscarPais.Id }, buscarPais);
		}

		[HttpPatch("{id}")]
		public IActionResult PatchPais(int id, [FromBody] JsonPatchDocument<Pais> patchDoc)
		{
			if (patchDoc == null)
			{
				return BadRequest();
			}
			var buscarPais = _repositorio.BuscarPaisPorId(id);

			if (buscarPais == null)
				return NotFound();

			var paisToPatch = new Pais
			{
				Nombre = buscarPais.Nombre
			};

			patchDoc.ApplyTo(paisToPatch, ModelState);

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			TryValidateModel(paisToPatch);

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			buscarPais.Nombre = paisToPatch.Nombre;
			_repositorio.ActualizarPais(buscarPais);
			return CreatedAtRoute("GetPaises", new
			{ id = buscarPais.Id }, buscarPais);
		}

		[HttpDelete("{id}")]
		public IActionResult DeletePais(int id)
		{
			var buscarPais = _repositorio.BuscarPaisPorId(id);

			if (buscarPais == null)
				return NotFound();
			_repositorio.BorrarPais(buscarPais);

			return NoContent();
		}
	}
}