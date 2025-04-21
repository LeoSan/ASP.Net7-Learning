using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion.DtoS
{
    [Serializable]
    public class DtoDshgoRespuesta
    {
        
        public int dshgo_pregunta_respuesta { get; set; }
        public int dshgo_pregunta_id { get; set; }
        public int dpresp_orden { get; set; }
        public string dpresp_respuesta { get; set; }
        public string sentencia { get; set; }        
        public string relacionado { get; set; }
        
    }
}
