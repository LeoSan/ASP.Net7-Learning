using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
	[Serializable()]
	public class DtoDshgoRevisionInfo
	{
		public int dshgo_revision_info_id = -1;
		public int dshgo_revision_id = -1;
		public int ind_info_adicional_id = -1;
		public string dri_informacion = "";
		public string sys_usr = "";
	}
}
