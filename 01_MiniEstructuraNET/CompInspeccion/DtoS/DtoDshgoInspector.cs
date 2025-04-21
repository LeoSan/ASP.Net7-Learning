using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgoInspector
    {
        public int dshgo_inspector_id = -1;
        public int 	inspector_id  = -1;
        public int 	dshgo_participante_id  = -1;
        public int 	cve_ur  = -1;
        public string dinsp_fec_expedicion = String.Empty;
        public string dinsp_fec_inicio = String.Empty;
        public string dinsp_fec_termino = String.Empty;
        public string dinsp_num_credencial = String.Empty;
        public string dinsp_nombre_suscribe = String.Empty;
        public string dinsp_puesto_suscribe = String.Empty;
     
        public void AgregarInsp()
        {
            //dshgo_participante_id = Agregar();
            ComponentInsp miComponente = new ComponentInsp();
            miComponente.Dshgo_Inspector_AgregarActualizar(this);
        }

        public int EliminarInsp()
        {
            ComponentInsp miComponente = new ComponentInsp();
           // dshgo_participante_id = miComponente.DshgoInspector_Eliminar(dshgo_inspector_id);
           // Eliminar();
           return miComponente.DshgoInspector_Eliminar(this.dshgo_inspector_id);
        }

       
    }
}
