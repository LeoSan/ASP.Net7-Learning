using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
	[Serializable()]
	public class DtoDshgoTrabajador
	{
		public int dshgo_trabajador_id = -1;
		public int desahogo_id = -1;
		public int dshgo_tipo_trabajador_id = -1;
		public int dtrab_num_hombres = -1;
		public int dtrab_num_mujeres = -1;
		public int dtrab_num_total = -1;
		public string sys_usr = "";

		public DtoDshgoTrabajador() { }
		public DtoDshgoTrabajador(DtoDshgoTrabajador dtoTrabajador)
		{
			this.desahogo_id = dtoTrabajador.desahogo_id;
			this.dshgo_tipo_trabajador_id = dtoTrabajador.dshgo_tipo_trabajador_id;
			this.dshgo_trabajador_id = dtoTrabajador.dshgo_trabajador_id;
			this.dtrab_num_hombres = dtoTrabajador.dtrab_num_hombres;
			this.dtrab_num_mujeres = dtoTrabajador.dtrab_num_mujeres;
			this.dtrab_num_total = dtoTrabajador.dtrab_num_total;
			this.sys_usr = dtoTrabajador.sys_usr;
		} 
	}
}
