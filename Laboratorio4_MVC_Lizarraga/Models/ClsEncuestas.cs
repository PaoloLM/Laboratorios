using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio4_MVC_Lizarraga.Models
{
    public class ClsEncuestas
    {
        public string Titulo { get; set; }
        public int CantidadTotal { get; set; }

        public List<ClsAlternativa> Alternativa { get; set; }
    }
}