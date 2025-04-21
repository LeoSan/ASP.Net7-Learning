using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
	public class DtoReprogramacion
	{

		public int reprogramacion_id    = -1;
		public int inspeccion_origen_id = -1;
		public int inspeccion_id        = -1;
		public String sys_usr           = "";
		public String rep_fec_envio_notificacion = "";
	}
}
