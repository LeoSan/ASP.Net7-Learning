using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgo 
    {
        //Datos empresa
        public int cve_ur = -1;
        public int centro_trabajo_id = -1;
        public String ct_rfc = String.Empty;
        public String ct_razon_social = String.Empty;
        public String ct_nombre = String.Empty;
        public String ct_nombre_completo = String.Empty;
        public String domicilio = String.Empty;
        public int descripcionID = -1;

        public String materia = String.Empty;
        public String subtipo = String.Empty;
        public int subtipo_inspeccion_id = -1;
        public int inspeccion_id = -1;
        public int tipo_inspeccion = -1;
        public int operativo_id = -1;
        public int tipo_programacion = -1;
        public bool esConsulta = false;
        public String fec_inspeccion = String.Empty;
        public String hora_inspeccion = String.Empty;
        public String num_inspeccion = String.Empty;

        public Stack<String> PageCaller = new Stack<String>();
        public String PaginaAnterior = String.Empty;
        public String PaginaSiguiente = String.Empty;
        public ArrayList Pagelist = new ArrayList();
        public ArrayList SeccionIdlist = new ArrayList();
        public int PagesIndex = 0;

        public int indice_navegador = 0;
        public int in_estatus = -1;
        public int ordenar = -1;
        public int mes_id = -1;
        public int in_anio = -1;
        public int inspector_id = -1;
        public String fecha = String.Empty;
        public String inspectores = String.Empty;
        public String nombre_dictaminador = String.Empty;

        public int desahogo_id = -1;
        public int materia_id = -1;
        public int esNom = -1;
        public int dsecc_en_oficio = -1;
        public int dsecc_en_acta = -1;
        public int dsecc_en_negativa = -1;
        public int dshgo_centro_trabajo_id = -1;
        public int dshgo_medida_id = -1;
        public int ind_medida_id = -1;
        public int dshgo_med_descatalogada_id = 0;
        public String titulo = "";
        public int infogral = 0;
        public int infogral2 = 0;
        public int dshgo_tipo_cierre = -1;
        public int dshgo_se_pudo_constituir = -1;
        public int dne_centro_trabajo_id_domicilio_fiscal = -1;
        public int dne_centro_trabajo_id_domicilio_fiscal_anterior = -1;
        public int num_camaras = -1;
        public int centro_informacion_id = -1;
        public DtoCentro dtoCentroInfo = new DtoCentro();
        public DtoEmpresa dtoEmpresa = new DtoEmpresa();
        public DtoCentro dtoCentroFiscal = new DtoCentro();
        public int centro_movto_id = -1;

        //PARA BUSCAR
        public String BuscarNombreRazonSocial = String.Empty;
        public String BuscarNoinspeccion = String.Empty;
        public String BuscarFechaprogramada = String.Empty;

		// Para Trabajadores
		public int dshgo_trabajador_id = -1;
		public int dtrab_num_total = -1;
		public string dtt_tipo_trabajador = "";

        //Interrogados
        public int dshgo_interrogado_id = -1;

		//Para revision documental
		public int dshgo_alcance_id = -1;
		public int dshgo_revision_id = -1;
		public Hashtable hash;

		//para emplezamiento o reprogramacion
		public int emp_rev = -1;
		public bool esReprogramacion = false;
        public int dcapt_info_capturada = 0;
        public bool cambiosDatos = false;

        //para saber si el acta se genera cómo visita de orientación y asesoría
        public int dshgo_genera_acta_como_visita = -1;

        public static implicit operator DtoDshgo(string v)
        {
            throw new NotImplementedException();
        }

        public int in_id_firmante = 0;
        public int dshgo_tipo_desahogo = -1;
        public string nombre_imagen = string.Empty;
        public string ruta_imagen_centro_trabajo_actual = string.Empty;
        public string ruta_imagen_centro_trabajo_origen = string.Empty;

        public int normatividad_version_id = -1;
        public int inspeccion_origen_id = -1;
        //public int cs_ant_inspeccion_origen_id = -1;
    }
}
