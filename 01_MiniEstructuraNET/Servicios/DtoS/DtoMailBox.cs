using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.DtoS
{
    public class DtoMailBoxInsertar
    {
        public string subject { get; set; }
        public string reference { get; set; }
        public Array users { get; set; }
        public int? send_mail { get; set; }
        public string message_mail { get; set; }
        public string from_name { get; set; }
        public int? id_created_by { get; set; }
        public string email_created_by { get; set; }
        public string description { get; set; }
        public string client_to_assign { get; set; }
        public int? group { get; set; }
        public List<DtoServicioInsertarMailBoxDocumentos> documentos { get; set; }
        public int id_mailbox_edit { get; set; }
        public bool status { get; set; }
        public string type { get; set; }
        public string update_date { get; set; }

    }
    public class DtoServicioInsertarMailBox
    {
        public string message { get; set; }
        public int? id_notificacion { get; set; }
        public DtoMailBoxInsertar buzon { get; set; }

    }

    public class DtoServicioInsertarMailBoxDocumentos
    {
        public string nombre { get; set; }
        public string destino { get; set; }
        public string documento_base64 { get; set; }

    }
    public class DtoDatosInfoApoyo
    {
        public  List<DtoMailBoxDocumento> DatosInfoApoyo { get; set; }
    }

    public class DtoMailBoxDocumento
    {        
        public DtoMailBoxInsertar buzon { get; set; }
        public DtoDocumentos documento { get; set; }

    }

    public class DtoServicioInsertarMailBoxDocuments
    {
        public string message { get; set; }       

    }

    public class DtoServicioConsultarTotalMessageNotReadMailBox
    {        
        public string total_message_not_read { get; set; }
        public string user_core_id { get; set; }
        public string email_current { get; set; }
        

    }


}
