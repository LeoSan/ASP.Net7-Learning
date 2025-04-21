using System;
using System.Collections.Generic;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoBusquedaAvanzada
    {
        //busqueda normal y avanzada de empresas
         public int tema_id        =  -1; 
         public int tipo           =  -1; 
		 public int desahogo_id    =  -1;
         public int submateria_id  = -1;
		 public int tipoBusqueda   =   2; 
		 public int lugarBusqueda  =   1; 
		 public int orden          =   1;
		 public String texto       =  "";
    }
}
