using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.IO;
using System.Globalization;
using CompInspeccion;

namespace Inspeccion_PA.Generales
{
    public partial class ConsultaCatalogosCGTCAACXLS : System.Web.UI.Page
    {
        ComponentInsp miComponente = new ComponentInsp();


        protected void Page_Load(object sender, EventArgs e)
        {
            //miDtoDshgo.desahogo_id = 28;
            if (Session["usrSesion"] == null) Response.Redirect("~/Login/Login.aspx");

            if (!IsPostBack)
            {
                if (Context.Items["materia_id"] == null)
                    Response.Redirect("~/Login/Bienvenida.aspx");

                ViewState["materia_id"] = Context.Items["materia_id"];
                litTitulo.Text = Context.Items["titulo"].ToString();
                ViewState["nombre_archivo"] = Context.Items["nombre_archivo"];
                ViewState["nombre_normatividad"] = Context.Items["nombre_normatividad"];
                ltTituloNormatividad.Text = ViewState["nombre_normatividad"].ToString();
                CargarGrid();
                ConvertRepeaterToExcel(ViewState["nombre_archivo"].ToString());
            }
        }


        void CargarGrid()
        {
            DataSet ds;
            DtoSubmateria dtoSub = new DtoSubmateria();
            int.TryParse(ViewState["materia_id"].ToString(), out dtoSub.materia_id);



            try
            {
                ds = miComponente.Submateria_Obtener(dtoSub);

            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }

            rptSubmaterias.DataSource = ds.Tables["resultado"];
            rptSubmaterias.DataBind();



        }





        public DataTable ObtenerMedidas(String submateria_id)
        {
            DataSet ds = new DataSet();
            int submat;
            int.TryParse(submateria_id, out submat);

            try
            {
                ds = miComponente.CatalogosMedidas_Submateria(submat);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return null;
            }

            return ds.Tables["resultado"];
        }


        void ConvertRepeaterToExcel(String ReporteName)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter htw = new HtmlTextWriter(sw);

            Page page = new Page();
            HtmlForm form = new HtmlForm();

            // Deshabilitar la validación de eventos, sólo asp.net 2
            page.EnableEventValidation = false;

            // Realiza las inicializaciones de la instancia de la clase Page que requieran los diseñadores RAD.
            page.DesignerInitialize();

            page.Controls.Add(form);
            form.Controls.Add(divExcel);

            page.RenderControl(htw);

            Response.Clear();
            Response.Buffer = true;
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("Content-Disposition", "attachment;filename=" + ReporteName + ".xls");
            Response.Charset = "UTF-8";
            Response.ContentEncoding = Encoding.Default;
            Response.Write(sb.ToString());
            Response.End();
        }
    }
}