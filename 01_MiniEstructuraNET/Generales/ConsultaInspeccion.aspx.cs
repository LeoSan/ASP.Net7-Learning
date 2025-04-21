using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using CompInspeccion;
using ServicioDto = Servicios.DtoS;
using Servicios.ControlUsuarios;
using System.Net;
using Newtonsoft.Json;
using Inspeccion_PA.UserControls;


namespace Inspeccion_PA.Generales
{
    public partial class ConsultaInspeccion : System.Web.UI.Page
    {
        ComponentInsp miComponente = new ComponentInsp();
        protected string msgConexBD = "No se pudo conectar con la base de datos intente de nuevo más tarde";
        int ind_index = 0;
        public string modalCentroTrabajo { get; private set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            modalCentroTrabajo = "";
            if (Session["usrSesion"] == null) Response.Redirect("~/Login/Login.aspx");
            if (!Session["usrLevel"].Equals(4) && !Session["usrLevel"].Equals(2) && !Session["usrLevel"].Equals(3) && !Session["usrLevel"].Equals(6)) Response.Redirect("~/Login/Bienvenida.aspx");

            if (!IsPostBack)
            {
                if (Session["usrLevel"].Equals(2))
                {
                    ltTitulo.Text = "Consulta de inspecciones";
                    trRFC.Visible = false;
                }
                if (Session["usrLevel"].Equals(4))
                    trRFC.Visible = false;


                if (Context.Items["DtoBusqueda"] != null)
                {
                    ViewState["DtoBusqueda"] = Context.Items["DtoBusqueda"];
                    DtoBusqueda midtoB = (DtoBusqueda)ViewState["DtoBusqueda"];
                    String[] info = midtoB.fecha_inicio.Split(' ');
                    String[] info1 = midtoB.fecha_fin.Split(' ');

                    tbRFC.Text = midtoB.rfc;
                    tbNombre.Text = midtoB.nombre_corto;
                    tbExpediente.Text = midtoB.exp_corto;
                    tbFechaDe.Text = info[0];
                    tbFechaA.Text = info1[0];
                    CargarGrid(ind_index, false);
                }

                CargarGrid(ind_index, false);
            }
            navegador.Click += new NumerosCommand(navegador_Click);
        }

        void CargarGrid(int indice_pagina, bool viewModal)
        {
            DataSet ds;
            DtoBusqueda midtoB = new DtoBusqueda();

            if (Session["usrLevel"].Equals(6))
                midtoB.rfc = tbRFC.Text;

            midtoB.exp_corto = tbExpediente.Text;
            if (tbFechaDe.Text != "")
                midtoB.fecha_inicio = tbFechaDe.Text + " 00:00:00.000";
            if (tbFechaA.Text != "")
                midtoB.fecha_fin = tbFechaA.Text + " 23:59:59.999";
            midtoB.nombre_corto = tbNombre.Text;
            if (((DtoUsuario)Session["usrSesion"]).cur_cve_ur.Value != 221 && ((DtoUsuario)Session["usrSesion"]).cur_cve_ur.Value != 513 && ((DtoUsuario)Session["usrSesion"]).cur_cve_ur.Value != 112
                && (((DtoUsuario)Session["usrSesion"]).cur_cve_ur.Value < 116 || ((DtoUsuario)Session["usrSesion"]).cur_cve_ur.Value > 261))
                midtoB.cve_ur = ((DtoUsuario)Session["usrSesion"]).cur_cve_ur.Value;


            
            if (((DtoUsuario)Session["usrSesion"]).cur_cve_ur.Value >= 116 && ((DtoUsuario)Session["usrSesion"]).cur_cve_ur.Value <= 261)
                midtoB.ct_entidad = ((DtoUsuario)Session["usrSesion"]).cen_cve_edorep.Value;

            if(es_Dgift(((DtoUsuario)Session["usrSesion"]).cur_cve_ur.Value))
            {
                midtoB.cve_ur = -1;
                midtoB.ct_entidad = -1;
            }
                

            ViewState["DtoBusqueda"] = midtoB;

            try
            {
                ds = miComponente.Inspeccion_ConsultarEmpresa(midtoB);
            }
            catch (Exception ex)
            {
                wucMessageBox.Show(msgConexBD, wucMessageBox.eTipoAviso.Error);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }

            if (ds.Tables[0].Rows.Count > 0)
                notice.Visible = false;
            else
                notice.Visible = true;

            //PagedDataSource
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = 20;
            pds.DataSource = ds.Tables[0].DefaultView;
            pds.CurrentPageIndex = indice_pagina;

            //Navegador
            navegador.IndicePagina = indice_pagina;
            navegador.NumeroPaginas = pds.PageCount;
            navegador.CargaLinks();

            rptBusqueda.DataSource = pds;
            rptBusqueda.DataMember = "resultado";
            rptBusqueda.DataBind();
            divTablero.Visible = true;
        }

