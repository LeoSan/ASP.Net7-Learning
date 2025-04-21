using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicios.DtoS
{
    public class DtoUsuario
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string second_last_name { get; set; }
        public string complete_name { get; set; }
        public string username { get; set; }
        public string curp { get; set; }
        public string rfc { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public string password_confirmation { get; set; }
        public string token_session { get; set; }
        public string estatus_accion { get; set; }
        public int? user_core_id { get; set; }
        public int? send_email { get; set; }

        public int? platform { get; set; }
        public string one_time_token { get; set; }
        public DateTime? update_data_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime created_at { get; set; }
        public int? no_ldpa { get; set; }

    }

    public class DtoUsuarioSearch
    {
        public string search { get; set; }
    }    
    
    public class DtoUsuaResultSearch
    {
        public int id { get; set; }
        public string complete_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string second_last_name { get; set; }
        public string email { get; set; }

    }

    public class DtoUsuarioApi
    {
        public string complete_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string second_last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }

    public class DtoOneTimeTokenResult
    {
        public string token { get; set; }
    }

    public class DtoOneTimeTokenRequest
    {
        public int core_id { get; set; }
        public string usuario_ip { get; set; }
    }

    public class DtoUsuarioContrasena
    {
        public int id { get; set; }
        public string password { get; set; }
        public string current_password { get; set; }
        public string password_confirmation { get; set; }
        public int? user_core_id { get; set; }
        public string email_current { get; set; }
    }

    public class DtoUsuarioUpdateContrasena
    {
        public int? send_email { get; set; }
        public string email_current { get; set; }

    }

    public class DtoUsuarioRecoverPassword
    {
        public string email { get; set; }
        public string callback_url { get; set; }

    }

    public class DtoUsuarioRecoverPasswordRequest
    {
        public string message { get; set; }
        public string token_resetting { get; set; }

    }

    public class DtoUsuarioUpdateContrasenaToken
    {
        public string token { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string password_confirmation { get; set; }
    }

}
