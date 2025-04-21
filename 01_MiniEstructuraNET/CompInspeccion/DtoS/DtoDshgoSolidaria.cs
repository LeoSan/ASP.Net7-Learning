using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
	[Serializable()]
	public class DtoDshgoSolidaria
	{
		public int dshgo_solidaria_dne_id = 1;
		public int dshgo_centro_trabajo_id = -1;
		public int dsol_dne_centro_trabajo_id = -1;
		public int dsol_dne_seguridad_social_id = -1;
		public int dsol_mismo_domicilio = -1;
		public int dsol_no_conoce_domicilio = -1;
		public int dsol_cae_id = -1;
		public string dsol_razon_social = "";
		public string dsol_rfc = "";
		public string dsol_calle = "";
		public string dsol_num_exterior = "";
		public string dsol_num_interior = "";
		public string dsol_colonia = "";
		public string dsol_poblacion = "";
		public string dsol_cp = "";
		public string dsol_ref_ubicacion = "";
		public string dsol_longitud = "";
		public string dsol_latitud = "";
		public string dsol_telefono = "";
		public string dsol_fax = "";
		public string dsol_email = "";
		public int dsol_cve_edorep = -1;
		public int dsol_cve_municipio = -1;
		public string dsol_imss_registro = "";
		public int dsol_num_hombres = -1;
		public int dsol_num_mujeres = -1;
		public int dsol_num_total = -1;
	}
}
