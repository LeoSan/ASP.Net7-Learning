using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoCalifViolacion
    {
        public int calif_violacion_id = -1;
        public int dshgo_revision_id = -1;
        public int cdshgo_medida_id = -1;
        public int calificacion_id = -1;
        public String cviol_numeral = String.Empty;
        public String cviol_violacion = String.Empty;
        public int cviol_procede = -1;
        public String sys_usr = String.Empty;
        public String num_solicitud= String.Empty;
        public String code_tipo_documento = String.Empty;
        
    }

    public class DtoCalifViolacionLista
    {
        public int calif_violacion_id = -1;
        public int dshgo_revision_id = -1;
        public int calificacion_id = -1;
        public String cviol_numeral = String.Empty;
        public String cviol_violacion = String.Empty;
        public int cviol_procede = -1;
        public String sys_usr = String.Empty;
        public String num_solicitud = String.Empty;
    }
}
