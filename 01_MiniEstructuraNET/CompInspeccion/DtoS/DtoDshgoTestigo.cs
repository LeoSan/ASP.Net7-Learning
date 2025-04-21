using System;
using System.Collections.Generic;
using System.Text;

namespace CompInspeccion
{	
    [Serializable()]
    public  class DtoDshgoTestigo
    {
      public int dshgo_testigo_id = -1;
      public int dshgo_participante_id = -1;
      public int tipo_identificacion_id = -1;
      public int supuesto_designacion_id = -1;
      public string dtes_num_identificacion = "";
      public int dtes_num_testigo = -1;
      public int dtes_designado_por = -1;
      public string dtes_motivo_inspector = "";
      public int dtes_es_mismo_domicilio = -1;
      public string dtes_domicilio_notificaciones = "";
     
        public void Agregar()
      {
          ComponentInsp miComponente = new ComponentInsp();
          miComponente.DshgoTestigo_AgregarActualizar(this);
      }
    }
}
