using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
  	[Serializable()]
	public class DtoDoctoParrafoTexto
	{

		public int docto_parrafo_texto_id = -1;
		public int docto_parrafo_id       = -1;
		public int dpt_consecutivo        = -1;
		public String dpt_parrafo         = "";
		public String dpt_condicion       = "";
		public int cve_ur                 = -1;


		public void Agregar()
        {
            ComponentInsp miComponente = new ComponentInsp();
            miComponente.DoctoParrafoTexto_AgregarActualizar(this);
        }

	}

	public class DtoDoctoParrafoTextoSipas
	{

		public int s_docto_parrafo_texto_id = -1;
		public int s_docto_parrafo_id = -1;
		public int dpt_consecutivo = -1;
		public String dpt_parrafo = "";


		public void Agregar()
		{
			ComponentInsp miComponente = new ComponentInsp();
			miComponente.SDoctoParrafoTexto_AgregarActualizar(this);
		}

	}


	public class DtoDoctoParrafoTextoJson
    {
		public DtoDoctoParrafoTexto antes { get; set; }
		public DtoDoctoParrafoTexto despues { get; set; }
	}


}
