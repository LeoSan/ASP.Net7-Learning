using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoDshgoMedDescatalogada
    {
        public int dshgo_med_descatalogada_id = -1;
        public int desahogo_id = -1;
        public int submateria_id = -1;
        public int ind_medida_plazo_id = -1;
        public String dmd_medida = String.Empty;
        public String dmd_fundamento = String.Empty;
        public String dmd_observaciones = String.Empty;
        public int dmd_cumplimiento_espontaneo = -1;
        public String sys_usr = String.Empty;
        public int dmd_restriccion_acceso = -1;
        public int dmd_restriccion_decreto = -1;  //1=LIMITACIÓN DE OPERACIONES, 2=RESTRICCIÓN DE ACCESO, 3=RESTRICCIÓN DE ACCESO Y LIMITACIÓN DE OPERACIONES
    }
}
