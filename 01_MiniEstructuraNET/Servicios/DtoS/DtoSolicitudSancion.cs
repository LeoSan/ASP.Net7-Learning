using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.DtoS
{
    public class DtoSolicitudSancion
    {
        public string solicitud_sancion_siapi { get; set; }
        public int materia_id { get; set; }
        public int centro_trabajo_id { get; set; }
        public string centro_trabajo_nombre { get; set; }
        public string rfc { get; set; }
        public string domicilio { get; set; }
        public int inspeccion_id { get; set; }
        public int unidad_responsable_id { get; set; }
        public string num_expediente_siapi { get; set; }
        public int siapi_normativa_id { get; set; }
        public string acronimo_materia { get; set; }
        public int tipo_documento_sancion_id { get; set; }
        public string tipo_documento_sancion { get; set; }
        public string tipo_solicitud { get; set; }
        public string razon_social { get; set; }
        public string respuesta { get; set; }
        public int solicita_core_id { get; set; }
        public DtoDatosSiapi datos_siapi { get; set; }
        public Dictionary<int, DtoIncumplimientos> incumplimientos { get; set; }
    }

    public class DtoDatosSiapi
    {
        public string acronimo_materia { get; set; }
        public string nombre_materia { get; set; }
        public string subtipo_actuacion { get; set; }
        public int inspeccion_ur_id { get; set; }
        public int calificacion_id { get; set; }

        public string inspeccion_ur_nombre { get; set; }
        public string fecha_acta { get; set; }
        public string fecha_inspeccion { get; set; }
        public string domicilio_fiscal { get; set; }
        public string telefono { get; set; }
        public string nombre_inspector { get; set; }
        public int no_trabajadores { get; set; } = 0;
        public string capital_contable { get; set; }
        public string capital_contable_letra { get; set; }
    }

    public class DtoIncumplimientos
    {
        public int submateria_id { get; set; }
        public string submateria { get; set; }
        public int indicador_id { get; set; }
        public int inciso_id { get; set; }
        public string descripcion_condenatoria { get; set; }
        public string marco_normativo { get; set; }
        public string descripcion_siapi { get; set; }
        public string tipo_incumplimiento { get; set; }
        public int? medida_id { get; set; }
        public int numero_reincidencias { get; set; } = 0;
        public string reincidencia_texto { get; set; }
        public string capacidad_economica { get; set; }
    }
}
