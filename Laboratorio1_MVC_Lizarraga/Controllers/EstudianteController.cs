using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Laboratorio1_MVC_Lizarraga.Models;
using System.Web.Mvc;

namespace Laboratorio1_MVC_Lizarraga.Controllers
{
    public class EstudianteController : Controller
    {
        // GET: Estudiante
        public ActionResult VerEstudiante()
        {
            ClsEstudiante objEstudiante = new ClsEstudiante();

            objEstudiante.apellido = "Lizarraga Morera";
            objEstudiante.nombre = "Paolo Patrick";
            objEstudiante.edad = 18;
            objEstudiante.sexo = true;
            objEstudiante.talla = 1.75;

            return View(objEstudiante);
        }
    }
}