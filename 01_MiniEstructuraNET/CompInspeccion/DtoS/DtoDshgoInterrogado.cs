using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgoInterrogado
    {
        public int dshgo_interrogado_id             =   -1;
	    public int dshgo_participante_id            =   -1;
	    public int tipo_identificacion_id           =   -1;
	    public String dint_num_identificacion       =   String.Empty;
	    public String dint_domicilio_notificaciones =   String.Empty;
        public int dint_mismo_domicilio             =   -1;
    }
}
