using System;
using System.Collections.Generic;
using System.Configuration;
using Servicios.DtoS;
using System.Linq;
using System.Text;
using Servicios.Generales;

namespace Servicios.ControlUsuarios
{
    public class ConfiguracionUsuarios
    {
        /// <summary>
        /// Método que devuelve los datos de configuración para la conexión al servicio y autenticar el usuario
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlAutenticar()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/usuarios/autenticar";
            return Datoconfig;
        }

        /// <summary>
        /// Configuración registrar usuarios
        /// </summary>
        public DtoConfig getUrlRegistrarUsuario()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/usuarios/registro";
            return Datoconfig;
        }

        /// <summary>
        /// Configuración actualizar usuarios
        /// </summary>
        public DtoConfig getUrlActualizarUsuario()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/usuarios/actualizar";
            return Datoconfig;
        }

        /// <summary>
        /// Configuración actualizar usuarios
        /// </summary>
        public DtoConfig getSearchUsuario()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/usuarios/buscador";
            return Datoconfig;
        }

        /// <summary>
        /// Configuración actualizar usuarios
        /// </summary>
        public DtoConfig getValidateTokenByCoreId()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/usuarios/validar/one-time-token";
            return Datoconfig;
        }

        /// <summary>
        /// Configuración actualizar usuarios
        /// </summary>
        public DtoConfig setOneTimeTokenByCoreId()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/usuarios/set-one-time-token";
            return Datoconfig;
        }

        /// <summary>
        /// Configuración actualizar usuarios password
        /// </summary>
        public DtoConfig setActualizarUsuarioPassword()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/usuarios/actualizar-contraseña";
            return Datoconfig;
        }

        /// <summary>
        /// Configuración Recuperar contraseña
        /// </summary>
        public DtoConfig setRecuperarContrasena()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/usuarios/recuperar-contrasena";
            return Datoconfig;
        }

        /// <summary>
        /// Configuración actualizar usuarios password token
        /// </summary>
        public DtoConfig setActualizarUsuarioPasswordToken()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/usuarios/actualizar-contrasena/token";
            return Datoconfig;
        }

        /// <summary>
        /// Cononsulta de usuarios
        /// </summary>
        public DtoConfig getUsuario()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/usuarios/consulta-mail";
            return Datoconfig;
        }

    }
}
