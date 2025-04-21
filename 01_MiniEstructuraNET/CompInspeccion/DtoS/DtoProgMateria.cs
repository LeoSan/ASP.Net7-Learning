using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
	[Serializable()]
	public class DtoProgMateria
	{
		public int prog_anual_materia_id = -1;
		public int prog_anual_id = -1;
		public int materia_grupo_id = -1;
		public int prog_atributo_iniciales_id = -1;
		public int prog_atributo_periodicas_id = -1;
		public int pmat_pct_anual = -1;
		public int pmat_prioridad = -1;
		public int pmat_pct_iniciales = -1;
		public int pmat_pct_periodicas = -1;
		public String sys_usr = "";
	}
}
