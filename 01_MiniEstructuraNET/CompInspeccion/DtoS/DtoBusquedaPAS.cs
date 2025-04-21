using System;
using System.Collections.Generic;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoBusquedaPAS
    {
        public bool esBusquedaAvanzada = false;
        public string nombre = "";
        public int estatus = -1;
        public string num_expediente = "";

        public string cp = "";
        public int cve_ur = -1;
        public int cve_ur_autoridad_turna = -1;
        public int inspeccion_id = -1;
        public String domicilio = "";
        public String materia = "";
        public String subtipo = "";
        public int centro_trabajo_id = -1;

        // Busqueda centros
        public int ct_entidad = -1;
        public int ct_municipio = -1;
        public int operativo_id = -1;
        public int tipo_documento_id = -1;
        public int emplazamiento_id = -1;
        public int materia_id = -1;
        public int subtipo_inspeccion_id = -1;
        public int inspector_id = -1;
        public int in_etapa = -1;
        public string fec_inspeccion = "";
        public int desahogo_id = -1;
        public int calificacion_id = -1;
        public int participante_id = -1;
        public int inspeccion_comprobacion_id = -1;
        public int tipo_inspeccion_id = -1;
        public int semaforo = -1;
        public int sin_resolucion = -1;


        //busqueda expedientes seguimiento
        public int s_expediente_id = -1;
        public String numInsp = "";
        public String RFC = "";
        public String num_sol_san = "";
        public String fecDe = "";
        public String fecA = "";
        public int etapa = -1;
        public int dictaminador = -1;
        public int orden = -1;
        public int notif = -1;
        public int see_estatus = -1;

        public string cve_ur_texto = "";
        public string fecDeA_texto = "";
        public string ct_entidad_texto = "";
        public string dictaminador_texto = "";

        public int indice_navegador = 0;

    }
}
