using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio_LINQ_Arrays_MVC_Lizarraga.Models;

namespace Laboratorio_LINQ_Arrays_MVC_Lizarraga.Controllers
{
    public class AlumnoNotasController : Controller
    {

        string[] alumno = { "Calos", "Leonardo", "Ana", "Maria", "Miguel", "Sergio", "Diego", "Luis" };
        int[] notas = { 10, 15, 18, 16, 18, 11, 08, 06 };

        // GET: AlumnoNotas
        public ActionResult Index(ClsAlumnoNota objAlumnoNota)
        {
            string busqueda;

            if (objAlumnoNota.busqueda != null)
            {
                busqueda = objAlumnoNota.busqueda;

                var query = (from a in alumno.Select((alumno, index) => new { alumno, index })
                             join n in notas.Select((nota, index) => new { nota, index })
                             on a.index equals n.index
                             where a.alumno.Contains(busqueda)
                             select new { a.alumno, n.nota }).ToList();

                foreach (var item in query)
                {
                    objAlumnoNota.resultado += Convert.ToString(item) + "\n";
                }
            }

            else
            {
                var query = (from a in alumno.Select((alumno, index) => new { alumno, index })
                             join n in notas.Select((nota, index) => new { nota, index })
                             on a.index equals n.index
                             select new { a.alumno, n.nota }).ToList();

                foreach (var item in query)
                {
                    objAlumnoNota.resultado += Convert.ToString(item) + "\n";
                }
            }

            return View(objAlumnoNota);
        }
    }
}