using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.DtoS
{
    public class DtoEventos
    {
        public List<DtoEvento> eventos { get; set; }
    }

    public class DtoEvento
    {
        public int? evento_id { get; set; }
        public string fecha { get; set; }
        public string hora_fin { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string tipo { get; set; }
        public string referencia { get; set; }
        public int referencia_id { get; set; }
        public List<object> personas { get; set; }
        public int usuario_registro_id { get; set; }
        public string asignar_usuario_registro { get; set; } = "no";
        public int? notificacion { get; set; }
    }


    public class DtoActualizarEvento
    {
        public int? evento_id { get; set; }
        public List<ListPerson> personas { get; set; }
        public string tipo { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string remplazo { get; set; }
        public string fecha { get; set; }
        public int? usuario_registro_id { get; set; }
        public int? atendido { get; set; }
        public int? notificacion { get; set; }

    }

    public class DtoActualizarAtencion
    {
        public int? evento_id { get; set; }
        public string tipo { get; set; }
        public int? atendido { get; set; }

    }


    public class ListPerson
    {
        public String remplazar { get; set; }
        public String asignar { get; set; }
    }


    public class DtoGetDisponibilidad
    {
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public int persona_id { get; set; }
    }



    public class DtoServicioDisponibilidad
    {
        public DtoDisponibilidad disponibilidad { get; set; }
        public DtoNoDisponibles no_disponibles { get; set; }
        public DtoDisponibles disponibles { get; set; }
    }


    public class DtoDisponibilidad
    {
        public bool[] disponibles { get; set; }
    }
    public class DtoNoDisponibles
    {
        public int total { get; set; }
        public string[] fechas { get; set; }
    }


    public class DtoDisponibles
    {
        public int total { get; set; }
        public string[] fechas { get; set; }
    }



    public class DtoActividad
    {
        public int? evento_id { get; set; }
        public int usuario_registro_id { get; set; }
        public string titulo { get; set; }
        public string tipo { get; set; }
        public string fecha { get; set; }
        public string hora_inicio { get; set; }
        public string hora_fin { get; set; }
        public List<object> personas { get; set; }
        public string descripcion { get; set; }
        public string referencia { get; set; }
        public int referencia_id { get; set; }
        
    }    
    

    public class DtoDomicilio
    {
        public int? usuario_registro_id { get; set; }
        public int? evento_id { get; set; }
        public string cp { get; set; }
        public string estado { get; set; }
        public string municipio_alcaldia { get; set; }
        public string colonia { get; set; }
        public string calle { get; set; }
        public string no_exterior { get; set; }
        public string no_interior { get; set; }
    }


    public class DtoEventoSuccess
    {
        public string message { get; set; }
        public int event_id { get; set; }
        public string error { get; set; }
        public List<object> error_emails { get; set; }
    }


    public class DtoActualizarEventoDomicilio
    {
        public int? evento_id { get; set; }
        public string buscar_por { get; set; }
        public string fecha { get; set; }
        public string hora_fin { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public string tipo { get; set; }
        public string referencia { get; set; }
        public int referencia_id { get; set; }
        public List<object> personas { get; set; }
        public int usuario_registro_id { get; set; }
        public string remplazo { get; set; }
        public int notificacion { get; set; }
        public List<DtoDomicilio> domicilios { get; set; }
    }

    public class DtoEliminarEventoDomicilio
    {
        public int id { get; set; }
        public int usuario_registro_id { get; set; }
    }    
    
    public class DtoGetEventoPersonaPorFecha
    {
        public string fecha_evento { get; set; }
        public string fecha_fin { get; set; }
        public string respuesta { get; set; }
    }

    public class DtoInspectoresEventos
    {
        public string nombre { get; set; }
        public int participante_id { get; set; }
        public string disponible { get; set; }
        public int inspector_id { get; set; }
        public string email { get; set; }
        public  string seleccionado { get; set; }
        public int total_inspeccion_materia { get; set; }
        public string mat_acronimo { get; set; }

    }

    public class DtoListPersonasIds
    {
        public List<object> persona_ids { get; set; }
    }

    public class DtoGetEventoPorReferencia
    {
        public string referencia { get; set; }
        public int referencia_id { get; set; }
    }

    public class DtoEventoReferencia
    {
        public int id { get; set; }
        public int evento_id { get; set; }
        public int usuario_registro_id { get; set; }
        public string titulo { get; set; }
        public string tipo { get; set; }
        public DateTime fecha { get; set; }
        public string hora_fin { get; set; }
        public string codigo_estado { get; set; }
        public string municipio_alcaldia { get; set; }
        public string cp { get; set; }
        public string referencia { get; set; }
        public int referencia_id { get; set; }
        public string estatus { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public string descripcion { get; set; }
        public string atendido { get; set; }
        public bool es_recordatorio { get; set; }
        public List<int> personas { get; set; }
    }

}
