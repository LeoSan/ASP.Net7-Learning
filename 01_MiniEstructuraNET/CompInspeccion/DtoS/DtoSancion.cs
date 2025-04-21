using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion.DtoS
{
    public class DtoSancion
    {
		public int sancion_id = -1;
		public int inspeccion_origen_id = -1;
		public int inspeccion_sancion_id = -1;
		public String san_num_sancion = "";
		public String san_fec_notificacion = "";
		public int san_plazo_mayor = -1;
		public int san_atencion_inmediata = -1;
		public String san_fec_acuse_solicitud = "";
		public String san_motivo_solicitud = "";
		public int san_resolucion_ampliacion = -1;
		public String san_motivo_resolucion = "";
		public String sys_usr_insert = "";
		public String sys_usr_update = "";
		public String san_fec_sancion = "";
		public int san_estatus = -1;
		public String sys_usr = "";
		public int calificacion_origen_id = -1;
		public int calificacion_sancion_id = -1;
		public int san_dias_otorgados = -1;
		public String san_fecha_limite = "";
		public String num_expediente_juridico = "";
		public int tipo_resolucion = -1;
		public int sentido_resolucion = -1;
		public DateTime fecha_resolucion;
		public String fecha_notificacion = "";
		public int num_sanciones = -1;

	}
}