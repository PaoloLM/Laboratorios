using Laboratorio2_MVC_Lizarraga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio2_MVC_Lizarraga.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VisualizarTabla(ClsTabla objTabla)
        {
            return View(objTabla);
        }
    }
}