using Servicios.DtoS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Servicios.ControlExpedientes
{
    public class ConfiguracionExpedientes
    {
        /// <summary>
        /// Método que devuelve los datos de configuración para la conexión al servicio y registrar un expediente
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlRegistrarActualizarExpediente()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["ExpedientesUrlApi"].ToString() + "/api/expedientes/registrar-actualizar";
            return Datoconfig;
        }
    }
}
