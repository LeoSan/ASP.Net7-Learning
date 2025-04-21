using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CompInspeccion;
using System.Data;

namespace Inspeccion_PA.Generales
{
    public partial class ConsultaMedidasViolaciones : System.Web.UI.Page
    {
        public String Submateria = String.Empty;
        public String Submateria1 = String.Empty;
        public String Submateria2 = String.Empty;
        ComponentInsp miComponente = new ComponentInsp();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usrSesion"] == null) Response.Redirect("~/Login/Login.aspx");
            if (!Session["usrLevel"].Equals(4) && !Session["usrLevel"].Equals(2) && !Session["usrLevel"].Equals(3) && !Session["usrLevel"].Equals(6)) Response.Redirect("~/Login/Bienvenida.aspx");

            if (!IsPostBack)
            {
                if (Context.Items["DtoBusqueda"] != null)
                {
                    ViewState["DtoBusqueda"] = Context.Items["DtoBusqueda"];

                    //DtoBusqueda busca = new DtoBusqueda();
                    //ViewState["DtoBusqueda"] = busca;


                    //((DtoBusqueda)ViewState["DtoBusqueda"]).in_etapa = 6;
                    //((DtoBusqueda)ViewState["DtoBusqueda"]).calificacion_id = 87;


                    ObtenerDatos();
                }
            }
        }

        public void ObtenerDatos()
        {
            DtoBusqueda busca = (DtoBusqueda)ViewState["DtoBusqueda"];
            DataSet ds;
            if (busca.in_etapa == 6)
                if (busca.tipo_documento_id == 14 || busca.tipo_documento_id == 15 || busca.tipo_documento_id == 12)
                {
                    ltTitulo.Text = "Presuntas violaciones";
                    Violaciones.Visible = true;
                    MedidasAdmin.Visible = false;
                    MedidasRecorrido.Visible = false;
                }
                else
                {
                    ltTitulo.Text = "Emplazamiento de medidas";
                    MedidasAdmin.Visible = true;
                    MedidasRecorrido.Visible = true;
                    Violaciones.Visible = false;
                }

            try 
            {
                ds = miComponente.MedidasViolaciones_ParaConsulta(busca.calificacion_id);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }
            if (ds.Tables["resultado"].Rows.Count > 0 && busca.in_etapa == 6 && (busca.tipo_documento_id == 14 || busca.tipo_documento_id == 15 || busca.tipo_documento_id == 12))
            {
                
                
                
            }
            if (ds.Tables["resultado1"].Rows.Count > 0 && busca.in_etapa == 6 && (busca.tipo_documento_id != 14 && busca.tipo_documento_id != 15 && busca.tipo_documento_id != 12))
            {

                
                
            }
            if (ds.Tables["resultado2"].Rows.Count > 0 && busca.in_etapa == 6 && (busca.tipo_documento_id != 14 && busca.tipo_documento_id != 15 && busca.tipo_documento_id != 12))
            {

                Violaciones.Visible = false;
                
            }
            
            rptViolacion.DataSource = ds.Tables["resultado"];
            rptViolacion.DataBind();
            rptMedidasAdm.DataSource = ds.Tables["resultado1"];
            rptMedidasAdm.DataBind();
            rptMedidasRec.DataSource = ds.Tables["resultado2"];
            rptMedidasRec.DataBind();

			if (ds.Tables["resultado"].Rows.Count == 0 && busca.in_etapa == 6 && (busca.tipo_documento_id == 14 || busca.tipo_documento_id == 15)) {
				rptViolacion.DataSource = ds.Tables["resultado3"];
				rptViolacion.DataBind();
			}
        }

        public bool Sub(String StrSub)
        {
            if (Submateria == StrSub)
                return false;
            Submateria = StrSub;
            return true;

        }

        public bool Sub1(String StrSub)
        {
            if (Submateria1 == StrSub)
                return false;
            Submateria1 = StrSub;
            return true;
        }

        public bool Sub2(String StrSub)
        {
            if (Submateria2 == StrSub)
                return false;
            Submateria2 = StrSub;
            return true;
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaDatosCalificacion.aspx");
        }

    }
}