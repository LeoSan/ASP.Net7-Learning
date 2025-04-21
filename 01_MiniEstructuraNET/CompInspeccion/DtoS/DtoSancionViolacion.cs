using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion.DtoS
{
    public class DtoSancionViolacion
    {
        public int sancion_violacion_id = -1;
        public string expediente_juridico = "";
        public int inspeccion_id = -1; 
        public int dshgo_revision_id = -1;
        public int calificacion_id = -1;
        public int indicador_id = -1;
        public int submateria_id = -1;
        public string cviol_numeral = "";
        public string cviol_violacion = "";
        public int cviol_procede = -1;
        public string sys_usr_insert = "";
        public string num_solicitud = "";
        public int tipo_incumplimiento = -1;
        public string cviol_fundamento = "";
        public string cviol_descripcion = "";
        public string origen = "";

    }
}