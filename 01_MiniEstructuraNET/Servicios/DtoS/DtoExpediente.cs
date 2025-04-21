using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.DtoS
{
    public class DtoExpediente
    {
        public int inspeccion_id { get; set; }
        public string nombre_empresa { get; set; }
        public string razon_social { get; set; }
        public string num_exp_inspeccion { get; set; }
        public string fecha_inspeccion { get; set; }
        public string centro_trabajo { get; set; }
        public string domicilio { get; set; }
        public string entidad_federativa { get; set; }
        public string ur_descripcion { get; set; }
        public string ur_descripcion_corta { get; set; }
        public string num_exp_sancion { get; set; }
        public string fecha_creacion_expediente { get; set; }
        public string sub_tipo_inspeccion { get; set; }
        public string materia { get; set; }
        public string normatividad { get; set; }
        public string etapa_inspeccion { get; set; }
        public string nombre_del_inspector { get; set; }
        public string numero_violaciones { get; set; }
        public string nombre_dictaminador { get; set; }
        public string nombre_calificador { get; set; }
        public string etapa_sancion { get; set; }
        public string etapa_notificacion { get; set; }
        public int resolucion_sipas_id { get; set; }
        public int sentido_resolucion_sipas_id { get; set; }
        public string resolucion_siapi { get; set; }
        public string tipo_programacion { get; set; }
        public string tipo_inspeccion { get; set; }
        public int tipo_desahogo { get; set; }
        public int inspeccion_origen_id { get; set; }
        public int centro_trabajo_id { get; set; }
        public int empresa_id { get; set; }
        public string num_solicitud_sancion { get; set; }
    }
}
