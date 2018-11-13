using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CambioMonedaWeb.Data;
using Microsoft.AspNetCore.Mvc;
using CambioMonedaWeb.Models;
using Conversor;
using ForexQuotes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ModeloCore;
using RepositorioCore;


namespace CambioMonedaWeb.Controllers
{

    public class HomeController : Controller
    {
        private readonly IRepositorio _repositorio;
        private readonly UserManager<UsuarioConversor> userManager;
        private readonly SignInManager<UsuarioConversor> signInManager;

        private readonly IConversionMoneda _conversionMoneda;
        private Task<UsuarioConversor> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);


        public HomeController(UserManager<UsuarioConversor> userManager,
            SignInManager<UsuarioConversor> signInManager,
            IRepositorio repositorio, IConversionMoneda conversionMoneda)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _repositorio = repositorio;
            _conversionMoneda = conversionMoneda;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult VerMonedas()
        {
            var listaMonedas = _repositorio.ObtenerMonedas();

            var homeViewModel = new HomeViewModel
            {
                Titulo = "Calculin",
                ListaMonedas = listaMonedas
            };

            return View(homeViewModel);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            var listaMonedas = _repositorio.ObtenerMonedas();
            if (listaMonedas.Count == 0)
            {
                _conversionMoneda.LoadDataBase();
            }
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            _conversionMoneda.LoadConversionList();
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
        public async Task<IActionResult> VerConversor()
        {
            var listaMonedas = _repositorio.ObtenerMonedas();
            var user = await GetCurrentUserAsync();
            var conversionView = new ConversionViewModel()
            {
                ListaMonedas = listaMonedas,
                Historiales = _repositorio.BuscarNHistoriales(0, 10, user.Id)
            };
            return View(conversionView);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> VerConversor(HomeViewModel model)
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
                var user = await GetCurrentUserAsync();
                var idOrigen = _repositorio.BuscarMonedaPorIdentificador(model.IdOrigen);
                var idDestino = _repositorio.BuscarMonedaPorIdentificador(model.IdDestino);
                var factor = _repositorio.BuscarFactorPorOrigenDestino(idOrigen.Id, idDestino.Id);

                _repositorio.CrearHistorial(new Historial
                {
                    IdOrigen = model.IdOrigen,
                    IdDestino = model.IdDestino,
                    IdUsuario = user.Id,
                    Factor = factor.Factor,
                    Cantidad = model.Cantidad,
                    Resultado = resultado,
                    Fecha = DateTime.Now
                });

                var conversorViewModel = new ConversionViewModel
                {
                    IdOrigen = model.IdOrigen,
                    IdDestino = model.IdDestino,
                    Cantidad = model.Cantidad,
                    Resultado = resultado,
                    ListaMonedas = listaMonedas,
                    ErrorMsg = error,
                    Historiales = _repositorio.BuscarNHistoriales(0, 10, user.Id)
                };
                return View(conversorViewModel);
            }
            return View();
        }

    }
}
