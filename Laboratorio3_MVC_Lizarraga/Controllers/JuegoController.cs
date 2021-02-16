using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio3_MVC_Lizarraga.Models;

namespace Laboratorio3_MVC_Lizarraga.Controllers
{
    public class JuegoController : Controller
    {
        // GET: Juego
        public ActionResult Index(ClsJuegp objJuego)
        {
            Random rnd = new Random();

            objJuego.numero1 = rnd.Next(3);
            objJuego.numero2 = rnd.Next(3);
            objJuego.numero3 = rnd.Next(3);

            if (objJuego.numero1 == objJuego.numero2 && objJuego.numero1 == objJuego.numero3)
            {
                objJuego.resultado = "Eres un crack, Ganaste S./1000 soles";              
            }
            else if (objJuego.numero1 == objJuego.numero2 || objJuego.numero1 == objJuego.numero3 || objJuego.numero2 == objJuego.numero3)
            {
                objJuego.resultado = "Sigue intentando........";                
            }
            else
            {
                objJuego.resultado = "Perdiste........";
            }

            return View(objJuego);
        }
    }
}