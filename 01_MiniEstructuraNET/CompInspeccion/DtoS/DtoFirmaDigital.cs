using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompInspeccion.DtoS
{
    public class DtoFirmaDigital
    {
        public int fd_document_id = -1;
        public int fd_pd_documento_id = -1;
        public int fd_inspeccion_id = -1;
        public string fd_referencia = "";
        public int fd_referencia_id = -1;
        public int fd_tipo_documento_id = -1;
        public string fd_nombre_firmante = "";
        public string fd_cargo_firmante = "";
        public string fd_rfc_emisor = "";
        public string fd_cadena_original = "";
        public string fd_cadena_original_hash = "";
        public string fd_codigo_verificador = "";
        public string fd_certificado_emisor = "";
        public string fd_estatus = "";
        public string fd_ruta = "";
        public string fd_sello = "";
    }
}
