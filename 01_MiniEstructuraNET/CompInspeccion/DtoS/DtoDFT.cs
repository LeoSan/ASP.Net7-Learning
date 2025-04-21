using CompInspeccion.DtoS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDFT
    {
        //Datos empresa
        public int cve_ur = -1;
        public String unidad_responsable = string.Empty;
        public int cve_ur_dgift = 0;
        public bool dgift = false;
        public int centro_trabajo_id = -1;
        public int empresa_id = -1;
        public int ct_cve_edorep = -1;
        public int municipio_id = -1;
        public String ct_rfc = String.Empty;
        public String ct_razon_social = String.Empty;
        public String ct_nombre = String.Empty;
        public String ct_imss_registro = String.Empty;
        public String ct_clase_riesgo = String.Empty;
        public String domicilio_fiscal = String.Empty;
        public String domicilio = String.Empty;        
        public int descripcionID = -1;

        public String materia = String.Empty;
        public String mat_acronimo = String.Empty;
        public int mat_controlada_sistema = -1;

        public String subtipo= String.Empty;
        public int inspeccion_id = -1;
        public int ipar_tipo_participacion = -1;
        
        public int normativa_version_id = 1;
        public string normativa_version = string.Empty;

        public int tipo_inspeccion = -1;
        public int subtipo_inspeccion = -1;
        public String subtipo_actuacion = string.Empty;
        public int operativo_id = -1;
		public int tipo_programacion = -1;
        public string tipoprogramacion = string.Empty;
        public string titulo_programacion = string.Empty;
        public int esnuevo = 1;
        public bool esConsulta = false;
        public string num_expediente = String.Empty;
        public string in_tipo = String.Empty;

		public DtoBusqueda dtoBusqueda = new DtoBusqueda();
		public DtoInspeccion dtoInspeccion = new DtoInspeccion();
        public DtoParticipante dtoInspectorResponsable = new DtoParticipante();
      
        public List<DtoParticipante> dtoInspectoresAdicionales = new List<DtoParticipante>();
        public List<DtoParticipante> dtoExpertos = new List<DtoParticipante>();
        public List<DtoCopias> dtoCopias = new List<DtoCopias>();

        public Stack<String> PageCaller = new Stack<String>();
		public String PaginaAnterior = String.Empty;
		public String PaginaSiguiente = String.Empty;

		public int indice_navegador = 0;
		public int in_estatus = -1;
		public int ordenar = -1;
        public int mes_id = -1;
        public int in_anio = -1;
        public int inspector_id = -1;
        public int notificador_id = -1;
        public String fecha = String.Empty;

		//Datos del emplazamiento
		public int emplazamiento_id = -1;
		public int inspeccion_origen_id = -1;
		public int inspeccion_comprobacion_id = -1;
		public int em_estatus = -1;
		public int em_resolucion_ampliacion = -1;

        //Datos de la sancion
        public int sancion_id = -1;
        public int san_inspeccion_origen_id = -1;
        public int inspeccion_sancion_id = -1;
        public int san_estatus = -1;
        public int san_resolucion_ampliacion = -1;

        //Datos de la reprogramacion
        public int reprogramacion_id = -1;
        public int documento_id = -1;

		//Datos de la reprogramacion
		public string name_breadcrumb = "";
        public string url_breadcrumb = "";

        public bool save = false;

        public String vista = String.Empty;

        public String current = String.Empty;
        
        public List<DtoRamasIndustriales> listaRamasSeleccionadas = new List<DtoRamasIndustriales>();

        public string grupo_rama_industrial_id = string.Empty;

        
        public bool centro_trabajo = false;
        public bool datos_actuacion = false;
        public bool asignacion_inspectores = false;
        public bool asignacion_expertos = false;
        public bool datos_documentos = false;
        public bool obtener_documentos = false;
        public bool cargar_centros_trabajo = false;
        public bool iDLinep = true;

        public bool enabled_empresa = false;
        public bool enabled_centro_trabajo = false;

        public int cambio_inspector = 0;
        public int cambio_dato = 0;

        public int in_id_firmante = 0;
        public int in_firman_titulares = 0;
        public int total_documentos = 0;
        public int total_firmados = 0;


        public int origen_desahogo_id=0;
        public int origen_calificacion_id=0;
        public int origen_materia_id = -1;
        public bool tiene_violaciones = false;
        public int origen_tipo_desahogo_id = 0;

    }
}
