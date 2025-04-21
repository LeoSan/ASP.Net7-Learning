using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgoInterrogatorioAbierta
    {

        public int dshgo_interrogatorio_abierta_id  = -1;
        public int dshgo_interrogado_id =-1;
        public String diabie_pregunta  =String.Empty;
        public String diabie_respuesta = String.Empty;
        public String sys_usr = String.Empty;

    }
}
