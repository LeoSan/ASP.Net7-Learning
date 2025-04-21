using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion.DtoS
{
    public class DtoDashboard
    {
            public String id_documento { get; set; }
            public String tabla_origen_doc { get; set; }
            public String tipo_documento { get; set; }
            public String nombre_documento { get; set; }
            public String fecha { get; set; }
            public String usuario { get; set; }
            public String numero_inspeccion { get; set; }
            public String sys_fec_insert { get; set; }
            public String in_anio { get; set; }
            public String mes_id { get; set; }
            public String centro_trabajo_id { get; set; }
            public String cve_rama { get; set; }
            public String in_ct_rfc { get; set; }
            public String in_fec_inspeccion { get; set; }
            public String subtipo_inspeccion { get; set; }
            public String fundamento_designacion { get; set; }
            public String motivo_inspeccion { get; set; }
            public String inspector_id { get; set; }
            public string nombre_inspector { get; set; }
            public String materia_id { get; set; }
            public String materia { get; set; }
            public String cve_ur { get; set; }
            public String oficina { get; set; }
            public String etapa { get; set; }
            public String tipo_desahogo { get; set; }
            public String in_num_expediente { get; set; }
            public String operativo { get; set; }
            public String listado_personal { get; set; }
            public String nalcances { get; set; }
            public String submaterias { get; set; }
            public String nind { get; set; }
            public String nrevisiones { get; set; }
            public String nrevisionesCumple { get; set; }
            public String nrevisionesNoCumple { get; set; }
            public String nrevisionesNoAplica { get; set; }
            public String nmed { get; set; }
            public String nmedespontaneo_si { get; set; }
            public String nmedespontaneo_no { get; set; }
            public String nvio { get; set; }
            public String nvio_procede { get; set; }
            public String nvio_no_procede { get; set; }
            public String documentos { get; set; }

    }
}
