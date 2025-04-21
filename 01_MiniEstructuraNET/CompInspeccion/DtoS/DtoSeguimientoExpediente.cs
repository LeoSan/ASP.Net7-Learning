using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable]
    public class DtoSeguimientoExpediente
    {
        public string bsq_numero_expediente = "";
        public string bsq_numero_inspeccion = "";
        public string bsq_numero_solicitud = "";
        public string bsq_re_nombre = "";
        //Busqueda Avanzada
        public string bsq_re_rfc = "";
        public int bsq_etapa_siguiente = -1;
        public int bsq_entidad_federativa = -1;
        public int bsq_unidad_responsable = -1;
        public int bsq_participante_id = -1;
        public string bsq_fecha_inicio = "";
        public string bsq_fecha_final = "";
        public int bsq_see_estatus = -1;

        //Control de paginas
        public Stack<String> PaginaAnterior = new Stack<String>();
        public int indice_navegador = 0;

        // Datos para el proceso
        public int s_expediente_id = -1;
        public string se_num_expediente = "";
        public int s_expediente_etapa_id = -1;
        public int s_documento_id = -1;
        public string ct_nombre = "";
        public string ct_domicilio = "";
        public string setapa_nombre = "";
        public string num_expediente = "";
        public int insp_cve_ur = -1;
        public int insp_cve_edo = -1;
        public int se_en_notificacion = -1;
        public int setapa_requiere_notificacion = -1;
        public int resultado = -1;
        public int s_etapa_id = -1;
        public String see_fec_documento = "";
        public int setapa_final = -1;
        public int se_estatus = -1;
        //para procedimientos sancionadores de la empresa, CS
        public int id_ct = -1;

        //Emplazamiento
        public int s_emplazamiento_id = -1;
        public int s_incumplimiento_id = -1;
        public int calif_documento_id = -1;
        public int s_cve_ur = -1;
        public int materia_id = -1;
        public string ct_domicilio_fiscal = "";
        public string fec_emplazamiento = "";
        public string materia_nombre = "";
        public string num_inspeccion = "";
        public string fec_inspeccion = "";
        public string num_solicitud = "";
        public string fec_solicitud = "";
        public string fec_escito = "";
        public string autoridad_ur = "";
        public bool es_comparecencia = false;

        //Copias fijas y domicilio de notificacion
        public int notif_cve_ur = -1;
        public string notif_nombre_ur = "";
        public string notif_domicilio = "";
        public string copia_ur = "";
        public string copia_centro = "";
        public bool cambioDomicilio = false;

        //Informe de cobro
        public int s_cobro_informe_id = -1;
        public int s_autoridad_fiscal_id = -1;
        public string safis_autoridad = "";
        public string scobi_fec_envio = "";
        public decimal scobi_monto_multa = decimal.MinusOne;

        //Solicitud de cobro
        public int s_cobro_solicitud_id = -1;

        //para Resolucion
        public int s_resolucion_id = -1;
        public int inspeccion_id = -1;
        public string inspectores = String.Empty;
        public int sentido_resolucion = -1;
        public string fec_resolucion_doc = String.Empty;

        //Comparecencia
        public int s_comparecencia_id = -1;

        //Acuerdo de Cierre de Procedimiento
        public int s_acuerdo_cierre_id = -1;

        //Impugnaciones
        public int s_impugnacion_id = -1;
        public string tipo_impugnacion = "";
        public string simpug_sentido = "";

        //Notificación
        public String sns_tipo_notif = "";

        //Resolucion cumplimiento
        public int s_resolucion_cumplimiento_id = -1;

        //Acuerdo de notificación
        public int s_notif_resultado_id = -1;
        public int s_acuerdo_notificacion_id = -1;

        //para el proceso de notificación
        /// <summary>
        /// 1) si, 2) no por domicilio, 3) no por huelga
        /// </summary>
        public int matriz_respuesta = -1;
        public int matriz_etapa_notifico = 0;
        public int matriz_etapa_inicio_notificacion = 0;
        public string sys_usr;

        //Acuerdo Trámite practique notificación
        public string ct_domicilio_nuevo = "";
        public string copia_centro_nuevo = "";
    }
}
