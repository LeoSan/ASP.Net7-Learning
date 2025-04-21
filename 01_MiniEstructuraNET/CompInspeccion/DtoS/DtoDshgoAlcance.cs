using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{   
    [Serializable()]
    public class DtoDshgoAlcance
    {
        public int dshgo_alcance_id =   -1;
		public int desahogo_id      =   -1;
        public int submateria_id    =   -1;
        public int dsal_estatus     =   -1;
        public String sys_usr       =   String.Empty;
        public int dsal_no_aplica   =   -1;
    }
}
