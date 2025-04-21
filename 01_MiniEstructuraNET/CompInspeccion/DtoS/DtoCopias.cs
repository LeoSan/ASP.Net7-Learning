using CompInspeccion.DtoS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoCopias
    {
        public int inspec_copia_id = -1;
        public String icop_nombre_copia = String.Empty;        
        public int inspeccion_id = -1;        
        public String sys_usr = String.Empty;
    }
}
