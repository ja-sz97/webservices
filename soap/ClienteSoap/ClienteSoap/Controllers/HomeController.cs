using clientesoap.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clientesoap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Rut(string rut)
        {
            var ServicioSoap = new ServicioSoap();
            var model = ServicioSoap.ctrRut(rut);
            return View(model);
        }
        [HttpPost]
        public ActionResult Nombre(string ap, string am, string nombres, string sexo)
        {

            var ServicioSoap = new ServicioSoap();
            var model = ServicioSoap.ctrSaludo(ap, am, nombres, sexo);
            return View(model);
        }
    }
}