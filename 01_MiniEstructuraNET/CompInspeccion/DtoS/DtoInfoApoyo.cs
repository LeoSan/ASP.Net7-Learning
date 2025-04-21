using System;
using System.Collections.Generic;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoInfoApoyo
    {
        public int info_apoyo_id;        
        public String infa_descripcion = "";
        public String infa_url = "";
        public int infa_orden;
        public String sys_usr = "";
        public int infa_tipo;
        public String infa_material = "";
        public int infa_vinculo;

        public DateTime fecha_actualizacion { get; set; }
        public string infa_emisor { get; set; }
        public int orden { get; set; }
        public string material { get; set; }
        public string descripcion { get; set; }
        public string url { get; set; }
        public int tipo { get; set; }

    }
}
