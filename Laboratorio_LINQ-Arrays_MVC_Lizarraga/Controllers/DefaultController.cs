﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio_LINQ_Arrays_MVC_Lizarraga.Controllers
{
    public class DefaultController : Controller
    {

        String[] meses =
        {
            "Enero", "Febrero","Marzo","Abril","Mayo","Junio","Julio",
            "Agosto","Septiembre","Octubre","Noviembre","Diciembre"
        };

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SelectMany()
        {
            var query = meses.SelectMany(e => e.ToCharArray());

            foreach (char mes in query)
            {
                ViewData["Resultado"] += Convert.ToString(mes) + "\n";
            }

            return View();
        }

        public ActionResult ListarMeses()
        {
            var query = meses.ToList();

            foreach (var mes in query)
            {
                ViewData["Resultado"] += Convert.ToString(mes) + "\n";
            }

            return View();
        }

        public ActionResult Reverse()
        {
            String[] mesesEnReversa = meses.Reverse().ToArray();
            
            foreach (var mes in mesesEnReversa)
            {
                ViewData["Resultado"] += Convert.ToString(mes) + "\n";
            }

            return View();
        }

        public ActionResult Where()
        {
            var query = from mes in meses
                        where mes.StartsWith("A")
                        select new { NombreMes = mes };

            foreach (var mes in query)
            {
                ViewData["Resultado"] += Convert.ToString(mes) + "\n";
            }

            return View();
        }

        public ActionResult Where2()
        {
            var query = from mes in meses
                        where mes.ToLowerInvariant().Contains("a")
                        select new { NombreMes = mes };

            foreach (var mes in query)
            {
                ViewData["Resultado"] += Convert.ToString(mes) + "\n";
            }

            return View();
        }

        public ActionResult Where3()
        {
            var query = from mes in meses
                        where mes.Length > 5
                        select new { NombreMes = mes };

            foreach (var mes in query)
            {
                ViewData["Resultado"] += Convert.ToString(mes) + "\n";
            }

            return View();
        }
    }
}