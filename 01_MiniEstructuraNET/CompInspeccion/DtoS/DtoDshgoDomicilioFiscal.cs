using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoDshgoDomicilioFiscal
    {
        public int dshgo_domicilio_fiscal_id=-1;
        public int dshgo_centro_trabajo_id=-1; 
        public int dne_centro_trabajo_id=-1;
        public String ddf_calle=String.Empty;
        public String ddf_num_exterior=String.Empty;
        public String ddf_num_interior=String.Empty; 
        public String ddf_colonia=String.Empty;
        public String ddf_poblacion=null;
        public String ddf_cp=String.Empty; 
        public String ddf_ref_ubicacion=String.Empty; 
        public String ddf_longitud=String.Empty; 
        public String ddf_latitud=String.Empty;
        public String ddf_telefono=String.Empty;
        public String ddf_fax=String.Empty;
        public String ddf_email=String.Empty;
        public int ddf_cve_edorep=-1;
        public int ddf_cve_municipio=-1;
    }
}
