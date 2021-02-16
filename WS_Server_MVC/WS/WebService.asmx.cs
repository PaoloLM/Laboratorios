using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS_Server_MVC.WS
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HolaMundo()
        {
            return "Bienvenidos al curso de Web II";
        }


        [WebMethod]
        public string Adios()
        {
            return "Gracias, nos vemos la proxima clase";
        }


        [WebMethod]
        public double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }


        [WebMethod]
        public double Operaciones(int tipo, double numero1, double numero2)
        {            
            if (tipo == 1)
            {
                return numero1 + numero2;
            }

            else if (tipo == 2)
            {
                return numero1 - numero2;
            }

            else if(tipo == 3)
            {
                return numero1 * numero2;
            }

            else
            {
                return numero1 / numero2;
            }
        }

        [WebMethod]
        public string Tabla(double numero1)
        {
            string resultado = "";
            for (int i = 0; i <= 12; i++)
            {
                resultado += i + " x " + numero1 + " = " + (numero1 * i) + "\r\n";
            }
            return resultado;
        }


        [WebMethod]
        public string Bisiestos(int añoinicial, int añofinal)
        {
            string resultado = "Años bisiestos comprendidos entre " + añoinicial + " - " + añofinal + ": \r\n";
            for (int i = añoinicial; i <= añofinal; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    resultado += i + " < -- >\r\n";
                }
            }
            return resultado;
        }


        [WebMethod]
        public string ExamenUnidad(string json)
        {
            
            return json;
        }
    }
}
