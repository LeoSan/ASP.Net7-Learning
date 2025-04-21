using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgoCentroTrabajo
    {
        public int dshgo_centro_trabajo_id=-1;
        public int desahogo_id=-1;
        public int dct_cae_id=-1;
        public int dct_dne_centro_trabajo_id=-1;
        public int dct_dne_seguridad_social_id=-1;
        public int dct_dne_tipo_agencia_id=-1;
        public int dct_mismo_domicilio_fiscal=-1;
        public int dct_no_conoce_domicilio=-1;
        public String dct_razon_social=String.Empty;
        public String dct_rfc=String.Empty;
        public String dct_calle=String.Empty;
        public String dct_num_exterior=String.Empty;
        public String dct_num_interior=null;
        public String dct_colonia=String.Empty;
        public String dct_poblacion=null;
        public String dct_cp=String.Empty;
        public String dct_ref_ubicacion=null;
        public String dct_longitud=null;
        public String dct_latitud=null;
        public String dct_telefono=null;
        public String dct_fax=null;
        public String dct_email=null;
        public int dct_cve_edorep=-1;
        public int dct_cve_municipio=-1;
        public int dct_cuenta_registro_patronal=-1;
        public String dct_imss_registro=null;
        public String dct_clase_riesgo=String.Empty;
        public double dct_prima_riesgo=-1;
        public int dct_tiene_sindicato=-1;
        public int dct_tiene_acta_constitutiva=-1;
        public String dct_notario_num_escritura=String.Empty;
        public String dct_notario_fec_emision=String.Empty;
        public String dct_notario_nombre=String.Empty;
        public String dct_notario_numero=String.Empty;
        public int dct_notario_cve_edorep=-1;
        public int dct_contrato_colectivo=-1;
        public int dct_contrato_ley=-1;
        public int dct_contrato_individual=-1;
        public String dct_fec_colectivo=null;
        public String dct_fec_ley=null;
        public int dct_cuenta_fec_colectivo=-1;
        public int dct_cuenta_fec_ley=-1;
        public int dct_cuenta_capital_contable=-1;
        public String dct_capital_contable = String.Empty; 
        public int dct_afiliado_camara=-1;
        public int dct_cuenta_solidarias=-1;
        public int dct_tiene_rspc=-1;
        public int dct_rspc_numero=-1;
        public int dct_rspc_calderas=-1;
        public int dct_rspc_criogenicos=-1;
        public int dct_sust_quimicas_peligrosas=-1;
        public int dct_liquidos_inflamables=-1;
        public int dct_materiales_piroforicos=-1;
        public String sys_usr=String.Empty;
        public String dct_nombre_comercial = null;
        public String dct_objeto_social = String.Empty;
        public String url_imagen_centro { get; set; }

        public int dct_doc_soporte = -1;
        public String dct_doc_soporte_descripcion = String.Empty;

    }
}
