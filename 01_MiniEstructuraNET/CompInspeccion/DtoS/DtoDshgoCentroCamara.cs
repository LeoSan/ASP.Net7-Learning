using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
     [Serializable()]
    public class DtoDshgoCentroCamara
    {
        public int dshgo_centro_camara_id=-1;
	    public int dshgo_centro_trabajo_id=-1;
        public int dcc_dne_camara_id=-1;
        public String dcc_camara=String.Empty;
        public int dcc_orden=-1;
	    public int dcc_no_incluida=-1;
        public String sys_usr = String.Empty;
    }
}
