using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Servicios.DtoS;

namespace Servicios.SIPAS3
{
    public class Configuracion
    {

        /// <summary>
        /// Método que devuelve los datos de configuración para la conexión al servicio y registrar solicitudes de sanción
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlRegistrarSolicitudSancion()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["SIPASUrlApi"].ToString() + "/api/solicitud-sancion/nueva";

            return Datoconfig;
        }

        /// <summary>
        /// Método que devuelve los expedientes de sanción de una inspección
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlExpedientesSipas()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["SIPASUrlApi"].ToString() + "/api/expediente";

            return Datoconfig;
        }

        /// <summary>
        /// Método que devuelve las multas de los expedientes de sanción de una inspección
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlExpedientesMultasSipas()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["SIPASUrlApi"].ToString() + "/api/expediente/multas";

            return Datoconfig;
        }

        /// <summary>
        /// Método que devuelve los documentos de los expedientes de sanción de una inspección
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlExpedientesDocumentosSipas()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["SIPASUrlApi"].ToString() + "/api/expediente/documentos";

            return Datoconfig;
        }

        public DtoConfig getUrlActualizarIncumplimientosSIPAS()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["SIPASUrlApi"].ToString() + "/api/incumplimientos/actualizar";

            return Datoconfig;
        }

    }

}
