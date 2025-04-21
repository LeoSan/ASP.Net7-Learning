using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoIndTema
    {
        public int ind_tema_nom_id=-1;
        public int submateria_id=-1;
        public int indtnom_consecutivo=-1;
        public string indtnom_tema="";
        public int indtnom_tipo=-1;
        public int indtnom_estatus=-1;
        public int tema_padre_id = -1;
        public string sys_ur = "";
        public string sentencia = "";
    }
}
