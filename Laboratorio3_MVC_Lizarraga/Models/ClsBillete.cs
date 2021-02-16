using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Laboratorio3_MVC_Lizarraga.Models
{
    public class ClsBillete
    {
        [Required(ErrorMessage = "Ingrese el monto")]
        [RegularExpression(@"[^0]+", ErrorMessage = "No esta permitido ese monto")]
        public int monto { get; set; }
        public int b100 { get; set; }
        public int b50 { get; set; }
        public int b20 { get; set; }
        public int b10 { get; set; }
    }
}