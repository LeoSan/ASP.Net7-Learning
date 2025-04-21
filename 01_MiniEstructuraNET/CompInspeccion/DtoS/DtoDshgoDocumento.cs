using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgoDocumento
    {
        public int dshgo_documento_id=-1;
		public int desahogo_id=-1;
        public int tipo_documento_id=-1;
        public String ddoc_nombre_documento=String.Empty;
        public String ddoc_url_documento=String.Empty;
        public String ddoc_hash=String.Empty;
        public String sys_usr = String.Empty;
        public int documento_firmado = -1;
        public String doc_url_archivo_sin_firmas = "";

        public int AgregarPorDesahogo()
        {
            ComponentInsp miComponente = new ComponentInsp();
            return miComponente.DshgoDocumentoAgregarActualizar2(this);
        }
    }

}
