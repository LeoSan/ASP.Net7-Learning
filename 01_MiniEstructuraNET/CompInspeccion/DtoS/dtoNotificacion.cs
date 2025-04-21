using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
   [Serializable()]
	public class DtoNotificacion
	{

         public int    notificacion_id             = -1;
         public int    tipo_documento_id           = -1;
		 public int    inspector_id                = -1;
         public int    inspeccion_id               = -1;
		 public int notif_motivo_no_entrega_id     = -1;
	     public int notif_forma_constatacion_id    = -1;
         public int notif_estatus_asignacion       = -1;
	     public int notif_forma_entrega            = -1 ;
	     public String notif_forma_envio           = String.Empty;
         public String notif_fec_limite_entrega    = String.Empty;
         public String notif_hora_limite_recepcion = String.Empty;
	     public int notif_notificacion_personal    = -1;
	     public String notif_fec_envio             = String.Empty;
         public String notif_num_guia              = String.Empty;
         public String notif_fec_entrega_programada = String.Empty;
	     public int notif_estatus_entrega          = -1;
	     public int notif_se_recibio               = -1;
	     public int notif_quedo_pegado             = -1;
         public String notif_otro_motivo           = String.Empty;
         public String notif_fec_entrega           = String.Empty;
         public String notif_nombre_recibio        = String.Empty;
         public String notif_dijo_ser              = String.Empty;
         public String notif_observaciones         = String.Empty;
         public String sys_usr                     = String.Empty;
        public String tipo = String.Empty;
        public String code_documento = String.Empty;

        //Agregado Ariana
        public String fecha_ini = String.Empty;
         public String fecha_fin = String.Empty;
         public int cve_ur = -1;
         public String in_ct_nombre = String.Empty;
         public int ct_cve_municipio = -1;
       //Agregado Ariana


        public void Agregar()
        {
            ComponentInsp miComponente = new ComponentInsp();
            miComponente.NotificacionAgregarActualizar(this);
        }

	}
}
