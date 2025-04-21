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
    public partial class ConsultaNotificacion : System.Web.UI.Page
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

        public void ObtenerDatos()
        {
            DtoBusqueda busqueda = (DtoBusqueda)ViewState["DtoBusqueda"];
            int etapa = busqueda.in_etapa;
            DataSet ds;
            DataTable dt= new DataTable();
            DateTime fec;
            
            switch(etapa)
            {
                case 2://asignación de la notificación 
                    divAsignar.Visible = true;
                    divRegistrar.Visible = false;
                    ltTitulo.Text = "Datos de la asignación de la notificación";
                    try
                    {
                        ds = miComponente.Notificacion_ObtenerPorEtapa(busqueda.inspeccion_id, -1);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }
                    
                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dt = ds.Tables["resultado"].Clone();
                        ds.Tables["resultado"].Select("tipo_documento_id="+ busqueda.tipo_documento_id.ToString()).CopyToDataTable(dt, LoadOption.OverwriteChanges);
                        DataRow row = dt.Rows[0];
                        ltNombre.Text = row["emp_nombre"].ToString();
                        ltDomicilio.Text = row["dom"].ToString();
                        DateTime.TryParse(row["in_fec_inspeccion"].ToString(), out fec);
                        ltFecInsp.Text = fec.ToShortDateString() + " Hora: " + fec.ToShortTimeString();
                        ltNumExp.Text = row["in_num_expediente"].ToString();
                        ltSubTipoAct.Text = row["stins_subtipo"].ToString();
                        ltMateria.Text = row["mat_materia"].ToString();
                        ltTipoDoc.Text = row["td_tipo_documento"].ToString();
                        ltFormaEntrega.Text = row["notif_forma_entrega"].ToString().Equals("1") ? "Notificación" : "Correo certificado";
                        

                        if (row["notif_estatus_asignacion"].ToString().Equals("2"))
                        {
                            //2	Citatorio
                            if (row["tipo_documento_id"].ToString().Equals("2"))
                                ltFecLimiteEntrega.Text = ((DateTime)Generales.getFechaEnXDiasHabiles(fec, 1)).ToShortDateString();
                            //10	Acuerdo de reprogramación
                            if (row["tipo_documento_id"].ToString().Equals("10"))
                                ltFecLimiteEntrega.Text = ((DateTime)Generales.getFechaEnXDiasHabiles2(fec, 10)).ToShortDateString();

                            //13	Emplazamiento de medidas
                            if (row["tipo_documento_id"].ToString().Equals("13"))
                                ltFecLimiteEntrega.Text = ((DateTime)Generales.getFechaEnXDiasHabiles2(fec, 10)).ToShortDateString();
                                                                //// 1 orden de inspección para la prueba
                                                                //if (row["tipo_documento_id"].ToString().Equals("1"))
                                                                //    ltFecLimiteEntrega.Text = ((DateTime)Generales.getFechaEnXDiasHabiles2(fec, 10)).ToShortDateString();
                            //9	Ampliación de término	Correo certificado
                            if (row["tipo_documento_id"].ToString().Equals("9"))
                                ltFecLimiteEntrega.Text = ((DateTime)Generales.getFechaEnXDiasHabiles2(fec, 10)).ToShortDateString();
                            //11	Acuerdo de archivo	Correo certificado
                            if (row["tipo_documento_id"].ToString().Equals("11"))
                                ltFecLimiteEntrega.Text = ((DateTime)Generales.getFechaEnXDiasHabiles2(fec, 10)).ToShortDateString();
                            //12	Acuerdo de terminación	Correo certificado
                            if (row["tipo_documento_id"].ToString().Equals("12"))
                                ltFecLimiteEntrega.Text = ((DateTime)Generales.getFechaEnXDiasHabiles2(fec, 10)).ToShortDateString();

                        }
                        else
                        {
                            if (row["notif_fec_limite_entrega"].ToString() != "") ltFecLimiteEntrega.Text = row["notif_fec_limite_entrega"].ToString().Substring(0, 10);
                        }


                        ltNombreNotificador.Text = row["Notificador"].ToString();
                        if (!row["notif_fec_entrega_programada"].ToString().Equals("")) ltFecProgramada.Text = row["notif_fec_entrega_programada"].ToString().Substring(0, 10);
                        

                    }


                    break;
                case 3://registro de notificación
                    divAsignar.Visible = false;
                    divRegistrar.Visible = true;
                    ltTitulo.Text = "Datos de la entrega de la notificación ";
                    try
                    {
                        ds = miComponente.Notificacion_ObtenerPorEtapa(busqueda.inspeccion_id, -1);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dt = ds.Tables["resultado"].Clone();
                        ds.Tables["resultado"].Select("tipo_documento_id=" + busqueda.tipo_documento_id.ToString()).CopyToDataTable(dt, LoadOption.OverwriteChanges);
                        DataRow row = dt.Rows[0];

                        ltNombre2.Text = row["emp_nombre"].ToString();
                        ltDomicilio2.Text = row["dom"].ToString();
                        DateTime.TryParse(row["in_fec_inspeccion"].ToString(), out fec);
                        ltFecInsp2.Text = fec.ToShortDateString() + " Hora: " + fec.ToShortTimeString();
                        ltNumExp2.Text = row["in_num_expediente"].ToString();
                        ltSubTipoAct2.Text = row["stins_subtipo"].ToString();
                        ltMateria2.Text = row["mat_materia"].ToString();
                        ltNombreNotificador2.Text = row["Notificador"].ToString();
                        if (row["notif_se_recibio"].ToString().Equals("1"))
                        {
                            ltRecibio.Text = "Sí";
                            tblRegistrar.Rows[11].Visible = false;
                            tblRegistrar.Rows[12].Visible = false;
                            tblRegistrar.Rows[13].Visible = true;
                            tblRegistrar.Rows[14].Visible = true;
                            tblRegistrar.Rows[15].Visible = true;
                            tblRegistrar.Rows[16].Visible = true;
                        }
                        else
                        {
                            ltRecibio.Text = "No";
                            tblRegistrar.Rows[11].Visible = true;
                            tblRegistrar.Rows[12].Visible = true;
                            tblRegistrar.Rows[13].Visible = false;
                            tblRegistrar.Rows[14].Visible = false;
                            tblRegistrar.Rows[15].Visible = false;
                            tblRegistrar.Rows[16].Visible = false;
                        }

                        ltSeDejo.Text = row["notif_quedo_pegado"].ToString().Equals("1")?"Sí":"No";


                        ltMotivoDejo.Text = row["motivo_no_entrega"].ToString();
                        ltFormaCons.Text = row["forma_constatacion"].ToString();
                        
                        DateTime.TryParse(row["notif_fec_entrega"].ToString(), out fec);
                        ltFecEntrega.Text = fec.ToShortDateString() +" Hora: "+ fec.ToShortTimeString();

                        ltNombreRecibio.Text = row["notif_nombre_recibio"].ToString();
                        ltDijoSer.Text = row["notif_dijo_ser"].ToString(); ;
                        ltObservaciones.Text = row["notif_observaciones"].ToString();
                    }
                    break;

            }
            


        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaInspeccionEtapas.aspx");
        }

        protected void btnCancelar2_Click(object sender, EventArgs e)
        {
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaInspeccionEtapas.aspx");
        }



    }
}