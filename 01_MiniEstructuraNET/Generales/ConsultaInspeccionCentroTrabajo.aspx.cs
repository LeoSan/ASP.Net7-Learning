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
using CompInspeccion;

namespace Inspeccion_PA.Generales
{
    public partial class ConsultaInspeccionCentroTrabajo : System.Web.UI.Page
    {
        ComponentInsp miComponente = new ComponentInsp();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usrSesion"] == null) Response.Redirect("~/Login/Login.aspx");
            if (!Session["usrLevel"].Equals(4) && !Session["usrLevel"].Equals(2) && !Session["usrLevel"].Equals(3) && !Session["usrLevel"].Equals(6)) Response.Redirect("~/Login/Bienvenida.aspx");

            if (!IsPostBack)
            {
                if (Session["usrLevel"].Equals(2))
                    ltTitulo.Text = "Consulta";

                if (Session["usrLevel"].Equals(4))
                    ltTitulo.Text = "Seguimiento";

                if (Context.Items["DtoBusqueda"] != null)
                {
                    ViewState["DtoBusqueda"] = Context.Items["DtoBusqueda"];
                    ObtenerDatos();
                }
            }
        }

        void ObtenerDatos()
        {
            DtoBusqueda midtoB = (DtoBusqueda)ViewState["DtoBusqueda"];
            ltNombre.Text = midtoB.nombre;
            ltDomicilio.Text = midtoB.domicilio;
        
            CargarGrid();
        }

        void CargarGrid()
        {
            DataSet ds;
            DtoBusqueda midtoB = (DtoBusqueda)ViewState["DtoBusqueda"];

            try
            {
                ds = miComponente.Inspeccion_Consulta(midtoB.centro_trabajo_id);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }

            rptInspeccion.DataSource = ds;
            rptInspeccion.DataMember = "resultado";
            rptInspeccion.DataBind();
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaInspeccion.aspx");
        }

        protected void lbArchivos_Click(object sender, CommandEventArgs e)
        {
            String[] info = e.CommandArgument.ToString().Split('|');
            DtoBusqueda midtoB = (DtoBusqueda)ViewState["DtoBusqueda"];
            int.TryParse(info[0], out midtoB.inspeccion_id);
            int.TryParse(info[1], out midtoB.in_etapa);
            midtoB.num_expediente = info[2];
            midtoB.subtipo = info[3];
            midtoB.materia = info[4];
            midtoB.fec_inspeccion = info[5];
            int.TryParse(info[6], out midtoB.desahogo_id);
            int.TryParse(info[7], out midtoB.operativo_id);
            int.TryParse(info[8], out midtoB.materia_id);
            int.TryParse(info[9], out midtoB.subtipo_inspeccion_id);
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaInspeccionDocumentos.aspx");
        }

        protected void lbConsultar_Click(object sender, CommandEventArgs e)
        {
            String[] info = e.CommandArgument.ToString().Split('|');
            DtoBusqueda midtoB = (DtoBusqueda)ViewState["DtoBusqueda"];
            int.TryParse(info[0], out midtoB.inspeccion_id);
            int.TryParse(info[1], out midtoB.in_etapa);
            midtoB.num_expediente = info[2];
            midtoB.subtipo = info[3];
            midtoB.materia = info[4];

            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaInspeccionEtapas.aspx");
        }
    }
}