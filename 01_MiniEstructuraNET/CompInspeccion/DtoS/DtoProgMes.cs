using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoProgMes
    {
        public int prog_mes_id = -1;
        public int prog_anual_id = -1;
        public int mes_id=-1;
		public int pmes_total_nacional =-1;
	    public double pmes_total_foraneas =-1;
        public int pmes_total_operativo = -1;

        public int anio = -1;
        public int meta_anual = -1;
        public int num_inspectores = -1;
        public bool metas_mensuales = false;
        public bool distribucion_inspecciones = false;

    }
}
