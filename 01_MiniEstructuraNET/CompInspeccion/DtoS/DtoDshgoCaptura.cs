using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgoCaptura
    {
        public int desahogo_id          = -1;
        public int dshgo_seccion_id     = -1;
        public int dcapt_info_capturada = -1;
        public String sys_usr           =   String.Empty; 
    }

}
