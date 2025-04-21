using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]

    public class DtoDoctoBusqueda
    {

        public int    documento_id           = -1;
        public int    dp_tipo_documento_id   = -1;
        public String dp_variable            = "";
        public int    dp_tipo_parrafo        = -1;
        public String td_tipo_documento      = "";
        public int    docto_parrafo_id       = -1;
        public int    docto_parrafo_texto_id = -1;
        public int    docto_valor_id         = -1;
        public int    docto_variable_id      = -1;
        public String var_variable           = "";
        public int    var_tipo_variable      = -1;
        public int    td_proceso             = -1;
        public int    dshgo_documento_id     = -1;
        public int    cve_ur                 = -1;
        public int    normatividad_id = -1;
	}

    public class DtoDoctoBusquedaSipas
    {
        public int s_tipo_documento_id = -1;
        public int s_docto_parrafo_id = -1;
        public String sdp_variable = "";
        public int sdp_tipo_parrafo = -1;
        public int sdp_cond_comparecencia = -1;
        public int sdp_cond_materia = -1;
        public int sdp_cond_otra = -1;
        public String sdp_condicion = "";
        public int sdp_estatus = -1;
        public String sys_usr_insert = "";
    }
}
