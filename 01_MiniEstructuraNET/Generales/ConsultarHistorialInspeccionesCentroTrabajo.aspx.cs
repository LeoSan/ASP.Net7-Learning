using CompInspeccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Inspeccion_PA.UserControls;
using System.Data;

namespace Inspeccion_PA.Generales
{
    public partial class ConsultarHistorialInspeccionesCentroTrabajo : System.Web.UI.Page
    {
        ComponentInsp miComponente = new ComponentInsp();
        DtoInspeccion dtoInspeccion = new DtoInspeccion();
        DtoDFT dtoDFT
        {
            get
            {
                if (ViewState["dtoDFT"] == null) ViewState["dtoDFT"] = new DtoDFT();
                return ViewState["dtoDFT"] as DtoDFT;
            }
            set { ViewState["dtoDFT"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usrSesion"] == null) Response.Redirect("~/Login/Login.aspx");

            if (!IsPostBack)
            {

                if (Request.QueryString["centro_trabajo_id"] != null)
                {
                    drawBreadcrumb(Request.QueryString["nombre_bread"], Request.QueryString["ruta_bread"]);

                    int centro_trabajo_id = -1;
                    int.TryParse(Request.QueryString["centro_trabajo_id"], out centro_trabajo_id);
                    dtoDFT.centro_trabajo_id = dtoInspeccion.centrotrabajo_id = centro_trabajo_id;

                    CargarDatos();
                }
                else
                {
                    Server.Transfer("~/CalendarioActividades/ConsultarActividades.aspx");
                }
            }
        }

        protected void CargarDatos()
        {
            List<DtoInspeccion> historial_inspecciones = new List<DtoInspeccion>();
            DtoInspeccion inspeccion = new DtoInspeccion();

            try
            {                
                historial_inspecciones = miComponente.Historial_Inspecciones(dtoInspeccion);
            }
            catch (Exception ex)
            {
                wucMessageBox.Show("No se pudo conectar con la base de datos intente de nuevo más tarde", wucMessageBox.eTipoAviso.Error);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }
            
            rephistorialinspecciones.DataSource = historial_inspecciones;
            rephistorialinspecciones.DataBind();

            cargarDatosDelCentroDeTrabajo();
           
            if (historial_inspecciones.Count > 0)
            {                
                notice.Visible = false;
                buscador.Visible = true;
            }
            else {                
                notice.Visible = true;
                buscador.Visible = false;                
            }

        }

        public void cargarDatosDelCentroDeTrabajo()
        {
            DataSet ds;
            try
            {                
                ds = miComponente.CentroTrabajo_ObtenerDatosPorID(dtoDFT.centro_trabajo_id);                
            }
            catch (Exception ex)
            {
                wucMessageBox.Show("No se pudo conectar con la base de datos intente de nuevo más tarde", wucMessageBox.eTipoAviso.Error);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }

            if (ds.Tables["resultado"].Rows.Count > 0)
            {
                DataRow miRow = ds.Tables[0].Rows[0];

                lbldireccion.InnerText = miRow["ct_domicilio"].ToString();
                dtoDFT.ct_razon_social = lblrazon_social.InnerText = lblrazonsocial.InnerText = miRow["emp_nombre"].ToString();
                dtoDFT.ct_rfc = miRow["emp_rfc"].ToString();
                dtoDFT.ct_nombre = miRow["ct_nombre"].ToString();
                dtoDFT.domicilio = miRow["ct_domicilio"].ToString();
            }
        }

        protected void lbtnRevisar_Click(object sender, CommandEventArgs e)
        {            
            dtoInspeccion.inspeccionid = int.Parse(e.CommandArgument.ToString());            
            Server.Transfer("~/Expedientes/ExpedientesProgramacion.aspx?inspeccion_id=" + dtoInspeccion.inspeccionid);
        }

        protected void lbCentroTrabajo_Click(Object sender, EventArgs e)
        {
            wucCentroTrabajo.CargarCentroTrabajo(dtoDFT,false);
        }

        protected void imgbtnBuscar_Click(object sender, EventArgs e)
        {
            dtoInspeccion.centrotrabajo_id = dtoDFT.centro_trabajo_id;
            dtoInspeccion.numero_expediente = txtBuscar.Text;
            CargarDatos();
        }

        protected void lbRegresar_Click(object sender, CommandEventArgs e)
        {
            Response.Redirect(Request.QueryString["ruta_bread"]);
        }

        protected void drawBreadcrumb(string nombre, string ruta) {
            lbRegresar.Text = nombre;
        }

        protected string revisarResolucion(string resolucion)
        {
            if (resolucion.Trim() == "")
                return "Sin información";
            if (resolucion == "12")
                return "Con Comparecencia";
            if (resolucion == "13")
                return "En Rebeldía";
            if (resolucion == "14")
                return "Por Improcedencia";
            return resolucion;
        }

        protected string revisarSentidoResolucion(string resolucion)
        {
            if (resolucion.Trim() == "")
                return "Sin información";
            if (resolucion == "1")
                return "Condenatoria";
            if (resolucion == "2")
                return "Absolutoria";
            if (resolucion == "3")
                return "Improcedente";
            return resolucion;
        }

        protected string revisarMulta(string sentido_resolucion)
        {
            if (sentido_resolucion == "Sin información")
                return sentido_resolucion;
            if (sentido_resolucion == "Condenatoria")
                return "Sí";
            return "No";
        }


    }
}