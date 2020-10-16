using SoapClient.Servicios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SoapClient.Models;

namespace SoapClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Saludo()
        {
            return View();
        }

        public IActionResult Rut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VerRut(string rut)
        {
            var ServicioSoap = new ServicioSoap();
            var model = ServicioSoap.CtrRut(rut);
            return View(model);
        }
        [HttpPost]
        public IActionResult VerSaludo(string nombres, string ap, string am, string sexo)
        {

            var ServicioSoap = new ServicioSoap();
            var model = ServicioSoap.CtrSaludo(nombres, ap, am, sexo);
            return View(model);
        }

    }
}
