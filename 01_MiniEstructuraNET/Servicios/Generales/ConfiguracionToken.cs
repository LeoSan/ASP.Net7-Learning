using Servicios.DtoS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Servicios.Generales
{
    public class ConfiguracionToken
    {
        /// <summary>
        /// Método que devuelve los datos de configuracion para conectarse al servicio
        /// </summary>
        /// <returns>Datos de configuración</returns>
        public DtoConfig getDataTokenUsuarios()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.ClientId = ConfigurationManager.AppSettings["UsuariosClientId"].ToString();
            Datoconfig.ClientSecret = ConfigurationManager.AppSettings["UsuariosClientSecret"].ToString();
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/oauth/token";
            Datoconfig.NameApi = "usuarios";
            return Datoconfig;

        }

        /// <summary>
        /// Método que devuelve los datos de configuracion para conectarse al servicio
        /// </summary>
        /// <returns>Datos de configuración</returns>
        public DtoConfig getDataTokenDisponibilidad()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.ClientId = ConfigurationManager.AppSettings["DisponibilidadClientId"].ToString();
            Datoconfig.ClientSecret = ConfigurationManager.AppSettings["DisponibilidadClientSecret"].ToString();
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["DisponibilidadUrlApi"].ToString() + "/oauth/token";
            Datoconfig.NameApi = "disponibilidad";
            return Datoconfig;

        }

        /// <summary>
        /// Método que devuelve los datos de configuracion para conectarse al servicio
        /// </summary>
        /// <returns>Datos de configuración</returns>
        public DtoConfig getDataTokenSIPAS3()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.ClientId = ConfigurationManager.AppSettings["SIPASClientId"].ToString();
            Datoconfig.ClientSecret = ConfigurationManager.AppSettings["SIPASClientSecret"].ToString();
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["SIPASUrlApi"].ToString() + "/oauth/token";
            Datoconfig.NameApi = "sipas3";
            return Datoconfig;

        }

        /// <summary>
        /// Método que devuelve los datos de configuracion para conectarse al servicio de expedientes
        /// </summary>
        /// <returns>Datos de configuración</returns>
        public DtoConfig getDataTokenExpedientes()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.ClientId = ConfigurationManager.AppSettings["ExpedientesClientId"].ToString();
            Datoconfig.ClientSecret = ConfigurationManager.AppSettings["ExpedientesClientSecret"].ToString();
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["ExpedientesUrlApi"].ToString() + "/oauth/token";
            Datoconfig.NameApi = "expedientes";
            return Datoconfig;
        }
    }
}
