using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoSExpedienteEtapa
    {
		public int s_expediente_etapa_id = -1;
		public int s_etapa_id = -1;
		public int s_expediente_id = -1;
		public int responsable_id = -1;
		public int elaboro_id = -1;
		public int reviso_id = -1;
		public int see_plazo = -1;
		public string see_fec_inicio = String.Empty;
		public string see_fec_cierre = String.Empty;
		public string see_fec_documento = String.Empty;
		public string see_fec_asignacion = String.Empty;
		public string see_semaforo = String.Empty;
		public int see_estatus = -1;
		public string sys_usr = String.Empty;

		public int s_etapa_tipo_id = -1;
		public int responsable_atencion_id = -1;
		public int see_plazo_tipo_dias = -1;
	}
}
