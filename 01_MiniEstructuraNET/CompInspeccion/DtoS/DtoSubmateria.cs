using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
    public class DtoSubmateria
    {

       public int submateria_id=-1;
       public int materia_id = -1;
       public int smat_consecutivo = -1;
       public int smat_es_nom = -1;
       public String smat_nom = String.Empty;
       public int smar_anio = -1;
       public String smat_submateria = String.Empty;
       public String smat_nombre_corto = String.Empty;
       public int smat_alcance = -1;
       public int smat_opcion_no_aplicar = -1;
       public int smat_estatus = -1;
       public String sys_usr = String.Empty;
       public String sentencia = "UPDATE";


    }
}
