using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.DtoS
{
    public class DtoBitacora
    {
        public int id { get; set; }
        public int usuario_id { get; set; }
        public string componente { get; set; }
        public string subcomponente { get; set; }
        public string descripcion { get; set; }
        public int? referencia_id { get; set; }
        public string tipo_referencia { get; set; }
        public string usuario_ip { get; set; }
        public int plataforma_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public string words { get; set; }
        public string user_core_id { get; set; }
        public string email_current { get; set; }
        public int per_page { get; set; }
        public int current_page { get; set; }
    }

    public class DtoBitacoraInsertar
    {
        public int usuario_id { get; set; }
        public string componente { get; set; }
        public string subcomponente { get; set; }
        public string descripcion { get; set; }
        public int? referencia_id { get; set; }
        public string tipo_referencia { get; set; }
        public string usuario_ip { get; set; }

        public int? inspeccion_id { get; set; }
    }

    public class DtoServicioConsultaBitacora
    {
        public List<DtoBitacora> data { get; set; }
        public int per_page { get; set; }
        public int? to { get; set; }
        public int current_page { get; set; }
        public int? total { get; set; }
        public int last_page { get; set; }

    }

    public class DtoServicioRegistroBitacora
    {
        public string message { get; set; }
        public DtoBitacoraServicio bitacora { get; set; }

    }

    public class DtoBitacoraServicio
    {
        //dto DEL MODELO DE DATOS DE LA TABLA bitacora_test de la BD de SIAPI
        //De preferencia la primera letra mayusculas
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string nombre { get; set; }
        public int? edad { get; set; }
        public bool estatus { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime? deleted_at { get; set; }

    }
}
