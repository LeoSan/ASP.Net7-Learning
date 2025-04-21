using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]

    public class DtoSubtipoMateria
    {

        public int subtipo_inspeccion_id { get; set; }
        public int materia_id { get; set; }
        public string sentencia { get; set; }
        public string ms_atribuciones_541_lft { get; set; }
        public string ms_atribuciones_art_9_rgiasvll { get; set; }
        public string ms_asesoria_art_10_rgiasvll { get; set; }
        public string ms_requisitos_rgiasvll { get; set; }
        public string ms_tipo_542_lft { get; set; }
        public int materia_subtipo_id { get; set; }
    }
}
