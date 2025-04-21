using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion
{
    [Serializable()]
	public class DtoDocumento
	{

		public int    documento_id               = -1;
		public int    inspeccion_id              = -1;
		public int    inspector_id               = -1;
		public int    tipo_documento_id          = -1;
		public String doc_url_archivo            = "";
        public int    doc_esta_asignado          = -1;
		public String doc_fec_documento          = "";
        public int    doc_forma_entrega          = -1;
		public String doc_fec_limite_entrega     = "";
		public String doc_fec_entrega_programada = "";
		public String doc_observaciones          = "";
        public int    doc_estatus                = -1;
		public String sys_usr                    = "";

        public int doc_firman_titulares = -1;
        public String doc_nombre_firmante = String.Empty;
        public String doc_cargo_firmante = String.Empty;
        public int documento_firmado = -1;
        public String doc_url_archivo_sin_firmas = "";

        public int? aplica_notificacion { get; set; }
        public int? etapa = -1;
        public String code = "";


        public int AgregarPorInspeccion()
        {
            ComponentInsp miComponente = new ComponentInsp();
            return  miComponente.DocumentoAgregarActualizar2(this);
        }

	}

    public class DtoGestorDocumentos
    {
        public String sentencia { get; set; }
        public int tipo_documento_id { get; set; }
        public String tipo_documento { get; set; }
        public int aplica_aleatoria { get; set; }
        public int aplica_directa { get; set; }
        public int aplica_automatica { get; set; }
        public int aplica_notificacion { get; set; }
        public int normativa_version { get; set; }
        public String etapa { get; set; }
        public int td_activo { get; set; }


    }
}
