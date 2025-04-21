using CompInspeccion.DtoS;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoBusqueda
    {
        //busqueda normal y avanzada de empresas
        public string nombre = "";
        public string nombre_grupo = "";
        public string rfc = "";
        public string rfc_corto = "";
        public string registro_patronal = "";
        public string calle = "";
        public int entidad_federativa = -1;
        public int municipio = -1;
        public string cp = "";
        public string forma_entrega = null;
        public int jurisdiccion = -1;
        public int tipo_de_alta = -1;
        public int estatus = -1;
        public string num_expediente="";
        public int cve_ur = -1;
        public int inspeccion_id = -1;
        public String domicilio = "";
        public String materia = "";
        public String subtipo = "";
        public int centro_trabajo_id = -1;
        public String nombre_corto = "";
        public String exp_corto = "";

        //busqueda movimientos pendientes
        public int movimiento = -1;
        public int origen = -1;
        public string fecha_inicio = "";
        public string fecha_fin = "";

        // Busqueda centros
        public int ct_entidad = -1;
        public int ct_municipio = -1;
        public int operativo_id = -1;

        

        public int materia_id = -1;
        public int in_tipo_programacion_id = -1;
        public int tipo_inspeccion_id = -1;
        public int subtipo_inspeccion_id = -1;
        public int inspector_id = -1;
        public int participante_id = -1;
        public int in_etapa = -1;
        public int mes_id = -1;
        public int ordenar = -1;
        public string fec_inspeccion = "";
        public string mensaje = "";

        public int calificacion_id = -1;
        public int tipo_documento_id = -1;
        public int desahogo_id = -1;
        public int emplazamiento_id = -1;
        public int inspeccion_comprobacion_id = -1;

        //Notificacion PAS
        public int s_notif_resultado_id = -1;
        public int s_expediente_etapa_id = -1;
        public int s_expediente_id = -1;
        public int estatusPAS=-1;
        public int forma = -1;
        public int tipo = -1;
        public string tipo_notif = string.Empty;
        public int mun = -1;
        public int area = -1;

        //Reporte Sipas
        public string rblReporte = "-1"; 
        public string ddlTipoReporte = "-1";
        public string ddlEntidad = "-1";
        public string ddlEntidadTexto = "-1";
        public string ddlUnidadResponsable = "-1"; 
        public string ddlDictaminador = "-1";
        public string tbFecInicio = ""; 
        public string tbFecFinal = "";

        //Listado Reporte SIPAS 
        public string tipoReporteSipas = "-1";
        public string parametroExpediente = "-1";
        public string parametroTitulo = "-1";
        public string parametroTipoInpugnaciones = "-1";
        public string parametroEtapaProcesalA = "-1";
        public string parametroEtapaProcesalB = "-1";

        public DtoBusqueda(DtoBusqueda dtoBusq)
        {
            this.calle = dtoBusq.calle;
            this.cp = dtoBusq.cp;
            this.ct_entidad = dtoBusq.ct_entidad;
            this.ct_municipio = dtoBusq.ct_municipio;
            this.entidad_federativa = dtoBusq.entidad_federativa;
            this.estatus = dtoBusq.estatus;
            this.fecha_fin = dtoBusq.fecha_fin;
            this.fecha_inicio = dtoBusq.fecha_inicio;
            this.jurisdiccion = dtoBusq.jurisdiccion;
            this.movimiento = dtoBusq.movimiento;
            this.municipio = dtoBusq.municipio;
            this.nombre = dtoBusq.nombre;
            this.nombre_grupo = dtoBusq.nombre_grupo;
            this.origen = dtoBusq.origen;
            this.registro_patronal = dtoBusq.registro_patronal;
            this.rfc = dtoBusq.rfc;
            this.rfc_corto = dtoBusq.rfc_corto;
            this.tipo_de_alta = dtoBusq.tipo_de_alta;
        }

        public DtoBusqueda()
        {
            // TODO: Complete member initialization
        }
    }
}
