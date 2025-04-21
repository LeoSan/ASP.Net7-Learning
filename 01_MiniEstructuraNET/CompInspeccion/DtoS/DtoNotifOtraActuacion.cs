using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoNotifOtraActuacion
    {
        public int notif_otra_actuacion_id      =-1;
        public int inspector_id                 =-1;
        public int cve_ur_solicita              =-1;
        public int cve_ur                       =-1;
        public int notif_motivo_no_entrega_id   =-1;
        public int notif_forma_constatacion_id  =-1;
        public String notifoa_ur_especifica     =String.Empty;
        public int notifoa_cve_edorep           =-1;
        public int notifoa_cve_municipio        =-1;
        public String notifoa_razon_social      =String.Empty;
        public String notifoa_domicilio         =String.Empty;
        public int notifoa_estatus_asignacion   =-1;
        public String notifoa_fec_solicitud     =String.Empty;
        public String notifoa_num_solicitud     =String.Empty;
        public String notifoa_tipo_documento    =String.Empty;
        public String notifoa_cp                =String.Empty;
        public int notifoa_forma_entrega        =-1;
        public String notifoa_forma_envio       =String.Empty;
        public String notifoa_fec_limite_entrega=String.Empty;
        public String notifoa_hora_limite_recepcion=String.Empty;
        public int notifoa_notificacion_personal=-1;
        public String notifoa_fec_envio         =String.Empty;
        public String notifoa_num_guia          =String.Empty;
        public int notifoa_estatus_entrega      =-1;
        public int notifoa_se_recibio           =-1;
        public int notifoa_quedo_pegado         =-1;
        public String notifoa_otro_motivo       =String.Empty;
        public String notifoa_fec_entrega       =String.Empty;
        public String notifoa_nombre_recibio    =String.Empty;
        public String notifoa_dijo_ser          =String.Empty;
        public String notifoa_observaciones     =String.Empty;
        public String sys_usr = String.Empty;
    }
}
