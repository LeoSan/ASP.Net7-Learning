using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    public class DtoInspectorInfoAdmin
    {
        public Int32 id = -1;
        public String num_credencial = String.Empty;
        //Informacion Administrativa
        public Int16 permisos = 0;
        public Int16 omisiones = 0;
        public Int16 comisiones = 0;
        public Int16 inasistencias = 0;
        public Int16 incapacidad = 0;
        public Int16 maternidad = 0;
        public Int16 paternidad = 0;
        public Int16 per1Tomadas = 0;
        public Int16 per1Pendientes = 0;
        public Int16 per2Tomadas = 0;
        public Int16 per2Pendientes = 0;
        //Cargos del Inspector 
        public String cargo = String.Empty;
        public DateTime fecInicio;
        public DateTime? fecFin = null;
    }
}
