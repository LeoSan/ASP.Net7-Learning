using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoIndMedida
    {
        public int ind_medida_id = -1;
        public int ind_medida = -1;
        public int indicador_id = -1;
        public int ind_inciso_id = -1;
        public int ind_medida_plazo_id = -1;
        public int imed_tipo_incumplimiento = -1;
        public int imed_gravedad = -1;
        public int imed_respuesta = -1;
        public String imed_medida = String.Empty;
        public String descripcion_condenatoria = String.Empty;
        public int imed_estatus = -1;
        public String sys_usr = String.Empty;


    }
}
