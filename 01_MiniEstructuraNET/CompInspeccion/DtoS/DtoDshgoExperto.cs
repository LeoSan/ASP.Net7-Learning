using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
     [Serializable()]
     public class  DtoDshgoExperto
     {
        public int dshgo_experto_id = -1;
        public int dshgo_participante_id = -1;
        public Int16 tipo_identificacion_id = -1;
        public string dexp_num_identificacion = String.Empty;
        public int inspec_experto_id = -1;

        public void AgregarExp()
        {
            ComponentInsp miComponente = new ComponentInsp();
            miComponente.Dshgo_Experto_AgregarActualizar(this);
        }

        public int EliminarExp()
        {
            ComponentInsp miComponente = new ComponentInsp();
            return miComponente.DshgoExperto_Eliminar(this.dshgo_experto_id);
        }
    }
}
