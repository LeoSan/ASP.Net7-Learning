using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{ 
    [Serializable()]
    public class DtoDshgoRepTrabajadores
    {
              public int dshgo_rep_trabajadores_id = -1;
              public int dshgo_participante_id  = -1;
              public int tipo_representante_id  = -1;
              public int tipo_identificacion_id  = -1;
              public int dshgo_sindicato_id  = -1;
              public String drtrab_tipo_acreditacion = "";
              public int drtrab_se_acredita  = -1;
              public int drtrab_se_identifica  = -1;
              public String drtrab_acreditacion_documento  = "";
              public String drtrab_acreditacion_num_escritura  = "";
              public String  drtrab_acreditacion_fec_emision   = "";
              public String  drtrab_acreditacion_notario  = "";
              public String  drtrab_acreditacion_notario_numero  = "";
              public String drtrab_acreditacion_fec_inicio = "";
              public int drtrab_acreditacion_cve_edorep  = -1;
              public String  drtrab_acreditacion_rfc = "";
              public String  drtrab_acreditacion_actividad  = "";
              public String  drtrab_acreditacion_fec_inscripcion = "";
              public String  datetime = "";
              public String  drtrab_acreditacion_reg_patronal  = "";
              public String  drtrab_acreditacion_giro_economico  = "";
              public String  drtrab_identificacion_numero  = "";
              public String  drtrab_toma_nota_numero  = "";
              public String  drtrab_toma_nota_expediente = "";
              public String  drtrab_toma_nota_fecha = "";
              public String  drtrab_motivo_ausencia   = "";
    
    public void Agregar(string sentencia = "")
        {
            ComponentInsp miComponente = new ComponentInsp();
            miComponente.Dshgo_RepTrab_AgregarActualizar(this, sentencia);
        }
      }



}
