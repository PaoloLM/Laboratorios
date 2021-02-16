using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio1_MVC_Lizarraga.Controllers
{
    public class indexController : Controller
    {
        // GET: index
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VerInformacion()
        {
            //Definiendo datos como el bundle en android
            ViewBag.Nombre = "Paolo";
            ViewBag.Apellido = "Lanchipa";
            ViewBag.Edad = 18;

            ViewData["Talla"] = 1.75;
            ViewData["Sexo"] = true;

            ViewData["FechaHora"] = DateTime.Now.ToString();

            return View();
        }
    }
}