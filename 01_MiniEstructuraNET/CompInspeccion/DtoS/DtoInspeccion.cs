using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
	[Serializable()]
    public class DtoInspeccion
    {
        public int inspeccion_id = -1;
        public int inspeccion_origen_id = -1;
        public int inspector_id = -1;
		public int notificador_id = -1;
		public int mes_id = -1;
		public int materia_id = -1;
		public int fundamento_designacion_id = -1;
		public String fundamento_designacion = String.Empty;
		public int motivo_inspeccion_id = -1;
		public int subtipo_inspeccion_id = -1;
		public int operativo_id = -1;
		public int cve_ur = -1;
		public int cve_rama = -1;
		public int centro_trabajo_id = -1;
		public int in_anio = -1;
		public String submaterias = String.Empty;
		public String stins_nombre_corto = String.Empty;		
		public String rama_industrial = String.Empty;
		public String notificador_nombre = String.Empty;
		public String copias_nombre = String.Empty;
		public String in_num_expediente = String.Empty;
		public String in_otra_submateria = String.Empty;
		public String in_ct_rfc = String.Empty;
		public String in_ct_razon_social = String.Empty;
		public String in_ct_nombre = String.Empty;
		public String in_ct_imss_registro = String.Empty;
		public String in_ct_clase_riesgo = String.Empty;
		public String in_fec_inspeccion = String.Empty;
        public String in_hr_inspeccion = String.Empty;
		public int in_alcance = -1;
		public int in_habilitar_dias_inhabiles = -1;
		public int in_habilitar_horas_inhabiles = -1;
		public int in_incluye_noms_esp = -1;
		public String in_fec_emision = String.Empty;
		public int in_es_inspeccion_en_centro = -1;
		public String inspeccion_en_centro = String.Empty;
		public String motiv_nombre_corto = String.Empty;		
		public String in_domicilio_inspeccion = String.Empty;
		public int in_firman_titulares = -1;
		public String firman_titulares = String.Empty;
		public String in_nombre_firmante = String.Empty;
		public int in_id_firmante = -1;
		public String in_cargo_firmante = String.Empty;
		public int in_generar_citatorio = -1;
		public String generar_citatorio = String.Empty;
		public int in_incluir_notificador = -1;
		public String incluir_notificador = String.Empty;
		public int in_en_declare = -1;
		public int in_en_passt = -1;
		public String in_medio_informacion = String.Empty;
		public String motiv_pedir_campo_adicional = String.Empty;
		public String motiv_nombre_dato_adicional = String.Empty;
		public String operativo = String.Empty;
		public String in_req_documentos_inicio = String.Empty;
		public String in_req_documentos_termino = String.Empty;
		public String in_rsp_tipo_equipo = String.Empty;
		public String in_rsp_equipo = String.Empty;
		public String in_rsp_num_control = String.Empty;
		public String in_rsp_fec_autorizacion_provisional = String.Empty;
		public String in_rsp_tipo_aviso = String.Empty;
		public String in_rsp_folio = String.Empty;
		public String in_rsp_pruebas = String.Empty;
		public int in_resultado = -1;
		public int in_etapa = -1;
        public int in_estatus = -1;
        public int in_tipo_programacion_id = -1;
        public String in_domicilio_inspeccion2 = String.Empty;
        public String sys_usr = String.Empty;
        public String in_otra_materia_motivo = String.Empty;
        public int in_otra_materia_submateria = -1;

        public String xml_centro = String.Empty;
        public int tipo_inspeccion_id = -1;
        public int ordenar = -1;

        public int ct_entidad = -1;
        public int ct_municipio = -1;

        public int in_aplica_especial = -1;
		public String mat_acronimo = String.Empty;
		public int colectivo_id = -1;

		public int inspeccionid { get; set; }
		public int centrotrabajo_id { get; set; }
		public string numero_expediente { get; set; }
		public DateTime fecha_inspeccion { get; set; }
		public String fecha_emision { get; set; }
		public string etapa { get; set; }
		public string estatus_notificacion { get; set; }
		public string resolucion { get; set; }
		public string inspector { get; set; }
		public string inspector_adicionales { get; set; }
		public string expertos_nombre { get; set; }
		
		public String razon_social { get; set; }
		public DtoUsuario usuario { get; set; }
		public int? normativa_version_id { get; set; }
		public string normativa_version { get; set; }

		public string stins_subtipo { get; set; }
		public string tins_tipo { get; set; }
		public string multa { get; set; }

		public string num_solicitud { get; set; }
		public string codigo_documento { get; set; }


		// Para definir los datos de la inspeccion, desahogo ,calificacion origen		
		public int origen_desahogo_id = -1;
		public int origen_calificacion_id = -1;
		public int origen_tipo_desahogo_id = -1;
		public int rep_inspeccion_origen_id = -1;
		public int ant_subtipo_inspeccion_id = -1;


	}
}
