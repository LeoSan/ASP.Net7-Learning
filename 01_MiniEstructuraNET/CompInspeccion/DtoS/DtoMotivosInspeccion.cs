using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoMotivosInspeccion
    {
        public int motivo_inspeccion_id;
        public int motiv_consecutivo;
        public String motiv_motivo;
        public String motiv_nombre_corto;
        public String motiv_motivo_rgiasvll;
        public int motiv_definicion;
        public int motiv_para_operativo_especial;
        public int motiv_para_operativo_programado;
        public int motiv_pedir_campo_adicional;
        public String motiv_nombre_dato_adicional;
        public int motiv_estatus;
        public String sys_usr;
        public int normativa_version_id;
    }

    public class DtoMotivosInspeccionNorma
    {
        public int motivo_inspeccion_id;
        public int nuevo_id;
    }
}
