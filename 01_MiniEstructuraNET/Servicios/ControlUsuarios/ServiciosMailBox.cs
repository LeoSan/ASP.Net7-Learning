using Newtonsoft.Json;
using Servicios.DtoS;
using Servicios.Generales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Servicios.ControlUsuarios
{
    public class ServiciosMailBox : ConfiguracionMailBox
    {
        ConfiguracionServicios ConfiguracionServicio = new ConfiguracionServicios();
        ConfiguracionToken DataToken = new ConfiguracionToken();
        public DtoServicioInsertarMailBox InsertarMailbox(DtoMailBoxInsertar entidad)
        {
            DtoConfig Dataconfig = getDataInsertarMailBox(); //Obtiene la ruta, end point
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios(); //Obtiene la configuración de los datos del satélite
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios); //Obtenemos el token
            string json = JsonConvert.SerializeObject(entidad);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);

            DtoServicioInsertarMailBox buzon = JsonConvert.DeserializeObject<DtoServicioInsertarMailBox>(resultjson);
            return buzon;
        }

        public DtoServicioInsertarMailBox EditarMailbox(DtoMailBoxInsertar entidad)
        {
            DtoConfig Dataconfig = setDataEditarMailBox(); //Obtiene la ruta, end point
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios(); //Obtiene la configuración de los datos del satélite
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios); //Obtenemos el token
            string json = JsonConvert.SerializeObject(entidad);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);

            DtoServicioInsertarMailBox buzon = JsonConvert.DeserializeObject<DtoServicioInsertarMailBox>(resultjson);
            return buzon;
        }

        public DtoServicioInsertarMailBoxDocuments InsertarMailboxDocuments(DtoDatosInfoApoyo DatosInfoApoyo)
        {
            DtoConfig Dataconfig = getDataInsertarMailBoxDocuments(); //Obtiene la ruta, end point
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios(); //Obtiene la configuración de los datos del satélite
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios); //Obtenemos el token
            string json = JsonConvert.SerializeObject(DatosInfoApoyo);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            DtoServicioInsertarMailBoxDocuments buzon = JsonConvert.DeserializeObject<DtoServicioInsertarMailBoxDocuments>(resultjson);
            return buzon;
        }

        public DtoServicioConsultarTotalMessageNotReadMailBox ConsultarTotalMessageNotReadMailbox(string core_usuario_id)
        {
            DtoConfig Dataconfig = setDataConsultarTotalMessageNotReadMailBox(); //Obtiene la ruta, end point
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios(); //Obtiene la configuración de los datos del satélite
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios); //Obtenemos el token
            DtoServicioConsultarTotalMessageNotReadMailBox dtoConsultarTotalMessageNotReadMailBox = new DtoServicioConsultarTotalMessageNotReadMailBox();
            dtoConsultarTotalMessageNotReadMailBox.user_core_id = core_usuario_id;
           
            
            string json = JsonConvert.SerializeObject(dtoConsultarTotalMessageNotReadMailBox);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);

            DtoServicioConsultarTotalMessageNotReadMailBox total_message_not_read = JsonConvert.DeserializeObject<DtoServicioConsultarTotalMessageNotReadMailBox>(resultjson);
            return total_message_not_read;
        }
    }
}
