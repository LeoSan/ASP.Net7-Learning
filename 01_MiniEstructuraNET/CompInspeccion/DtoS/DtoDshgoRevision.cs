using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
	[Serializable()]
	public class DtoDshgoRevision
	{
		public int dshgo_revision_id = -1;
		public int dshgo_alcance_id = -1;
		public int indicador_id = -1;
		public int ind_inciso_id = -1;
		public int drev_respuesta = -1;
		public string drev_observaciones = "";
		public string sys_usr = "";
	}
}
