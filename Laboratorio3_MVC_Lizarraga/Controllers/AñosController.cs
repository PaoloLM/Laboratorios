using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3_MVC_Lizarraga.Models;

namespace Laboratorio3_MVC_Lizarraga.Controllers
{
    public class AñosController : Controller
    {
        // GET: Años
        public ActionResult Index(ClsBisiesto objBisiesto)
        {
            if (Request.Form["verCalculo"] == "B")
            {
                objBisiesto.verCalculo = 1;
            }

            else if (Request.Form["verCalculo"] == "N")
            {
                objBisiesto.verCalculo = 2;
            }

            else if (Request.Form["verCalculo"] == "A")
            {
                objBisiesto.verCalculo = 3;
            }

            return View(objBisiesto);
        }
    }
}