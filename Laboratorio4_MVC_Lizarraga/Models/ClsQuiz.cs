using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio4_MVC_Lizarraga.Models
{
    public class ClsQuiz
    {
        public string Pregunta1 { get; set; }
        public string Pregunta2 { get; set; }
        public string Pregunta3 { get; set; }
        public int CantidadTotal1 { get; set; }
        public int CantidadTotal2 { get; set; }
        public int CantidadTotal3 { get; set; }

        public List<ClsQuestions> Questions { get; set; }

        public List<ClsQuestions> Questions1 { get; set; }
        public List<ClsQuestions> Questions2 { get; set; }
        public List<ClsQuestions> Questions3 { get; set; }
    }
}