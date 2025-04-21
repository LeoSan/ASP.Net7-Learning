using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoCentroCamara
    {
        public int centro_camara_id = -1;
        public int camara_id = -1;
        public int centro_trabajo_id = -1;
        public int cc_orden = -1;
        public int cc_no_incluida = -1;
        public string cc_otra_camara = "";
        public string sys_usr = "";
    }
}
