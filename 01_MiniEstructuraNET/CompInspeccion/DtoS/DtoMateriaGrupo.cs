using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]

    public class DtoMateriaGrupo
    {
        public int materia_grupo_id { get; set; }
        public int materia_id { get; set; }
        public string sentencia { get; set; }
        public string mg_nombre { get; set; }
        public int mg_num_materias { get; set; }
        public int mg_jurisdiccion { get; set; }
        public int normativa_version_id { get; set; }        
    }
}
