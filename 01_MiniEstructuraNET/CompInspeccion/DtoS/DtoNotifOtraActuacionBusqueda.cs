using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoNotifOtraActuacionBusqueda
    {
        public int notif_otra_actuacion_id = -1;
        public int notifoa_estatus_asignacion = -1;
        public int notifoa_forma_entrega = -1;
        public int notifoa_cve_municipio = -1;
        public int cve_ur_solicita = -1;
        public String fechaini = String.Empty;
        public String fechafin = String.Empty;

        public int notifoa_estatus_entrega = -1;
        public int inspector_id = -1;
        public String notifoa_num_solicitud = String.Empty;
        public String notifoa_razon_social = String.Empty;
        public String mensaje = String.Empty;
        public int cambio_consulta = 0;
    }
}
