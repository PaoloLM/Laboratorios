using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio4_MVC_Lizarraga.Models;

namespace Laboratorio4_MVC_Lizarraga.Controllers
{
    public class EncuestasController : Controller
    {
        private ClsEncuestas Encuesta;

        // Constructor
        public EncuestasController()
        {
            if (System.Web.HttpContext.Current.Session["encuesta"] == null)
            {
                Encuesta = new ClsEncuestas();

                // Encuesta
                Encuesta.Titulo = "¿Que lenguaje de programacion te gusta?";
                Encuesta.CantidadTotal = 0;
                Encuesta.Alternativa = new List<ClsAlternativa>();

                // Alternativas
                ClsAlternativa objAlternativa1 = new ClsAlternativa();
                objAlternativa1.Titulo = "Visual Basic";
                objAlternativa1.Cantidad = 0;
                objAlternativa1.Porcentaje = 0;
                Encuesta.Alternativa.Add(objAlternativa1);

                ClsAlternativa objAlternativa2 = new ClsAlternativa();
                objAlternativa2.Titulo = "Java Script";
                objAlternativa2.Cantidad = 0;
                objAlternativa2.Porcentaje = 0;
                Encuesta.Alternativa.Add(objAlternativa2);

                ClsAlternativa objAlternativa3 = new ClsAlternativa();
                objAlternativa3.Titulo = "C++";
                objAlternativa3.Cantidad = 0;
                objAlternativa3.Porcentaje = 0;
                Encuesta.Alternativa.Add(objAlternativa3);

                ClsAlternativa objAlternativa4 = new ClsAlternativa();
                objAlternativa4.Titulo = "Java";
                objAlternativa4.Cantidad = 0;
                objAlternativa4.Porcentaje = 0;
                Encuesta.Alternativa.Add(objAlternativa4);

                System.Web.HttpContext.Current.Session["encuesta"] = Encuesta;
            }

            else
            {
                Encuesta = System.Web.HttpContext.Current.Session["encuesta"] as ClsEncuestas;
            }
        }

        [HttpGet]
        public ActionResult Index(ClsEncuestas encuesta)
        {
            return View(Encuesta);
        }

        [HttpPost]
        public ActionResult Index()
        {
            int index = Int32.Parse(Request["index"].ToString());
            ClsAlternativa alternativa = Encuesta.Alternativa[index];

            alternativa.Cantidad++;
            Encuesta.CantidadTotal = Encuesta.Alternativa.Sum(x => x.Cantidad);

            foreach (ClsAlternativa alt in Encuesta.Alternativa)
            {
                alt.Porcentaje = alt.Cantidad * 100 / Encuesta.CantidadTotal;
            }

            System.Web.HttpContext.Current.Session["encuesta"] = Encuesta;

            return View(Encuesta);
        }
    }
}