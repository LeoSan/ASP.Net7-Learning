using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoNotifSancionador
    {

        public int notif_sancionador_id = -1;
        public int s_expediente_etapa_id = -1;
        public int inspeccion_id = -1;
        public int inspector_id = -1;
        public int cve_ur = -1;
        public int notif_motivo_no_entrega_id = -1;
        public int notif_forma_constatacion_id = -1;
        public int notifs_estatus_asignacion = -1;
        public int notifs_forma_entrega = -1;
        public String notifs_forma_envio = String.Empty;
        public String notifs_fec_limite_entrega = String.Empty;
        public String notifs_hora_limite_recepcion = String.Empty;
        public int notifs_notificacion_personal = -1;
        public String notifs_fec_envio = String.Empty;
        public String notifs_num_guia = String.Empty;
        public String notifs_fec_entrega_programada = String.Empty;
        public int notifs_estatus_entrega = -1;
        public int notifs_se_recibio = -1;
        public int notifs_quedo_pegado = -1;
        public String notifs_otro_motivo = String.Empty;
        public String notifs_fec_entrega = String.Empty;
        public String notifs_nombre_recibio = String.Empty;
        public String notifs_dijo_ser = String.Empty;
        public String notifs_observaciones = String.Empty;
        public String notifs_hechos_constatados = String.Empty;

    }

    public class DtoNotificacionSIPAS
    {
        public int proceso_expediente_etapa_id { get; set; } = -1;
        public int expediente_etapa_notificacion_id { get; set; } = -1;
        public int notificacion_id { get; set; } = -1;
        public int inspeccion_id { get; set; } = -1;
        [JsonIgnore]
        public string sentencia { get; set; }
        public string num_expediente_sipas { get; set; }
        [JsonIgnore]
        public int estatus { get; set; } = -1;
        public int cve_ur { get; set; } = -1;
        public int cve_ur_solicita { get; set; } = -1;
        public int cve_edorep { get; set; } = -1;
        public string tipo_documento { get; set; } = "";
         public int cve_municipio { get; set; } = -1;
        [JsonIgnore]
        public string fecha1 { get; set; } = "";
        [JsonIgnore]
        public string fecha2 { get; set; } = "";
        public string fecha_solicitud { get; set; } = "";
        public int notificacion_personal { get; set; } = -1;
        public int inspector_id { get; set; } = -1;
        public String nombre_inspector { get; set; } = null;
        public DateTime? fecha_entrega { get; set; } = null;
        public string forma_envio { get; set; } = "";
        public DateTime? fecha_envio { get; set; } = null;
        public string num_guia { get; set; } = "";
        public int estatus_asignacion { get; set; } = -1;
        public int estatus_entrega { get; set; } = -1;
        public string sys_usr { get; set; } = "";
        public string forma_entrega { get; set; } = "";
        public DateTime? fecha_documento { get; set; } = null;
        public DateTime? fec_limite_entrega { get; set; } = null;
        public string razon_social { get; set; } = "";
        public int se_recibio { get; set; } = -1;
        public int quedo_pegado { get; set; } = -1;
        public int motivo_no_entrega_id { get; set; } = -1;
        public string otro_motivo { get; set; } = null;
        public int forma_constatacion_id { get; set; } = -1;
        public DateTime? fecha_entrega_centro { get; set; } = null;
        public string nombre_recibio { get; set; } = null;
        public string dijo_ser { get; set; } = null;
        public string hechos_constatados { get; set; } = null;
        public string observaciones { get; set; } = null;
        public int es_comprobacion { get; set; } = -1;
        public string num_solicitud_doc { get; set; }
        public string resolucion { get; set; } = null;
        public string fecha_resolucion { get; set; } = null;
    }
}
