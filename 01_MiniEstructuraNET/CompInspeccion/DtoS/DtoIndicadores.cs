using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoIndicadores
    {
        public int indicador_id = -1;
        public int submateria_id = -1;
        public int requisito_id = -1;
        public int ind_consecutivo = -1;
        public String ind_indicador = String.Empty;
        public Int16 ind_aplica_alcance = -1;
        public String ind_alcance_inspeccion = String.Empty; 
        public String ind_fundamento = String.Empty;
        public int ind_alcance = -1;
        public int ind_obligatorio = -1;
        public int ind_se_incluye_en_docto = -1;
        public int ind_dependiente = -1;
        public int ind_info_adicional = -1;
        public int ind_anexar_docto = -1;
        public int ind_incisos = -1;
        public int ind_conduce_medida = -1;
        public int ind_tipo_incumplimiento = -1;
        public String ind_respuesta_depende = String.Empty;
        public Int16 ind_estatus = -1;
        public int indicador_depende_id  = -1;
        public String sys_usr = String.Empty;
        public int ind_tema_nom_id = -1;
        public int ind_tema_frecuente = -1;
        public String sentencia = "UPDATE";



    }
}
