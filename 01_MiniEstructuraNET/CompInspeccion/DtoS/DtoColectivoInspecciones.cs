using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoColectivoInspecciones
    {
        public int colectivo_id = -1;
        public int usuario_id = -1;
        public string nombre = "";
        public int total = -1;
        public string fecha_creacion = "";
    }
}
