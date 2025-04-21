using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoCentroMovimiento
    {
        public int centro_movto_id = -1;
        public int centro_trabajo_id = -1;
        public int segruidad_social_id = -1;
        public int tipo_organismo_id = -1;
        public int tipo_agencia_id = -1;
        public int rama_industrial_id = -1;
        public int ctmov_tipo_movto = -1;
        public int ctmov_es_movil = -1;
        public int ctmov_es_estacional = -1;
        public int ctmov_es_temporal = -1;
        public string ctmov_autor = "";
        public string ctmov_origen = "";
        public int ctmov_resolucion = -1;
        public int ctmov_estatus = -1;
        public string ctmov_nombre = "";
        public string ctmov_nombre_comercial = "";
        public string ctmov_imss_registro = "";
        public int ctmov_cve_edorep = -1;
        public int ctmov_cve_municipio = -1;
        public string ctmov_calle = "";
        public string ctmov_num_exterior = "";
        public string ctmov_num_interior = "";
        public string ctmov_colonia = "";
        public string ctmov_cp = "";
        public string sys_usr = "";

        public string ctmov_observaciones = "";
        public int ctmov_es_domicilio_fiscal = -1;
        public string ctmov_poblacion = "";
        public string ctmov_ref_ubicacion = "";
        public string ctmov_longitud = "";
        public string ctmov_latitud = "";
        public string ctmov_telefono = "";
        public string ctmov_fax = "";
        public string ctmov_email = "";
        public int ctmov_actividad_scian = -1;
        public int ctmov_actividad_imss = -1;
        public int ctmov_actividad_imss_riesgo = -1;
        public int ctmov_jurisdiccion = -1;
        public int ctmov_contrato_individual = -1;
        public int ctmov_contrato_colectivo = -1;
        public int ctmov_contrato_ley = -1;
        public string ctmov_fec_colectivo = "";
        public string ctmov_fec_ley = "";
        public int ctmov_num_trabajadores = -1;
        public int ctmov_tiene_sindicato = -1;
        public int ctmov_afiliado_camara = -1;
        public int ctmov_es_organismo = -1;
        public int ctmov_es_agencia_colocacion = -1;
        public float ctmov_prima_riesgo = -1.0f;
        public int ctmov_es_prioritario = -1;
        public int ctmov_en_declare = -1;
        public int ctmov_en_passt = -1;
        public int ctmov_todo_centro = -1;
        public int ctmov_acreditado_sasst = -1;
        public int ctmov_tiene_rspc;
        public int ctmov_rspc_aut_provisional;
        public int ctmov_rspc_aut_vencida;
        public String ctmov_fec_ultima_inspeccion;
        public int ctmov_visitada_oper_ptu = -1;
        public int ctmov_reincidente_violacion_grave = -1;
        public int ctmov_proc_pendientes_ultimo_anio = -1;
        public int ctmov_accidentes_dos_anios = -1;
        public int ctmov_menores_aut = -1;
        public int ctmov_sin_planes = -1;
        public float ctmov_pct_inclumplimiento_declare = -1.0f;
        public int ctmov_baja_declare = -1;
        public int ctmov_passt_mas_tres_anios = -1;
        public float ctmov_pct_incumplimiento_passt = -1.0f;
        public string ctmov_solidarias = "";
        public string ctmov_sindicatos = "";
        public string ctmov_camaras = "";
    }
}
