using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgoMedidaPrecautoriaConsulta
    {
        public int dshgo_medida_precautoria_consulta_id =   -1;
	    public int desahogo_id =   -1;
	    
	    public String dshgo_doc_respuesta_url =   String.Empty;
	    public DateTime dshgo_consulta_fecha_emision;
        public DateTime dshgo_consulta_fecha_respuesta;
        public String sys_usr_inserte = String.Empty;
        public String sys_usr_update = String.Empty;
        public int dshgo_consulta_estatus = -1;


        //Datos para las consultas
        public string fecha_ini = String.Empty;
        public string fecha_fin = String.Empty;
        public string in_num_expediente = String.Empty;
        public int inspeccion_id = -1;



    }
}