        private bool es_Dgift(int ur)
        {
            bool dgift = false;

               
                DataSet ds1a;
                try
                {
                    ds1a = miComponente.UnidadResp_Obtener(ur, -1);
                }
                catch (Exception ex)
                {
                    wucMessageBox.Show(wucMessageBox.Mensaje(wucMessageBox.eTipoMensaje.Exception), wucMessageBox.eTipoAviso.Error);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return false;
                }

                if (ds1a.Tables["resultado"].Rows.Count > 0)
                {
                    if (ds1a.Tables["resultado"].Rows[0]["cur_descrip_corta"].ToString().Equals("DGIFT"))
                        dgift = true;

                }
            

            return dgift;
        }

        protected void navegador_Click(int indice_pagina)
        {
            CargarGrid(indice_pagina, false);
        }

        public String municipio(String StrMun, String StrEdo)
        {
            DataSet ds;
            short mun, edo;
            short.TryParse(StrMun, out mun);
            short.TryParse(StrEdo, out edo);

            try
            {
                ds = miComponente.Municipios_ObtenerMunicipio(edo, mun);
            }
            catch (Exception ex)
            {
                wucMessageBox.Show(msgConexBD, wucMessageBox.eTipoAviso.Error);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return "";
            }

            if (ds.Tables["resultado"].Rows.Count > 0)
                return ds.Tables["resultado"].Rows[0]["cmu_descripcion"].ToString().ToUpper();
            return "";
        }

        public String estado(String StrEdo)
        {
            DataSet ds;
            short edo;
            short.TryParse(StrEdo, out edo);

            try
            {
                ds = miComponente.Entidades_ObtenerPorId(edo);
            }
            catch (Exception ex)
            {
                wucMessageBox.Show(msgConexBD, wucMessageBox.eTipoAviso.Error);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return "";
            }

            if (ds.Tables["resultado"].Rows.Count > 0)
                return ds.Tables["resultado"].Rows[0]["cen_descripcion"].ToString().ToUpper();
            return "";
        }

        protected void cvNombre_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            if (tbNombre.Text.Length < 4 && tbNombre.Text.Length > 0)
                args.IsValid = false;
        }

