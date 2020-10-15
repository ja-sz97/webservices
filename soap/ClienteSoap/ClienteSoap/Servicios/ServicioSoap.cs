using clientesoap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace clientesoap.Servicios
{
    public class ServicioSoap
    {
        public SoapRut ctrRut(string rut)
        {

            SOAP.redesClient run = new SOAP.redesClient();
            return new SoapRut()
            {
                Rut = run.validarut(rut)
            };
        }
        public SoapSaludo ctrSaludo(string nombres, string ap, string am, string sexo)
        {
            SOAP.redesClient name = new SOAP.redesClient();
            return new SoapSaludo()
            {
                Saludo = name.nombrepropio(nombres, ap, am, sexo)
            };
        }
    }
}