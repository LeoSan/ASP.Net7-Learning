using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoInfoMetadato
    {
        public int metadato_id { get; set; }
        public int  documento_id{ get; set; }
        public string tipo_metadato { get; set; }
        public string valor { get; set; }
        public string documento_tabla { get; set; }
    }
}

