using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModeloCore;
using RepositorioCore;

namespace ApiWeb.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FactoresController : ControllerBase
	{
		private readonly IRepositorio _repositorio;
		private ILogger<FactoresController> _logger;


		public FactoresController(IRepositorio repositorio, ILogger<FactoresController> logger)
		{
			_repositorio = repositorio;
			_logger = logger;
		}

		[HttpGet()]
		public IActionResult GetFactores()
		{
			var factores = _repositorio.ObtenerFactores();

			if (factores == null)
				return NotFound();
			return Ok(factores);
		}

		[HttpGet("{id}", Name = "GetFactores")]
		public IActionResult GetFactor(int id)
		{
			var buscarFactor = _repositorio.BuscarFactorPorId(id);

			if (buscarFactor == null)
				return NotFound();

			return Ok(buscarFactor);
		}

		[HttpPost()]
		public IActionResult PostFactor([FromBody]FactorConversion factor)
		{
			_repositorio.CrearFactores(factor);
			var newFactor = _repositorio.BuscarFactorPorId(factor.Id);

			return CreatedAtRoute("GetFactores", new
			{ id = newFactor.Id }, newFactor);
		}

		[HttpPut("{id}")]
		public IActionResult PutFactor(int id, [FromBody]FactorConversion factor)
		{
			var buscarFactor = _repositorio.BuscarFactorPorId(id);

			if (buscarFactor == null)
				return NotFound();
			buscarFactor.Factor = factor.Factor;
			buscarFactor.IdMonedaOrigen = factor.IdMonedaOrigen;
			buscarFactor.IdMonedaDestino = factor.IdMonedaDestino;
			_repositorio.ActualizarFactores(buscarFactor);

			return CreatedAtRoute("GetFactores", new
			{ id = buscarFactor.Id }, buscarFactor);
		}

		[HttpPatch("{id}")]
		public IActionResult PatchFactor(int id, [FromBody] JsonPatchDocument<FactorConversion> patchDoc)
		{
			if (patchDoc == null)
			{
				return BadRequest();
			}
			var buscarFactor = _repositorio.BuscarFactorPorId(id);

			if (buscarFactor == null)
				return NotFound();

			var factorToPatch = new FactorConversion
			{
				Factor = buscarFactor.Factor,
				IdMonedaOrigen = buscarFactor.IdMonedaOrigen,
				IdMonedaDestino = buscarFactor.IdMonedaDestino
			};

			patchDoc.ApplyTo(factorToPatch, ModelState);

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			TryValidateModel(factorToPatch);

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			buscarFactor.Factor = factorToPatch.Factor;
			buscarFactor.IdMonedaOrigen = factorToPatch.IdMonedaOrigen;
			buscarFactor.IdMonedaDestino = factorToPatch.IdMonedaDestino;
			_repositorio.ActualizarFactores(buscarFactor);
			return CreatedAtRoute("GetFactores", new
			{ id = buscarFactor.Id }, buscarFactor);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteFactor(int id)
		{
			var buscarFactor = _repositorio.BuscarFactorPorId(id);

			if (buscarFactor == null)
				return NotFound();
			_repositorio.BorrarFactor(buscarFactor);

			return NoContent();
		}
	}
}