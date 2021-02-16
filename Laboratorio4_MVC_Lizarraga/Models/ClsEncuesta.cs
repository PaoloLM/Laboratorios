using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio4_MVC_Lizarraga.Models
{
    public class ClsEncuesta
    {
        public string alternativa1 { get; set; }
        public string alternativa2 { get; set; }
        public string alternativa3 { get; set; }
        public string alternativa4 { get; set; }

        public int voto1 { get; set; }
        public int voto2 { get; set; }
        public int voto3 { get; set; }
        public int voto4 { get; set; }

        public double porcentaje1 { get; set; }
        public double porcentaje2 { get; set; }
        public double porcentaje3 { get; set; }
        public double porcentaje4 { get; set; }

        public int totalv { get; set; }
        public double totalp { get; set; }
    }
}