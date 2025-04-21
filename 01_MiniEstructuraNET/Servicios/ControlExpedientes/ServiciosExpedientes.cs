using CompInspeccion;
using Newtonsoft.Json;
using Servicios.DtoS;
using Servicios.Generales;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ServicioDto = Servicios.DtoS;


namespace Servicios.ControlExpedientes
{
    public class ServiciosExpedientes : ConfiguracionExpedientes
    {
        ConfiguracionServicios ConfiguracionServicio = new ConfiguracionServicios();
        ConfiguracionToken DataToken = new ConfiguracionToken();
        ComponentInsp miComponente = new ComponentInsp();

        public string RegistrarActualizarExpediente(DtoExpediente expediente)
        {
            DtoConfig Dataconfig = getUrlRegistrarActualizarExpediente();
            DtoConfig DataConfigTokenExpedientes = DataToken.getDataTokenExpedientes();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenExpedientes);
            string json = JsonConvert.SerializeObject(expediente);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }

        public void RegistrarActualizarExpedientePorInspeccionId(int inspeccion_id)
        {
            DataSet ds;

            
            ds = miComponente.Obtener_DatosExpediente_Satelite(inspeccion_id);
            
            ServicioDto.DtoExpediente entidadServicioExpedientes = new ServicioDto.DtoExpediente();

            if (ds.Tables["resultado"].Rows.Count > 0)
            {

                DataRow miRow = ds.Tables[0].Rows[0];
                DateTime fecha_insp = new DateTime();
                DateTime fecha_creacion_expediente = new DateTime();

                entidadServicioExpedientes.inspeccion_id = int.Parse(miRow["inspeccion_id"].ToString());
                entidadServicioExpedientes.nombre_empresa = miRow["razon_social"].ToString();
                entidadServicioExpedientes.razon_social = miRow["razon_social"].ToString();
                entidadServicioExpedientes.num_exp_inspeccion = miRow["num_exp_inspeccion"].ToString();
                if (miRow["fecha_inspeccion"].ToString().Trim() != "")
                {
                    DateTime.TryParse(miRow["fecha_inspeccion"].ToString(), out fecha_insp);
                    entidadServicioExpedientes.fecha_inspeccion = fecha_insp.ToString("yyyy-MM-dd HH:mm:ss");
                }
                entidadServicioExpedientes.centro_trabajo = miRow["centro_trabajo"].ToString();
                entidadServicioExpedientes.domicilio = miRow["domicilio"].ToString();
                entidadServicioExpedientes.entidad_federativa = miRow["entidad_federativa"].ToString();
                entidadServicioExpedientes.ur_descripcion = miRow["ur_descripcion"].ToString();
                entidadServicioExpedientes.ur_descripcion_corta = miRow["ur_descripcion_corta"].ToString();
                entidadServicioExpedientes.num_exp_sancion = miRow["num_exp_sancion"].ToString();
                if (miRow["fecha_creacion_expediente"].ToString().Trim() != "")
                {
                    DateTime.TryParse(miRow["fecha_creacion_expediente"].ToString(), out fecha_creacion_expediente);
                    entidadServicioExpedientes.fecha_creacion_expediente = fecha_creacion_expediente.ToString("yyyy-MM-dd HH:mm:ss");
                }
                entidadServicioExpedientes.sub_tipo_inspeccion = miRow["sub_tipo_inspeccion"].ToString();
                entidadServicioExpedientes.materia = miRow["materia"].ToString();
                entidadServicioExpedientes.normatividad = miRow["normatividad"].ToString();
                entidadServicioExpedientes.etapa_inspeccion = miRow["etapa_inspeccion"].ToString();
                entidadServicioExpedientes.nombre_del_inspector = miRow["nombre_del_inspector"].ToString();
                entidadServicioExpedientes.numero_violaciones = miRow["numero_violaciones"].ToString();
                entidadServicioExpedientes.nombre_dictaminador = miRow["nombre_dictaminador"].ToString();
                entidadServicioExpedientes.nombre_calificador = miRow["nombre_calificador"].ToString();
                entidadServicioExpedientes.etapa_sancion = miRow["etapa_sancion"].ToString();
                entidadServicioExpedientes.etapa_notificacion = null;
                if (miRow["etapa_notificacion"].ToString() == "Solicitud de notificación" || miRow["etapa_notificacion"].ToString() == "Resultado de la notificación")
                    entidadServicioExpedientes.etapa_notificacion = miRow["etapa_notificacion"].ToString();

                if (miRow["resolucion_sipas_id"].ToString().Trim() != "")
                    entidadServicioExpedientes.resolucion_sipas_id = int.Parse(miRow["resolucion_sipas_id"].ToString());
                if (miRow["sentido_resolucion_sipas_id"].ToString().Trim() != "")
                    entidadServicioExpedientes.sentido_resolucion_sipas_id = int.Parse(miRow["sentido_resolucion_sipas_id"].ToString());
                entidadServicioExpedientes.resolucion_siapi = miRow["resolucion_siapi"].ToString();
                entidadServicioExpedientes.tipo_programacion = miRow["tipo_programacion"].ToString();
                entidadServicioExpedientes.tipo_inspeccion = miRow["tipo_inspeccion"].ToString();
                if (miRow["tipo_desahogo"].ToString().Trim() != "")
                    entidadServicioExpedientes.tipo_desahogo = int.Parse(miRow["tipo_desahogo"].ToString());
                if (miRow["inspeccion_origen_id"].ToString().Trim() != "")
                    entidadServicioExpedientes.inspeccion_origen_id = int.Parse(miRow["inspeccion_origen_id"].ToString());
                if (miRow["centro_trabajo_id"].ToString().Trim() != "")
                    entidadServicioExpedientes.centro_trabajo_id = int.Parse(miRow["centro_trabajo_id"].ToString());
                if (miRow["empresa_id"].ToString().Trim() != "")
                    entidadServicioExpedientes.empresa_id = int.Parse(miRow["empresa_id"].ToString());
            }

            RegistrarActualizarExpediente(entidadServicioExpedientes);
        }
    }
}
