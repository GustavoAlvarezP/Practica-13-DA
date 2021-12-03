using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Traductor
{
    /// <summary>
    /// Descripción breve de Traducir
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Traducir : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public  String Traducir_Frase( String palabra)
        {
            if (palabra == "Ir")
                return "GO";
            if (palabra == "jugar")
                return "play";
            if (palabra == "ver")
                return "See";
            if (palabra == "Empezar")
                return "Start";
            if (palabra == "saltar")
                return "jump";
            if (palabra == "disparar")
                return "shoot";
            if (palabra == "presionar")
                return "press";
            if (palabra == "ayudar")
                return "help";
            return "No tiene traduccion";
        }
    }
}
