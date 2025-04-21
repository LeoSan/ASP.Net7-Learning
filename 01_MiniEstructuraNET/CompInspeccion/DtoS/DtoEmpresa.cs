using System;
using System.Collections.Generic;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoEmpresa
    {
        public int empresa_id = -1;
        public int grupo_empresarial_id = -1;
        public string grupo_empresarial_nombre = "";
        public short emp_tipo_persona = -1;
        public string emp_rfc = "";
        public string emp_curp = "";
        public string emp_nombre = "";
        public string emp_nombre_comercial = "";
        public string emp_observaciones = "";
        public short emp_estatus = -1;
        public string sys_usr = "";
    }
}
