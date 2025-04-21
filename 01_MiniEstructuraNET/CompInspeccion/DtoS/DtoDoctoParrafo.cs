using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]

    public class DtoDoctoParrafo
    {

        public int docto_parrafo_id     = -1;
        public int dp_tipo_documento_id = -1;
        public String dp_variable       = "";
        public int dp_tipo_parrafo      = -1;
        public int dp_cond_tipo         = -1;
        public int dp_cond_subtipo      = -1;
        public int dp_cond_materia      = -1;
        public int dp_cond_otra         = -1;
        public String dp_condicion      = "";
        public int dp_estatus           = -1;
        public String sys_usr           = "";
        public int dp_es_fundamento     = -1;



        public int Agregar()
        {
            ComponentInsp miComponente = new ComponentInsp();
           return miComponente.DoctoParrafo_AgregarActualizar(this);
        }

	}

    public class DtoDoctoParrafoSipas
    {
        public int s_tipo_documento_id = -1;
        public int s_docto_parrafo_id = -1;
        public String sdp_variable = "";
        public int sdp_tipo_parrafo = -1;
        public int sdp_cond_comparecencia = -1;
        public int sdp_cond_materia = -1;
        public int sdp_cond_otra = -1;
        public String sdp_condicion = "";
        public int sdp_estatus = -1;
        public String sys_usr_insert = "";

        public int Agregar()
        {
            ComponentInsp miComponente = new ComponentInsp();
           return miComponente.DoctoParrafo_AgregarActualizarSipas(this);
        }

	}
}
