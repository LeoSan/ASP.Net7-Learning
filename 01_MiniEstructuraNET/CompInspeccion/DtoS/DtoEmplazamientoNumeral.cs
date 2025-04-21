using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
	[Serializable]
	public class DtoEmplazamientoNumeral
	{
		public int emplazamiento_numeral_id = -1;
		public int emplazamiento_id = -1;
		public int en_consecutivo = -1;
		public String en_numeral = "";
		public int en_estatus = -1;
		public int submateria_id = -1;
		public int ind_medida_plazo_id = -1;
		public String en_medida = "";
		public String en_fundamento = "";
		public String en_areas = "";
	}
}