using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoMaterias
    {
        public int materia_id = -1;
        public String mat_acronimo = String.Empty;
        public String mat_materia = String.Empty;
        public String mat_nombre_corto = String.Empty;
        public int mat_controlada_sistema = 0;
        public int mat_estatus = -1;
        public String sys_usr = String.Empty;
        public String sentencia = "UPDATE";
        public int normatividad_version_id = -1;
        public String normatividad_version = String.Empty;

        public int dshgo_seccion_materia_id = -1;
        public int dshgo_seccion_id = -1;
        public bool active_seccion = false;

    }
}
