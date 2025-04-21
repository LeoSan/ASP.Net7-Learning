using System;
using System.Collections.Generic;
using System.Text;


/*
 * 
 * Se tiene que agregar la libreria System.web
 * Se puede revisar su locacion el object browser =P
 * 
 */

using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;



namespace utilerias.web
{
    public class alerta
    {
        static Random rand = new Random();
        /// <summario>
        /// Método estático que despliega un mensaje en pantalla
        /// </summario>
        /// <parametro nombre="msg">
        /// Variable String que recibe el texto a mostrar
        /// </parametro>
        /// <parametro nombre="pagina">
        /// Objeto tipo Page recibe la referencia de la pagina en donde se desplegará el mensaje
        /// </parametro>
        public static void mensaje(string msg, System.Web.UI.Page pagina) {
            string alerta = "<Script languaje='JavaScript'> " +
                            "alert(' " + msg + "');" +
                            "</Script>";
            if(pagina!=null) if (pagina.ClientScript != null){
                pagina.ClientScript.RegisterStartupScript(pagina.ClientScript.GetType(), "msg_" + rand.Next().ToString(), alerta);
            }
        }
    }
}
