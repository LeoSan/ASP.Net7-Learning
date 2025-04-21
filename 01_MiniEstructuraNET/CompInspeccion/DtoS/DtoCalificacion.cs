using System;
using System.Collections.Generic;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoCalificacion
    {
        public int    calificacion_id              = -1;
        public int    desahogo_id                  = -1;
        public int    participante_id              = -1;
        public int    usuario_id                   = -1;
        public int    core_usuario_id              = -1;
        public String usr_email                    = "";
        public String calif_fec_asignacion         = "";
        public String calif_fec_calificacion       = "";
        public int    calif_se_recibio_escrito     = -1;
        public int    calif_escrito_dentro_plazo   = -1;
        public String calif_fec_recibio_escrito    = "";
        public String calif_num_fojas              = "";
        public int    calif_acredita_personalidad = -1;
        public int    calif_solventa_violaciones  = -1;
        public String calif_valoracion_pruebas     = "";
        public int    calif_cumple_requisitos     = -1;
        public int    calif_contiene_violaciones  = -1;
        public int    calif_contiene_medidas      = -1;
        public int    calif_estatus               = -1;
        public String sys_usr                     = "";
        public String sys_usr_insert              = "";


        //Busqueda
        public String fecha_ini = "";
        public String fecha_fin = "";
        public int    cve_ur    = -1;
        public int estatus      = -1;
        public int inspeccion_id = -1;
        public String razon_social = "";
        public String vista = "";
        public String numExpediente = "";


    }

}
