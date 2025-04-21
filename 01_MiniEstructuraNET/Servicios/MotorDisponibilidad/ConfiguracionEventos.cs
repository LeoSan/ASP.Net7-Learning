using Servicios.DtoS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Servicios.MotorDisponibilidad
{
    public class ConfiguracionEventos
    {
        /// <summary>
        /// Método que devuelve los datos de configuración para la conexión al servicio y registrar un evento
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlRegistrarEvento()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["DisponibilidadUrlApi"].ToString() + "/api/eventos/crear";
            return Datoconfig;
        }       

        /// <summary>
        /// Método que devuelve los datos de configuración para la conexión al servicio y actualizar las personas de un evento
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlActualizarEvento()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["DisponibilidadUrlApi"].ToString() + "/api/eventos/editar";
            return Datoconfig;
        }


        /// <summary>
        /// Método que devuelve el json con las fechas disponibles, no disponibles y el total de c/u
        /// </summary>
        /// <returns></returns>
        public DtoConfig getDisponibilidadPersona()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["DisponibilidadUrlApi"].ToString() + "/api/fechas/disponibilidadPersona";
            return Datoconfig;
        }

        /// <summary>
        /// Método que devuelve los datos de configuración para la conexión al servicio y actualizar un domicilio para un evento
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlRegistrarEventoDomicilio()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["DisponibilidadUrlApi"].ToString() + "/api/eventos/domicilio";
            return Datoconfig;
        }

        /// <summary>
        /// Método que devuelve los datos de configuración para la conexión al servicio eliminar un evento domicilio
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlEliminarEventoDomicilio()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["DisponibilidadUrlApi"].ToString() + "/api/evento/eliminar";
            return Datoconfig;
        }

        /// <summary>
        /// Método que devuelve las personas no disponibles para una fecha
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlFechaDisponibilidadPersonas()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["DisponibilidadUrlApi"].ToString() + "/api/evento/consultaDisponibilidadPersonas";
            return Datoconfig;
        }

        public DtoConfig getUrlObtenerPorReferencia()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["DisponibilidadUrlApi"].ToString() + "/api/eventos/consultaReferencia";
            return Datoconfig;
        }

        /// <summary>
        ///  Regresa la fecha final sin contar los días inhabiles
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlObtenerFechaEnDiasHabiles()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["DisponibilidadUrlApi"].ToString() + "/api/fechas/obtenerDiasHabiles";
            return Datoconfig;
        }

        /// <summary>
        ///  Regresa el número de días restantes a la fecha final
        /// </summary>
        /// <returns></returns>
        public DtoConfig getUrlObtenerDiasHabilesRestantes()
        {
            DtoConfig Datoconfig = new DtoConfig();
            Datoconfig.TipoMetodo = "POST";
            Datoconfig.UrlApi = ConfigurationManager.AppSettings["DisponibilidadUrlApi"].ToString() + "/api/fechas/obtenerDiasHabilesRestantes";
            return Datoconfig;
        }

    }
}
