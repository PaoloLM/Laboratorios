using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_LINQ_Arrays_MVC_Lizarraga.Models
{
    public class ClsAlumno
    {
        public string busqueda { get; set; } = "";
        public string resultado { get; set; } = "";

        public List<string> nombreA { get; set; }
        public List<double> notaA { get; set; }
        public int filas { get; set; }
    }
}