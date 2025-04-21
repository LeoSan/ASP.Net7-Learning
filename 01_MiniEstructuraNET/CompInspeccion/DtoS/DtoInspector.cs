using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoInspector
    {
        public int inspector_id = -1;
        public String insp_nombre = String.Empty;
        public int cve_edorep = -1;
        public int cve_ur = -1;
        public int insp_solo_notifica = -1;
        public String insp_fec_expedicion = String.Empty;
        public String insp_fec_inicio = String.Empty;
        public String insp_fec_termino = String.Empty;
        public String insp_num_credencial = String.Empty;
        public String insp_nombre_suscribe = String.Empty;
        public String insp_puesto_suscribe = String.Empty;
        public int insp_estatus = -1;
        public int insp_oportunidad_sh = -1;
		public int insp_oportunidad_rspc = -1;
		public int insp_oportunidad_supervision = -1;
        public int insp_oportunidad_todas = -1;
        public String sys_usr = String.Empty;
    }
}
