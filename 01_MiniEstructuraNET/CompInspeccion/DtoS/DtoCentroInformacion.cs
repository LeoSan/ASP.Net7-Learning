using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoCentroInformacion
    {
        public int centro_informacion_id = -1;
        public int centro_trabajo_id = -1;
        public int ci_identificacion_capturado = -1;
        public String ci_identificacion_fec = "";
        public String ci_identificacion_origen = "";
        public String ci_identificacion_usr = "";
        public int ci_domicilio_capturado = -1;
        public String ci_domicilio_fec = "";
        public String ci_domicilio_origen = "";
        public String ci_domicilio_usr = "";
        public int ci_actividad_capturado = -1;
        public String ci_actividad_fec = "";
        public String ci_actividad_origen = "";
        public String ci_actividad_usr = "";
        public int ci_trabajadores_capturado = -1;
        public String ci_trabajadores_fec = "";
        public String ci_trabajadores_origen = "";
        public String ci_trabajadores_usr = "";
        public int ci_sindicato_capturado = -1;
        public String ci_sindicato_fec = "";
        public String ci_sindicato_origen = "";
        public String ci_sindicato_usr = "";
        public int ci_camara_capturado = -1;
        public String ci_camara_fec = "";
        public String ci_camara_origen = "";
        public String ci_camara_usr = "";
        public int ci_tipo_capturado = -1;
        public String ci_tipo_fec = "";
        public String ci_tipo_origen = "";
        public String ci_tipo_usr = "";
        public int ci_programas_capturado = -1;
        public String ci_programas_fec = "";
        public String ci_programas_origen = "";
        public String ci_programas_usr = "";
        public int ci_empresas_capturado = -1;
        public String ci_empresas_fec = "";
        public String ci_empresas_origen = "";
        public String ci_empresas_usr = "";
    }
}
