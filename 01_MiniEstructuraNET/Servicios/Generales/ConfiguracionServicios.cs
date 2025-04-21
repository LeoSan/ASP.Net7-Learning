using Newtonsoft.Json;
using Servicios.DtoS;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using CompInspeccion;
using System.Web;

namespace Servicios.Generales
{
    public class ConfiguracionServicios
    {
        ComponentInsp miComponente = new ComponentInsp();

        /// <summary>
        /// Método generico que permite conectar a los servicios web 
        /// </summary>
        /// <param name="Token">Valor que permite obtener los datos del servicio</param>
        /// <param name="Dataconfig">Datos de configuración del servicio a conectarse</param>
        /// <param name="json">parametros que se enviaran al servicio</param>
        /// <returns>Datos en formato Json</returns>
        public string ServiceRequest(DtoToken Token, DtoConfig Dataconfig, string json)
        {
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)768 | (SecurityProtocolType)3072;
                var request = (HttpWebRequest)WebRequest.Create(Dataconfig.UrlApi);
                request.Method = Dataconfig.TipoMetodo;
                request.ContentType = "application/json";
                request.Accept = "application/json";
                request.Headers.Add("Authorization", Token.token_type + " " + Token.access_token);

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            var resultjson = objReader.ReadToEnd();
                            return resultjson;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                WebException webexcepcion = new WebException();

                if (ex.Status == WebExceptionStatus.UnknownError)
                {
                    webexcepcion = new WebException(ex.Message, ex);
                    webexcepcion.Source = "Servicio OffLine";
                }
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    webexcepcion = new WebException(Tilde(((HttpWebResponse)ex.Response).StatusDescription), ex);
                    webexcepcion.Source = "Validación para autenticar usuario";
                }
                throw webexcepcion;
            }
        }
        /// <summary>
        /// Método que permite obtener los valores del Token
        /// </summary>
        /// <param name="DataConfigToken">Datos de configuracion del servicio a conectarse</param>
        /// <returns>Datos del token</returns>
        public DtoToken GetToken(DtoConfig DataConfigToken)
        {
            string NameApi = DataConfigToken.NameApi;
            string token = GetTokenSession(NameApi);

            DtoToken dtoToken = new DtoToken();
            dtoToken.token_type = "Bearer";
            if (token != "no-token")
            {
                dtoToken.access_token = token;
                return dtoToken;
            }

            string[] tokenArr = GetTokenConfigurationDB(NameApi, DataConfigToken.ClientSecret);

            if (tokenArr.Length > 0)
            {
                dtoToken.access_token = tokenArr[0];
                DateTime currentDateTime = DateTime.Now;
                DateTime expire = Convert.ToDateTime(tokenArr[1]);
                if (currentDateTime > expire.AddHours(2))
                    return GetTokenApi(DataConfigToken, "update");

                return dtoToken;
            }

            return GetTokenApi(DataConfigToken, "store");
        }

        public DtoToken GetTokenApi(DtoConfig DataConfigToken, string accion)
        {
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)768 | (SecurityProtocolType)3072;
                var request = (HttpWebRequest)WebRequest.Create(DataConfigToken.UrlApi);
                string json = $"{{\"grant_type\":\"client_credentials\",\"client_id\":\"{ DataConfigToken.ClientId }\",\"client_secret\":\"{ DataConfigToken.ClientSecret }\",\"scope\":\"*\"}}";
                request.Method = DataConfigToken.TipoMetodo;
                request.ContentType = "application/json";
                request.Accept = "application/json";
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return null;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            var resultjson = objReader.ReadToEnd();
                            var result = JsonConvert.DeserializeObject<DtoToken>(resultjson);

                            if(accion == "update")
                            {
                                SetToken(result.access_token, DataConfigToken.NameApi, DataConfigToken.ClientSecret);
                            }
                            else if(accion == "store")
                            {
                                StoreToken(result.access_token, DataConfigToken.NameApi, DataConfigToken.ClientSecret);
                            }
                                

                            return result;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                WebException webexcepcion = new WebException();

                if (ex.Status == WebExceptionStatus.ConnectFailure)
                {
                    webexcepcion = new WebException(ex.Message, ex);
                    webexcepcion.Source = "Servicio no disponible: GetRequestStream()";
                }

                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    webexcepcion = new WebException(Tilde(((HttpWebResponse)ex.Response).StatusDescription), ex);
                    webexcepcion.Source = "Servicio: GetResponse()";
                }
                throw webexcepcion;
            }
        }

        /// <summary>
        /// Método que formatea las letras Ñ y Acentos
        /// </summary>
        /// <param name="texto">Texto a corregir los acentos y Ñ</param>
        /// <returns>Cadena con sus respectivos acentos y Ñ</returns>
        public string Tilde(string texto)
        {
            byte[] bytes = Encoding.Default.GetBytes(texto);
            string mensaje = Encoding.UTF8.GetString(bytes);
            return mensaje;
        }

        public string GetTokenSession(string ApiName)
        {
            if(HttpContext.Current.Session == null)
                return "no-token";

            if (HttpContext.Current.Session["token_siapi_" + ApiName] == null)
                return "no-token";

            string token = HttpContext.Current.Session["token_siapi_" + ApiName].ToString();

            if(String.IsNullOrEmpty(token))
                return "no-token";

            return token;
        }

        public string[] GetTokenConfigurationDB(string ApiName, string ClientSecret)
        {
            DataSet ds;

            try
            {
                DtoConfiguracion dtoConfiguracion = new DtoConfiguracion();
                dtoConfiguracion.co_code = "token-siapi-" + ApiName;
                dtoConfiguracion.sentencia = "SELECT";
                dtoConfiguracion.co_dato_extra = ClientSecret;

                ds = miComponente.Configuracion(dtoConfiguracion);
            }
            catch (Exception ex)
            {
                return null;
            }

            if (ds.Tables["resultado"].Rows.Count > 0)
            {
                string token = ds.Tables["resultado"].Rows[0]["co_valor"].ToString();
                string update = ds.Tables["resultado"].Rows[0]["sys_fec_update"].ToString();
                HttpContext.Current.Session["token_siapi_" + ApiName] = token;
                string[] args = { token, update };
                return args;
            }

            string[] argsNot = {};
            return argsNot;
        }

        public void SetToken(string token, string NameApi, string ClientSecret)
        {
            HttpContext.Current.Session["token_siapi_" + NameApi] = token;

            try
            {
                DtoConfiguracion dtoConfiguracion = new DtoConfiguracion();
                dtoConfiguracion.co_nombre = "Token SIAPI "+ NameApi;
                dtoConfiguracion.co_code = "token-siapi-" + NameApi;
                dtoConfiguracion.co_dato_extra = ClientSecret;
                dtoConfiguracion.co_valor = token;

                dtoConfiguracion.sentencia = "UPDATETOKEN";

                miComponente.Configuracion(dtoConfiguracion);
            }
            catch (Exception ex)
            {
            }
        }

        public void StoreToken(string token, string NameApi, string ClientSecret)
        {
            HttpContext.Current.Session["token_siapi_" + NameApi] = token;

            try
            {
                DtoConfiguracion dtoConfiguracion = new DtoConfiguracion();
                dtoConfiguracion.sentencia = "INSERT";
                dtoConfiguracion.co_nombre = "Token SIAPI " + NameApi;
                dtoConfiguracion.co_code = "token-siapi-" + NameApi;
                dtoConfiguracion.co_dato_extra = ClientSecret;
                dtoConfiguracion.co_valor = token;

                miComponente.Configuracion(dtoConfiguracion);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
