using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgoListadoPersonalActivo
    {
        public int dshgo_listado_personal_id =   -1;
	    public int desahogo_id =   -1;
	    
	    public String dshgo_listado_trab_nombre =   String.Empty;
	    public String dshgo_listado_trab_puesto =   String.Empty;
        public String dshgo_listado_trab_actividad = String.Empty;
        public String dshgo_listado_trab_patron = String.Empty;
        public String dshgo_listado_trab_ss = String.Empty;

        public String sys_usr_insert = String.Empty;
        public String sys_usr_update = String.Empty;


    }
}
