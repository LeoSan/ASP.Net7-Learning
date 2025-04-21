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
    public partial class ConsultaInspeccionEtapas : System.Web.UI.Page
    {
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
                    ObtenerDatos();
                }
            }
        }

        void ObtenerDatos()
        {
            DtoBusqueda midtoB = (DtoBusqueda)ViewState["DtoBusqueda"];
            ltNombre.Text = midtoB.nombre;
            ltDomicilio.Text = midtoB.domicilio;

            ltMateria.Text = midtoB.materia;
            ltSubtipo.Text = midtoB.subtipo;




            DataSet ds;

            try
            {
                ds = miComponente.Inspeccion_ConsultarEtapas(midtoB.inspeccion_id, midtoB.in_etapa);
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

        void ObtenerDesahogo(int inspeccion_id)
        {
            DataSet ds;
            DtoDesahogo dtoD = new DtoDesahogo();
            dtoD.inspeccion_id = inspeccion_id;

            try
            {
                ds = miComponente.Desahogo_Obtener(dtoD);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }

            if (ds.Tables["resultado"].Rows.Count > 0)
            {
                DtoDshgo miDtoD = new DtoDshgo();
                miDtoD.inspeccion_id = inspeccion_id;
                int.TryParse(ds.Tables["resultado"].Rows[0]["materia_id"].ToString(), out miDtoD.materia_id);
                miDtoD.materia = ds.Tables["resultado"].Rows[0]["mat_materia"].ToString();

                if (ds.Tables["resultado"].Rows[0]["dshgo_tipo_desahogo"].ToString().Equals("1")) miDtoD.dsecc_en_oficio = 1;
                if (ds.Tables["resultado"].Rows[0]["dshgo_tipo_desahogo"].ToString().Equals("2")) miDtoD.dsecc_en_acta = 1;
                if (ds.Tables["resultado"].Rows[0]["dshgo_tipo_desahogo"].ToString().Equals("3")) miDtoD.dsecc_en_negativa = 1;

                int.TryParse(ds.Tables["resultado"].Rows[0]["desahogo_id"].ToString(), out miDtoD.desahogo_id);
                int.TryParse(ds.Tables["resultado"].Rows[0]["subtipo_inspeccion_id"].ToString(), out miDtoD.subtipo_inspeccion_id);

                Context.Items["DtoDshgo"] = miDtoD;
            }
        }

        protected void lbConsultar_Click(object sender, CommandEventArgs e)
        {
            int etapa;
            int tipo_documento_id;
            int emplazamiento_id;
            string[] argument = e.CommandArgument.ToString().Split(new char[] { ',' });
            int.TryParse(argument[0], out etapa);
            int.TryParse(argument[1], out tipo_documento_id);
            int.TryParse(argument[2], out emplazamiento_id);


            ((DtoBusqueda)ViewState["DtoBusqueda"]).in_etapa = etapa;
            ((DtoBusqueda)ViewState["DtoBusqueda"]).tipo_documento_id = tipo_documento_id;
            ((DtoBusqueda)ViewState["DtoBusqueda"]).emplazamiento_id = emplazamiento_id;

            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];

            switch (etapa)
            {
                case 1: Server.Transfer("~/DFT/DFTResumenDatos.aspx?id=1"); break;
                
                case 2: Server.Transfer("~/Generales/ConsultaNotificacion.aspx"); break;

                case 3: Server.Transfer("~/Generales/ConsultaNotificacion.aspx"); break;


                case 4: ObtenerDesahogo(((DtoBusqueda)ViewState["DtoBusqueda"]).inspeccion_id);
                    Server.Transfer("~/Inspector/InspectorDesahogoResumenDatosXLS.aspx?id=1"); break;

                case 5:
                case 6: Server.Transfer("~/Generales/ConsultaDatosCalificacion.aspx"); break;

                case 8: Server.Transfer("~/Generales/ConsultaInspeccionAmpliacion.aspx"); break;

            
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaInspeccionCentroTrabajo.aspx");
        }
    }
}