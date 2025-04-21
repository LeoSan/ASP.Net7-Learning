using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
	public class DtoDoctoValores
	{

		public int docto_valor_id    = -1;
        public int documento_id      = -1;
        public int docto_variable_id = -1;
		public String dv_valor       = "";


        public void Agregar()
        {
            ComponentInsp miComponente = new ComponentInsp();
            miComponente.DoctoValores_AgregarActualizar(this);
        }

	}
}
