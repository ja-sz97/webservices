using SoapClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoapClient.Servicios
{
    public class ServicioSoap
    {
        public SoapRut CtrRut(string rut)
        {

            SOAP.redesClient run = new SOAP.redesClient();
            if(rut == null)
            {
                rut="";
            }
            return new SoapRut()
            {
                Rut = run.validarut(rut)
            };
        }
        public SoapSaludo CtrSaludo(string nombres, string ap, string am, string sexo)
        {
            SOAP.redesClient name = new SOAP.redesClient();
            if(nombres == null)
            {
                nombres = "";
            }
            if (ap == null)
            {
                ap = "";
            }
            if (am == null)
            {
                am = "";
            }
            if (sexo == null)
            {
                sexo = " ";
            }
            return new SoapSaludo()
            {
                Saludo = name.nombrepropio(nombres, ap, am, sexo)
            };
        }
    }
}
