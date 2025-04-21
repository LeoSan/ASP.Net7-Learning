using Newtonsoft.Json;
using Servicios.DtoS;
using Servicios.Generales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.MotorDisponibilidad
{
    public class ServiciosEventos : ConfiguracionEventos
    {
        ConfiguracionServicios ConfiguracionServicio = new ConfiguracionServicios();
        ConfiguracionToken DataToken = new ConfiguracionToken();

        public string RegisterEvents(DtoEventos eventos)
        {
            DtoConfig Dataconfig = getUrlRegistrarEvento();
            DtoConfig DataConfigTokenDisponibilidad = DataToken.getDataTokenDisponibilidad();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenDisponibilidad);
            string json = JsonConvert.SerializeObject(eventos);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }

        public string UpdateEvent(DtoActualizarEvento evento)
        {
            DtoConfig Dataconfig = getUrlActualizarEvento();
            DtoConfig DataConfigTokenDisponibilidad = DataToken.getDataTokenDisponibilidad();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenDisponibilidad);
            string json = JsonConvert.SerializeObject(evento);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }

        public DtoServicioDisponibilidad getDisponibilidad(DtoGetDisponibilidad data)
        {
            DtoConfig Dataconfig = getDisponibilidadPersona();
            DtoConfig DataConfigTokenDisponibilidad = DataToken.getDataTokenDisponibilidad();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenDisponibilidad);
            string json = JsonConvert.SerializeObject(data);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            DtoServicioDisponibilidad disponibilidad = JsonConvert.DeserializeObject<DtoServicioDisponibilidad>(resultjson);
            return disponibilidad;
        }

        public string RegisterEventsDomicilio(DtoDomicilio domicilio)
        {
            DtoConfig Dataconfig = getUrlRegistrarEventoDomicilio();
            DtoConfig DataConfigTokenDisponibilidad = DataToken.getDataTokenDisponibilidad();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenDisponibilidad);
            string json = JsonConvert.SerializeObject(domicilio);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }

        public string UpdateEventDomicilios(DtoActualizarEventoDomicilio eventosDomicilio)
        {
            DtoConfig Dataconfig = getUrlActualizarEvento();
            DtoConfig DataConfigTokenDisponibilidad = DataToken.getDataTokenDisponibilidad();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenDisponibilidad);
            string json = JsonConvert.SerializeObject(eventosDomicilio);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }       
        
        public string DeleteEventDomicilios(DtoEliminarEventoDomicilio eventoDomicilio)
        {
            DtoConfig Dataconfig = getUrlEliminarEventoDomicilio();
            DtoConfig DataConfigTokenDisponibilidad = DataToken.getDataTokenDisponibilidad();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenDisponibilidad);
            string json = JsonConvert.SerializeObject(eventoDomicilio);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }

        public string GetDisponibilidadFechaPersonas(DtoGetEventoPersonaPorFecha eventoPersonaPorFecha)
        {
            DtoConfig Dataconfig = getUrlFechaDisponibilidadPersonas();
            DtoConfig DataConfigTokenDisponibilidad = DataToken.getDataTokenDisponibilidad();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenDisponibilidad);
            string json = JsonConvert.SerializeObject(eventoPersonaPorFecha);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }

        public List<DtoEventoReferencia> GetEventoPersonasPorReferencia(DtoGetEventoPorReferencia eventoReferencia)
        {
            DtoConfig Dataconfig = getUrlObtenerPorReferencia();
            DtoConfig DataConfigTokenDisponibilidad = DataToken.getDataTokenDisponibilidad();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenDisponibilidad);
            string json = JsonConvert.SerializeObject(eventoReferencia);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            List<DtoEventoReferencia> eventos_por_referencia = JsonConvert.DeserializeObject<List<DtoEventoReferencia>>(resultjson);
            return eventos_por_referencia;
        }

        public string GetObtenerFechaEnDiasHabiles(DtoFechaEnHabiles fechaEnHabiles)
        {
            DtoConfig Dataconfig = getUrlObtenerFechaEnDiasHabiles();
            DtoConfig DataConfigTokenDisponibilidad = DataToken.getDataTokenDisponibilidad();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenDisponibilidad);
            string json = JsonConvert.SerializeObject(fechaEnHabiles);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }

        public string GetObtenerDiasHabilesRestantes(DtoFechaEnHabiles fechaEnHabiles)
        {
            DtoConfig Dataconfig = getUrlObtenerDiasHabilesRestantes();
            DtoConfig DataConfigTokenDisponibilidad = DataToken.getDataTokenDisponibilidad();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenDisponibilidad);
            string json = JsonConvert.SerializeObject(fechaEnHabiles);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }
    }
}
