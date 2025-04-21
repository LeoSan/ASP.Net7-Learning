using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
	[Serializable()]
	public class DtoFirmantesDoc
    {
		public int fd_participante_id = -1;
		public int fd_inspeccion_id = -1;
		public int fd_desahogo_id = -1;
		public int fd_calificacion_id = -1;
		public string fd_proceso = String.Empty;
		public int fd_estatus = -1;
		public String fd_fecha_firma = String.Empty;
		public String fd_fecha_generacion = String.Empty;
		public int fd_total_documentos = -1;
		public int fd_total_firmados = -1;
		public int firmantes_documentos_id = -1;
	}
}
