using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoInciso
    {
        public int ind_inciso_id = -1;
        public int indicador_id = -1;
        public int inc_consecutivo = -1;
        public string inc_inciso = "";
        public int inc_alcance = -1;
        public int inc_obligatorio = -1;
        public int inc_info_adicional = -1;
        public string inc_fundamento = "";
        public int inc_conduce_medida = -1;
        public int inc_estatus = -1;
        public string sys_usr = "";
        public String sentencia = "UPDATE";
    }
}
