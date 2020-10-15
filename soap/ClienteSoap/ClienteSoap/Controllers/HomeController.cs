﻿using clientesoap.Servicios;
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

        public ActionResult Rut()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Saludo()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult VerRut(string rut)
        {
            var ServicioSoap = new ServicioSoap();
            var model = ServicioSoap.CtrRut(rut);
            return View(model);
        }
        [HttpPost]
        public ActionResult VerSaludo(string nombres, string ap, string am, string sexo)
        {

            var ServicioSoap = new ServicioSoap();
            var model = ServicioSoap.CtrSaludo(nombres, ap, am, sexo);
            return View(model);
        }
    }
}