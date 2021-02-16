using Laboratorio4_MVC_Lizarraga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio4_MVC_Lizarraga.Controllers
{
    public class QuizController : Controller
    {
        private ClsQuiz Quiz;

        public QuizController()
        {
            if (System.Web.HttpContext.Current.Session["quiz"] == null)
            {
                Quiz = new ClsQuiz();

                // Encuesta
                Quiz.Pregunta1 = "¿Cual es mi primer nombre de pila?";
                Quiz.Pregunta2 = "¿Cual es mi primer apellido?";
                Quiz.Pregunta3 = "¿Me conoces? ¿Puedes decirme mi edad?";

                Quiz.CantidadTotal1 = 0;
                Quiz.CantidadTotal1 = 0;
                Quiz.CantidadTotal1 = 0;

                Quiz.Questions1 = new List<ClsQuestions>();

                // Respuestas 1
                ClsQuestions objAnswer1_1 = new ClsQuestions();
                objAnswer1_1.Titulo = "Bumer";
                objAnswer1_1.Cantidad = 0;
                objAnswer1_1.Porcentaje = 0;
                Quiz.Questions1.Add(objAnswer1_1);

                // Respuestas 1
                ClsQuestions objAnswer1_2 = new ClsQuestions();
                objAnswer1_2.Titulo = "Paolo";
                objAnswer1_2.Cantidad = 0;
                objAnswer1_2.Porcentaje = 0;
                Quiz.Questions1.Add(objAnswer1_2);

                // Respuestas 1
                ClsQuestions objAnswer1_3 = new ClsQuestions();
                objAnswer1_3.Titulo = "Pabolo";
                objAnswer1_3.Cantidad = 0;
                objAnswer1_3.Porcentaje = 0;
                Quiz.Questions1.Add(objAnswer1_3);

                Quiz.Questions2 = new List<ClsQuestions>();

                // Respuestas 2
                ClsQuestions objAnswer2_1 = new ClsQuestions();
                objAnswer2_1.Titulo = "Lizarraga";
                objAnswer2_1.Cantidad = 0;
                objAnswer2_1.Porcentaje = 0;
                Quiz.Questions2.Add(objAnswer2_1);

                // Respuestas 2
                ClsQuestions objAnswer2_2 = new ClsQuestions();
                objAnswer2_2.Titulo = "Bumer";
                objAnswer2_2.Cantidad = 0;
                objAnswer2_2.Porcentaje = 0;
                Quiz.Questions2.Add(objAnswer2_2);

                // Respuestas 2
                ClsQuestions objAnswer2_3 = new ClsQuestions();
                objAnswer2_3.Titulo = "Alonso";
                objAnswer2_3.Cantidad = 0;
                objAnswer2_3.Porcentaje = 0;
                Quiz.Questions2.Add(objAnswer2_3);

                Quiz.Questions3 = new List<ClsQuestions>();

                // Respuestas 3
                ClsQuestions objAnswer3_1 = new ClsQuestions();
                objAnswer3_1.Titulo = "18";
                objAnswer3_1.Cantidad = 0;
                objAnswer3_1.Porcentaje = 0;
                Quiz.Questions3.Add(objAnswer3_1);

                // Respuestas 3
                ClsQuestions objAnswer3_2 = new ClsQuestions();
                objAnswer3_2.Titulo = "19";
                objAnswer3_2.Cantidad = 0;
                objAnswer3_2.Porcentaje = 0;
                Quiz.Questions3.Add(objAnswer3_2);

                // Respuestas 3
                ClsQuestions objAnswer3_3 = new ClsQuestions();
                objAnswer3_3.Titulo = "20";
                objAnswer3_3.Cantidad = 0;
                objAnswer3_3.Porcentaje = 0;
                Quiz.Questions3.Add(objAnswer3_3);

                System.Web.HttpContext.Current.Session["quiz"] = Quiz;
            }

            else
            {
                Quiz = System.Web.HttpContext.Current.Session["quiz"] as ClsQuiz;
            }
        }


        [HttpGet]
        public ActionResult Index(ClsQuiz quiz)
        {
            return View(Quiz);
        }

        [HttpPost]
        public ActionResult Index()
        {
            if (Request["index"] != null)
            {
                int index = Int32.Parse(Request["index"].ToString());

                if (index < 3)
                {
                    ClsQuestions respuestas1 = Quiz.Questions1[index];
                    ClsQuestions respuestas = Quiz.Questions1[index];
                    respuestas.Cantidad++;
                    Quiz.CantidadTotal1 = Quiz.Questions1.Sum(x => x.Cantidad);

                    foreach (ClsQuestions alt in Quiz.Questions1)
                    {
                        alt.Porcentaje = alt.Cantidad * 100 / Quiz.CantidadTotal1;
                    }
                }

                if (index < 6 && index > 2)
                {
                    index = index - 3;
                    ClsQuestions respuestas2 = Quiz.Questions2[index];
                    ClsQuestions respuestas = Quiz.Questions2[index];
                    respuestas.Cantidad++;
                    Quiz.CantidadTotal2 = Quiz.Questions2.Sum(x => x.Cantidad);

                    foreach (ClsQuestions alt in Quiz.Questions2)
                    {
                        alt.Porcentaje = alt.Cantidad * 100 / Quiz.CantidadTotal2;
                    }
                }

                if (index < 9 && index > 5)
                {
                    index = index - 6;
                    ClsQuestions respuestas3 = Quiz.Questions3[index];
                    ClsQuestions respuestas = Quiz.Questions3[index];
                    respuestas.Cantidad++;
                    Quiz.CantidadTotal3 = Quiz.Questions3.Sum(x => x.Cantidad);

                    foreach (ClsQuestions alt in Quiz.Questions3)
                    {
                        alt.Porcentaje = alt.Cantidad * 100 / Quiz.CantidadTotal3;
                    }
                }

                System.Web.HttpContext.Current.Session["quiz"] = Quiz;
                
            }

            return View(Quiz);
        }
    }
}