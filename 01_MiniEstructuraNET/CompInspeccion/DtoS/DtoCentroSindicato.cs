using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoCentroSindicato
    {
        public int centro_sindicato_id = -1;
        public int centro_trabajo_id = -1;
        public int sindicato_id = -1;
        public int cs_orden = -1;
        public int cs_no_incluido = -1;
        public string cs_otro_sindicato = "";
        public string sys_usr = "";
    }
}
