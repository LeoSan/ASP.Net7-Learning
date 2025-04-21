using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
	[Serializable()]
	public class DtoDshgoTrabajadorDetalle
	{
		public int dshgo_trabajador_det_id = -1;
		public int dshgo_trabajador_id = -1;
		public string dtrabd_nombre = "";
		public string dtrabd_edad = "";
		public string dtrabd_puesto = "";
		public string dtrabd_actividad = "";
	}
}
