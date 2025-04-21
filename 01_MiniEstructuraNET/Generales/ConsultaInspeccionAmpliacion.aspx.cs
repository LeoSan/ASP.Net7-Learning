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
    public partial class ConsultaInspeccionAmpliacion : System.Web.UI.Page
    {
        ComponentInsp miComponente = new ComponentInsp();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usrSesion"] == null) Response.Redirect("~/Login/Login.aspx");
            if (!Session["usrLevel"].Equals(4) && !Session["usrLevel"].Equals(2) && !Session["usrLevel"].Equals(3)) Response.Redirect("~/Login/Bienvenida.aspx");

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
            DataSet ds, ds1, ds2, ds3, ds4;
            DtoBusqueda dtoB = (DtoBusqueda)ViewState["DtoBusqueda"];
            DtoDocumento dtoD = new DtoDocumento();
            DtoInspeccion dtoI = new DtoInspeccion();

            dtoI.inspeccion_id = dtoD.inspeccion_id = dtoB.inspeccion_id;
            dtoD.tipo_documento_id = 9;

            try
            {
                ds = miComponente.MedidasAdminPorSubmateriaEmplazamiento_Obtener(dtoB.emplazamiento_id, -1);
                ds1 = miComponente.Inspeccion_Obtener(dtoI);
                ds2 = miComponente.Documento_Obtener(dtoD);
                ds3 = miComponente.Emplazamiento_Obtener(dtoB.inspeccion_comprobacion_id, dtoB.inspeccion_id);
                ds4 = miComponente.Emplazamiento_ObtenerMedidasRecorrido(dtoB.emplazamiento_id);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }

            if (ds1.Tables["resultado"].Rows.Count > 0)
            {
                DateTime dt;
                DateTime.TryParse(ds1.Tables["resultado"].Rows[0]["in_fec_inspeccion"].ToString(), out dt);
                ltTipo.Text = ds1.Tables["resultado"].Rows[0]["tins_tipo"].ToString();
                ltSubtipo.Text = ds1.Tables["resultado"].Rows[0]["stins_subtipo"].ToString();
                ltMateria.Text = ds1.Tables["resultado"].Rows[0]["mat_materia"].ToString();
                ltRazon.Text = ds1.Tables["resultado"].Rows[0]["in_ct_nombre"].ToString();

                if (!String.IsNullOrEmpty(dt.ToString()))
                    ltFecha.Text = String.Format("{0:dd/MM/yyyy}", dt) + "    Hora: " + String.Format("{0:hh:mm tt}", dt); ;

            }

            if (ds2.Tables["resultado"].Rows.Count > 0)
            {
                ltFechaEmosion.Text = ds2.Tables["resultado"].Rows[0]["fec_emision"].ToString();
                ltTitulares.Text = ds2.Tables["resultado"].Rows[0]["doc_firman_titulares"].ToString().Equals("1") ? "Sí" : ds2.Tables["resultado"].Rows[0]["doc_firman_titulares"].ToString().Equals("0") ? "No" : "";

                ltFirmante.Text = ds2.Tables["resultado"].Rows[0]["doc_nombre_firmante"].ToString();
                ltCargo.Text = ds2.Tables["resultado"].Rows[0]["doc_cargo_firmante"].ToString();
            }

            if (ds3.Tables["resultado"].Rows.Count > 0)
                ltOtorga.Text = ds3.Tables["resultado"].Rows[0]["em_resolucion_ampliacion"].ToString().Equals("1") ? "Se otorga" : "No se otorga";

            repMedidas.DataSource = ds;
            repMedidas.DataMember = "resultado";
            repMedidas.DataBind();

            rptRecorrido.DataSource = ds4;
            rptRecorrido.DataMember = "resultado";
            rptRecorrido.DataBind();
        }

        public string codeTipodocumento(int tipo_documento_id)
        {
            DtoTipoDocumento dtoTipoDoc = new DtoTipoDocumento();
            dtoTipoDoc.tipo_documento_id = tipo_documento_id;
            dtoTipoDoc.mat_normativa_version_id = -1;

            DataSet ds = null;

            string code = "";
            try
            {   //traer tipo de documentos
                ds = miComponente.Tipo_Documento_Obtener(dtoTipoDoc);
            }
            catch (Exception ex)
            {
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
            }


            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow miRow = ds.Tables[0].Rows[0];
                code = miRow["code"].ToString();
            }

            return code;
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaInspeccionEtapas.aspx");
        }
    }
}