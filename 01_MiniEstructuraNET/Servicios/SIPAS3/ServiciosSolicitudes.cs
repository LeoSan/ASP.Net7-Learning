using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Servicios.Generales;
using Servicios.DtoS;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CompInspeccion;

namespace Servicios.SIPAS3
{
    public class ServiciosSolicitudes : Configuracion
    {
        ConfiguracionServicios ConfiguracionServicio = new ConfiguracionServicios();
        ConfiguracionToken DataToken = new ConfiguracionToken();

        public string RegistrarSolicitud(DtoSolicitudSancion solicitud)
        {
            DtoConfig Dataconfig = getUrlRegistrarSolicitudSancion();
            DtoConfig DataConfigTokenSIPAS = DataToken.getDataTokenSIPAS3();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenSIPAS);
            string json = JsonConvert.SerializeObject(solicitud);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }

        public DtoExpedientesSipas ObtenerExpedienteSipas(int inspeccion_id, string expediente_sipas)
        {
            DtoConfig Dataconfig = getUrlExpedientesSipas();
            DtoConfig DataConfigTokenSIPAS = DataToken.getDataTokenSIPAS3();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenSIPAS);
            var json = new JObject
            {
                ["inspeccion_id"] = inspeccion_id,
                ["expediente_sipas"] = expediente_sipas
            };
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json.ToString(Formatting.None));

            DtoExpedientesSipas ListaExpedientes = JsonConvert.DeserializeObject<DtoExpedientesSipas>(resultjson);
            return ListaExpedientes;
        }

        public DtoExpedientesSipas ObtenerExpedienteMultasSipas(int inspeccion_id, string expediente_sipas)
        {
            DtoConfig Dataconfig = getUrlExpedientesMultasSipas();
            DtoConfig DataConfigTokenSIPAS = DataToken.getDataTokenSIPAS3();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenSIPAS);
            var json = new JObject
            {
                ["inspeccion_id"] = inspeccion_id,
                ["expediente_sipas"] = expediente_sipas
            };
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json.ToString(Formatting.None));

            DtoExpedientesSipas ListaExpedientes = JsonConvert.DeserializeObject<DtoExpedientesSipas>(resultjson);
            return ListaExpedientes;
        }

        public DtoExpedientesSipas ObtenerExpedienteDocumentosSipas(int inspeccion_id, string expediente_sipas)
        {
            DtoConfig Dataconfig = getUrlExpedientesDocumentosSipas();
            DtoConfig DataConfigTokenSIPAS = DataToken.getDataTokenSIPAS3();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenSIPAS);
            var json = new JObject
            {
                ["inspeccion_id"] = inspeccion_id,
                ["expediente_sipas"] = expediente_sipas
            };
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json.ToString(Formatting.None));

            DtoExpedientesSipas ListaExpedientes = JsonConvert.DeserializeObject<DtoExpedientesSipas>(resultjson);
            return ListaExpedientes;
        }

        public string ActualizarIncumplimientos(DtoSolicitudSancion solicitud)
        {
            DtoConfig Dataconfig = getUrlActualizarIncumplimientosSIPAS();
            DtoConfig DataConfigTokenSIPAS = DataToken.getDataTokenSIPAS3();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenSIPAS);
            string json = JsonConvert.SerializeObject(solicitud);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }



    }
}
      