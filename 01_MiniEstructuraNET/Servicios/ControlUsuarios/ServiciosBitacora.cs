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
    public class ServiciosBitacora : ConfiguracionBitacora
    {
        ConfiguracionServicios ConfiguracionServicio = new ConfiguracionServicios();
        ConfiguracionToken DataToken = new ConfiguracionToken();

        /// <summary>
        /// Método que consulta la bitácora
        /// </summary>
        /// <param name="palabra">Texto libre a buscar</param>
        /// <param name="user_id">core_usuario_id</param>
        /// <param name="per_page">Numero por pagina</param>
        /// <param name="current_page">Cantidad por pagina</param>
        /// <returns>Listado de la bitácora</returns>
        public DtoServicioConsultaBitacora ConsultarBitacora(string palabra, string core_usuario_id, string usr_email, int per_page, int current_page)
        {
            DtoConfig Dataconfig = getDataConsultarBitacora();
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios);
            DtoBitacora dtoBitacora = new DtoBitacora();
            dtoBitacora.words = palabra;
            dtoBitacora.user_core_id = core_usuario_id;
            dtoBitacora.email_current = usr_email;
            dtoBitacora.per_page = per_page;
            dtoBitacora.current_page = current_page;
            string json = JsonConvert.SerializeObject(dtoBitacora);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            DtoServicioConsultaBitacora ListaBitacora = JsonConvert.DeserializeObject<DtoServicioConsultaBitacora>(resultjson);
            return ListaBitacora;
        }
        public DtoServicioRegistroBitacora InsertarBitacora(DtoBitacoraInsertar entidad)
        {
            DtoConfig Dataconfig = getDataInsertarBitacora(); //Obtiene la ruta, end point
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios(); //Obtiene la configuración de los datos del satélite
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios); //Obtenemos el token
            string json = JsonConvert.SerializeObject(entidad);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);

            DtoServicioRegistroBitacora Bitacora = JsonConvert.DeserializeObject<DtoServicioRegistroBitacora>(resultjson);
            return Bitacora;
        }
    }
}
