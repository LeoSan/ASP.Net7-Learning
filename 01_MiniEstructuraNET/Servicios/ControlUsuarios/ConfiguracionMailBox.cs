using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Servicios.DtoS;

namespace Servicios.ControlUsuarios
{
    public class ConfiguracionMailBox
    {
        /// <summary>
        /// Método que inserta los datos en el buzón para x cliente y para n usuarios
        /// x es el id de la plataforma
        /// </summary>
        /// <returns></returns>
        public DtoConfig getDataInsertarMailBox()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/buzon/mensaje";
            return Datoconfig;
        }

        public DtoConfig setDataEditarMailBox()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/buzon/mensaje/editar";
            return Datoconfig;
        }

        public DtoConfig getDataInsertarMailBoxDocuments()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/buzon/mensajedocumentos";
            return Datoconfig;
        }

        public DtoConfig setDataConsultarTotalMessageNotReadMailBox()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["UsuariosUrlApi"].ToString() + "/api/buzon/mensaje/totalmessagenotread";
            return Datoconfig;
        }
    }
}
