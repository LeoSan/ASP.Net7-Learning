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
    public partial class ConsultaDatosCalificacion : System.Web.UI.Page
    {
        ComponentInsp miComponente = new ComponentInsp();

        DtoBusqueda dtoBusqueda
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
            if (!Session["usrLevel"].Equals(4) && !Session["usrLevel"].Equals(2) && !Session["usrLevel"].Equals(6) && !Session["usrLevel"].Equals(3)) Response.Redirect("~/Login/Bienvenida.aspx");

            if (!IsPostBack)
            {
              
                if (Context.Items["DtoBusqueda"] != null)
                    {
                        ViewState["DtoBusqueda"] = Context.Items["DtoBusqueda"];
                        if (dtoBusqueda.in_etapa == 5)
                        {
                            EsconderTr();
                            ltTitulo.Text = "Datos de la asignación de la calificación ";
                            ltNomFecha.Text = "Fecha de Asignación:";
                            btnMedidas.Text = "Medidas";

                        }
                        if (dtoBusqueda.in_etapa == 6)
                        {
                            if (dtoBusqueda.tipo_documento_id == 14 || dtoBusqueda.tipo_documento_id == 15)// || dtoBusqueda.tipo_documento_id == 12)
                            {
                                btnMedidas.Text = "Violaciones";
                                ActivarTR(true);
                            }
                            else 
                            {
                                if (dtoBusqueda.tipo_documento_id == 10 || dtoBusqueda.tipo_documento_id == 11 || dtoBusqueda.tipo_documento_id == 12 || dtoBusqueda.tipo_documento_id == -1)
                                {
                                    btnMedidas.Visible = false;
                                }
                            }
                           
                                ltTitulo.Text = "Datos de la calificación";
                                ltNomFecha.Text = "Fecha de calificación:";
                            }



                        CargarTablero();
                    }
                }
            

        }

        protected void btnMedidas_Click(object sender, EventArgs e)
        {
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaMedidasViolaciones.aspx");
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaInspeccionEtapas.aspx");
        }

        void EsconderTr() 
        {
            tr1.Visible = tr2.Visible = tr3.Visible = tr4.Visible = tr5.Visible = tr6.Visible =
            tr7.Visible = tr8.Visible  = tr11.Visible = btnMedidas.Visible = false;
         }

        void ActivarTR(bool value)
        {
            //Escrito de comparecencia
        tr17.Visible = tr16.Visible = tr15.Visible = tr14.Visible = tr13.Visible = tr12.Visible = value;
        tr19.Visible = tr20.Visible = tr21.Visible = true;
        }

        void CargarTablero()
        {
            int desahogo_id = -1;
            int calif_documento_id = -1;
            cargarInspeccion();

           desahogo_id =  cargarDesahogo();
           dtoBusqueda.calificacion_id = cargarCalificacion(desahogo_id);
            
           if (dtoBusqueda.in_etapa == 6)
           {
               calif_documento_id = cargarCalificacionDocumento(dtoBusqueda.calificacion_id);
               cargarCopias(calif_documento_id);
           }
        
        }

        void cargarInspeccion() 
        {

            DataSet ds;
            DtoInspeccion dtoI = new DtoInspeccion();
            dtoI.inspeccion_id = dtoBusqueda.inspeccion_id;
            DateTime fec_inspeccion;
            try
            {
                ds = miComponente.Inspeccion_Obtener(dtoI);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }

            if (ds.Tables["resultado"].Rows.Count > 0)
            {
                DataRow miRow = ds.Tables[0].Rows[0];
                ltNombre.Text = miRow["in_ct_razon_social"].ToString();
                ltDomicilio.Text = miRow["in_domicilio_inspeccion"].ToString();

                if (!String.IsNullOrEmpty(miRow["in_fec_inspeccion"].ToString()))
                {
                    DateTime.TryParse(miRow["in_fec_inspeccion"].ToString(), out fec_inspeccion);
                    ltFechaInsp.Text = fec_inspeccion.ToShortDateString() + " Hora: " + fec_inspeccion.ToShortTimeString();
                }

                ltNumExp.Text = miRow["in_num_expediente"].ToString();
                ltSubtipoAct.Text = miRow["stins_subtipo"].ToString();
                ltMateria.Text = miRow["mat_materia"].ToString();
            }
        
        
        }

        public int cargarDesahogo()
        {
            DataSet ds;
            int valor = -1;
            DtoDesahogo dtoD = new DtoDesahogo();
            dtoD.inspeccion_id = dtoBusqueda.inspeccion_id;

            try
            {
                ds = miComponente.Desahogo_Obtener(dtoD);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return -1;
            }

            if (ds.Tables["resultado"].Rows.Count > 0)
            {
                DataRow miRow = ds.Tables[0].Rows[0];
                int.TryParse(miRow["desahogo_id"].ToString(), out valor);
            }

            return valor;
        }

        public int cargarCalificacion(int desahogo_id)
        {
            DataSet ds;
            DateTime fec_calif = new DateTime();
            DateTime fec_acuse = new DateTime();
            DtoCalificacion dtoCalif = new DtoCalificacion();
            dtoCalif.desahogo_id = desahogo_id;
 

            try
            {
               ds =  miComponente.Calificacion_ConsultarPorParticipante(dtoCalif);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return -1;
            }

            if (ds.Tables["resultado"].Rows.Count > 0)
            {
                DataRow miRow = ds.Tables[0].Rows[0];
                int.TryParse( miRow["calificacion_id"].ToString(), out dtoBusqueda.calificacion_id);

                ltNombreDic.Text = miRow["nombre_dictaminador"].ToString();

                if (ltNomFecha.Text == "Fecha de calificación:")
                {
                    if (!String.IsNullOrEmpty(miRow["calif_fec_calificacion"].ToString()))
                    {
                        DateTime.TryParse(miRow["calif_fec_calificacion"].ToString(), out fec_calif);
                        ltFechaCal.Text = fec_calif.ToShortDateString() + " Hora: " + fec_calif.ToShortTimeString();

                    }
                }
                else 
                {
                    if (!String.IsNullOrEmpty(miRow["calif_fec_asignacion"].ToString()))
                    {
                        DateTime.TryParse(miRow["calif_fec_asignacion"].ToString(), out fec_calif);
                        ltFechaCal.Text = fec_calif.ToShortDateString() + " Hora: " + fec_calif.ToShortTimeString();

                    }
                
                
                }

                if (dtoBusqueda.tipo_documento_id == 14 || dtoBusqueda.tipo_documento_id == 15 || dtoBusqueda.tipo_documento_id == 12)
                {

                    DateTime.TryParse(miRow["calif_fec_recibio_escrito"].ToString(), out fec_acuse);
                    ltRecibioEscrito.Text = (miRow["calif_se_recibio_escrito"].ToString() == "1" ? "Sí" : "No");
                    ltDentrodelPlazo.Text = (miRow["calif_escrito_dentro_plazo"].ToString() == "1" ? "Sí" : "No");
                    ltFechadeAcuse.Text = fec_acuse.ToShortDateString();
                    ltNodeFojas.Text = (miRow["calif_num_fojas"].ToString() != "" ? miRow["calif_num_fojas"].ToString() : "0");
                    ltAcreditaPersonalidad.Text = (miRow["calif_acredita_personalidad"].ToString() == "1" ? "Sí" : "No");
                    ltSolventaViolaciones.Text = (miRow["calif_solventa_violaciones"].ToString() == "1" ? "Sí" : "No");
                   
                    if (dtoBusqueda.in_etapa == 5 && ltRecibioEscrito.Text == "No")
                        ActivarTR(false);
                }
             }

            return dtoBusqueda.calificacion_id; 
        }

        public int cargarCalificacionDocumento(int calificacion_id)
        {
            int value = -1;
            DateTime fec_doc;
            DataSet ds;
            DtoCalifDocumento dtoCalifdoc = new DtoCalifDocumento();
            dtoCalifdoc.calificacion_id = calificacion_id;
            dtoCalifdoc.tipo_documento_id = dtoBusqueda.tipo_documento_id;
            try
            {
                ds = miComponente.CalifDocumento_Consultar(dtoCalifdoc);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return -1;
            }

            if (ds.Tables["resultado"].Rows.Count > 0)
            {
                DataRow miRow = ds.Tables[0].Rows[0];
                ltDocEmitido.Text = miRow["cdoc_nombre_documento"].ToString();
                ltNumero.Text = miRow["cdoc_num_documento"].ToString();

                if (!String.IsNullOrEmpty(miRow["cdoc_fec_documento"].ToString()))
                {
                    DateTime.TryParse(miRow["cdoc_fec_documento"].ToString(), out fec_doc);
                    ltFechaDoc.Text = fec_doc.ToShortDateString();
                }

                ltFirmoTitular.Text = (miRow["cdoc_firma_titular"].ToString() == "1" ? "Sí" : "No");
                ltFirmante.Text = miRow["cdoc_firmante"].ToString();
                ltCargo.Text = miRow["cdoc_puesto"].ToString();
                ltObs.Text = miRow["cdoc_observaciones"].ToString();
                int.TryParse(miRow["calif_documento_id"].ToString(), out  value);
                int.TryParse(miRow["participante_juridico_id"].ToString(), out  dtoBusqueda.participante_id);
            }

            return value;
        
        }

        void cargarCopias(int calif_documento_id) 
        {
            DataSet ds;
            
            try
            {
                ds = miComponente.CalifDoctoCopias_Consultar(calif_documento_id, -1);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }

            
            foreach (DataRow miRow in ds.Tables["resultado"].Rows)
            {
                if (miRow["cdc_copia_o_rubrica"].ToString() == "1")
                {
                    ltCopias.Text += miRow["cdc_nombre"].ToString() + "<br>";
                 }
                else
                    ltRubricas.Text += miRow["cdc_nombre"].ToString() + "<br>";

            }

            ltCopias.Text = (ltCopias.Text == "" ?  "No cuenta" :  ltCopias.Text);
            ltRubricas.Text = (ltRubricas.Text == "" ? "No cuenta" : ltCopias.Text);


            cargarCalifVariables(calif_documento_id);
    
        }


        void cargarCalifVariables(int calif_documento_id)
        {
            DataSet ds;
            
           DtoParticipante dtopar = new DtoParticipante();
           dtopar.participante_id = dtoBusqueda.participante_id;
           //dtopar.par_es_resp_juridico = 1;
           //dtopar.cve_ur = dtoBusqueda.cve_ur;
            //try
            //{
            //    ds = miComponente.CalifVariables_Obtener(calif_documento_id);
            //}
            //catch (Exception ex)
            //{
            //    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
            //    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
            //    return;
            //}
            //if (ds.Tables["resultado"].Rows.Count > 0)
            //{
            //    DataRow miRow = ds.Tables[0].Rows[0];
            //    ltNombreResp.Text = miRow["responsable_juridico"].ToString();
            //    ltAreaJuridica.Text = miRow["area_juridica"].ToString();
            //    ltPuesto.Text = miRow["cargo_responsable_juridico"].ToString();
            //}

           try
           {
               ds = miComponente.Participante_Obtener(dtopar);
           }
           catch (Exception ex)
           {
               utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
               utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
               return;
           }
           if (ds.Tables["resultado"].Rows.Count > 0)
           {
               DataRow miRow = ds.Tables[0].Rows[0];
               ltNombreResp.Text = miRow["par_nombre"].ToString() + " " + miRow["par_primer_apellido"].ToString() + " " + miRow["par_segundo_apellido"].ToString();
               ltAreaJuridica.Text = miRow["par_area_juridica"].ToString();
               ltPuesto.Text = miRow["par_puesto"].ToString();
           }
           else 
           {
               tr19.Visible = false;
               tr20.Visible = false;
               tr21.Visible = false;
           }

           dtoBusqueda.participante_id = -1;
        
        }


    }
}