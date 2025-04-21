using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoBusquedaRegistroActividad
    {
        public String tipo_actividad = "";
        public int cve_ur = -1;
        public DateTime fecha_ini;
        public DateTime fecha_fin;
        public String fecha_ini_tx = "";
        public String fecha_fin_tx = "";
        public int estatus = -1;
    }
}
