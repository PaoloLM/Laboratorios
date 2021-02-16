using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio2_MVC_Lizarraga.Models;

namespace Laboratorio2_MVC_Lizarraga.Controllers
{
    public class OperacionController : Controller
    {
        // GET: Operacion
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VisualizarOperacion(ClsOperacion objOperacion)
        {
            //TODO : Cuando es nivel html
            //ClsOperacion objOperacion = new ClsOperacion();
            //objOperacion.numero1 = Convert.ToDouble(Request.Form["txtN1"]);
            //objOperacion.numero2 = Convert.ToDouble(Request.Form["txtN2"]);

            if (Request.Form["tipo"] == "S")
            {
                objOperacion.tipo = "Suma";
                objOperacion.resultado = objOperacion.numero1 + objOperacion.numero2;
            } 
            
            else if (Request.Form["tipo"] == "R")
            {
                objOperacion.tipo = "Resta";
                objOperacion.resultado = objOperacion.numero1 - objOperacion.numero2;
            }
            
            else if (Request.Form["tipo"] == "M")
            {
                objOperacion.tipo = "Multiplicacion";
                objOperacion.resultado = objOperacion.numero1 * objOperacion.numero2;
            }
            
            else if (Request.Form["tipo"] == "D")
            {
                objOperacion.tipo = "Division";
                objOperacion.resultado = objOperacion.numero1 / objOperacion.numero2;
            }

            return View(objOperacion);
        }
    }
}