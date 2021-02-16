using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio4_MVC_Lizarraga.Models;

namespace Laboratorio4_MVC_Lizarraga.Controllers
{
    public class EncuestaController : Controller
    {
        // GET: Encuesta
        public ActionResult Index(ClsEncuesta objEncuesta)
        {
            ViewBag.Alternativa1 = "Java";
            ViewBag.Alternativa2 = "PHP";           
            ViewData["Alternativa3"] = "C#";
            ViewBag.Alternativa4 = "Python";

            objEncuesta.totalv = 0;
            objEncuesta.totalp = 0;

            objEncuesta.voto1 = 0;
            objEncuesta.voto2 = 0;
            objEncuesta.voto3 = 0;
            objEncuesta.voto4 = 0;

            objEncuesta.porcentaje1 = 0.0d;
            objEncuesta.porcentaje2 = 0.0d;
            objEncuesta.porcentaje3 = 0.0d;
            objEncuesta.porcentaje4 = 0.0d;

            // VALIDACION 1

            if (Request["Lenguaje"] == "Lenguaje 1")
            {
                int contador = 0;
                if (Session["cantidadVotos1"] == null)
                {
                    Session["cantidadVotos1"] = 1;
                } 
                
                else
                {
                    contador = Convert.ToInt32(Session["cantidadVotos1"]);
                    contador++;
                    Session["cantidadVotos1"] = contador;
                    objEncuesta.totalv += Convert.ToInt32(Session["cantidadVotos1"]);
                }
            }

            // VALIDACION 2

            if (Request["Lenguaje"] == "Lenguaje 2")
            {
                int contador = 0;
                if (Session["cantidadVotos2"] == null)
                {
                    Session["cantidadVotos2"] = 1;
                }

                else
                {
                    contador = Convert.ToInt32(Session["cantidadVotos2"]);
                    contador++;
                    Session["cantidadVotos2"] = contador;
                    objEncuesta.totalv += Convert.ToInt32(Session["cantidadVotos2"]);
                }
            }

            // VALIDACION 3

            if (Request["Lenguaje"] == "Lenguaje 3")
            {
                int contador = 0;
                if (Session["cantidadVotos3"] == null)
                {
                    Session["cantidadVotos3"] = 1;
                }

                else
                {
                    contador = Convert.ToInt32(Session["cantidadVotos3"]);
                    contador++;
                    Session["cantidadVotos3"] = contador;
                    objEncuesta.totalv += Convert.ToInt32(Session["cantidadVotos3"]);
                }
            }

            // VALIDACION 4

            if (Request["Lenguaje"] == "Lenguaje 4")
            {
                int contador = 0;
                if (Session["cantidadVotos4"] == null)
                {
                    Session["cantidadVotos4"] = 1;
                }

                else
                {
                    contador = Convert.ToInt32(Session["cantidadVotos4"]);
                    contador++;
                    Session["cantidadVotos4"] = contador;
                    objEncuesta.totalv += Convert.ToInt32(Session["cantidadVotos4"]);
                }
            }

            Session["totalvotos"] = (Convert.ToInt32(Session["cantidadVotos1"])
                + Convert.ToInt32(Session["cantidadVotos2"])
                + Convert.ToInt32(Session["cantidadVotos3"])
                + Convert.ToInt32(Session["cantidadVotos4"]));

            // PORCENTAJES

            Session["vp1"] = Convert.ToDouble(Session["porcentajeC1"]).ToString("0.00");
            Session["porcentajeC1"] = ((Convert.ToDouble(Session["vp1"]) * 100.0d) /
                Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            Session["vp2"] = Convert.ToDouble(Session["porcentajeC2"]).ToString("0.00");
            Session["porcentajeC2"] = ((Convert.ToDouble(Session["vp2"]) * 100.0d) /
                Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            Session["vp3"] = Convert.ToDouble(Session["porcentajeC3"]).ToString("0.00");
            Session["porcentajeC3"] = ((Convert.ToDouble(Session["vp3"]) * 100.0d) /
                Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            Session["vp4"] = Convert.ToDouble(Session["porcentajeC4"]).ToString("0.00");
            Session["porcentajeC4"] = ((Convert.ToDouble(Session["vp4"]) * 100.0d) /
                Convert.ToDouble(Session["totalvotos"])).ToString("0.00");

            // TOTAL PORCENTAJES

            Session["totalporcentajes"] = (Convert.ToDouble(Session["porcentajeC1"])
                + Convert.ToDouble(Session["porcentajeC2"])
                + Convert.ToDouble(Session["porcentajeC3"])
                + Convert.ToDouble(Session["porcentajeC4"])).ToString("0");
            return View(objEncuesta);
        }
    }
}