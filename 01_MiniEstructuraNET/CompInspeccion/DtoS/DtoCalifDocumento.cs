using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoCalifDocumento
    {
        public int calif_documento_id = -1;
        public int tipo_documento_id = -1;
        public String code_documento = String.Empty;
        public int calificacion_id = -1;
        public int participante_id = -1;
        public String cdoc_num_documento = String.Empty;
        public String cdoc_fec_documento = String.Empty;
        public String cdoc_nombre_documento = String.Empty;
        public int cdoc_firma_titular = -1;
        public String cdoc_firmante = String.Empty;
        public String cdoc_puesto = String.Empty;
        public String cdoc_observaciones = String.Empty;
        public String cdoc_url_documento = String.Empty;
        public String cdoc_hash = String.Empty;
        public String sys_usr = String.Empty;

        public int participante_juridico_id = -1;
        public int cve_ur = -1;
        public int documento_firmado = -1;
        public String doc_url_archivo_sin_firmas = "";

        public int? aplica_notificacion = -1;
        public int? etapa = -1;
        public int? inspeccion_id = -1;
        public int td_aplica_automatica = -1;
        
    }
}
