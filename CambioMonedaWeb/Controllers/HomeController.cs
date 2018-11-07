using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CambioMonedaWeb.Models;
using Conversor;
using ForexQuotes;
using Microsoft.AspNetCore.Authorization;
using ModeloCore;
using RepositorioCore;


namespace CambioMonedaWeb.Controllers
{
    
    public class HomeController : Controller
	{
		private readonly IRepositorio _repositorio;

		private readonly IConversionMoneda _conversionMoneda;

		public HomeController(IRepositorio repositorio, IConversionMoneda conversionMoneda)
		{
			_repositorio = repositorio;
			_conversionMoneda = conversionMoneda;
		}

		public IActionResult Index()
		{
		    var listaMonedas = _repositorio.ObtenerMonedas();
		    if (listaMonedas == null)
		    {
                _conversionMoneda.LoadConversionList();
                _conversionMoneda.ActualizarNombres();
            }
            return View();
		}

        [Authorize]
		public IActionResult VerMonedas()
		{
			var listaMonedas = _repositorio.ObtenerMonedas();

			var homeViewModel = new HomeViewModel
			{
				Titulo = "Calculin",
				ListaMonedas = listaMonedas,
				ImagenMoneda = "https://www.worldatlas.com/r/w728-h425-c728x425/upload/d0/91/86/shutterstock-403371907.jpg"
			};

			return View(homeViewModel);
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
        [Authorize]
		public IActionResult DetalleMoneda(int id)
		{
			var moneda = _repositorio.BuscarMonedaPorId(id);
			if (moneda == null)
			{
				return NotFound();
			}
			return View(moneda);
		}

        [Authorize]
		[HttpPost]
		public IActionResult DetalleMoneda(Moneda moneda)
		{
			if (ModelState.IsValid)
			{
				_repositorio.ActualizarMoneda(moneda);
				return RedirectToAction("Index");
			}
			return View();
		}

        [Authorize]
		[HttpGet]
		public IActionResult VerConversor()
		{
			var listaMonedas = _repositorio.ObtenerMonedas();

			var conversionView = new ConversionViewModel()
			{
				ListaMonedas = listaMonedas,
			};
			return View(conversionView);
		}

        [Authorize]
		[HttpPost]
		public IActionResult VerConversor(HomeViewModel model)
		{
			if (ModelState.IsValid)
			{
				var listaMonedas = _repositorio.ObtenerMonedas();
				var error = "";
				var resultado = _conversionMoneda.RealizarCambio(model.IdOrigen, model.IdDestino, model.Cantidad);

				if (resultado == -1)
				{
					error = "No se ha podido realizar el cambio";
				}

				var conversorViewModel = new ConversionViewModel
				{
					IdOrigen = model.IdOrigen,
					IdDestino = model.IdDestino,
					Cantidad = model.Cantidad,
					Resultado = resultado,
					ListaMonedas = listaMonedas,
					ErrorMsg = error
				};
				return View(conversorViewModel);
			}
			return RedirectToAction("VerConversor");
		}

	}
}
