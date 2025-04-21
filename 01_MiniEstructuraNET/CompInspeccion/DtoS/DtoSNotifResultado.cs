using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoSNotifResultado
    {

        public int s_notif_resultado_id = -1;
        public int s_expediente_etapa_id = -1;
        public int inspeccion_id = -1;
        public int inspector_id = -1;
        public int cve_ur = -1;
        public int notif_motivo_no_entrega_id = -1;
        public int notif_forma_constatacion_id = -1;
        public String snotif_numero = String.Empty;
        public int snotif_estatus_asignacion = -1;
        public int snotif_forma_entrega = -1;
        public String snotif_forma_envio = String.Empty;
        public String snotif_fec_limite_entrega = String.Empty;
        public String snotif_hora_limite_recepcion = String.Empty;
        public int snotif_notificacion_personal = -1;
        public String snotif_fec_envio = String.Empty;
        public String snotif_num_guia = String.Empty;
        public String snotif_fec_entrega_programada = String.Empty;
        public int snotif_estatus_entrega = -1;
        public int snotif_se_recibio = -1;
        public int snotif_quedo_pegado = -1;
        public String snotif_otro_motivo = String.Empty;
        public String snotif_fec_entrega = String.Empty;
        public String snotif_nombre_recibio = String.Empty;
        public String snotif_dijo_ser = String.Empty;
        public String snotif_observaciones = String.Empty;
        public String sys_usr = String.Empty;
        public String snotif_hechos_constatados = String.Empty;

    }
}
