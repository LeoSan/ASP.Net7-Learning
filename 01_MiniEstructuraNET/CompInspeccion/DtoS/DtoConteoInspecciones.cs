using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion.DtoS
{
    public class DtoConteoInspecciones
    {
        public int Dshgo_conteo_inspecciones_id { get; set; }
        public int Usuario_id { get; set; }
        public string Materia_acronimo { get; set; }
        public int Total { get; set; }        

    }
}
