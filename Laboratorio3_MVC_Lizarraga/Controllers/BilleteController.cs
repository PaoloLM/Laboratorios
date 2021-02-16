using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3_MVC_Lizarraga.Models;

namespace Laboratorio3_MVC_Lizarraga.Controllers
{
    public class BilleteController : Controller
    {
        public ActionResult RealizarCalculo(ClsBillete objBillete)
        {
            int cant100, cant50, cant20, cant10;
            int res100, res50, res20, res10;
            int total;

            total = objBillete.monto;

            cant100 = total / 100;
            res100 = total % 100;

            cant50 = res100 / 50;
            res50 = res100 % 50;

            cant20 = res50 / 20;
            res20 = res50 % 20;

            cant10 = res20 / 10;
            res10 = res20 % 10;

            objBillete.b100 = cant100;
            objBillete.b50 = cant50;
            objBillete.b20 = cant20;
            objBillete.b10 = cant10;

            return View(objBillete);
        }
    }
}