using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable]
    public class DtoInspeccionDetalle
    {
        public int inspectorId = -1;
        public string inspectorNombre = string.Empty;
        public string inspectorCredencial = string.Empty;
        public DateTime inspeccionFecha;
        public string inspeccionExpediente = string.Empty;
        public string unidadResponsable = string.Empty;
        public string estado = string.Empty;
        public string razonSocial = string.Empty;
        public string materiaAcronimo = string.Empty;
        public string materiaNombre = string.Empty;
        public string infoAdicional = string.Empty;
    }
}