using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]

    public class DtoSeccionesMateria
    {

        public int dshgo_seccion_materia_id { get; set; }
        public int materia_id { get; set; }
        public string sentencia { get; set; }
        public int dshgo_seccion_id { get; set; }
    }
}
