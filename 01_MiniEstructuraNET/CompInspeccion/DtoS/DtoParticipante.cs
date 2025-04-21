using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable]
    public class DtoParticipante
    {
        public int participante_id = -1;
        public int inspector_id = -1;
        public int usuario_id = -1;
        public int cve_ur = -1;
        public int perfil_id = -1;
        public int cve_edorep = -1;
        public String par_nombre = String.Empty;
        public String par_primer_apellido = String.Empty;
        public String par_segundo_apellido = String.Empty;
        public String par_puesto = String.Empty;
        public int par_es_inspector = -1;
        public int par_es_notificador = -1;
        public int par_es_firmante = -1;
        public int par_es_resp_juridico = -1;
        public int par_estatus = -1;
        public String par_area_juridica = String.Empty;

        public int par_es_dictaminador = -1;

        public String insp_num_credencial = String.Empty;

        public int cve_ur_comision = -1;
        public bool par_esta_comisionado = false;
        public string txt_search = string.Empty;
        public String code_participante = String.Empty;

        public String nombre_completo_alea = String.Empty;
        public int inspector_aleatorio_id = -1;

    }
}
