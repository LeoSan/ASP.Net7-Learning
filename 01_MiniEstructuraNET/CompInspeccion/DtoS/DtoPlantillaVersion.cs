using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoPlantillaVersion
    {
        public int pv_version_id { get; set; }
        public int pv_tipo_documento_id { get; set; }
        public int pv_version { get; set; }
        public String pv_plantilla_html { get; set; }
        public String pv_estatus { get; set; }
        public String pv_descripcion_corta { get; set; }
        public DateTime pv_fecha_creacion { get; set; }
        public DateTime pv_fecha_activacion { get; set; }
        public DateTime pv_fecha_actualizacion { get; set; }
        public String sys_usr_insert { get; set; }
    }
}
