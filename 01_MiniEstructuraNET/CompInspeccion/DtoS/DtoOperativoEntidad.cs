using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoOperativoEntidad
    {
        public int operativo_entidad_id = -1;
        public int operativo_id = -1;
        public int operent_cve_edorep = -1;
        public int operent_cve_ur = -1;
        public int operent_total_mensual = -1;
        public int operent_num_operativos = -1;
        public String sys_usr = String.Empty;

        //Datos para agregar total mensual
        public int mes_id = -1;
        public int anio = -1;
        public int prog_anual_id = -1;
    }
}
