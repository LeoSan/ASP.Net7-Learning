using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace CompInspeccion
{
    public class Constantes
    {
        public static bool cargado = false;
        public static String StrCon = "Data Source=127.0.0.1;Database=db_PTC; user id=saBV; password=sasasa;";
        public SqlConnection ObjConnection;
        public SqlCommand ObjCommand;

        public static String StrConRemote = "Data Source=127.0.0.1;Database=db_stps_remota; user id=saBV; password=sasasa;";
        public SqlConnection ObjConnectionRemote;
        public SqlCommand ObjCommandRemote;

        public static String StrConPServicios = "Data Source=  ;Database= ; user id= ; password= ;";
        public SqlConnection ObjConnectionPServicios;
        public SqlCommand ObjCommandPServicios;

        public static String StrConEPSST = "Data Source=  ;Database= ; user id= ; password= ;";
        public SqlConnection ObjConnectionEPSST;
        public SqlCommand ObjCommandEPSST;

        public static String StrConCNSST = "Data Source=  ;Database= ; user id= ; password= ;";
        public SqlConnection ObjConnectionCNSST;
        public SqlCommand ObjCommandCNSST;

        public static String StrConSASST = "Data Source=  ;Database= ; user id= ; password= ;";
        public SqlConnection ObjConnectionSASST;
        public SqlCommand ObjCommandSASST;

        public static String StrConSICAPE = "Data Source=127.0.0.1;Database=SISEM2; user id=saBV; password=sasasa;";
        public SqlConnection ObjConnectionSICAPE;
        public SqlCommand ObjCommandSICAPE;

        public static String StrConASINOM = "Data Source=3.190;Database=db_ASINOM; user id=saBV; password=sasasa;";
        public SqlConnection ObjConnectionASINOM;
        public SqlCommand ObjCommandASINOM;

        public static String StrConDNE = "Data Source=3.190;Database=db_ASINOM; user id=saBV; password=sasasa;";
        public SqlConnection ObjConnectionDNE;
        public SqlCommand ObjCommandDNE;



        /// <summario>
        /// Método que carga las conection String al objeto de Constantes
        /// </summario>
        public static void CargaStringsConeccion()
        {
            if (cargado) return;

            cargado = true;
            string msg;
            //llena las connStrings esten encriptadas o no
            
            if (ConfigurationManager.AppSettings["connectionStringSistema"] != null)
                StrCon = ConfigurationManager.AppSettings["connectionStringSistema"];
            if (ConfigurationManager.AppSettings["connectionStringCatalogos"] != null)
                StrConRemote = ConfigurationManager.AppSettings["connectionStringCatalogos"];
            if (ConfigurationManager.AppSettings["connectionStringPSE"] != null)
                StrConPServicios = ConfigurationManager.AppSettings["connectionStringPSE"];
            if (ConfigurationManager.AppSettings["connectionStringEPSST"] != null)
                StrConEPSST = ConfigurationManager.AppSettings["connectionStringEPSST"];
            if (ConfigurationManager.AppSettings["connectionStringSASST"] != null)
                StrConCNSST = ConfigurationManager.AppSettings["connectionStringCNSST"];
            if (ConfigurationManager.AppSettings["connectionStringSASST"] != null)
                StrConSASST = ConfigurationManager.AppSettings["connectionStringSASST"];
            if (ConfigurationManager.AppSettings["connectionStringSICAPE"] != null)
                StrConSICAPE = ConfigurationManager.AppSettings["connectionStringSICAPE"];
            if (ConfigurationManager.AppSettings["connectionStringASINOM"] != null)
                StrConASINOM = ConfigurationManager.AppSettings["connectionStringASINOM"];
            if (ConfigurationManager.AppSettings["connectionStringDNE"] != null)
                StrConDNE = ConfigurationManager.AppSettings["connectionStringDNE"];

            if (ConfigurationManager.AppSettings["connectionStringEncrypted"] != null)
            {
                if (ConfigurationManager.AppSettings["connectionStringEncrypted"].Equals("TRUE"))
                {
                    if (ConfigurationManager.AppSettings["connectionStringSistema"] != null)
                        StrCon = utilerias.CryptoLibrerias.DPAPI.Decrypt(ConfigurationManager.AppSettings["connectionStringSistema"], "aÑ7B9cYduiyq32oJlñÑy", out msg);
                    if (ConfigurationManager.AppSettings["connectionStringCatalogos"] != null)
                        StrConRemote = utilerias.CryptoLibrerias.DPAPI.Decrypt(ConfigurationManager.AppSettings["connectionStringCatalogos"], "aÑ7B9cYduiyq32oJlñÑy", out msg);
                    if (ConfigurationManager.AppSettings["connectionStringPSE"] != null)
                        StrConPServicios = utilerias.CryptoLibrerias.DPAPI.Decrypt(ConfigurationManager.AppSettings["connectionStringPSE"], "aÑ7B9cYduiyq32oJlñÑy", out msg);
                    if (ConfigurationManager.AppSettings["connectionStringEPSST"] != null)
                        StrConEPSST = utilerias.CryptoLibrerias.DPAPI.Decrypt(ConfigurationManager.AppSettings["connectionStringEPSST"], "aÑ7B9cYduiyq32oJlñÑy", out msg);
                    if (ConfigurationManager.AppSettings["connectionStringCNSST"] != null)
                        StrConCNSST = utilerias.CryptoLibrerias.DPAPI.Decrypt(ConfigurationManager.AppSettings["connectionStringCNSST"], "aÑ7B9cYduiyq32oJlñÑy", out msg);
                    if (ConfigurationManager.AppSettings["connectionStringSASST"] != null)
                        StrConSASST = utilerias.CryptoLibrerias.DPAPI.Decrypt(ConfigurationManager.AppSettings["connectionStringSASST"], "aÑ7B9cYduiyq32oJlñÑy", out msg);
                    if (ConfigurationManager.AppSettings["connectionStringSICAPE"] != null)
                        StrConSICAPE = utilerias.CryptoLibrerias.DPAPI.Decrypt(ConfigurationManager.AppSettings["connectionStringSICAPE"], "aÑ7B9cYduiyq32oJlñÑy", out msg);
                    if (ConfigurationManager.AppSettings["connectionStringASINOM"] != null)
                        StrConASINOM = utilerias.CryptoLibrerias.DPAPI.Decrypt(ConfigurationManager.AppSettings["connectionStringASINOM"],"aÑ7B9cYduiyq32oJlñÑy", out msg);
                     if (ConfigurationManager.AppSettings["connectionStringDNE"] != null)
                         StrConDNE = utilerias.CryptoLibrerias.DPAPI.Decrypt(ConfigurationManager.AppSettings["connectionStringDNE"], "aÑ7B9cYduiyq32oJlñÑy", out msg);

                }
            }
        }
    }
}
