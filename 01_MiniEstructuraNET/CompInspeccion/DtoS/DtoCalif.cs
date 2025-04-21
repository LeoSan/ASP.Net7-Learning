using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompInspeccion;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoCalif
    {
        public int cve_ur = -1;
        public int centro_trabajo_id = -1;
        public String ct_rfc = String.Empty;
        public String ct_razon_social = String.Empty;
        public String ct_nombre = String.Empty;
        public String ct_nombre_completo = String.Empty;
        public String domicilio = String.Empty;

        public int desahogo_id = -1;
        public int calificacion_id = -1;
        public int inspeccion_id = -1;
        public int CalifDocumento_id = -1;
        public int tipo_documento_id = -1;

        public string fec_inspeccion = String.Empty;
        public string num_inspeccion = String.Empty;
        public string subtipo = String.Empty;
        public string materia = String.Empty;
        public string mat_acronimo = String.Empty;
        
        
        public int subtipo_inspeccion_id = -1;
        public int materia_id = -1;
        public int tipo_inspeccion = -1;
        public string hora_inspeccion = String.Empty;
        public string inspectores = String.Empty;
        public string nombre_dictaminador = String.Empty;
        public int calif_estatus = -1;
        public int dshgo_tipo_desahogo = -1;
        public int drev_respuesta = -1;
        public int dshgo_alcance_id = -1;
        public int indicador_id = -1;

        //busqueda
        public string fecha_ini = String.Empty;
        public string fecha_fin = String.Empty;
        public int busq_estatus = -1;
        public int participante_id=-1;
        public string calif_fec_asignacion = String.Empty;
        public String numExpediente = "";

        //JC
        public bool fueAutomatico = false;

        //los datos del segundo documento
        public int CalifDocumento_id2 = -1;
        public int tipo_documento_id2 = -1;

        //documento actual
        public int CalifDocumento_id_act = -1;
        public int tipo_documento_id_act = -1;
        public string mensaje = String.Empty;
        public string tipo_calificacion = String.Empty;

        public DtoCalificacion calificacionDocumento;
        public bool requisitosTodosCumplenViolaciones;
        public bool valoracionViolacionesDescripcion;
        public bool tieneVol;

        public int in_id_firmante = 0;
        public int in_firman_titulares = 0;
        public int total_documentos = 0;
        public int total_firmados = 0;

        public int normatividadId = 0;
        public string code_documento = "";        
        public int tipoPorgramacion = 0;

        public bool existeDocumentales_SH_RSPC = false;
        public bool existePeriodicas_SH_RSPC = false;

        public List<DtoTipoDocumento> ListaDocumentosGenerados;

        public string num_acuerdo_acipai_np = String.Empty;
        public string num_acuerdo_acipai_in = String.Empty;
        public bool negativa_comprobacion = false;

        public List<DtoTipoDocumento> ListaDocumentosSeleccionados;
        



    }
}
