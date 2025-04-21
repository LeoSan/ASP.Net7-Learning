using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

//para no poner todo el path
using System.Configuration;

namespace utilerias.web
{
	public class correoE
	{
		//Configuracion
		static private bool checkOnce = true;
		static private bool usarNet1 = false;

		//SMPT connection info
		static private int port = 25;
		static private string host = "txtec.uson.mx";
		static private string fromMail = "administrador@STPS.com";

		//SMPT con autentificacion
		static public bool autentificar = false;
		static private string user = "txtec@txtec.uson.mx";
		static private string pass = "";

		/// <summario>
		/// Método carga la información del web.config para la conección al SMPT
		/// </summario>
		private static void CargaInfoConeccion()
		{
			if (checkOnce == false) return;
			checkOnce = false;
			if (ConfigurationManager.AppSettings["MailInfoDefault"] == null) return;
			if (ConfigurationManager.AppSettings["MailInfoDefault"].Equals("FALSE")) {
				host = ConfigurationManager.AppSettings["MailHostIP"];
				fromMail = ConfigurationManager.AppSettings["MailFrom"];
				if (!int.TryParse(ConfigurationManager.AppSettings["MailPort"], out port)) port = 25;
				autentificar = false;
				user = pass = String.Empty;
				if (ConfigurationManager.AppSettings["MailAutenticar"] != null) {
					if (ConfigurationManager.AppSettings["MailAutenticar"].Equals("TRUE")) {
						autentificar = true;
						user = ConfigurationManager.AppSettings["Mailuser"];
						pass = ConfigurationManager.AppSettings["Mailpass"];
					}
				}
			}
			if (ConfigurationManager.AppSettings["LibreriasMailNet1"] != null) {
				if (ConfigurationManager.AppSettings["LibreriasMailNet1"].Equals("TRUE")) {
					usarNet1 = true;
				}
			}
		}

		/// <summario>
		/// Método estático tipo bool que envia correo electrónico
		/// </summario>
		/// <parametro nombre="to">
		/// Variable tipo String que recibe a quien se madará el correo
		/// </parametro> 
		/// <parametro nombre="msg">
		/// Variable tipo String que recibe el mensaje del correo
		/// </parametro> 
		/// <parametro nombre="asunto">
		/// Variable tipo String que recibe el asunto del correo
		/// </parametro> 
		public static bool enviar(string to, string msg, string asunto)
		{
			CargaInfoConeccion();
			if (to.Trim().Equals("")) return false;  // el campo TO no puede estar vacio
			if (usarNet1) return enviarMailNET1(to, msg, asunto);
			else return enviarMailNET2(to, msg, asunto);
		}

		/// <summario>
		/// Método estático tipo bool que envia correo electrónico utilizando librerias del NET 2
		/// </summario>
		/// <parametro nombre="to">
		/// Variable tipo String que recibe a quien se madará el correo
		/// </parametro> 
		/// <parametro nombre="msg">
		/// Variable tipo String que recibe el mensaje del correo
		/// </parametro> 
		/// <parametro nombre="asunto">
		/// Variable tipo String que recibe el asunto del correo
		/// </parametro> 
		public static bool enviarMailNET2(string to, string msg, string asunto)
		{
			try {
				MailMessage message = new MailMessage(fromMail, to);
				message.Subject = asunto;
				message.Body = msg;

				SmtpClient client = new SmtpClient(host, port);
				if (autentificar) {
					client.EnableSsl = true;
					client.UseDefaultCredentials = false;
					client.Credentials = new System.Net.NetworkCredential(user, pass);
				}
				//client.Host = host;
				//client.Port = port;
				client.Send(message);
			} catch (Exception ex) {
				utilerias.log.error("correoE.enviarMailNET2()", "correoE.cs", ex.ToString());
				return false;
			}
			return true;
		}

		/// <summario>
		/// Método estático tipo bool que envia correo electrónico utilizando librerias del NET 1
		/// </summario>
		/// <parametro nombre="to">
		/// Variable tipo String que recibe a quien se madará el correo
		/// </parametro> 
		/// <parametro nombre="msg">
		/// Variable tipo String que recibe el mensaje del correo
		/// </parametro> 
		/// <parametro nombre="asunto">
		/// Variable tipo String que recibe el asunto del correo
		/// </parametro> 
		public static bool enviarMailNET1(string to, string msg, string asunto)
		{
			try {
				System.Web.Mail.MailMessage message = new System.Web.Mail.MailMessage();

				if (autentificar) {
					message.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", 1);
					message.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", user);
					message.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", pass);
				}
				msg = msg.Replace("\n", "\r\n");
				message.BodyFormat = System.Web.Mail.MailFormat.Text;
				message.From = fromMail;
				message.To = to;
				message.Subject = asunto;
				message.Body = msg;

				System.Web.Mail.SmtpMail.SmtpServer = host;
				System.Web.Mail.SmtpMail.Send(message);
			} catch (Exception ex) {
				utilerias.log.error("correoE.enviarMailNET1()", "correoE.cs", ex.ToString());
				return false;
			}
			return true;
		}
	}
}