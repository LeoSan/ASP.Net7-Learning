using System;
using System.Collections.Generic;
using System.Text;

using System.Configuration;

namespace utilerias
{
    public class log
    {
        private static bool cargado = false;
        private static string appFolder = @"\temp";


        public static void error(string metodo, string archivo, string error, Exception ex)
        {
            CargaFolder();
            try
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + appFolder + @"\logErrores.txt", true))
                {
                    //sw.WriteLine("<error>" + metodo + "\t" + archivo + "\t" + error + "\n" + FlattenException(ex) + "\n" + Convert.ToString(System.DateTime.Now) + "\n <\\error>");
                    sw.WriteLine("<error>{0}\t{1}\t{2}t{3}{4}\n <\\error>", metodo, archivo, error, FlattenException(ex), Convert.ToString(System.DateTime.Now));
                }
            }
            catch (Exception e)
            {
                //throw e;
                string s = e.Message;
            }

        }
        /// <summario>
        /// Método estático que escribe log de errores en un archivo de texto
        /// </summario>
        /// <parametro nombre="metodo">
        /// Variable tipo String que recibe el método en dodne ocurrió el error
        /// </parametro> 
        /// <parametro nombre="archivo">
        /// Variable tipo String que recibe el archivo en donde ocurrío el error
        /// </parametro> 
        /// <parametro nombre="error">
        /// Variable tipo String que recibe el error que se guardara en el archivo de texto
        /// </parametro> 
        public static void error(string metodo, string archivo, string error) {
            CargaFolder();
            try{
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory + appFolder + @"\logErrores.txt", true)){
                    sw.WriteLine(metodo + "\t" + archivo + "\t" + error + "\t" + Convert.ToString(System.DateTime.Now));
                }
            }catch (Exception e) {
                //throw e;
                string s = e.Message;
            }

        }

        public static string FlattenException(Exception exception)
        {
            var stringBuilder = new StringBuilder();
            string indent = String.Empty;

            while (exception != null)
            {
                stringBuilder.AppendFormat("\nException Found:\n{0}Type: {1}", indent, exception.GetType().FullName);
                stringBuilder.AppendFormat("\n{0}Message: {1}", indent, exception.Message);
                stringBuilder.AppendFormat("\n{0}Source: {1}", indent, exception.Source);
                stringBuilder.AppendFormat("\n{0}Stacktrace: {1}", indent, exception.StackTrace);

                exception = exception.InnerException;
                indent = String.Format("{0}{1}", indent, "\t");
            }

            return stringBuilder.ToString();
        }
        /// <summario>
        /// Método estático carga desde el web.config el folder relativo donde se guardará el archivo de texto
        /// </summario>
        private static void CargaFolder(){
            if (cargado) return;
            cargado = true;
            if (ConfigurationManager.AppSettings["logFolder"] != null) {
                appFolder = ConfigurationManager.AppSettings["logFolder"];
            }

        }
    }
}
