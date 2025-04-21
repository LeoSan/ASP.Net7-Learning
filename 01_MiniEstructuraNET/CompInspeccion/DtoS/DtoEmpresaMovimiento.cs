using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoEmpresaMovimiento
    {
        public int empresa_movto_id = -1;
        public int empresa_id = -1;
        public int emov_tipo_movto = -1;
        public string emov_autor = "";
        public string emov_origen = "";
        public int emov_resolucion = -1;
        public string emov_rfc = "";
        public string emov_curp = "";
        public string emov_nombre = "";
        public string sys_usr = "";
        public int emov_estatus = -1;
    }
}
