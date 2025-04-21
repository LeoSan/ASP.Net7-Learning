using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion.DtoS
{
    [Serializable]
    public class DtoDshgoPregunta
    {
        public int dshgo_pregunta_id { get; set; }
        public int submateria_id  { get; set; }
        public int dpreg_tipo_pregunta  { get; set; }
        public int dpreg_consecutivo  { get; set; }
        public string dpreg_pregunta { get; set; }
        public int dpreg_estatus  { get; set; }
        public string sys_usr_insert  { get; set; }
        public DateTime sys_fec_insert { get; set; }
        public string sys_usr_update { get; set; }
        public DateTime sys_fec_update { get; set; }
        public int materia_id { get; set; }
        public DtoMaterias materia = new DtoMaterias();
        public DtoSubmateria submateria = new DtoSubmateria();
        public string sentencia { get; set; }
        public string accion_respuesta { get; set; }
        public List<DtoDshgoRespuesta> Respuestas = new List<DtoDshgoRespuesta>();

    }
}
