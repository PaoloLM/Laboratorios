using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio_LINQ_Arrays_MVC_Lizarraga.Models;

namespace Laboratorio_LINQ_Arrays_MVC_Lizarraga.Controllers
{
    public class AlumnosController : Controller
    {
        string[] alumno = { "Calos", "Leonardo", "Ana", "Maria", "Miguel", "Sergio", "Diego", "Luis" };
        int[] notas = { 10, 15, 18, 16, 18, 11, 08, 06 };

        // GET: Alumnos
        public ActionResult Index()
        {
            var query = (from a in alumno.Select((alumno, index) => new { alumno, index })
                         join n in notas.Select((nota, index) => new { nota, index })
                         on a.index equals n.index
                         select new { a.alumno, n.nota }).ToList();

            List<ClsAlumnos> listAlumnos = new List<ClsAlumnos>();

            foreach (var item in query)
            {
                ClsAlumnos objAlumnos = new ClsAlumnos();
                objAlumnos.nombre = item.alumno;
                objAlumnos.nota = item.nota;

                if (objAlumnos.nota > 10.5)
                {
                    objAlumnos.condicion = "Aprobado";
                } else { objAlumnos.condicion = "Desaprobado"; }

                listAlumnos.Add(objAlumnos);
            }

            return View(listAlumnos);
        }
    }
}