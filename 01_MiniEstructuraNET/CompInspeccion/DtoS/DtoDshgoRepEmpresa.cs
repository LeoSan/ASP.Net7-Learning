using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgoRepEmpresa
    {
           public int dshgo_participante_id = -1;
           public int dshgo_rep_empresa_id  = -1;
           public int tipo_representante_id = -1;
           public int tipo_identificacion_id  = -1;
           public string dremp_tipo_acreditacion = "";
           public int dremp_se_acredita  = -1;
           public int dremp_se_identifica  = -1;
           public string dremp_acreditacion_documento = "";
           public string dremp_acreditacion_num_escritura = "";
           public string dremp_acreditacion_fec_emision = "";
           public string dremp_acreditacion_notario = "";
           public string dremp_acrecitacion_notario_numero= "";
           public int  dremp_acreditacion_entidad = -1;
           public string dremp_acreditacion_rfc  = "";
           public string dremp_acreditacion_actividad  = "";
           public string dremp_acreditacion_fec_inscripcion  = "";
           public string dremp_acreditacion_fec_inicio  = "";
           public string dremp_acreditacion_reg_patronal  = "";
           public string dremp_acreditacion_giro_economico = "";
           public string dremp_acreditacion_contrato_servicios  = "";
           public string dremp_acreditacion_empresa_contratista  = "";
           public string dremp_media_filiacion = "";
           public string dremp_identificacion_numero = "";
           public int dremp_facilidades_desahogo = -1;

           public void AgregarRep()
           {
             //dshgo_participante_id = Agregar();
             ComponentInsp miComponente = new ComponentInsp();
             miComponente.Dshgo_RepEmp_AgregarActualizar(this);
           }
    }
}
