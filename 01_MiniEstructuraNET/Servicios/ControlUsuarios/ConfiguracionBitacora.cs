using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Servicios.DtoS;

namespace Servicios.ControlUsuarios
{
    public class ConfiguracionBitacora
    {
        /// <summary>
        /// Método que devuelve los datos de configuración para la conexión al servicio para consultar la bitácora
        /// </summary>
        /// <returns></returns>
        public DtoConfig getDataConsultarBitacora()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/bitacora/buscador";
            return Datoconfig;
        }
        /// <summary>
        /// Método que inserta los valores de la bitácora en el servicio o end point de registro (Método de configuración)
        /// </summary>
        /// <returns></returns>
        public DtoConfig getDataInsertarBitacora()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/bitacora/registro";
            return Datoconfig;
        }
    }
}
