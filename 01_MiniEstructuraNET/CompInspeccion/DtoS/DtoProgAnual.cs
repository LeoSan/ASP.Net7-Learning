using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoProgAnual
    {
        public int prog_anual_id = -1;
        public int panual_anio = -1;
        public int panual_meta_anual = -1;
        public String panual_fec_programacion = String.Empty;
        public int panual_num_inspectores = -1;
        public double panual_inspecciones_por_inspector = -1;
        public int panual_pct_prog_aleatoria = -1;
        public int panual_pct_prog_directa = -1;
        public int panual_estatus = -1;
        public String sys_usr = String.Empty;

		public int panual_estatus_metas = -1;
		public int panual_estatus_distribucion = -1;
		public int panual_estatus_operativo = -1;

        public int normativa_version_id = -1;
    }
}