        protected void cvRFC_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            if (tbRFC.Text.Length < 9 && tbRFC.Text.Length > 0)
                args.IsValid = false;
        }

        protected void lbExpediente_Click(object sender, CommandEventArgs e)
        {
            DtoBusqueda midtoB = (DtoBusqueda)ViewState["DtoBusqueda"];
            String[] info = e.CommandArgument.ToString().Split('|');
            int.TryParse(info[0], out midtoB.centro_trabajo_id);
            midtoB.nombre = info[1];
            midtoB.domicilio = info[2];

            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/DFT/DFTConsultarExpediente.aspx?id=1");
        }

        protected void lbVer_Click(object sender, CommandEventArgs e)
        {
            DtoBusqueda midtoB = (DtoBusqueda)ViewState["DtoBusqueda"];
            String[] info = e.CommandArgument.ToString().Split('|');
            int.TryParse(info[0], out midtoB.centro_trabajo_id);
            midtoB.nombre = info[1];
            midtoB.domicilio = info[2];
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Response.Redirect("~/Generales/ConsultarHistorialInspeccionesCentroTrabajo.aspx?centro_trabajo_id=" + midtoB.centro_trabajo_id + "&nombre_bread=Seguimiento de inspecciones" + "&ruta_bread=~/Generales/ConsultaInspeccion.aspx");
        }
        protected void btnUltimaISH_Click(object sender, CommandEventArgs e)
        {
            var parametrosInspeccion = e.CommandArgument.ToString().Split('|');
            int inspeccion_id_sh;
            int centro_trabajo_id;
            int.TryParse(parametrosInspeccion[0], out inspeccion_id_sh);
            int.TryParse(parametrosInspeccion[1], out centro_trabajo_id);
            if (inspeccion_id_sh != 0){
                Response.Redirect("~/Expedientes/ExpedientesProgramacion.aspx?inspeccion_id=" + inspeccion_id_sh);
            }
            else
            {
                string materia_acronimo = "SH";
                int inspeccion_id;
                try
                {
                    inspeccion_id = miComponente.Inspeccion_Obtener_Ultima_Por_Materia(centro_trabajo_id, materia_acronimo);
                    if (inspeccion_id != 0){
                        Response.Redirect("~/Expedientes/ExpedientesProgramacion.aspx?inspeccion_id=" + inspeccion_id + "&seguimientoInspeccion=1");
                    }
                    else{
                        wucMessageBox.Show("La información histórica de este expediente no existe en la plataforma.", wucMessageBox.eTipoAviso.Mensaje);
                    }
                }
                catch (Exception ex)
                {
                    wucMessageBox.Show(msgConexBD, wucMessageBox.eTipoAviso.Error,ex.Message);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                }
                
            }
            
        }
        protected void btnUltimaICGT_Click(object sender, CommandEventArgs e)
        {
            var parametrosInspeccion = e.CommandArgument.ToString().Split('|');
            int inspeccion_id_cgt;
            int centro_trabajo_id;
            int.TryParse(parametrosInspeccion[0], out inspeccion_id_cgt);
            int.TryParse(parametrosInspeccion[1], out centro_trabajo_id);
            if (inspeccion_id_cgt != 0)
            {
                Response.Redirect("~/Expedientes/ExpedientesProgramacion.aspx?inspeccion_id=" + inspeccion_id_cgt);
            }
            else
            {
                string materia_acronimo = "CGT";
                int inspeccion_id;
                try
                {
                    inspeccion_id = miComponente.Inspeccion_Obtener_Ultima_Por_Materia(centro_trabajo_id, materia_acronimo);
                    if (inspeccion_id != 0){
                        Response.Redirect("~/Expedientes/ExpedientesProgramacion.aspx?inspeccion_id=" + inspeccion_id + "&seguimientoInspeccion=1");
                    }
                    else{
                        wucMessageBox.Show("La información histórica de este expediente no existe en la plataforma.", wucMessageBox.eTipoAviso.Mensaje);
                    }
                }
                catch (Exception ex)
                {
                    wucMessageBox.Show(msgConexBD, wucMessageBox.eTipoAviso.Error, ex.Message);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                }

            }
        }
        protected void btnUltimaICA_Click(object sender, CommandEventArgs e)
        {
            var parametrosInspeccion = e.CommandArgument.ToString().Split('|');
            int inspeccion_id_ca;
            int centro_trabajo_id;
            int.TryParse(parametrosInspeccion[0], out inspeccion_id_ca);
            int.TryParse(parametrosInspeccion[1], out centro_trabajo_id);
            if (inspeccion_id_ca != 0)
            {
                Response.Redirect("~/Expedientes/ExpedientesProgramacion.aspx?inspeccion_id=" + inspeccion_id_ca);
            }
            else
            {
                string materia_acronimo = "CA";
                int inspeccion_id;
                try
                {
                    inspeccion_id = miComponente.Inspeccion_Obtener_Ultima_Por_Materia(centro_trabajo_id, materia_acronimo);
                    if (inspeccion_id != 0){
                        Response.Redirect("~/Expedientes/ExpedientesProgramacion.aspx?inspeccion_id=" + inspeccion_id + "&seguimientoInspeccion=1");
                    }
                    else{
                        wucMessageBox.Show("La información histórica de este expediente no existe en la plataforma.", wucMessageBox.eTipoAviso.Mensaje);
                    }
                }
                catch (Exception ex)
                {
                    wucMessageBox.Show(msgConexBD, wucMessageBox.eTipoAviso.Error, ex.Message);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                }

            }
        }


        protected void btnBusqueda_Click(object sender, EventArgs e)
        {
            divBusqueda.Visible = !(divAvanzada.Visible = true);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            if (Session["usrLevel"].Equals(6) && (tbNombre.Text == "" && tbExpediente.Text == "" && tbFechaDe.Text == "" && tbFechaA.Text == "" && tbRFC.Text == "") ||
                !Session["usrLevel"].Equals(6) && (tbNombre.Text == "" && tbExpediente.Text == "" && tbFechaDe.Text == "" && tbFechaA.Text == ""))
                wucMessageBox.Show("Seleccione una opción de consulta", wucMessageBox.eTipoAviso.Mensaje);
            else
                CargarGrid(ind_index, false);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login/Bienvenida.aspx");
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {

        }
        protected void ibtnConsultar_Click(object sender, CommandEventArgs e)
        {
            String[] info = e.CommandArgument.ToString().Split('|');
            DtoDFT dtoDFT = new DtoDFT();
            int.TryParse(info[0], out dtoDFT.centro_trabajo_id);
            dtoDFT.ct_razon_social = info[1];
            dtoDFT.domicilio = info[2];
            dtoDFT.ct_rfc = info[3];
            dtoDFT.name_breadcrumb = "Consulta";
            dtoDFT.url_breadcrumb = "~/Generales/ConsultaInspeccion.aspx";

            wucCentroTrabajo.CargarCentroTrabajo(dtoDFT, true);
        }
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Generales/ConsultaInspeccion.aspx");
        }
    }
}