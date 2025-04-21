using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class NormatividadVersion
    {
        public string sentencia { get; set; }
        public int normatividad_version_id { get; set; }
        public string nv_version { get; set; }
        public string nv_descripcion { get; set; }
        public string nv_estatus { get; set; }
        public DateTime? nv_fecha_publicacion { get; set; }
        public DateTime? nv_fecha_eliminacion { get; set; }
        public int nv_duplicar { get; set; }
        public string estatus_actual { get; set; }
        public int nv_activa { get; set; }

    }
}
