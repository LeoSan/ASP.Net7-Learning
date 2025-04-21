using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.DtoS
{
    public class DtoDocumentos
    {
        public int id { get; set; }
        public string ruta { get; set; }        
        public string nombre { get; set; }
        public string tipo_documento_id { get; set; }
        public string model { get; set; }
        public string model_id { get; set; }       
    }
}
