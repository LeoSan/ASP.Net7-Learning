using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion.DtoS
{
    [Serializable()]
    public class DtoFactor
    {
        public int ent_cve_edo_rep { get; set; }
        public int ur_cur_cve_ur { get; set; }
        public int anio { get; set; }
        public int total_inspecciones { get; set; }
        public string factor { get; set; }
        public int fecha_ultima_actualizacion { get; set; }
        public int fecha_creacion { get; set; }
        
    }
}
