using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace ServicioWebContador
{
    /// <summary>
    /// Descripción breve de ServicioContador
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioContador : System.Web.Services.WebService
    {

        [WebMethod]
        public int ContadorDePalabras(string texto, string palabra)
        {
            String cadena = texto;
            int total = Regex.Matches(cadena, palabra).Count;
            return total;
        }
    }
}
