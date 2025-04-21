using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoProcesosOffline
    {
        public string sentencia { get; set; }
        public int desahogo_id { get; set; }
        public int seccion_id { get; set; }
        public int marcado_offline { get; set; }
        public int core_usuario_id { get; set; }
        public int materia_id { get; set; }
        public string acronimo_materia { get; set; }
        public string nombre_materia { get; set; }
        public string expediente { get; set; }
        public string nombre_centro { get; set; }
        public string domicilio { get; set; }
        public int inspeccion_id { get; set; }
        public string subtipo_actuacion { get; set; }
        public string normatividad { get; set; }
        public int centro_trabajo_id { get; set; }
        public int inspector_core_id { get; set; }
        public string fecha_inspeccion { get; set; }
        public string fecha_inspeccion_texto { get; set; }
        public string fecha_estatus_offline { get; set; }
        public string alcance { get; set; }
        public string expidio_citatorio { get; set; }
        public string json_enviado { get; set; }
        public string json_respuesta { get; set; }
        public string fecha_primer_envio_json { get; set; }
        public string dispositivo_id { get; set; }
        public int dshgo_tipo_trabajador_id { get; set; }
        public int? dtrab_num_hombres { get; set; } = -1;
        public int? dtrab_num_mujeres { get; set; }
        public int? dtrab_num_total { get; set; }
        public DateTime? fecha_seleccion_offline { get; set; } = null;
    }

    public class DtoInspeccionesProcesosOffline
    {
        public int materia_id { get; set; }
        public string acronimo_materia { get; set; }
        public string nombre_materia { get; set; }
        public string expediente { get; set; }
        public string nombre_centro { get; set; }
        public string domicilio { get; set; }
        public int inspeccion_id { get; set; }
        public string subtipo_actuacion { get; set; }
        public int desahogo_id { get; set; }
        public string normatividad { get; set; }
        public int centro_trabajo_id { get; set; }
        public int inspector_core_id { get; set; }
        public string fecha_inspeccion { get; set; }
        public string fecha_inspeccion_texto { get; set; }
        public string alcance { get; set; }
        public string expidio_citatorio { get; set; }
        [JsonIgnore]
        public List<DtoSeccionesProceso> secciones { get; set; }
        public Dictionary<int, DtoSeccionesProceso> secciones_offline { get; set; }

    }

    public class DtoSeccionesProceso
    {
        public string seccion { get; set; }
        public string fecha_estatus_offline { get; set; }
    }

    public class DtoRevisionDocumentalOffline
    {
        public int materia_id { get; set; }
        public int inspeccion_id { get; set; }
        public int desahogo_id { get; set; }
        public int centro_trabajo_id { get; set; }
        public int inspector_core_id { get; set; }
        public string fecha_estatus_offline { get; set; }
        public bool forzar_actualizacion { get; set; } = false;
        public Dictionary<int, DtoSubmateriasAlcance> submaterias_alcance { get; set; }
    }

    public class DtoSubmateriasAlcance
    {
        public int dshgo_alcance_id { get; set; }
        public int submateria_id { get; set; }
        public bool dsal_estatus { get; set; }
        public string nombre { get; set; }
        public int orden { get; set; }
        public string norma { get; set; }
        public string update_at { get; set; }
        public Dictionary<int, DtoIndicadoresAlcance> indicadores { get; set; }
    }

    public class DtoIndicadoresAlcance
    {
        public int indicador_id { get; set; }
        public int orden { get; set; }
        public bool obligatorio { get; set; }
        public string nombre { get; set; }
        public string observaciones { get; set; }
        public string respuesta { get; set; }
        public Dictionary<int, DtoIncisosAlcance> incisos { get; set; }
    }

    public class DtoIncisosAlcance
    {
        public int inciso_id { get; set; }
        public string nombre { get; set; }
        public int orden { get; set; }
        public bool obligatorio { get; set; }
        public string respuesta { get; set; }
    }

    public class DtoTrabajadoresOffline
    {
        public int materia_id { get; set; }
        public int inspeccion_id { get; set; }
        public int desahogo_id { get; set; }
        public int centro_trabajo_id { get; set; }
        public int inspector_core_id { get; set; }
        public bool cuenta_con_trabajadores { get; set; } = false;
        public string fecha_estatus_offline { get; set; }
        public bool forzar_actualizacion { get; set; } = false;
        public DtoSeccionesTrabajadores secciones { get; set; }
    }

    public class DtoSeccionesTrabajadores
    {
        public DtoInfoGeneralTrabajadores informacion_general { get; set; }
        public DtoInfoEspecialTrabajadores informacion_especial { get; set; }
    }

    public class DtoInfoEspecialTrabajadores
    {
        public string nombre { get; set; }
        public Dictionary<int, DtoSeccionEspecialTrabajadores> secciones { get; set; }
    }

    public class DtoSeccionEspecialTrabajadores
    {
        public int dshgo_tipo_trabajador_id { get; set; }
        public int? dtrab_num_hombres { get; set; } = null;
        public int? dtrab_num_mujeres { get; set; } = null;
        public int? dtrab_num_total { get; set; } = null;
        public bool es_editable { get; set; } = false;
        public string nombre { get; set; }
        public bool bloquear_hombres { get; set; } = false;
        public Dictionary<int, DtoListadoTrabajadores> trabajadores { get; set; }
    }

    public class DtoListadoTrabajadores
    {
        public string dtrabd_actividad { get; set; } = "";
        public string dtrabd_edad { get; set; } = "";
        public string dtrabd_nombre { get; set; }
        public string dtrabd_puesto { get; set; } = "";
        public string genero { get; set; } = "";
    }

    public class DtoInfoGeneralTrabajadores
    {
        public string nombre { get; set; }
        public Dictionary<int, DtoSeccionGeneralTrabajadores> secciones { get; set; }
    }

    public class DtoSeccionGeneralTrabajadores
    {
        public int dshgo_tipo_trabajador_id { get; set; }
        public int? dtrab_num_hombres { get; set; } = null;
        public int? dtrab_num_mujeres { get; set; } = null;
        public int? dtrab_num_total { get; set; } = null;
        public bool es_editable { get; set; } = false;
        public string nombre { get; set; }
        public string altera { get; set; } = "";
        public string codigo { get; set; } = "";
        public Dictionary<int, DtoTiposGeneralTrabajadores> tipos { get; set; }
    }

    public class DtoTiposGeneralTrabajadores
    {
        public int dshgo_tipo_trabajador_id { get; set; }
        public int? dtrab_num_hombres { get; set; }
        public int? dtrab_num_mujeres { get; set; }
        public int? dtrab_num_total { get; set; }
        public string nombre { get; set; }
        public string altera { get; set; } = "";
    }

    public class DtoInterrogatoriosOffline
    {
        public int materia_id { get; set; }
        public int inspeccion_id { get; set; }
        public int desahogo_id { get; set; }
        public int centro_trabajo_id { get; set; }
        public int inspector_core_id { get; set; }
        public bool realizo_interrogatorios { get; set; } = false;
        public string domicilio { get; set; } = "";
        public string fecha_estatus_offline { get; set; }
        public bool forzar_actualizacion { get; set; } = false;
        public DtoCatalogosInterrogatorio catalogos { get; set; }
        public Dictionary<int, DtoInterrogados> interrogados { get; set; }
    }

    public class DtoCatalogosInterrogatorio
    {
        public Dictionary<int, DtoCatalogoObligatorias> obligatorias { get; set; }
        public DtoCatalogoSugeridas sugeridas { get; set; }
        public Dictionary<int, DtoCatalogoObligatorias> sugeridasRSPC { get; set; }
        public Dictionary<int, DtoCatalogoIdentificacion> tipo_identificacion { get; set; }
    }

    public class DtoCatalogoIdentificacion
    {
        public int tipo_identificacion_id { get; set; }
        public string tidef_identificacion { get; set; }
        public string tidef_expedida_por { get; set; }
    }

    public class DtoCatalogoSugeridas
    {
        public Dictionary<int, DtoSubmateriasSugeridas> submaterias { get; set; }
    }

    public class DtoSubmateriasSugeridas
    {
        public int submateria_id { get; set; }
        public string nombre_submateria { get; set; }
        public Dictionary<int, DtoCatalogoObligatorias> preguntas { get; set; }
    }

    public class DtoCatalogoObligatorias
    {
        public int dshgo_pregunta_id { get; set; }
        public int dpreg_tipo_pregunta { get; set; }
        public int dpreg_consecutivo { get; set; }
        public int materia_id { get; set; }
        public string dpreg_pregunta { get; set; }
        public Dictionary<int, DtoCatalogoRespuestas> opciones_respuesta { get; set; }
    }

    public class DtoCatalogoRespuestas
    {
        public int dshgo_pregunta_respuesta { get; set; } = 0;
        public string dpresp_respuesta { get; set; } = "";
    }

    public class DtoInterrogados
    {
        public int dshgo_interrogado_id { get; set; }
        public string nombre { get; set; } = "";
        public string puesto { get; set; } = "";
        public int tipo_identificacion_id { get; set; } = 0;
        public string dint_num_identificacion { get; set; } = "";
        public string dint_domicilio_notificaciones { get; set; } = "";
        public int dint_mismo_domicilio { get; set; } = 0;
        public Dictionary<int, DtoObligatoriasRespuestas> respuestas_preguntas_obligatorias { get; set; }
        public Dictionary<int, DtoObligatoriasRespuestas> respuestas_preguntas_sugeridas { get; set; }
        public Dictionary<int, DtoAbiertasRespuestas> preguntas_abiertas { get; set; }
    }

    public class DtoObligatoriasRespuestas
    {
        public int dshgo_pregunta_id { get; set; }
        public int dshgo_pregunta_respuesta { get; set; }
    }

    public class DtoAbiertasRespuestas
    {
        public string diabie_pregunta { get; set; } = "";
        public string diabie_respuesta { get; set; } = "";
    }

    public class DtoRespuestaProcesoRecibido
    {
        public string estatus { get; set; } = "";
        public string fecha_recepcion { get; set; } = "";
        public int desahogo_id { get; set; }
        public int inspeccion_id { get; set; }
        public int seccion_id { get; set; }
        public int core_usuario_id { get; set; }
        public string mensaje { get; set; } = "";
    }
}
