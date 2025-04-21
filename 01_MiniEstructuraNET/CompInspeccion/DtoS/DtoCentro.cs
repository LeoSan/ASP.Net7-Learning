using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoCentro
    {
        public int centro_trabajo_id = -1;
        public int empresa_id = -1;
        public int segruidad_social_id = -1;
        public int rama_industrial_id = -1;
        public int tipo_organismo_id = -1;
        public int tipo_agencia_id = -1;
        public int origen_prioridad_id = -1;
        public int ct_tipo_alta = -1;
        public int ct_es_movil = -1;
        public int ct_es_estacional = -1;
        public int ct_es_temporal = -1;
        public String ct_fec_baja_automatica;
        public int ct_vigencia_renovada;
        public String ct_nombre;
        public String ct_nombre_comercial;
        public String ct_imss_registro;
        public String ct_observaciones;
        public int ct_es_domicilio_fiscal = -1;
        public int ct_cve_edorep = -1;
        public int ct_cve_municipio = -1;
        public String ct_calle = "";
        public String ct_num_exterior = "";
        public String ct_num_interior = "";
        public String ct_colonia = "";
        public String ct_poblacion = "";
        public String ct_cp = "";
        public String ct_ref_ubicacion = "";
        public String ct_longitud = "";
        public String ct_latitud = "";
        public String ct_telefono = "";
        public String ct_fax = "";
        public String ct_email = "";
        public int ct_actividad_scian = -1;
        public int ct_actividad_imss = -1;
        public int ct_actividad_imss_riesgo = -1;
        public int ct_jurisdiccion = -1;
        public int ct_contrato_individual = -1;
        public int ct_contrato_colectivo = -1;
        public int ct_contrato_ley = -1;
        public String ct_fec_colectivo = "";
        public String ct_fec_ley = "";
        public int ct_num_trabajadores = -1;
        public int ct_tiene_sindicato = -1;
        public int ct_afiliado_camara = -1;
        public int ct_es_organismo = -1;
        public int ct_es_agencia_colocacion = -1;
        public float ct_prima_riesgo = -1.0f;
        public int ct_es_prioritario;
        public int ct_en_declare = -1;
        public int ct_en_passt = -1;
        public int ct_todo_centro = -1;
        public int ct_acreditado_sasst = -1;
        public int ct_tiene_rspc=-1;
        public int ct_rspc_aut_provisional=-1;
        public int ct_rspc_aut_vencida=-1;
        public String ct_fec_ultima_inspeccion="";
        public int ct_visitada_oper_ptu = -1;
        public int ct_reincidente_violacion_grave = -1;
        public int ct_proc_pendientes_ultimo_anio = -1;
        public int ct_accidentes_dos_anios = -1;
        public int ct_menores_aut = -1;
        public int ct_sin_planes = -1;
        public float ct_pct_inclumplimiento_declare = -1.0f;
        public int ct_baja_declare = -1;
        public int ct_passt_mas_tres_anios = -1;
        public float ct_pct_incumplimiento_passt = -1.0f;
        public int ct_estatus = -1;
        public int ct_sust_quimicas_peligrosas = -1;
        public int ct_liquidos_inflamables = -1;
        public int ct_materiales_piroforicos = -1;
        public String sys_usr = "";

        public String sindicatos = "";
        public String camaras = "";
    }
}
