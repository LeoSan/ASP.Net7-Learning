using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]

    public class DtoAutoridadesTurnan
    {
        public string nombre { get; set; }
        public int participante_id { get; set; }
        public string puesto { get; set; }
        public string area { get; set; }
        public string unidad_responsable { get; set; }
        public string estatus { get; set; }
    } 

    public class DtoUnidadesResponsables
    {
        public int id { get; set; }
        public string cur_descripcion { get; set; }
        public string cur_descrip_corta { get; set; }
        public int cur_cve_edorep { get; set; }
        public string cur_ciudad_ur { get; set; }
        public string telefono { get; set; }
        public string domicilio { get; set; }
        public string ur_circunscripcion { get; set; }
        public string ur_cir_acuerdo { get; set; }
        public string cir_acuerdo_firma_resolucion { get; set; }
        public string cir_regl_firma_resolucion { get; set; }
        public string cir_acuerdo_resolucion { get; set; }
        public string cir_reglamento_resolucion { get; set; }
    }

    public class DtoRespuestaSolicitudes
    {
        public string estatus { get; set; } = "";
        public string expediente_sipas { get; set; }
        public string mensaje { get; set; } = "";
    }

    public class DtoCatalogosNotificacionApi
    {
        public Dictionary<int, DtoAutoridadesTurnan> inspectores { get; set; }
        public Dictionary<int, DtoCatalogosApi> formas { get; set; }
        public Dictionary<int, DtoCatalogosApi> motivosNoEntrega { get; set; }
        public DtoNotificacionSIPAS notificacion { get; set; }
    }


    public class DtoCatalogosApi
    {
        public string nombre { get; set; }
        public int id { get; set; }
    }

    public class DtoCentroTrabajo
    {
        public DtoSeccionesCentroTrabajo datos_generales { get; set; }
        public DtoSeccionesCentroTrabajo domicilio { get; set; }
        public DtoSeccionesCentroTrabajo actividad_economica { get; set; }
        public DtoSeccionesCentroTrabajo trabajadores { get; set; }
        public DtoSeccionesCentroTrabajo otros_datos { get; set; }
        public DtoSeccionesCentroTrabajo empresas_solidarias { get; set; }

    }

    public class DtoSeccionesCentroTrabajo
    {
        public string nombre_seccion { get; set; } = "";
        public Dictionary<int, DtolemntoCentroTrabajo> datos { get; set; }
    }

    public class DtolemntoCentroTrabajo
    {
        public string etiqueta { get; set; } = "";
        public string valor { get; set; } = "";
    }

    public class DtoExpedientesSipas
    {
        public int inspeccion_id { get; set; }
        public List<DtoSolisitudSancion> solicitudes_sancion { get; set; } = null;
        public List<String> lista_expedientes { get; set; }
    }

    public class DtoSolisitudSancion
    {
        public string expediente_sancion { get; set; }
        public string num_solicitud_sancion { get; set; }
        public int tipo_documento_sancion_id { get; set; }
        public string tipo_documento_sancion { get; set; }
        public string monto_multa { get; set; }
        public string autoridad_fiscal { get; set; }
        public string fecha_resolucion { get; set; }
        public string url_proceso { get; set; } = "";
        public List<DtoProcesosSipas> procesos { get; set; } = null;
    }

    public class DtoProcesosSipas
    {
        public string nombre { get; set; }
        public int proceso_id { get; set; }
        public string url_proceso { get; set; }
        public List<DtoProcesoEtapasSipas> etapas { get; set; }
        public List<DtoProcesoDocumentosSipas> documentos { get; set; }
        public int conteo_documentos { get; set; } = 0;
        public List<DtoProcesoAnexosSipas> documentos_anexos { get; set; }
        public int conteo_anexos { get; set; } = 0;

    }

    public class DtoProcesoDocumentosSipas
    {
        public string tipo_documento { get; set; }
        public string actualizo { get; set; }
        public string fecha_documento { get; set; }
        public string asigando { get; set; }
        public string etapa { get; set; }
        public string url_documento { get; set; }
    }

    public class DtoProcesoAnexosSipas
    {
        public string descripcion { get; set; }
        public string cargado_por { get; set; }
        public string fecha_documento { get; set; }
        public string etapa { get; set; }
        public string url_documento { get; set; }
    }

    public class DtoProcesoEtapasSipas
    {
        public string nombre { get; set; }
        public string semaforo { get; set; }
        public string nombre_tipo_documento { get; set; }
        public string responsable_atencion { get; set; }
        public string fecha_termino { get; set; } = "";
        public string fecha_vencimiento { get; set; } = "";
        public int? plazo { get; set; }
        public string notificacion_solicitud { get; set; } = "";
        public string notificacion_resultado { get; set; } = "";
    }

    public class DtoSancionesViolacionSipas
    {
        public string expediente_juridico { get; set; }
        public int inspeccion_id { get; set; }
        public int indicador_id { get; set; }
        public int submateria_id { get; set; }
        public int cviol_numeral { get; set; }
        public string cviol_violacion { get; set; }
        public int cviol_procede { get; set; }
        public string num_solicitud { get; set; }
        public int tipo_incumplimiento { get; set; }
        public string cviol_fundamento { get; set; }
        public string cviol_descripcion { get; set; }
        public string origen { get; set; }
    }
}
