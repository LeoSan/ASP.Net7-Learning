using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgoParticipantes
    {
          public int @dshgo_participante_id            = -1;
	      public int @desahogo_id                      = -1;
          public int @motivo_no_firma_id             = -1;
          public Int16 @dpart_tipo_participante        = -1;
          public String @dpart_nombre                  = "";
          public String @dpart_puesto                  = "";
          public int @dpart_firma                    = -1;
          public int @dpart_manifestacion            = -1;
          public String @dpart_manifestacion_indicado  = "";
          public String  @dpart_otro_motivo_no_firma   = "";
          public String @Usr                           = "";

          public int Agregar()
          {
              ComponentInsp miComponente = new ComponentInsp();
              return miComponente.DshgoParticipantes_AgregarActualizar(this);
          }

          public void Eliminar()
          {
              ComponentInsp miComponente = new ComponentInsp();
              miComponente.DshgoParticipantes_Eliminar(this.dshgo_participante_id);
          }
    }

}
