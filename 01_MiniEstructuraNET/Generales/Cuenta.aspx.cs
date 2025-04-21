using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using CompInspeccion;
using Servicios.ControlUsuarios;
using ServicioDto = Servicios.DtoS;
using Inspeccion_PA.UserControls;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Inspeccion_PA.Generales
{
    public partial class Cuenta : System.Web.UI.Page
    {
        ComponentInsp miComponente = new ComponentInsp();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usrSesion"] == null) Response.Redirect("~/Default.aspx");

            if (!IsPostBack)
            {
                int usrID;
                DataSet miDS;
                DataRow miRow;
                DtoUsuario miDtoUsuario = new DtoUsuario();

                usrID = ((DtoUsuario)Session["usrSesion"]).usuario_id;
                try
                {
                    miDS = miComponente.Usuario_Obtener(usrID, "", "");
                }
                catch (Exception ex)
                {
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    wucMessageBox.Show("No se pudo conectar con la base de datos intente de nuevo más tarde", wucMessageBox.eTipoAviso.Error);
                    return;
                }

                miRow = miDS.Tables["resultado"].Rows[0];
                ltNombre.Text = miRow["usr_nombre"].ToString() + ' ' + miRow["usr_primer_apellido"].ToString() + ' ' + miRow["usr_segundo_apellido"].ToString();
                ltPuesto.Text = miRow["usr_puesto"].ToString();

                miDtoUsuario.usr_password = miRow["usr_password"].ToString();
                miDtoUsuario.usr_nombre = miRow["usr_nombre"].ToString();
                miDtoUsuario.usr_puesto = miRow["usr_puesto"].ToString();
                miDtoUsuario.usr_login = miRow["usr_login"].ToString();
                miDtoUsuario.usr_email = miRow["usr_email"].ToString();
                miDtoUsuario.usr_telefono = miRow["usr_telefono"].ToString();
                miDtoUsuario.usr_estatus = miRow["usr_estatus"].ToString();

                int estado_aux;
                int.TryParse(miRow["cve_ur"].ToString(), out estado_aux);
                if (estado_aux == 0) miDtoUsuario.cen_cve_edorep = null;
                else miDtoUsuario.cen_cve_edorep = estado_aux;

                int.TryParse(miRow["perfil_id"].ToString(), out miDtoUsuario.perfil_id);
                int.TryParse(miRow["usuario_id"].ToString(), out miDtoUsuario.usuario_id);

                tbTelefono.Text = miDtoUsuario.usr_telefono;
                tbEmail.Value = miDtoUsuario.usr_email;
                ltCorreo.Text = miRow["usr_email"].ToString();


                //Session["usrSesion"] = miDtoUsuario;
            }
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login/Bienvenida.aspx");
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            DtoUsuario miDtoUsr;

            miDtoUsr = (DtoUsuario)Session["usrSesion"];
            miDtoUsr.usr_email = tbEmail.Value;
            miDtoUsr.usr_telefono = tbTelefono.Text;

            try
            {
                DataSet ds;
                ds = miComponente.Usuario_Obtener(-1, String.Empty, tbEmail.Value);
                if (ds.Tables["resultado"].Rows.Count > 0)
                {
                    miDtoUsr.usr_login = ds.Tables["resultado"].Rows[0]["usr_login"].ToString();
                }
                miComponente.Usuario_AgregarActualizar(miDtoUsr);
            }
            catch (Exception ex)
            {
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                wucMessageBox.Show("No se pudo conectar con la base de datos intente de nuevo más tarde", wucMessageBox.eTipoAviso.Error);
                return;
            }
            InsertarBitacora(miDtoUsr.usuario_id, "cuenta", "Cuenta", "Actualización de la información.", "usuarios", 0, "");
            wucMessageBox.Show("Proceso realizado con éxito", wucMessageBox.eTipoAviso.Mensaje);
        }

        protected void cvPassActual_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //DtoUsuario miDtoUsr;
            //miDtoUsr = (DtoUsuario)Session["usrSesion"];
            //args.IsValid = false;
            //if (tbPassActual.Text.Equals(utilerias.Usuario.Password.DesencriptaCadena(miDtoUsr.usr_password)))
            //    args.IsValid = true;
        }

        protected void cvPasssNuevo1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //args.IsValid = false;
            //if (tbPassNuevo1.Text.Equals(tbPassNuevo2.Text))
            //    args.IsValid = true;
        }

        protected void cvEmail_ServerValidate(object source, ServerValidateEventArgs args)
        {
            //DataSet ds;
            //DtoUsuario miDtoUsr;
            //miDtoUsr = (DtoUsuario)Session["usrSesion"];

            //try
            //{
            //    ds = miComponente.Usuario_Obtener(-1, "", tbEmail.Value);
            //}
            //catch (Exception ex)
            //{
            //    utilerias.log.error("CustomValidator1", "Cuenta.aspx.cs", ex.Message);
            //    wucMessageBox.Show("No se pudo conectar con la base de datos intente de nuevo más tarde", wucMessageBox.eTipoAviso.Error);
            //    return;
            //}
            //args.IsValid = false;
            //if (ds.Tables["resultado"].Rows.Count == 0)
            //    args.IsValid = true;
            //if (miDtoUsr.usr_email.Equals(tbEmail.Value))
            //    args.IsValid = true;
        }

        void InsertarBitacora(int id_ref, string componente_ref, string subcomponente_ref, string descripcion_ref, string nombre_tabla, int inspeccion_id, string expediente)
        {
            ServiciosBitacora serv_bitacora = new ServiciosBitacora();
            ServicioDto.DtoBitacoraInsertar entidadServicioBitacora = new ServicioDto.DtoBitacoraInsertar();
            CompInspeccion.DtoUsuario miDtoUsr = (CompInspeccion.DtoUsuario)Session["usrSesion"];

            entidadServicioBitacora.usuario_id = (int)((DtoUsuario)Session["usrSesion"]).core_usuario_id;
            entidadServicioBitacora.usuario_ip = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
            entidadServicioBitacora.componente = componente_ref;
            entidadServicioBitacora.subcomponente = subcomponente_ref;
            entidadServicioBitacora.descripcion = descripcion_ref + ". Expediente: " + expediente;
            entidadServicioBitacora.referencia_id = id_ref;
            entidadServicioBitacora.tipo_referencia = nombre_tabla;
            entidadServicioBitacora.inspeccion_id = inspeccion_id;

            serv_bitacora.InsertarBitacora(entidadServicioBitacora); //core_usuario_id
        }

        private Servicios.DtoS.DtoUsuario ServicioActualizarUsuarios(DtoUsuario miDtoUsuario)
        {
            ServiciosUsuarios ServicioActualizarUsuarios = new ServiciosUsuarios();
            try
            {
                ServicioDto.DtoUsuario UsuarioNuevo = new ServicioDto.DtoUsuario();
                UsuarioNuevo.first_name = miDtoUsuario.usr_nombre;
                UsuarioNuevo.last_name = miDtoUsuario.usr_primer_apellido;
                UsuarioNuevo.second_last_name = miDtoUsuario.usr_segundo_apellido;
                UsuarioNuevo.email = miDtoUsuario.usr_email;
                UsuarioNuevo.password = miDtoUsuario.usr_password;
                UsuarioNuevo.password_confirmation = miDtoUsuario.usr_password;
                UsuarioNuevo.user_core_id = miDtoUsuario.core_usuario_id;
                UsuarioNuevo.id = (int)((DtoUsuario)Session["usrSesion"]).core_usuario_id;
                string json = JsonConvert.SerializeObject(UsuarioNuevo);
                var usuarios = (UsuarioNuevo.user_core_id > 0) ? ServicioActualizarUsuarios.UpdateUsers(json) : ServicioActualizarUsuarios.RegisterUsers(json);
                return usuarios;
            }
            catch (WebException ex)
            {
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                wucMessageBox.Show(ex.Message, wucMessageBox.eTipoAviso.Error);
                return null;
            }
        }

    }
}