using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]

    public class DtoTipoDocumento
    {
        public int tipo_documento_id    = -1;
        public int td_aplica_aleatoria  = -1;
        public int td_aplica_directa    = -1;
        public int td_aplica_automatica = -1;
        public int td_proceso           = -1;
        public int etapa                = -1;
        public int sub_etapa            = -1;
        public int mat_normativa_version_id = -1;
        public String td_plantilla_html = String.Empty;
        public String code = String.Empty;
        public String orientacion_documento = "vertical";
        public String td_url_plantilla = String.Empty;
        public String td_tipo_documento = String.Empty;
        public int td_requiere_notificacion = -1;
        public int td_forma_entrega = -1;
        public int td_limite_entrega = -1; 
        public int td_controlada_sistema = -1;
        public int td_activo = -1;
    }

    public class DtoTipoDocumentoInspeccion
    {
        public String sentencia { get; set; }
        public int pd_documento_id { get; set; }
        public String pd_plantilla_html { get; set; }
        public int pd_inspeccion_id { get; set; }
        public int pd_tipo_documento_id { get; set; }
        public int pd_confirmacion  { get; set; }
        public String es_plantilla_editada { get; set; }
        public String orientacion_documento { get; set; }
        public bool pd_plantilla_editada { get; set; }
    }

    public class DtoTipoDocumentoSipas
    {
        public int s_tipo_documento_id = -1;
        public int s_etapa_id = -1;
        public String std_tipo_documento = String.Empty;
        public String std_url_plantilla = String.Empty;
        public String std_plantilla_html = String.Empty;
        public String code = String.Empty;
        public String orientacion_documento = "vertical";
        public String tamanio_hoja = "oficio";
        public int std_controlado_por_el_sistema = -1;
        public int std_activo = -1;
        public int normativa_version_id = -1;
    }
}
