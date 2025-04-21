using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
	[Serializable()]
	public class DtoDesahogo
	{
		public int      desahogo_id = -1;
		public int      inspeccion_id = -1;
		public int      notif_forma_constatacion_id = -1;
		public int      tipo_establecimiento_id = -1;
		public int      dshgo_tipo_desahogo = -1;
		public int      dshgo_se_pudo_constituir = -1;
		public String   dshgo_otro_motivo_informe = String.Empty;
		public String   dshgo_otra_forma_constatacion = String.Empty;
		public String   dshgo_forma_constatacion = String.Empty;
		public int      dshgo_tiene_sindicato = -1;
		public int      dshgo_sin_testigos = -1;
		public String   dshgo_motivo_designacion = String.Empty;
		public int      dshgo_participa_comision = -1;
		public String   dshgo_motivo_no_comision = String.Empty;
		public String   dshgo_actividad_real = String.Empty;
		public String   dshgo_otro_tipo_establecimiento = String.Empty;
		public String   dshgo_otro_tipo_instalacion = String.Empty;
		public int      dshgo_metros_construccion = -1;
		public int      dshgo_metros_superficie = -1;
		public int      dshgo_no_cuenta_trabajadores = -1;
		public String   dshgo_proceso_descripcion = String.Empty;
		public String   dshgo_proceso_productos = String.Empty;
		public String   dshgo_proceso_desechos = String.Empty;
		public String   dshgo_proceso_maquinaria = String.Empty;
		public String   dshgo_proceso_tarifa = String.Empty;
		public int      dshgo_no_interrogatorios = -1;
        public int      dshgo_no_listado = -1;
        public int      dshgo_tipo_cierre = -1;
		public String   dshgo_fec_cierre_parcial = String.Empty;
		public String   dshgo_motivo_parcial = String.Empty;
		public String   dshgo_fec_reinicio = String.Empty;
		public String   dshgo_fec_cierre = String.Empty;
		public int      dshgo_forma_entrega_informe = -1;
		public String   dshgo_motivo_negativa = String.Empty;
		public int?      dshgo_con_notif_electronica = -1;
		public int? dshgo_recibe_claves = -1;
		public String dshgo_usuario_clave = String.Empty;
		public String dshgo_usuario_password = String.Empty;
		public int dshgo_estatus = -1;
		public String sys_usr = String.Empty;

		public int dshgo_no_cuenta_solidaria = -1;
		public String dshgo_no_cuenta_trabajadores_motivo = String.Empty;

        public String dshgo_descripcion_resultado = String.Empty;

        public String dshgo_fec_cierre_parcial2 = String.Empty;
        public String dshgo_motivo_parcial2 = String.Empty;
        public String dshgo_fec_reinicio2 = String.Empty;
        public int dshgo_sin_consulta_restriccion = -1;
		public int dshgo_genera_acta_como_visita = -1;
	}
}
