using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoOperativo
    {

        public int operativo_id                     = -1;
        public int prog_anual_id                    = -1;
        public int materia_id                       = -1;
        public int mes_id                           = -1;
        public int tipo_inspeccion_id               = -1;
        public int prog_atributo_id                 = -1;
        public int motivo_inspeccion_id             = -1;
        public int oper_tipo_operativo              = -1;
        public String opr_nombre                    = String.Empty;
        public String oper_descripcion              = String.Empty;
        public String oper_medio_informacion        = String.Empty;
        public int oper_tiene_indicadores           = -1;
        public int oper_dia_inicio                  =-1;
        public int oper_dia_termino                 =-1;
        public String oper_fec_inicio               = String.Empty;
        public String oper_fec_termino              = String.Empty;
        public int oper_es_prog_aleatoria           = -1;
        public int subtipo_inspeccion_id            = -1;
        public int oper_asignar_inspectores         = -1;
        public int oper_estatus                     = -1;
        public int oper_es_ptu                      = -1;
        public String sys_usr                       = String.Empty;
        public int normativa_version_id             = -1;
    }
}
