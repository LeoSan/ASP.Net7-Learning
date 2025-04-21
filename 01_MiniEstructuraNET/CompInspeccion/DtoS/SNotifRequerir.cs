using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoSNotifRequerir
    {

        public int s_notif_requerir_id = -1;
        public int s_notif_solicitud_id = -1;
        public int notificacion_sipas_id = -1;
        public int snr_estatus = -1;
        public String sys_usr = String.Empty;

    }
}
