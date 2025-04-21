using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
	public class DtoEmplazamiento
	{
		public int emplazamiento_id				= -1;
		public int inspeccion_origen_id			= -1;
		public int inspeccion_comprobacion_id	= -1;
		public String em_num_emplazamiento		= "";
		public String em_fec_notificacion		= "";
		public int em_plazo_mayor				= -1;
		public int em_atencion_inmediata		= -1;
		public String em_fec_acuse_solicitud	= "";
		public String em_motivo_solicitud		= "";
		public int em_resolucion_ampliacion		= -1;
		public String em_motivo_resolucion		= "";
		public String em_fec_emplazamiento		= "";
		public int em_estatus					= -1;
		public String sys_usr					= "";
		public int em_dias_otorgados            = -1;

		public int calificacion_origen_id = -1;
        public int calificacion_comprobacion_id = -1;
	}
}
