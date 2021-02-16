using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using Laboratorio5_LINQ_Lizarraga.Models;
using System.Web.WebPages;

namespace Laboratorio5_LINQ_Lizarraga.Controllers
{
    public class ProductoController : Controller
    {

        private PRODUCTO objProducto = new PRODUCTO();

        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            return View(objProducto.Listar());
        }

        public ActionResult ConsultaWhere()
        {
            return View(objProducto.ConsultaWhere());
        }

        public ActionResult ConsultaWhere2()
        {
            return View(objProducto.ConsultaWhere2());
        }

        public ActionResult BuscarPorCategoria(string buscar)
        {
            if (buscar == null || buscar == "")
            {
                return View(objProducto.Listar());
            }

            else
            {
                return View(objProducto.BuscarProductoPorCategoria(buscar));
            }            
        }

        public ActionResult BuscarPorCategoria2()
        {
            return View(objProducto.Ordenado());
        }
    }
}