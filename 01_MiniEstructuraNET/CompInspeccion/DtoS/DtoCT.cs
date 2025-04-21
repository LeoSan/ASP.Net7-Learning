using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
	[Serializable()]
	public class DtoCT
	{
		public int desahogo_id = -1;
		public int inspeccion_id = -1;
		public int cve_ur = -1;
		public int cve_edorep = -1;
		public String in_num_expediente = "";
		public String dct_razon_social = "";
		public String dct_rfc = "";
		public String dct_email = "";
		public String dshgo_usuario_clave = "";
		public String dshgo_usuario_password = "";
	}
}