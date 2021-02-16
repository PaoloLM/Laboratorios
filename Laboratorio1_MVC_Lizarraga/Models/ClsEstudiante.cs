using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio1_MVC_Lizarraga.Models
{
    public class ClsEstudiante
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public double talla { get; set; }
        public Boolean sexo { get; set; }
        public int edad { get; set; }
    }
}