using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Servicios.DtoS;
using Servicios.Generales;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;


namespace Servicios.ControlUsuarios
{
    public class ServiciosUsuarios: ConfiguracionUsuarios
    {
        ConfiguracionServicios ConfiguracionServicio = new ConfiguracionServicios();
        ConfiguracionToken DataToken = new ConfiguracionToken();
        /// <summary>
        /// Método que permite validar la autenticación del usuario
        /// </summary>
        /// <param name="usuario">correo electronico</param>
        /// <param name="password">contraseña</param>
        /// <returns>Los datos del usuario</returns>
        public DtoUsuario GetAutenticarUser(string usuario, string password, int no_ldpa = 0)
        {
            DtoConfig Dataconfig = getUrlAutenticar();
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios);
            DtoUsuario dtoUsuario = new DtoUsuario();
            dtoUsuario.email = usuario;
            dtoUsuario.password = password;
            dtoUsuario.no_ldpa = no_ldpa;
            string json = JsonConvert.SerializeObject(dtoUsuario);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            var result = JsonConvert.DeserializeObject<DtoUsuario>(resultjson);
            return result;
        }

        public DtoUsuario RegisterUsers(String json)
        {
            DtoConfig Dataconfig = getUrlRegistrarUsuario();
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            var result = JsonConvert.DeserializeObject<DtoUsuario>(resultjson);
            return result;
        }

        public DtoUsuario UpdateUsers(String json)
        {
            DtoConfig Dataconfig = getUrlActualizarUsuario();
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            var result = JsonConvert.DeserializeObject<DtoUsuario>(resultjson);
            return result;
        }

        public DtoUsuario UpdatePassword(String json)
        {
            DtoConfig Dataconfig = setActualizarUsuarioPassword();
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            var result = JsonConvert.DeserializeObject<DtoUsuario>(resultjson);
            return result;
        }

        public string SearchUsers(DtoUsuarioSearch search)
        {
            DtoConfig Dataconfig = getSearchUsuario();
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios);
            string json = JsonConvert.SerializeObject(search);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }

        public DtoUsuario ValidateOneTimeToken(int core_id, string one_time_token)
        {
            DtoConfig Dataconfig = getValidateTokenByCoreId();
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios);
            DtoUsuario dtoUsuario = new DtoUsuario();
            dtoUsuario.user_core_id = core_id;
            dtoUsuario.one_time_token = one_time_token;
            string json = JsonConvert.SerializeObject(dtoUsuario);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            var result = JsonConvert.DeserializeObject<DtoUsuario>(resultjson);
            return result;
        }

        public DtoOneTimeTokenResult SetOneTimeToken(int core_id, string usuario_ip)
        {
            DtoConfig Dataconfig = setOneTimeTokenByCoreId();
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios);
            DtoOneTimeTokenRequest dtoTokenReq = new DtoOneTimeTokenRequest();
            dtoTokenReq.core_id = core_id;
            dtoTokenReq.usuario_ip = usuario_ip;
            string json = JsonConvert.SerializeObject(dtoTokenReq);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            var result = JsonConvert.DeserializeObject<DtoOneTimeTokenResult>(resultjson);
            return result;
        }

        public DtoUsuario UpdateUsersPassword(String json)
        {
            DtoConfig Dataconfig = setActualizarUsuarioPassword();
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            var result = JsonConvert.DeserializeObject<DtoUsuario>(resultjson);
            return result;
        }

        public DtoUsuarioRecoverPasswordRequest UpdateRecoverPassword(DtoUsuarioRecoverPassword recover)
        {
            DtoConfig Dataconfig = setRecuperarContrasena();
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios);
            string json = JsonConvert.SerializeObject(recover);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            var result = JsonConvert.DeserializeObject<DtoUsuarioRecoverPasswordRequest>(resultjson);
            return result;
        }

        public string UpdateUsersPasswordToken(DtoUsuarioUpdateContrasenaToken recover)
        {
            DtoConfig Dataconfig = setActualizarUsuarioPasswordToken();
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios);
            string json = JsonConvert.SerializeObject(recover);
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json);
            return resultjson;
        }

        public DtoUsuario Usuario(string correo)
        {
            DtoConfig Dataconfig = getUsuario();
            DtoConfig DataConfigTokenUsuarios = DataToken.getDataTokenUsuarios();
            DtoToken Token = ConfiguracionServicio.GetToken(DataConfigTokenUsuarios);
            var json = new JObject
            {
                ["email"] = correo
            };
            var resultjson = ConfiguracionServicio.ServiceRequest(Token, Dataconfig, json.ToString(Formatting.None));
            var result = JsonConvert.DeserializeObject<DtoUsuario>(resultjson);
            return result;
        }
    }
}
