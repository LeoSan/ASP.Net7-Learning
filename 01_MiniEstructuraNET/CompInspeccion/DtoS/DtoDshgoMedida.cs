using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoDshgoMedida
    {
        public int dshgo_medida_id = -1;
        public int desahogo_id = -1;
        public int ind_medida_id = -1;
        public int ind_info_adicional_id = -1;
        public String dmed_observaciones = String.Empty;
        public int dmed_cumplimiento_espontaneo = -1;
        public String sys_usr = String.Empty;
        public String dmed_info_adicional_texto = String.Empty;
        public int dmed_restriccion_acceso = -1;
        public int dmed_restriccion_decreto = -1;  //1=LIMITACIÓN DE OPERACIONES, 2=RESTRICCIÓN DE ACCESO, 3=RESTRICCIÓN DE ACCESO Y LIMITACIÓN DE OPERACIONES
    }
}
