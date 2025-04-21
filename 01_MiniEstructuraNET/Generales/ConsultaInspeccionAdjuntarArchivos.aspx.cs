using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CompInspeccion;
using System.Data;
using System.IO;
namespace Inspeccion_PA.Generales
{
    public partial class ConsultaInspeccionAdjuntarArchivos : System.Web.UI.Page
    {
        ComponentInsp miComponente = new ComponentInsp();
        DtoBusqueda midtoB
        {
            get
            {
                if (ViewState["DtoBusqueda"] == null) ViewState["DtoBusqueda"] = new DtoBusqueda();
                return ViewState["DtoBusqueda"] as DtoBusqueda;
            }
            set { ViewState["DtoBusqueda"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usrSesion"] == null) Response.Redirect("~/Login/Login.aspx");
            if (!Session["usrLevel"].Equals(4) && !Session["usrLevel"].Equals(2) && !Session["usrLevel"].Equals(3) && !Session["usrLevel"].Equals(6)) Response.Redirect("~/Login/Bienvenida.aspx");
            MaintainScrollPositionOnPostBack = true;
            if (!IsPostBack)
            {

                if (Context.Items["DtoBusqueda"] != null)
                {
                    midtoB = Context.Items["DtoBusqueda"] as DtoBusqueda;
                   
                    if (midtoB.subtipo_inspeccion_id != 5) ddlTipoDocumento.Items.RemoveAt(3);

                    CargarGrid(midtoB.desahogo_id);
                }
            }
        }

        protected void ddlTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            trOtro.Visible = (ddlTipoDocumento.SelectedItem.Text.ToLower() == "otro");
        }

        void CargarGrid(int desahogo)
        {
            DataSet ds;
            DtoDshgoDocumento dtoDocumento = new DtoDshgoDocumento();
            dtoDocumento.desahogo_id = desahogo;

            try
            {
                ds = miComponente.DshgoDocumentoAnexo_Obtener(dtoDocumento);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }


            repDocumentos.DataSource = ds;
            repDocumentos.DataMember = "resultado";
            repDocumentos.DataBind();
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaInspeccionDocumentos.aspx");
        }
        protected void repDocumentos_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            string[] args = e.CommandArgument.ToString().Split('|');
            int dshgo_documento_id = 0;
            int.TryParse(args[0], out dshgo_documento_id);

            try
            {
                miComponente.DshgoDocumento_Eliminar(dshgo_documento_id, "dshgo");
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }

            if (File.Exists(Server.MapPath(args[1])))
                File.Delete(Server.MapPath(args[1]));

            CargarGrid(midtoB.desahogo_id);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!IsValid) return;
            if (!fuArchivo.HasFile) return;

            String pathFisico = Page.MapPath("~/Uploads/anexos");
            String extencion = Path.GetExtension(fuArchivo.FileName);
            String nombreAux = Guid.NewGuid().ToString() + extencion;

            try
            {
                if (!Directory.Exists(pathFisico)) Directory.CreateDirectory(pathFisico);
                while (File.Exists(pathFisico + "\\" + nombreAux))
                    nombreAux = String.Format("{0}{1}", Guid.NewGuid().ToString(), extencion);

                //Se comenta para no guardar ningun archivo fisico
                //fuArchivo.SaveAs(pathFisico + "\\" + nombreAux);
            }
            catch (Exception ex)
            {
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                utilerias.web.alerta.mensaje("Error al subir el archivo favor de intentar más tarde", Page);
                return;
            }

            DtoDshgoDocumento dtoDocumento = new DtoDshgoDocumento();
            dtoDocumento.desahogo_id = midtoB.desahogo_id;
            //int.TryParse(ddlTipoDocumento.SelectedValue, out  dtoDocumento.tipo_documento_id);
            dtoDocumento.ddoc_nombre_documento = ddlTipoDocumento.SelectedItem.Text.ToLower() == "otro" ? tbOtro.Text : ddlTipoDocumento.SelectedItem.Text;
            dtoDocumento.sys_usr = ((DtoUsuario)Session["usrSesion"]).nombre_completo;
            dtoDocumento.ddoc_url_documento = "~/Uploads/anexos/" + nombreAux;

            try
            {
                //Se comenta por que esta vista no debe estar activa, fue reemplazado por la vista de expediente.
                //miComponente.DshgoDocumentoAgregarActualizar(dtoDocumento);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }
            CargarGrid(midtoB.desahogo_id);
            tbOtro.Text = "";
            utilerias.web.alerta.mensaje("Proceso inactivo", Page);
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string[] extensionesPermitidas = new string[2] { ".doc", ".docx" };
            args.IsValid = false;
            String extencion = System.IO.Path.GetExtension(fuArchivo.FileName);

            foreach (String strExtencion in extensionesPermitidas)
                if (extencion.Equals(strExtencion))
                {
                    args.IsValid = true;
                    break;
                }
        }
    }
}