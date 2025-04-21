using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoModificacion
    {
        public int modificacion_id = -1;
        public int inspeccion_id = -1;
        public int motivo_modificacion_id = -1;
        public int mod_tipo_modificacion = -1;
        public String mod_descripcion = String.Empty;
        public String sys_usr = String.Empty;
    }
}
