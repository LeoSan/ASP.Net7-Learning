using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoInspecParticipante
    {
        public int inspec_participante_id = -1;
        public int inspeccion_id = -1;
        public int participante_id = -1;
        public int inspector_id = -1;
        public int ipar_tipo_participacion = -1;
        public int inspector_aleatorio_id = -1;        
        public String sys_usr = String.Empty;
        public String nombre_completo = String.Empty;
        public String nombre_completo_alea = String.Empty;
        public String fundamento_designacion = String.Empty;
        public String tipo_participacion = String.Empty;
        public String usr_email = String.Empty;
        
    }
}
