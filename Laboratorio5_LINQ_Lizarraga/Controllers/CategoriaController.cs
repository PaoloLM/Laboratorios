using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio5_LINQ_Lizarraga.Models;

namespace Laboratorio5_LINQ_Lizarraga.Controllers
{
    public class CategoriaController : Controller
    {
        private CATEGORIA objCategoria = new CATEGORIA();

        // GET: Categoria
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            return View(objCategoria.Listar());
        }

        public ActionResult ConsultaWhere()
        {
            return View(objCategoria.ConsultaWhere());
        }
    }
}