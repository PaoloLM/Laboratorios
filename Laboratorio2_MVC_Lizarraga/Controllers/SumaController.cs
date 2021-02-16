using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio2_MVC_Lizarraga.Models;

namespace Laboratorio2_MVC_Lizarraga.Controllers
{
    public class SumaController : Controller
    {
        // GET: Suma
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VisualizarSuma()
        {
            ClsSuma objSuma = new ClsSuma();
            objSuma.numero1 = Convert.ToDouble(Request.Form["txtN1"]);
            objSuma.numero2 = Convert.ToDouble(Request.Form["txtN2"]);
            objSuma.resultado = objSuma.numero1 + objSuma.numero2;
            //return View("VisualizarSuma", objSuma);
            return View(objSuma);
        }
    }
}