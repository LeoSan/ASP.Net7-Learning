using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
     [Serializable()]
    public class DtoProgEntidad
    {
        public int prog_entidad_id = -1;
        public int prog_mes_id = -1;
        public int pent_cve_edorep = -1;
        public int pent_cve_ur = -1;
        public int pent_total_mensual = -1;
        public int pent_pct_foraneas = -1;
        public int pent_num_operativos = -1;
        public int prog_anual_id = -1;
        public String sys_usr = String.Empty;
    }
}
