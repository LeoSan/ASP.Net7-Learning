using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
	public class DtoDoctoVariable
	{

		public int    docto_variable_id  = -1;
		public String var_variable       = "";
		public String var_descripcion    = "";
		public int    var_tipo_variable  = -1;



        public void Agregar()
        {
            ComponentInsp miComponente = new ComponentInsp();
            miComponente.DoctoVariable_AgregarActualizar(this);
        }

	}
}
