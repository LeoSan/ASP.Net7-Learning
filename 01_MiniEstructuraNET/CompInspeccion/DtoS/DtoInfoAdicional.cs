using System;
using System.Collections.Generic;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoInfoAdicional
    {
        public int ind_info_adicional_id = -1;
        public int indicador_id = -1;
        public int ind_inciso_id = -1;
        public Int16 iia_respuesta_depende = -1;
        public string iia_info_adicional = string.Empty;
        public int iia_consecutivo = -1;
        public Int16 iia_forma_incorporar = -1;
        public string iia_opciones =  string.Empty;
        public string sys_usr = "";

        public void Agregar()
        {
            ComponentInsp miComponente = new ComponentInsp();
            miComponente.InfoAdicional_AgregarActualizar(this);
        }
    }
}
