using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
	[Serializable()]
	public class DtoDGIFT
	{
        /*   Datos de Estados  */
        public int    cen_cve_edorep  = -1;
        public String cen_descripcion = String.Empty;

		/*  Datos para metas */
        public int mes          = -1;
        public int operativo_id = -1;
        public int anio         = -1;

		/* Datos para ProgAtributos */
        public int    prog_atributo_id = -1;
		public int    mg_jurisdiccion  = -1;
        public String tipo_atributo    = String.Empty;
        public String SubTitulo        = String.Empty;

        //Para operativos 
        public int prog_anual_id       = -1;
        public int oper_tipo_operativo = -1;

        //operativos_indicadores

        public int    operativo_alcance_id = -1;
        public int    submateria_id        = -1;
        public String smat_submateria      = String.Empty;
        public int    smat_consecutivo     = -1;


		/* Datos para páginas */
        public Stack<String> PageCaller      = new Stack<string>();
        public String        PaginaSiguiente = String.Empty;
        public String        PaginaAnterior  = String.Empty;
	}
}
