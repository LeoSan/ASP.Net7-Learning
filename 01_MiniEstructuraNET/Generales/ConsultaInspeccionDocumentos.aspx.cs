using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CompInspeccion;
using System.Data;
using Aspose.Words;
using Aspose.Words.Saving;
using Aspose.Words.Reporting;
using System.Collections;
namespace Inspeccion_PA.Generales
{
    public partial class ConsultaInspeccionDocumentos : System.Web.UI.Page
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

            if (!IsPostBack)
            {

                if (Context.Items["DtoBusqueda"] != null)
                {
                    midtoB = Context.Items["DtoBusqueda"] as DtoBusqueda;
                    if (midtoB.desahogo_id <= 0) btnAdjuntar.Visible = false;
                    ObtenerDatos();
                }
            }
        }

        void ObtenerDatos()
        {
            DataSet ds;
            ltnombre.Text = midtoB.nombre;
            try
            {
                ds = miComponente.TipoInspeccion_ObtenerPorIdSubtipo(midtoB.subtipo_inspeccion_id);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }
            foreach (DataRow row in ds.Tables["resultado"].Rows)
            {
                int.TryParse(row["tipo_inspeccion_id"].ToString(), out midtoB.tipo_inspeccion_id);
            }


            if (midtoB.tipo_inspeccion_id == 1)
                lttipo.Text = "Ordinaria";
            if (midtoB.tipo_inspeccion_id == 4)
                lttipo.Text = "Extraordinaria";
            ltsubtipo.Text = midtoB.subtipo;
            ltmateria.Text = midtoB.materia;
            ltfecha.Text = midtoB.fec_inspeccion;
            ltnumexpediente.Text = midtoB.num_expediente;
            CargarGrid();
        }

        void CargarGrid()
        {
            DataSet ds;


            try
            {
                // Se modificó el procedimiento - se quitan los rangos en etapas de inspeccion para los documentos del desahogo
                ds = miComponente.TodosDocumentos_ConsultarPorInspeccion(midtoB.inspeccion_id);
            }
            catch (Exception ex)
            {
                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return;
            }

            rptDocumentos.DataSource = ds;
            rptDocumentos.DataMember = "resultado";
            rptDocumentos.DataBind();

            rptDocumentosOtros.DataSource = ds.Tables[1];
            rptDocumentosOtros.DataBind();
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaInspeccionCentroTrabajo.aspx");
        }
        //***convertir romanos
        public string ConvertirARomano(int numero)
        {
            int ones, tens, hundreds;
            string num = "";
            string[] r_ones = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] r_tens = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] r_hund = { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            ones = numero % 10;
            tens = (numero - ones) % 100;
            hundreds = (numero - tens - ones) % 1000;
            tens = tens / 10;
            hundreds = hundreds / 100;
            if (hundreds != 0) { num = num + r_hund[hundreds - 1]; }
            if (tens != 0) { num = num + r_tens[tens - 1]; }
            if (ones != 0) { num = num + r_ones[ones - 1]; }
            return num;
        }
        protected void lbdescarga_Click(object sender, CommandEventArgs e)
        {

            int documento_id, tipo, numseccion, desahogo = 0;
            string plantilla;
            String[] info = e.CommandArgument.ToString().Split('|');
            int.TryParse(info[0], out documento_id);
            int.TryParse(info[1], out tipo);
            plantilla = info[2];
            int.TryParse(info[3], out midtoB.calificacion_id);
            int.TryParse(info[4], out midtoB.emplazamiento_id);
            string midocumento_id = e.CommandName.ToString();
            //los documentos de inspección
            #region documentos_inspeccion
            if (tipo >= 1 && tipo < 5)
            {
                DataTable dtsubmaterias = new DataTable();
                DtoInspeccion miinspeccion = new DtoInspeccion();
                Document doc = new Document();
                switch (tipo)
                {
                    case 1:
                        {
                            Context.Items["documento_id"] = documento_id;
                            miinspeccion.inspeccion_id = midtoB.inspeccion_id;
                            miinspeccion.subtipo_inspeccion_id = midtoB.subtipo_inspeccion_id;
                            miinspeccion.operativo_id = midtoB.operativo_id;
                            miinspeccion.materia_id = midtoB.materia_id;
                            Context.Items["materia"] = midtoB.materia;
                            Context.Items["DtoInspeccion"] = miinspeccion;
                            Context.Items["td_url_plantilla"] = plantilla;
                            Server.Transfer("~/DFT/DFTObtenerDocumentoOrdenInspeccion.aspx");
                            // doc = new Document(Server.MapPath("~/Uploads/Plantillas/Orden_inspeccion.doc"));
                            break;
                        }
                    default:
                        doc = new Document(Server.MapPath(plantilla));
                        break;
                }

                DtoDoctoBusqueda dtoBusqueda = new DtoDoctoBusqueda();
                DataSet ds;

                dtoBusqueda.documento_id = documento_id;
                try
                {
                    ds = miComponente.DoctoVariableValores_Obtener(dtoBusqueda);
                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }


                foreach (DataRow row in ds.Tables["resultado"].Rows)
                {

                    doc.MailMerge.Execute(
                            new string[] {
                        row["var_variable"].ToString()

                    },
                            new object[] {
                         row["dv_valor"].ToString()
                    });
                }

                if (tipo == 3)
                {
                    numseccion = 4;
                    char car = '\n';
                    try
                    {
                        if (midtoB.operativo_id != -1 && midtoB.operativo_id != 0)
                        {
                            ds = miComponente.SubmateriaIndicador_ObtenerParaDoctoConOperativo(midtoB.inspeccion_id, -1, midtoB.operativo_id);
                        }
                        else
                            ds = miComponente.SubmateriaIndicador_ObtenerParaDocto(midtoB.inspeccion_id, -1);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }
                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dtsubmaterias = ds.Tables["resultado"];
                        dtsubmaterias.Columns.Add("i_index");
                        //dtsubmaterias.AcceptChanges();
                    }
                    foreach (DataRow row in ds.Tables["resultado"].Rows)
                    {
                        row["i_index"] = ConvertirARomano(numseccion);
                        row["alcance_indicador"] = row["alcance_indicador"].ToString().Replace('|', car);
                        numseccion++;
                    }

                    dtsubmaterias.TableName = "submaterias";
                    doc.MailMerge.ExecuteWithRegions(dtsubmaterias);
                }

                try
                {
                    ds = miComponente.DoctoParrafoTexto_Obtener(dtoBusqueda);
                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }

                Hashtable mihash = new Hashtable();

                for (int i = 0; i < doc.Range.Bookmarks.Count; i++)
                {

                    mihash.Add(doc.Range.Bookmarks[i].Name, doc.Range.Bookmarks[i].Name);

                }

                foreach (DataRow row in ds.Tables["resultado1"].Rows)
                {

                    if (mihash.ContainsKey(row["variablesintags"].ToString()))
                    {

                        Bookmark bookmark = doc.Range.Bookmarks[row["variablesintags"].ToString()];
                        bookmark.Text = row["parrafovariables_replace"].ToString();

                    }

                }

                String id_inspeccion_ca = String.Format("{0:000}", midtoB.inspeccion_id.ToString());

                if (id_inspeccion_ca.Length == 6)
                {
                    id_inspeccion_ca = "0000" + id_inspeccion_ca;
                }
                if (id_inspeccion_ca.Length == 7)
                {
                    id_inspeccion_ca = "000" + id_inspeccion_ca;
                }
                if (id_inspeccion_ca.Length == 8)
                {
                    id_inspeccion_ca = "00" + id_inspeccion_ca;
                }
                if (id_inspeccion_ca.Length == 9)
                {
                    id_inspeccion_ca = "0" + id_inspeccion_ca;
                }

                int a;

                int.TryParse(id_inspeccion_ca, out a);



                String caracteres_autenticidad = utilerias.CryptoLibrerias.Cripto.EncriptarCadena(id_inspeccion_ca);
                //String desencriptada = utilerias.CryptoLibrerias.Cripto.DesEncriptarCadena(encriptado);



                string[] variable_ca = new string[2];
                string[] valor_ca = new string[2];

                variable_ca[0] = "<CARACTERES_AUTENCIDAD>";
                valor_ca[0] = caracteres_autenticidad;

                variable_ca[1] = "<TELEFONOS_UR>";

                int cve_ur_inspeccion = obtenerCVEURInspeccion(midtoB.inspeccion_id);

                valor_ca[1] = ((DataSet)(miComponente.CatalogoUnidadResp_BuscarPorUR(cve_ur_inspeccion))).Tables["resultado"].Rows[0]["ur_telefono"].ToString();

                doc.MailMerge.Execute(variable_ca, valor_ca);


                switch (tipo)
                {
                    case 1:
                        //doc.Save("Orden_inspeccion.doc", SaveFormat.Doc, SaveType.OpenInWord, Response);
                        doc.Save(Response, "Orden_inspeccion.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                    case 2:
                        //doc.Save("Citatorio.doc", SaveFormat.Doc, SaveType.OpenInWord, Response);
                        doc.Save(Response, "Citatorio.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                    case 3:
                        //doc.Save("ListadoAnexo.doc", SaveFormat.Doc, SaveType.OpenInWord, Response);
                        doc.Save(Response, "ListadoAnexo.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                    case 4:
                        //doc.Save("GuiaDerechos.doc", SaveFormat.Doc, SaveType.OpenInWord, Response);
                        doc.Save(Response, "GuiaDerechos.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                }
            }
            #endregion
            //los documentos de desahogo
            #region documentos_desahogo
            if (tipo >= 5 && tipo < 9)
            {

                DtoDesahogo mides = new DtoDesahogo();
                DataSet ds = null;
                mides.inspeccion_id = midtoB.inspeccion_id;
                try
                {
                    ds = miComponente.Desahogo_Obtener(mides);
                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }
                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow miRow = ds.Tables[0].Rows[0];
                    int.TryParse(miRow["desahogo_id"].ToString(), out desahogo);

                }
                DtoDshgo miDtoD = new DtoDshgo();
                miDtoD.desahogo_id = desahogo;
                midtoB.desahogo_id = desahogo;
                miDtoD.inspeccion_id = midtoB.inspeccion_id;
                miDtoD.materia_id = midtoB.materia_id;
                miDtoD.materia = midtoB.materia;
                miDtoD.subtipo_inspeccion_id = midtoB.subtipo_inspeccion_id;
                if (tipo == 6)
                {
                    Context.Items["dshgodocumento_id"] = documento_id;
                    Context.Items["td_url_plantilla"] = plantilla;
                    Context.Items["DtoDshgo"] = miDtoD;
                    Server.Transfer("~/Inspector/InspectorDesahogoObtenerDocumentoInformeComision.aspx");
                }
                else
                {
                    //Docto Ariana :)
                    if (tipo == 18)
                    {
                        miDtoD.materia_id = midtoB.materia_id;
                        Context.Items["DtoDshgo"] = miDtoD;
                        Server.Transfer("~/Inspector/InspectorDesahogoResumenDatosXLS.aspx");
                    }

                    int numinsp = 0;
                    int id = 0;
                    bool no_identifica = false;
                    String identifica = String.Empty;
                    String identifica1 = String.Empty;
                    String motivo_no = String.Empty;
                    DataTable dtDshgoInspectores = new DataTable();
                    DataTable dtDshgoExpertos = new DataTable();
                    DataTable dtDshgoExpertosFirma = new DataTable();
                    DataTable dtDshgoInspectoresFirma = new DataTable();
                    DataTable dtRepEmp = new DataTable();
                    DataTable dtIdent = new DataTable();
                    DataTable dtRepTrab = new DataTable();
                    DataTable dtIdent2 = new DataTable();
                    DataTable dtTestigo1 = new DataTable();
                    DataTable dtTestigo2 = new DataTable();
                    DataTable dtDshgoInterrogados = new DataTable();
                    DataTable dtDshgoListadoPactivo = new DataTable();
                    DataTable dtListado = new DataTable();
                    DataTable dtDshgoInterrogadoFirma = new DataTable();
                    DataTable dtComisionEmp = new DataTable();
                    DataTable dtComisionTrab = new DataTable();

                    DataTable dtRevisionDocumental = new DataTable();
                    DataTable dtMedidas = new DataTable();
                    DataTable dtMedidasParaCM = new DataTable();

                    DataTable dtMedidasNoAdmin = new DataTable();
                    DataTable dtMedidasNoAdmin1 = new DataTable();

                    DataSet dset = new DataSet();
                    DataTable tabla1 = new DataTable(); //alcance(submaterias)
                    DataTable tabla2 = new DataTable(); //revisión documental



                    DataTable dtRepTrabFirma = new DataTable();
                    DataTable dtRepEmpFirma = new DataTable();
                    DataTable dtComisionEmpFirma = new DataTable();
                    DataTable dtComisionTrabFirma = new DataTable();



                    DataTable dtseccion3 = new DataTable();

                    //trabajadores detalles
                    DataTable dtTrabDetalles = new DataTable();
                    DataTable dtseccion4 = new DataTable();
                    DataTable dtseccion5 = new DataTable();


                    DataTable dtseccion6 = new DataTable();
                    DataTable dtseccion7 = new DataTable();
                    DataTable dtseccion8 = new DataTable();
                    DataTable dtseccion9 = new DataTable();
                    DataTable dtseccion10 = new DataTable();

                    DataTable dtsubmateriasCGT = new DataTable();
                    DataTable dtrevisionCGT = new DataTable();
                    DataTable dtsubmatMedidasA = new DataTable();
                    DataTable dtMedidasAdmin1 = new DataTable();
                    DataTable dtMedidas1 = new DataTable();
                    DataTable dtMedidas2 = new DataTable();
                    DataTable dtMedidasAp1 = new DataTable();
                    DataTable dtMedidasAp2 = new DataTable();
                    DataTable dtsubmateriasCM = new DataTable();
                    DataTable dtmedidasAdmCM = new DataTable();

                    DataTable dtMedidasRecorridoCM = new DataTable();
                    DataTable dtMedidasRecorridoCM1 = new DataTable();

                    DataTable dtTipoParticipante = new DataTable();
                    DataTable dtManifiestaTestigo = new DataTable();
                    DataTable dtManifiestaRepEmpresa = new DataTable();
                    DataTable dtManifiestaRepTrabajadores = new DataTable();
                    DataTable dtManifiestaComision = new DataTable();
                    DataTable dtManifiestaInterrogado = new DataTable();

                    DataTable dtMedidasRec1 = new DataTable();
                    DataTable dtMedidasRec2 = new DataTable();
                    DataTable dtMedidasObs1 = new DataTable();
                    DataTable dtMedidasObs2 = new DataTable();

                    DataRow drMedidasRec1;
                    DataRow drMedidasRec2;
                    DataRow drMedidasObs1;
                    DataRow drMedidasObs2;
                    DataRow drInter;

                    DataRow drListado;

                    DataTable dtInter = new DataTable();


                    DataTable dtManifiestaInspector = new DataTable();
                    DataTable dtManifiestaExperto = new DataTable();
                    DataTable dtTestigoFirma = new DataTable();

                    String strTestigos = "";
                    String strComision = "";
                    String strInterrogado = "";
                    String strProceso = "";

                    String VOA = String.Empty;
                    String horaCierre = String.Empty;
                    String fechaCierre = String.Empty;

                    String strCierretotal2 = String.Empty;
                    String strDia = String.Empty;
                    String strCitando = String.Empty;
                    String strCierretotal = String.Empty;


                    dtMedidasRec1.Columns.Add("mostrar");
                    dtMedidasRec2.Columns.Add("mostrar");
                    dtMedidasObs1.Columns.Add("mostrar");
                    dtMedidasObs2.Columns.Add("mostrar");


                    //int.TryParse(args, out dshgo_documento_id);
                    DataTable dtsubmaterias = new DataTable();
                    Document doc = new Document(Server.MapPath(plantilla));




                    //obtener tabla de inspectores
                    try
                    {
                        ds = miComponente.DshgoParticipanteInspectores_Obtener(-1, miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        numinsp = ds.Tables["resultado"].Rows.Count;
                        dtDshgoInspectores = ds.Tables["resultado"].Clone();
                        ds.Tables["resultado"].Select("dshgo_inspector_id is not null").CopyToDataTable(dtDshgoInspectores, LoadOption.OverwriteChanges);



                    }
                    #region firmas
                    //obtener firma testigos

                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 2);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtTestigoFirma = ds.Tables["resultado2"].Clone();
                        ds.Tables["resultado2"].Select("dpart_firma=1").CopyToDataTable(dtTestigoFirma, LoadOption.OverwriteChanges);
                    }

                    //obtener firma inspectores

                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 1);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtDshgoInspectoresFirma = ds.Tables["resultado2"].Clone();
                        ds.Tables["resultado2"].Select("dpart_firma=1").CopyToDataTable(dtDshgoInspectoresFirma, LoadOption.OverwriteChanges);
                    }

                    //obtener firma expertos

                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 7);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtDshgoExpertosFirma = ds.Tables["resultado2"].Clone();
                        ds.Tables["resultado2"].Select("dpart_firma=1").CopyToDataTable(dtDshgoExpertosFirma, LoadOption.OverwriteChanges);
                    }

                    //obtener firma interrogado

                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 3);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtDshgoInterrogadoFirma = ds.Tables["resultado2"].Clone();
                        ds.Tables["resultado2"].Select("dpart_firma=1").CopyToDataTable(dtDshgoInterrogadoFirma, LoadOption.OverwriteChanges);
                    }

                    //obtener firma reptrab

                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 5);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtRepTrabFirma = ds.Tables["resultado2"].Clone();
                        ds.Tables["resultado2"].Select("dpart_firma=1").CopyToDataTable(dtRepTrabFirma, LoadOption.OverwriteChanges);
                    }


                    //obtener firma repemp

                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 6);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtRepEmpFirma = ds.Tables["resultado2"].Clone();
                        ds.Tables["resultado2"].Select("dpart_firma=1").CopyToDataTable(dtRepEmpFirma, LoadOption.OverwriteChanges);
                    }

                    // obtener firmas comisión Empresa

                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 4);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtComisionEmpFirma = ds.Tables["resultado2"].Clone();
                        ds.Tables["resultado2"].Select("dpart_firma=1 and tipo_participante ='POR PARTE DE LA EMPRESA DE LA COMISIÓN'").CopyToDataTable(dtComisionEmpFirma, LoadOption.OverwriteChanges);
                    }
                    // obtener firmas comisión trab

                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 4);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtComisionTrabFirma = ds.Tables["resultado2"].Clone();
                        ds.Tables["resultado2"].Select("dpart_firma=1 and tipo_participante ='POR PARTE DE LOS TRABAJADORES DE LA COMISIÓN'").CopyToDataTable(dtComisionTrabFirma, LoadOption.OverwriteChanges);
                    }



                    #endregion


                    //tabla seccion2
                    try
                    {
                        ds = miComponente.TablaExperto_Obtener(miDtoD.inspeccion_id, miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables.Count > 0 && ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dtDshgoExpertos = ds.Tables["resultado"].Clone();

                        ds.Tables["resultado"].Select("dshgo_experto_id is not null").CopyToDataTable(dtDshgoExpertos, LoadOption.OverwriteChanges);

                    }


                    //obtener tabla de representante empresa
                    try
                    {
                        ds = miComponente.TablaRepresentanteEmpresa_Obtener(miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables.Count > 0 && ds.Tables["resultado"].Rows.Count > 0)
                    {

                        dtRepEmp = ds.Tables["resultado"].Copy();
                    }


                    //obtener tabla de identificacion
                    try
                    {
                        ds = miComponente.TablaIdentificación_Obtener(miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        if (!ds.Tables["resultado"].Rows[0][0].ToString().Trim().Equals(""))
                        {
                            dtIdent = ds.Tables["resultado"].Copy();
                            if (dtRepEmp.Rows.Count > 0)
                                identifica = "y se identifica con:";

                        }
                    }


                    try
                    {
                        ds = miComponente.TablaRepresentanteTrabajadores_Obtener(miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables.Count > 0 && ds.Tables["resultado"].Rows.Count > 0)
                    {
                        if (!ds.Tables["resultado"].Rows[0][0].ToString().Trim().Equals(""))
                        {
                            dtRepTrab = ds.Tables["resultado"].Copy();
                        }
                        else
                        {
                            no_identifica = true;
                        }
                    }





                    //tabla rep de los trabajadores
                    try
                    {
                        ds = miComponente.TablaIdentificaciónRepresentanteTrabajadores_Obtener(miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables.Count > 0 && ds.Tables["resultado"].Rows.Count > 0)
                    {
                        if (!ds.Tables["resultado"].Rows[0][0].ToString().Trim().Equals("") && !no_identifica)
                        {
                            dtIdent2 = ds.Tables["resultado"].Copy();
                            if (dtRepTrab.Rows.Count > 0) identifica1 = "y se identifica con:";
                        }
                    }


                    try
                    {
                        ds = miComponente.Dshgo_Testigos_Consultar(miDtoD.desahogo_id);
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

                        if (miRow["dtes_num_testigo"].ToString() == "0")
                        {
                            motivo_no = miRow["dtes_motivo_inspector"].ToString();
                        }
                        else
                        {
                            //tabla testigos
                            try
                            {
                                ds = miComponente.TablaTestigos_Obtener(miDtoD.desahogo_id, 1);
                            }
                            catch (Exception ex)
                            {
                                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                                return;
                            }

                            if (ds.Tables["resultado"].Rows.Count > 0)
                            {

                                dtTestigo1 = ds.Tables["resultado"].Copy();
                            }

                            //tabla testigo2
                            try
                            {
                                ds = miComponente.TablaTestigos_Obtener(miDtoD.desahogo_id, 2);
                            }
                            catch (Exception ex)
                            {
                                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                                return;
                            }

                            if (ds.Tables.Count > 0 && ds.Tables["resultado"].Rows.Count > 0)
                            {

                                dtTestigo2 = ds.Tables["resultado"].Copy();
                            }
                        }

                    }




                    if (miDtoD.materia_id == 2 || miDtoD.materia_id == 3 || miDtoD.materia_id == 5)
                    {



                        //tabla ComisionEmpresa en caso de ser SH, RSPC o AC
                        try
                        {
                            ds = miComponente.TablaComsion_Obtener(miDtoD.desahogo_id, 1);
                        }
                        catch (Exception ex)
                        {
                            utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                            utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                            return;
                        }

                        if (ds.Tables["resultado"].Rows.Count > 0)
                        {

                            dtComisionEmp = ds.Tables["resultado"].Copy();
                        }

                        //tabla ComisionTrabajador en caso de ser SH, RSPC o AC
                        try
                        {
                            ds = miComponente.TablaComsion_Obtener(miDtoD.desahogo_id, 2);
                        }
                        catch (Exception ex)
                        {
                            utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                            utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                            return;
                        }

                        if (ds.Tables["resultado"].Rows.Count > 0)
                        {

                            dtComisionTrab = ds.Tables["resultado"].Copy();
                        }

                    }

                    //Interrogados

                    try
                    {
                        ds = miComponente.DshgoInterrogado_Obtener(-1, -1, miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }
                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dtDshgoInterrogados = ds.Tables["resultado"].Copy();


                    }

                    //Listado de personal activo

                    try
                    {
                        ds = miComponente.DshgoListadoPActivo_Obtener(miDtoD.desahogo_id, -1);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }
                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dtDshgoListadoPactivo = ds.Tables["resultado"].Copy();
                    }


                    dtListado.Columns.Add("mostrar");
                    drListado = dtListado.NewRow();
                    dtListado.Rows.Add(drListado);
                    dtListado.Rows[0]["mostrar"] = "LISTADO DE PERSONAL ACTIVO";
                    dtListado.AcceptChanges();
                    dtListado.TableName = "listado";


                    #region manifestaciones
                    //manifestacion inspectores
                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 1);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtManifiestaInspector = ds.Tables["resultado2"].Copy();
                    }
                    //manifestacion expertos
                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 7);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtManifiestaExperto = ds.Tables["resultado2"].Copy();
                    }

                    //manifestacion testigos

                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 2);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtManifiestaTestigo = ds.Tables["resultado2"].Copy();
                        strTestigos = "El(los) testigo(s), en uso de la palabra manifiesta(n):";
                    }

                    dtManifiestaTestigo.TableName = "ManifiestaTestigo";
                    dset.Tables.Add(dtManifiestaTestigo);

                    //manifestacion RepEmpresa

                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 6);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtManifiestaRepEmpresa = ds.Tables["resultado2"].Copy();
                    }

                    dtManifiestaRepEmpresa.TableName = "ManifiestaRepEmpresa";
                    dset.Tables.Add(dtManifiestaRepEmpresa);


                    //dtManifiestaRepTrabajadores
                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 5);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtManifiestaRepTrabajadores = ds.Tables["resultado2"].Copy();
                    }

                    dtManifiestaRepTrabajadores.TableName = "ManifiestaRepTrabajadores";
                    dset.Tables.Add(dtManifiestaRepTrabajadores);



                    //dtManifiestaComision
                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 4);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtManifiestaComision = ds.Tables["resultado2"].Copy();
                        strComision = "El(los) integrantes(s) de la Comisión de " + miDtoD.materia + " , en uso de la palabra manifiesta(n):";
                    }

                    dtManifiestaComision.TableName = "ManifiestaComision";
                    dset.Tables.Add(dtManifiestaComision);


                    //dtManifiestaInterrogado

                    try
                    {
                        ds = miComponente.DshgoParticipantes_ObtenerPorTipo(miDtoD.desahogo_id, 3);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado2"].Rows.Count > 0)
                    {
                        dtManifiestaInterrogado = ds.Tables["resultado2"].Copy();
                        strInterrogado = "El(los) interrogado(s), en uso de la palabra manifiesta(n):";
                    }

                    dtManifiestaInterrogado.TableName = "ManifiestaInterrogado";
                    dset.Tables.Add(dtManifiestaInterrogado);



                    #endregion

                    #region trabajadores detalle

                    //DataRow dr2;
                    // tabla para el titulo no ocupa
                    //dtTrabDetalles.Columns.Add("mostrar");
                    //dr2 = dtTrabDetalles.NewRow();
                    //dtTrabDetalles.Rows.Add(dr2);
                    //dtTrabDetalles.Rows[0]["mostrar"] = "TRABAJADORES DETALLES";
                    //dtTrabDetalles.AcceptChanges();
                    //dtTrabDetalles.TableName = "TrabDetalles";



                    try
                    {
                        ds = miComponente.Dshgo_Trabajador_Detalle_Tabla(miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado1"].Rows.Count > 0)
                    {

                        //dtsubmateriasCGT 
                        //dtseccion5 = ds.Tables["resultado1"].Clone();
                        dtseccion5 = ds.Tables["resultado1"].Copy();
                        // ds.Tables["resultado1"].Select(" ").CopyToDataTable(dtsubmateriasCGT, LoadOption.OverwriteChanges);

                    }

                    // 
                    try
                    {
                        ds = miComponente.Dshgo_Trabajador_Detalle_Tabla(miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        //dtrevisionCGT = ds.Tables["resultado"].Copy();
                        dtseccion4 = ds.Tables["resultado"].Copy();
                    }
                    if (dtseccion5.Rows.Count > 0 && dtseccion4.Rows.Count > 0)
                    {
                        dtseccion5.TableName = "seccion5";
                        dtseccion4.TableName = "seccion4";
                        dset.Tables.Add(dtseccion5);
                        dset.Tables.Add(dtseccion4);
                        dset.Relations.Add(
                                new DataRelation("relacionTrabDetalle", dtseccion4.Columns["dshgo_trabajador_id"], dtseccion5.Columns["dshgo_trabajador_id"])
                                );
                    }


                    // dset.Tables.Add(dtTrabDetalles);
                    #endregion trabajadores detalle




                    //sindicato obtener 
                    try
                    {
                        ds = miComponente.TablaSindicato_Obtener(miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dtseccion7 = ds.Tables["resultado"].Copy();
                    }


                    //solidarios obtener 

                    if (miDtoD.subtipo_inspeccion_id != 3)
                    {
                        try
                        {
                            ds = miComponente.TablaSolidario_Obtener(miDtoD.desahogo_id);
                        }
                        catch (Exception ex)
                        {
                            utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                            utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                            return;
                        }

                        if (ds.Tables.Count > 0 && ds.Tables["resultado"].Rows.Count > 0)
                        {
                            dtseccion8 = ds.Tables["resultado"].Copy();
                        }
                    }
                    //proceso obtener 
                    try
                    {
                        ds = miComponente.TablaProceso_Obtener(miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables.Count > 0 && ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dtseccion9 = ds.Tables["resultado"].Copy();
                    }

                    //proceso obtener 
                    try
                    {
                        ds = miComponente.TablaProcesoAC_Obtener(miDtoD.desahogo_id, miDtoD.inspeccion_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables.Count > 0 && ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dtseccion10 = ds.Tables["resultado"].Copy();
                    }



                    //sindicato obtener 
                    try
                    {
                        ds = miComponente.TablaInstalacion_Obtener(miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dtseccion3 = ds.Tables["resultado"].Copy();
                    }

                    //camara obtener 
                    try
                    {
                        ds = miComponente.TablaCamara_Obtener(miDtoD.desahogo_id);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dtseccion6 = ds.Tables["resultado"].Copy();
                    }

                    if (miDtoD.subtipo_inspeccion_id != 3)
                    {

                        #region interrogatorio
                        dtInter.Columns.Add("mostrar");
                        drInter = dtInter.NewRow();
                        dtInter.Rows.Add(drInter);
                        dtInter.Rows[0]["mostrar"] = "INTERROGATORIOS";
                        dtInter.AcceptChanges();
                        dtInter.TableName = "inter";

                        #endregion



                        #region revisión
                        if (miDtoD.materia_id != 6)
                        {
                            DataRow dr;

                            dtRevisionDocumental.Columns.Add("mostrar");
                            dr = dtRevisionDocumental.NewRow();
                            dtRevisionDocumental.Rows.Add(dr);
                            dtRevisionDocumental.Rows[0]["mostrar"] = "REVISIÓN DOCUMENTAL";
                            dtRevisionDocumental.AcceptChanges();
                            dtRevisionDocumental.TableName = "RevisionDocumental";
                            #region SH y RSPC
                            if (miDtoD.materia_id == 2 || miDtoD.materia_id == 5)
                            {
                                try
                                {
                                    ds = miComponente.DshgoAlcance_Obtener(-1, miDtoD.desahogo_id);
                                }
                                catch (Exception ex)
                                {
                                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                                    return;
                                }

                                if (ds.Tables["resultado1"].Rows.Count > 0)
                                {

                                    tabla1 = ds.Tables["resultado1"].Clone();
                                    ds.Tables["resultado1"].Select("dsal_no_aplica=0 or dsal_no_aplica is null").CopyToDataTable(tabla1, LoadOption.OverwriteChanges);

                                }

                                try
                                {
                                    ds = miComponente.Dshgo_Revision_ObtenerIndicadoresPorDesahogoID(miDtoD.desahogo_id);
                                }
                                catch (Exception ex)
                                {
                                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                                    return;
                                }

                                if (ds.Tables["resultado"].Rows.Count > 0)
                                {
                                    tabla2 = ds.Tables["resultado"].Clone();

                                    ds.Tables["resultado"].Select("not (ind_incisos =1 and (drev_resultado1='CUENTA' or drev_resultado1='NO APLICA'))", "row asc").CopyToDataTable(tabla2, LoadOption.OverwriteChanges);
                                }
                                if (tabla1.Rows.Count > 0 && tabla2.Rows.Count > 0)
                                {
                                    tabla1.TableName = "submateriasSH";
                                    tabla2.TableName = "revision";
                                    dset.Tables.Add(tabla1);
                                    dset.Tables.Add(tabla2);
                                    dset.Relations.Add(
                                            new DataRelation("relacion1", tabla1.Columns["submateria_id"], tabla2.Columns["submateria_id"])
                                            );

                                }
                                dtsubmateriasCGT.TableName = "submateriasCGT";
                                dtrevisionCGT.TableName = "revisionCGT";
                                dset.Tables.Add(dtsubmateriasCGT);
                                dset.Tables.Add(dtrevisionCGT);
                            }
                            #endregion
                            #region LAS DEMAS
                            if (miDtoD.materia_id == 1 || miDtoD.materia_id == 3 || miDtoD.materia_id == 4 || miDtoD.materia_id == 6)
                            {

                                try
                                {
                                    ds = miComponente.DshgoAlcance_Obtener(-1, miDtoD.desahogo_id);
                                }
                                catch (Exception ex)
                                {
                                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                                    return;
                                }

                                if (ds.Tables["resultado1"].Rows.Count > 0)
                                {

                                    dtsubmateriasCGT = ds.Tables["resultado1"].Clone();

                                    ds.Tables["resultado1"].Select("dsal_no_aplica=0  or dsal_no_aplica is null").CopyToDataTable(dtsubmateriasCGT, LoadOption.OverwriteChanges);

                                }

                                // 
                                try
                                {
                                    ds = miComponente.Dshgo_Revision_ObtenerIndicadoresPorDesahogoID(miDtoD.desahogo_id);
                                }
                                catch (Exception ex)
                                {
                                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                                    return;
                                }

                                if (ds.Tables["resultado"].Rows.Count > 0)
                                {
                                    dtrevisionCGT = ds.Tables["resultado"].Clone();
                                    ds.Tables["resultado"].Select("dsal_no_aplica=0 or dsal_no_aplica is null").CopyToDataTable(dtrevisionCGT, LoadOption.OverwriteChanges);
                                }
                                if (dtsubmateriasCGT.Rows.Count > 0 && dtrevisionCGT.Rows.Count > 0)
                                {
                                    dtsubmateriasCGT.TableName = "submateriasCGT";
                                    dtrevisionCGT.TableName = "revisionCGT";
                                    dset.Tables.Add(dtsubmateriasCGT);
                                    dset.Tables.Add(dtrevisionCGT);
                                    dset.Relations.Add(
                                            new DataRelation("relacion11", dtsubmateriasCGT.Columns["submateria_id"], dtrevisionCGT.Columns["submateria_id"])
                                            );
                                }
                                tabla1.TableName = "submateriasSH";
                                tabla2.TableName = "revision";
                                dset.Tables.Add(tabla1);
                                dset.Tables.Add(tabla2);
                            }
                            #endregion
                        }
                        dset.Tables.Add(dtRevisionDocumental);
                        #endregion revision


                        if (miDtoD.materia_id == 2 || miDtoD.materia_id == 5)
                        {

                            //dtMedidas
                            #region MedidasAd
                            //medidas administrativas
                            try
                            {
                                ds = miComponente.Dshgo_MedidaAdm_Obtener(miDtoD.desahogo_id);
                            }
                            catch (Exception ex)
                            {
                                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                                return;
                            }

                            if (ds.Tables["resultado1"].Rows.Count > 0)
                            {
                                dtsubmatMedidasA = ds.Tables["resultado1"].Copy();
                                dtMedidasAdmin1 = ds.Tables["resultado"].Copy();
                                dtMedidasAdmin1.Columns.Add("id");
                                foreach (DataRow dr in dtMedidasAdmin1.Rows)
                                {
                                    id++;
                                    dr["id"] = id;
                                }
                                dtMedidasAdmin1.AcceptChanges();
                                dtsubmatMedidasA.TableName = "submatMedidasA";
                                dtMedidasAdmin1.TableName = "MedidasAdmin1";
                                dset.Tables.Add(dtsubmatMedidasA);
                                dset.Tables.Add(dtMedidasAdmin1);
                                dset.Relations.Add(
                                new DataRelation("medidasAdministrativas", dtsubmatMedidasA.Columns["submateria_id"], dtMedidasAdmin1.Columns["submateria_id"])
                                );
                                DataRow drM;

                                dtMedidas.Columns.Add("mostrar");
                                drM = dtMedidas.NewRow();
                                dtMedidas.Rows.Add(drM);
                                dtMedidas.Rows[0]["mostrar"] = "MEDIDAS ADMINISTRATIVAS";
                                dtMedidas.AcceptChanges();
                                dtMedidas.TableName = "Medidas";
                            }
                            else
                            {
                                dtsubmatMedidasA.TableName = "submatMedidasA";
                                dtMedidasAdmin1.TableName = "MedidasAdmin1";
                                dset.Tables.Add(dtsubmatMedidasA);
                                dset.Tables.Add(dtMedidasAdmin1);
                            }
                            dset.Tables.Add(dtMedidas);
                            //medidas no administrativas
                            try
                            {
                                ds = miComponente.DshgoMedidaNoAdmin_Obtener(miDtoD.desahogo_id, 1);//cumplimiento espontáneo
                            }
                            catch (Exception ex)
                            {
                                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                                return;
                            }
                            if (ds.Tables["resultado"].Rows.Count > 0)
                            {

                                dtMedidas1 = ds.Tables["resultado"].Copy();
                                dtMedidas1.Columns.Add("id");

                                drMedidasRec1 = dtMedidasRec1.NewRow();
                                dtMedidasRec1.Rows.Add(drMedidasRec1);
                                dtMedidasRec1.Rows[0]["mostrar"] = "Medidas";
                                dtMedidasRec1.AcceptChanges();

                            }


                            if (ds.Tables["resultado1"].Rows.Count > 0)
                            {
                                dtMedidasAp1 = ds.Tables["resultado1"].Copy();
                                dtMedidasAp1.Columns.Add("id");

                                drMedidasObs1 = dtMedidasObs1.NewRow();
                                dtMedidasObs1.Rows.Add(drMedidasObs1);
                                dtMedidasObs1.Rows[0]["mostrar"] = "Medidas";
                                dtMedidasObs1.AcceptChanges();
                            }

                            try
                            {
                                ds = miComponente.DshgoMedidaNoAdmin_Obtener(miDtoD.desahogo_id, 0);//no cumplimiento espontáneo
                            }
                            catch (Exception ex)
                            {
                                utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                                return;
                            }
                            if (ds.Tables["resultado"].Rows.Count > 0)
                            {
                                dtMedidas2 = ds.Tables["resultado"].Copy();
                                dtMedidas2.Columns.Add("id");


                                drMedidasRec2 = dtMedidasRec2.NewRow();
                                dtMedidasRec2.Rows.Add(drMedidasRec2);
                                dtMedidasRec2.Rows[0]["mostrar"] = "Medidas";
                                dtMedidasRec2.AcceptChanges();

                            }


                            if (ds.Tables["resultado1"].Rows.Count > 0)
                            {
                                dtMedidasAp2 = ds.Tables["resultado1"].Copy();
                                dtMedidasAp2.Columns.Add("id");


                                drMedidasObs2 = dtMedidasObs2.NewRow();
                                dtMedidasObs2.Rows.Add(drMedidasObs2);
                                dtMedidasObs2.Rows[0]["mostrar"] = "Medidas";
                                dtMedidasObs2.AcceptChanges();
                            }




                            //
                            #region agregar num de orden
                            foreach (DataRow dr in dtMedidas1.Rows)
                            {
                                id++;
                                dr["id"] = id;
                            }
                            dtMedidas1.AcceptChanges();
                            dtMedidas1.TableName = "Medidas1";
                            dset.Tables.Add(dtMedidas1);


                            foreach (DataRow dr in dtMedidas2.Rows)
                            {
                                id++;
                                dr["id"] = id;
                            }
                            dtMedidas2.AcceptChanges();
                            dtMedidas2.TableName = "Medidas2";
                            dset.Tables.Add(dtMedidas2);

                            foreach (DataRow dr in dtMedidasAp1.Rows)
                            {
                                id++;
                                dr["id"] = id;
                            }
                            dtMedidasAp1.AcceptChanges();
                            dtMedidasAp1.TableName = "MedidasAp1";
                            dset.Tables.Add(dtMedidasAp1);

                            foreach (DataRow dr in dtMedidasAp2.Rows)
                            {
                                id++;
                                dr["id"] = id;
                            }
                            dtMedidasAp2.AcceptChanges();
                            dtMedidasAp2.TableName = "MedidasAp2";
                            dset.Tables.Add(dtMedidasAp2);

                            #endregion
                            //
                            dtMedidasNoAdmin.Columns.Add("mostrar");
                            dtMedidasNoAdmin1.Columns.Add("mostrar");
                            if (dtMedidas1.Rows.Count > 0 || dtMedidas2.Rows.Count > 0)
                            {
                                DataRow drNoAdm;


                                drNoAdm = dtMedidasNoAdmin.NewRow();
                                dtMedidasNoAdmin.Rows.Add(drNoAdm);
                                dtMedidasNoAdmin.Rows[0]["mostrar"] = "MEDIDAS IDENTIFICADAS DURANTE EL RECORRIDO";
                                dtMedidasNoAdmin.AcceptChanges();

                            }

                            if (dtMedidasAp1.Rows.Count > 0 || dtMedidasAp2.Rows.Count > 0)
                            {
                                DataRow drNoAdm1;


                                drNoAdm1 = dtMedidasNoAdmin1.NewRow();
                                dtMedidasNoAdmin1.Rows.Add(drNoAdm1);
                                dtMedidasNoAdmin1.Rows[0]["mostrar"] = "MEDIDAS DE APLICACIÓN INMEDIATA Y OBSERVANCIA PERMANENTE";
                                dtMedidasNoAdmin1.AcceptChanges();

                            }



                            #endregion MedidasAd
                        }

                        dtMedidasNoAdmin.TableName = "MedidasNoAdmin";
                        dtMedidasNoAdmin1.TableName = "MedidasNoAdmin1";
                        dtMedidasRec1.TableName = "MedidasRec1";
                        dtMedidasRec2.TableName = "MedidasRec2";
                        dtMedidasObs1.TableName = "MedidasObs1";
                        dtMedidasObs2.TableName = "MedidasObs2";

                        dset.Tables.Add(dtMedidasNoAdmin);
                        dset.Tables.Add(dtMedidasNoAdmin1);
                        dset.Tables.Add(dtMedidasRec1);
                        dset.Tables.Add(dtMedidasRec2);
                        dset.Tables.Add(dtMedidasObs1);
                        dset.Tables.Add(dtMedidasObs2);

                    }
                    else
                    {
                        DataRow drCM;




                        #region medidas CM
                        id = 0;
                        //medidas administrativas
                        try
                        {
                            ds = miComponente.Dshgo_MedidaAdm_Obtener(miDtoD.desahogo_id);
                        }
                        catch (Exception ex)
                        {
                            utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                            utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                            return;
                        }

                        if (ds.Tables["resultado3"].Rows.Count > 0)
                        {
                            dtsubmateriasCM = ds.Tables["resultado3"].Copy();
                            dtmedidasAdmCM = ds.Tables["resultado2"].Copy();
                            dtmedidasAdmCM.Columns.Add("id");
                            foreach (DataRow dr in dtmedidasAdmCM.Rows)
                            {
                                id++;
                                dr["id"] = id;
                            }
                            dtmedidasAdmCM.AcceptChanges();
                            dtsubmateriasCM.TableName = "submateriasCM";
                            dtmedidasAdmCM.TableName = "medidasAdmCM";
                            dset.Tables.Add(dtsubmateriasCM);
                            dset.Tables.Add(dtmedidasAdmCM);
                            dset.Relations.Add(
                            new DataRelation("medidasAdministrativas11", dtsubmateriasCM.Columns["submateria_id"], dtmedidasAdmCM.Columns["submateria_id"])
                            );
                        }
                        else
                        {
                            dtmedidasAdmCM.AcceptChanges();
                            dtsubmateriasCM.TableName = "submateriasCM";
                            dtmedidasAdmCM.TableName = "medidasAdmCM";
                            dset.Tables.Add(dtsubmateriasCM);
                            dset.Tables.Add(dtmedidasAdmCM);
                        }

                        //medidas no administrativas
                        try
                        {
                            ds = miComponente.DshgoMedidaNoAdmin_Obtener(miDtoD.desahogo_id, -1);
                        }
                        catch (Exception ex)
                        {
                            utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                            utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                            return;
                        }
                        if (ds.Tables["resultado2"].Rows.Count > 0)
                        {

                            dtMedidasRecorridoCM = ds.Tables["resultado2"].Copy();
                            dtMedidasRecorridoCM.Columns.Add("id");
                            foreach (DataRow dr in dtMedidasRecorridoCM.Rows)
                            {
                                id++;
                                dr["id"] = id;
                            }
                            dtMedidasRecorridoCM.AcceptChanges();

                        }
                        //if (ds.Tables["resultado1"].Rows.Count > 0)
                        //{
                        //    dtMedidasRecorridoCM1 = ds.Tables["resultado1"].Copy();
                        //    dtMedidasRecorridoCM1.Columns.Add("id");
                        //    foreach (DataRow dr in dtMedidasRecorridoCM1.Rows)
                        //    {
                        //        id++;
                        //        dr["id"] = id;
                        //    }
                        //    dtMedidasRecorridoCM1.AcceptChanges();

                        //}

                        dtMedidasRecorridoCM.TableName = "MedidasRecorridoCM";
                        dset.Tables.Add(dtMedidasRecorridoCM);
                        //dtMedidasRecorridoCM1.TableName = "MedidasRecorridoCM1";
                        //dset.Tables.Add(dtMedidasRecorridoCM1);

                        if (dtsubmateriasCM.Rows.Count > 0 || dtMedidasRecorridoCM.Rows.Count > 0)//|| dtMedidasRecorridoCM1.Rows.Count>0)
                        {
                            dtMedidasParaCM.Columns.Add("mostrar");
                            drCM = dtMedidasParaCM.NewRow();
                            dtMedidasParaCM.Rows.Add(drCM);
                            dtMedidasParaCM.Rows[0]["mostrar"] = "REVISIÓN DE MEDIDAS DE SEGURIDAD E HIGIENE";
                            dtMedidasParaCM.AcceptChanges();
                            dtMedidasParaCM.TableName = "MedidasParaCM";
                        }


                        //dtsubmatMedidasA.TableName = "submatMedidasA";
                        //dtMedidasAdmin1.TableName = "MedidasAdmin1";
                        //dset.Tables.Add(dtsubmatMedidasA);
                        //dset.Tables.Add(dtMedidasAdmin1);
                        //dtMedidas1.TableName = "Medidas1";
                        //dset.Tables.Add(dtMedidas1);
                        //dtMedidasAp1.TableName = "MedidasAp1";
                        //dset.Tables.Add(dtMedidasAp1);
                        //dtMedidas2.TableName = "Medidas2";
                        //dset.Tables.Add(dtMedidas2);
                        //dtMedidasAp2.TableName = "MedidasAp2";
                        //dset.Tables.Add(dtMedidasAp2);

                        //dtMedidasNoAdmin.TableName = "MedidasNoAdmin";
                        //dtMedidasRec1.TableName = "MedidasRec1";
                        //dtMedidasRec2.TableName = "MedidasRec2";
                        //dtMedidasObs1.TableName = "MedidasObs1";
                        //dtMedidasObs2.TableName = "MedidasObs2";

                        //dset.Tables.Add(dtMedidasNoAdmin);
                        //dset.Tables.Add(dtMedidasRec1);
                        //dset.Tables.Add(dtMedidasRec2);
                        //dset.Tables.Add(dtMedidasObs1);
                        //dset.Tables.Add(dtMedidasObs2);


                        #endregion medidas CM


                    }
                    dset.Tables.Add(dtInter);
                    dset.Tables.Add(dtMedidasParaCM);




                    if (miDtoD.materia_id == 4)
                    {
                        strProceso = "PROCESO DE RECLUTAMIENTO";
                    }
                    else
                    {
                        strProceso = "PROCESO PRODUCTIVO O ACTIVIDAD ECONÓMICA";
                    }


                    ds = null;


                    dtDshgoInspectoresFirma.TableName = "InspectorFirma";
                    dtDshgoInspectores.TableName = "seccion1";
                    dtRepEmp.TableName = "repEmp";
                    dtIdent.TableName = "Ident1";
                    dtRepTrab.TableName = "repTrab";
                    dtIdent2.TableName = "Ident2";
                    dtDshgoExpertos.TableName = "seccion2";
                    dtDshgoExpertosFirma.TableName = "ExpertoFirma";
                    dtDshgoInterrogados.TableName = "Interrogados";
                    dtDshgoInterrogados.TableName = "Interrogados";
                    dtDshgoListadoPactivo.TableName = "PersonalActivo";

                    dtDshgoInterrogadoFirma.TableName = "InterrogadoFirma";
                    dtRepEmpFirma.TableName = "RepEmpFirma";
                    dtRepTrabFirma.TableName = "RepTrabFirma";
                    dtComisionEmpFirma.TableName = "ComisionEmpFirma";
                    dtComisionTrabFirma.TableName = "ComisionTrabFirma";

                    dtTestigo1.TableName = "Testigo";
                    dtTestigo2.TableName = "Testigo2";
                    dtComisionEmp.TableName = "ComisionEmp";
                    dtComisionTrab.TableName = "ComisionTrab";


                    dtseccion3.TableName = "seccion3";

                    dtseccion6.TableName = "seccion6";
                    dtseccion7.TableName = "seccion7";
                    dtseccion8.TableName = "seccion8";
                    dtseccion9.TableName = "seccion9";
                    dtseccion10.TableName = "seccion10";





                    dtsubmateriasCM.TableName = "submateriasCM";
                    dtmedidasAdmCM.TableName = "medidasAdmCM";

                    dtMedidasRecorridoCM.TableName = "MedidasRecorridoCM";
                    dtTipoParticipante.TableName = "TipoParticipante";

                    dtManifiestaInspector.TableName = "ManifiestaInspector";
                    dtManifiestaExperto.TableName = "ManifiestaExperto";
                    dtTestigoFirma.TableName = "TestigoFirma";



                    //seccion3-7
                    //submateriasCGT
                    //submatMedidasA
                    //MedidasAdmin1
                    //Medidas1
                    //Medidas2
                    //MedidasAp1
                    //MedidasAp2
                    //submateriasCM
                    //MedidasRecorridoCM
                    //TipoParticipante
                    //    ManifiestaParticipante
                    //ManifiestaInspector
                    //ManifiestaExperto
                    //TestigoFirma





                    dset.Tables.Add(dtDshgoInspectoresFirma);
                    dset.Tables.Add(dtDshgoInspectores);
                    dset.Tables.Add(dtRepEmp);
                    dset.Tables.Add(dtIdent);
                    dset.Tables.Add(dtRepTrab);
                    dset.Tables.Add(dtIdent2);
                    dset.Tables.Add(dtDshgoExpertos);
                    dset.Tables.Add(dtDshgoExpertosFirma);
                    dset.Tables.Add(dtDshgoInterrogados);
                    dset.Tables.Add(dtDshgoListadoPactivo);
                    dset.Tables.Add(dtListado);

                    dset.Tables.Add(dtDshgoInterrogadoFirma);
                    dset.Tables.Add(dtRepEmpFirma);
                    dset.Tables.Add(dtRepTrabFirma);
                    dset.Tables.Add(dtComisionEmpFirma);
                    dset.Tables.Add(dtComisionTrabFirma);


                    dset.Tables.Add(dtTestigo1);
                    dset.Tables.Add(dtTestigo2);
                    dset.Tables.Add(dtComisionEmp);
                    dset.Tables.Add(dtComisionTrab);

                    dset.Tables.Add(dtManifiestaInspector);
                    dset.Tables.Add(dtManifiestaExperto);
                    dset.Tables.Add(dtTestigoFirma);

                    //tablas no llenas

                    dset.Tables.Add(dtseccion3); //tinst_instalacion»

                    dset.Tables.Add(dtseccion6);  //cc_camara
                    dset.Tables.Add(dtseccion7);  //dsind_sindicato
                    dset.Tables.Add(dtseccion8);
                    dset.Tables.Add(dtseccion9);
                    dset.Tables.Add(dtseccion10);



                    //dset.Tables.Add(dtsubmateriasCM);
                    //dset.Tables.Add(dtmedidasAdmCM);
                    //dset.Tables.Add(dtMedidasRecorridoCM);
                    dset.Tables.Add(dtTipoParticipante);

                    DtoDesahogo miDtoDesh = new DtoDesahogo();
                    miDtoDesh.desahogo_id = miDtoD.desahogo_id;
                    try
                    {
                        ds = miComponente.Desahogo_Obtener(miDtoDesh);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }
                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        VOA = ds.Tables["resultado"].Rows[0]["dshgo_tipo_desahogo"].ToString().Equals("4") && miDtoD.subtipo_inspeccion_id != 5 ? " (EN TÉRMINOS DE ORIENTACIÓN Y ASESORÍA)" : "";
                        int.TryParse(ds.Tables["resultado"].Rows[0]["dshgo_tipo_desahogo"].ToString(), out miDtoDesh.dshgo_tipo_desahogo);
                    }





                    DtoDoctoBusqueda dtoBusqueda = new DtoDoctoBusqueda();


                    dtoBusqueda.dshgo_documento_id = documento_id;


                    try
                    {
                        ds = miComponente.DoctoVariableValores_Obtener(dtoBusqueda);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }


                    if (ds.Tables["resultado"].Rows.Count < 1)
                    {
                        return;
                    }


                    DataTable Variables = new DataTable();
                    Variables = ds.Tables["resultado"].Copy();


                    //int count = 0;
                    string[] variable = new string[Variables.Rows.Count - 8];
                    object[] valor = new object[Variables.Rows.Count - 8];
                    int indice = 0;
                    //int i2=0;
                    String[] b = new String[6];
                    DataTable d = new DataTable();
                    d.Columns.Add("uno");
                    DataRow reng = d.NewRow();
                    d.Rows.Add(reng);
                    foreach (DataRow dr in Variables.Rows)
                    {
                        if (dr["var_variable"].ToString() == "<FECHA CIERRE PARCIAL>" || dr["var_variable"].ToString() == "<HORA CIERRE PARCIAL>" || dr["var_variable"].ToString() == "<HORA REINICIO>" || dr["var_variable"].ToString() == "<FECHA REINICIO>" || dr["var_variable"].ToString() == "<FECHA CIERRE>" || dr["var_variable"].ToString() == "<HORA CIERRE>" || dr["var_variable"].ToString() == "<HORA INSPECCIÓN>" || dr["var_variable"].ToString() == "<FECHA INSPECCIÓN>")
                        {
                            //b[i2][0]= ;
                            d.Columns.Add(dr["var_variable"].ToString());
                            //b[i2] = dr["dv_valor"].ToString();

                            d.Rows[0][dr["var_variable"].ToString()] = dr["dv_valor"];
                            //i2++;
                        }
                        else
                        {
                            variable[indice] = dr["var_variable"].ToString();
                            valor[indice] = dr["dv_valor"].ToString();
                            indice++;
                        }
                    }
                    doc.MailMerge.Execute(variable, valor);
                    if (miDtoD.dshgo_tipo_cierre == 1)
                    {
                        horaCierre = "Hora en que se cita:";
                        fechaCierre = "Fecha en que se cita:";

                        strCierretotal = "«cierretotal»";
                        strCierretotal2 = "En estos momentos, y por mutuo acuerdo entre las partes que intervienen, se suspende parcialmente la diligencia, siendo las ";
                        strDia = " del día ";
                        strCitando = ", citando por medio de este conducto a todas y cada una de las partes que intervienen, para que estén presentes nuevamente en la hora y fecha que se indica:";
                        //b[0] = b[1] = "";
                        d.Rows[0]["<HORA CIERRE>"] = d.Rows[0]["<FECHA CIERRE>"] = "";
                    }
                    else
                    {
                        if (d.Rows[0]["<FECHA REINICIO>"].ToString() != "")
                        {
                            d.Rows[0]["<HORA INSPECCIÓN>"] = d.Rows[0]["<HORA REINICIO>"].ToString();
                            d.Rows[0]["<FECHA INSPECCIÓN>"] = d.Rows[0]["<FECHA REINICIO>"].ToString();

                        }

                        d.Rows[0]["<FECHA CIERRE PARCIAL>"] = d.Rows[0]["<HORA CIERRE PARCIAL>"] = d.Rows[0]["<HORA REINICIO>"] = d.Rows[0]["<FECHA REINICIO>"] = "";
                        //b[4] = "";
                        //b[5] = "";
                        //b[2] = "";
                        //b[3] = "";
                        strCierretotal2 = strDia = strCitando = String.Empty;
                        horaCierre = "Hora de cierre:";
                        fechaCierre = "Fecha de cierre:";

                    }
                    doc.MailMerge.CleanupOptions = MailMergeCleanupOptions.RemoveUnusedFields;
                    doc.MailMerge.Execute(
                           new string[] {
                       "<FECHA CIERRE>",
                       "<HORA CIERRE>",
                        "identifica",
                        "identifica1",
                        "motivo_no",
                        "Interrogado",
                        "Comision",
                        "Testigos",
                        "Proceso_Reclutamiento",
                        "VOA",
                        "horaCierre",
                        "fechaCierre",
                        "<FECHA CIERRE PARCIAL>",
                        "<HORA CIERRE PARCIAL>",
                        "cierretotal2",
                        "dia",
                        "citando",
                        "<FECHA REINICIO>",
                        "<HORA REINICIO>",
                        "cierretotal",
                        "<HORA INSPECCIÓN>",
                        "<FECHA INSPECCIÓN>"
                   },
                           new object[] {
                        d.Rows[0]["<FECHA CIERRE>"].ToString(),
                        d.Rows[0]["<HORA CIERRE>"].ToString(),
                        identifica,
                        identifica1,
                        motivo_no,
                        strInterrogado,
                        strComision,
                        strTestigos,
                        strProceso,
                        VOA,
                        horaCierre,
                        fechaCierre,
                        d.Rows[0]["<FECHA CIERRE PARCIAL>"].ToString(),
                        d.Rows[0]["<HORA CIERRE PARCIAL>"].ToString(),
                        strCierretotal2,
                        strDia,
                        strCitando,
                        d.Rows[0]["<FECHA REINICIO>"].ToString(),
                        d.Rows[0]["<HORA REINICIO>"].ToString(),
                        strCierretotal,
                        d.Rows[0]["<HORA INSPECCIÓN>"].ToString(),
                        d.Rows[0]["<FECHA INSPECCIÓN>"].ToString() 
                    });



                    dtoBusqueda.documento_id = dtoBusqueda.dshgo_documento_id;
                    try
                    {
                        ds = miComponente.DshgoDoctoParrafoTexto_Obtener(dtoBusqueda);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    Hashtable mihash = new Hashtable();

                    for (int i = 0; i < doc.Range.Bookmarks.Count; i++)
                    {

                        mihash.Add(doc.Range.Bookmarks[i].Name, doc.Range.Bookmarks[i].Name);

                    }






                    foreach (DataRow row in ds.Tables["resultado1"].Rows)
                    {

                        if (mihash.ContainsKey(row["variablesintags"].ToString()))
                        {

                            Bookmark bookmark = doc.Range.Bookmarks[row["variablesintags"].ToString()];
                            //
                            DocumentBuilder builder = new DocumentBuilder(doc);
                            builder.MoveToBookmark(row["variablesintags"].ToString());
                            if (builder.CurrentParagraph.Runs.Count > 0)
                                foreach (Run run in builder.CurrentParagraph.Runs)
                                    run.Text = "";
                            builder.InsertHtml("<span style='font-family:Arial'>" + row["parrafovariables_replace"].ToString() + "</span>");
                        }


                    }
                    //borrar contenido ke no va
                    #region cierreParcial
                    if (miDtoD.dshgo_tipo_cierre == 1 && info[0].Equals("5"))
                    {

                        NodeCollection tables = doc.GetChildNodes(NodeType.Table, true);
                        int indice2 = 0;
                        foreach (Aspose.Words.Tables.Table tab in tables)
                        {
                            if (tab.FirstRow.Cells[0].Paragraphs[0].GetText() == "Nombre, denominación o razón social:\a")
                            {
                                indice2 = tables.IndexOf(tab);
                                break;
                            }
                        }
                        int j = indice2;
                        while (((Aspose.Words.Tables.Table)tables[j]).FirstRow.Cells[0].Paragraphs[0].GetText() != "tablaFin\a")
                        {

                            ((Aspose.Words.Tables.Table)tables[j]).Remove();

                        }

                        NodeCollection paragraphs = doc.GetChildNodes(NodeType.Paragraph, true);
                        int indice1 = 0;
                        foreach (Paragraph para in paragraphs)
                        {
                            if (para.Range.Text.Contains("«cierretotal»"))
                            {
                                indice1 = paragraphs.IndexOf(para);
                                break;
                            }
                        }
                        int i1 = indice1;
                        if (indice1 > 0)
                            do
                            {
                                paragraphs[i1].Range.Delete();
                            } while (!paragraphs[i1].Range.Text.Contains("En estos momentos, y por mutuo acuerdo entre las partes que intervienen, se suspende parcialmente la diligencia, siendo las "));



                    }

                    #endregion

                    #region Orientación y asesoría
                    if ((miDtoD.subtipo_inspeccion_id == 5 || miDtoDesh.dshgo_tipo_desahogo == 4) && info[0].Equals("5"))
                    {

                        NodeCollection paragraphs = doc.GetChildNodes(NodeType.Paragraph, true);
                        int indice1 = 0;
                        foreach (Paragraph para in paragraphs)
                        {
                            if (para.Range.Text.Contains("Con fundamento en lo dispuesto por los artículos 68 de la Ley Federal de Procedimiento Administrativo y 22 del Reglamento General para la Inspección y Aplicación de Sanciones por Violaciones a la Legislación Laboral, se hace constar que el patrón cuenta con cinco días hábiles, contados a partir del día siguiente de la fecha de la presente inspección, para presentar por escrito las observaciones y ofrecer pruebas con relación a los hechos contenidos en la presente acta"))
                            {
                                indice1 = paragraphs.IndexOf(para);
                                break;
                            }
                        }
                        paragraphs[indice1].Range.Delete();
                    }
                    #endregion





                    doc.MailMerge.CleanupOptions = MailMergeCleanupOptions.RemoveUnusedRegions;



                    // Set the appropriate mail merge clean up options to remove any unused regions from the document.
                    //doc.MailMerge.RemoveEmptyParagraphs = true;// .CleanupOptions = MailMergeCleanupOptions.RemoveUnusedRegions;
                    doc.MailMerge.ExecuteWithRegions(dset);



                    switch (tipo)
                    {
                        case 5:

                            doc.Save(Response, "ActaInspeccion.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                            break;
                        case 7:
                            doc.Save(Response, "ActaNegativa.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                            break;
                        case 17:
                            doc.Save(Response, "ClaveAcceso.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                            break;
                        default:
                            doc.Save(Response, "documento.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                            break;
                    }
                
                }

            }
            #endregion
            //los documentos de calificación
            #region documentos calificacion
            if (tipo >= 10 && tipo < 21)
            {
                DataSet ds = null;
                DataTable dtcopias = new DataTable();
                DataTable dtSubmaterias = new DataTable();
                DataTable dtMedidasAdmin = new DataTable();
                DataTable dtMedidasAdmin2 = new DataTable();
                DataTable dtMedidasAdmin3 = new DataTable();
                DataTable dtMedidasRecorr = new DataTable();
                DataTable dtMedidasRecorr2 = new DataTable();
                DataTable dtViolaciones = new DataTable();
                DataTable dtViolaciones2 = new DataTable();
                DataSet dset = new DataSet();
                Document doc = new Document(Server.MapPath(plantilla));
                int i,k, amp = 0, dshgo_tipo_desahogo=0;
                String medidas1 = String.Empty;
                String medidas2 = String.Empty;

                //obtener tipo de desahogo
                DtoDesahogo mides = new DtoDesahogo();
                mides.inspeccion_id = midtoB.inspeccion_id;
                try
                {
                    ds = miComponente.Desahogo_Obtener(mides);
                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }
                if (ds.Tables[0].Rows.Count > 0)
                {

                    DataRow miRow = ds.Tables[0].Rows[0];
                    int.TryParse(miRow["dshgo_tipo_desahogo"].ToString(), out dshgo_tipo_desahogo);

                }
                //obtener las copias
                try
                {
                    ds = miComponente.CalifDoctoCopias_Consultar(documento_id, 1);
                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }

                if (ds.Tables["resultado"].Rows.Count > 0)
                {
                    dtcopias = ds.Tables["resultado"];
                    dtcopias.Columns.Add("ccp");
                    dtcopias.AcceptChanges();

                }
                i = 1;
                foreach (DataRow row in ds.Tables["resultado"].Rows)
                {
                    if (i == 1)
                        row["ccp"] = "C.c.p.";
                    else row["ccp"] = "";
                    dtcopias.AcceptChanges();
                    i++;

                }
                dtcopias = dtcopias.Copy();

                //obtener violaciones
                try
                {
                    if (midtoB.materia_id == 1 || midtoB.materia_id == 3 || midtoB.materia_id == 4 || midtoB.materia_id == 6)
                        ds = miComponente.CalifViolacion_Consultar2(midtoB.desahogo_id, midtoB.calificacion_id, midtoB.materia_id, -1, 1);
                    else
                        ds = miComponente.CalifViolacion_Consultar(-1, midtoB.desahogo_id, midtoB.calificacion_id, midtoB.materia_id);

                    if (dshgo_tipo_desahogo == 3)
                        ds = miComponente.CalifViolacion_ConsultarNegativa(-1, midtoB.calificacion_id);
                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }

                if ((midtoB.materia_id == 1 || midtoB.materia_id == 3 || midtoB.materia_id == 4 || midtoB.materia_id == 6) && dshgo_tipo_desahogo != 3)
                {
                    dtViolaciones2 = ds.Tables["resultado1"];
                    dtViolaciones2.Columns.Add("i_index");

                    try
                    {
                        int renglones = 0;
                        renglones = dtViolaciones2.Rows.Count;
                        //foreach (DataRow row in dtViolaciones.Rows)
                        for (int j = 0; j < renglones; j++)
                        {
                            ds = miComponente.CalifViolacion_Consultar2(midtoB.desahogo_id, midtoB.calificacion_id, midtoB.materia_id, (int)dtViolaciones2.Rows[j]["indicador_id"], null);
                            dtViolaciones2.Merge(ds.Tables["resultado1"]);
                            //dtViolaciones.AcceptChanges();
                        }
                        dtViolaciones = dtViolaciones2.Clone();
                        //if ((DtoC.materia_id == 1 || DtoC.materia_id == 3 || DtoC.materia_id == 4 || DtoC.materia_id == 6) && DtoC.dshgo_tipo_desahogo != 3)
                        if (dtViolaciones2.Columns["smat_consecutivo"] != null &&
                            dtViolaciones2.Columns["ind_consecutivo"] != null &&
                            dtViolaciones2.Columns["inc_consecutivo"] != null)
                            dtViolaciones2.Select("not imed_medida is null", "smat_consecutivo, ind_consecutivo, inc_consecutivo").CopyToDataTable(dtViolaciones, LoadOption.OverwriteChanges);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }
                }
                else
                {
                    dtViolaciones = ds.Tables["resultado1"];
                    dtViolaciones.Columns.Add("i_index");
                }

                i = 1;
                foreach (DataRow row in dtViolaciones.Rows)
                {
                    row["i_index"] = i.ToString();
                    dtViolaciones.AcceptChanges();
                    i++;
                }
                dtViolaciones = dtViolaciones.Copy();

                //obtener medidas administrativas para ampliacion de término
                if (tipo == 9 || tipo == 13 || ((tipo == 14 || tipo == 15) && midtoB.subtipo_inspeccion_id == 3))
                {
                    if (tipo == 9)
                        amp = 1;
                    else
                        amp = 0;

                    try
                    {
                        ds = miComponente.SubmateriaMedidasAdmin_Obtener(midtoB.desahogo_id, -1, amp);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        medidas1 = "MEDIDAS ADMINISTRATIVAS";
                        dtSubmaterias = ds.Tables["resultado"];
                    }
                    dtSubmaterias = dtSubmaterias.Copy();

                    //sacar las medidas de cada submateria
                    try
                    {
                        ds = miComponente.MedidasAdminPorSubmateriaDesahogo_Obtener(midtoB.desahogo_id, -1);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dtMedidasAdmin = ds.Tables["resultado"];
                        dtMedidasAdmin.Columns.Add("i_index");
                        dtMedidasAdmin.Columns.Add("raya");
                    }
                    i = 1;
                    foreach (DataRow row in ds.Tables["resultado"].Rows)
                    {
                        row["i_index"] = i.ToString();
                        row["raya"] = "";
                        dtMedidasAdmin.AcceptChanges();
                        i++;

                    }
                    dtMedidasAdmin = dtMedidasAdmin.Copy();
                    if (tipo == 14 || tipo == 15)
                    {
                        //medidas administrativas para SIPAS
                        try
                        {
                            ds = miComponente.Dshgo_MedidaAdm_Obtener(midtoB.desahogo_id);
                        }
                        catch (Exception ex)
                        {
                            utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                            utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                            return;
                        }

                        if (ds.Tables["resultado4"].Rows.Count > 0)
                        {
                            dtMedidasAdmin2 = ds.Tables["resultado4"];
                            dtMedidasAdmin2.Columns.Add("i_index2");
                        }
                        k = 1;
                        foreach (DataRow row in ds.Tables["resultado4"].Rows)
                        {
                            row["i_index2"] = k.ToString();
                            dtMedidasAdmin2.AcceptChanges();
                            k++;
                        }
                        if (ds.Tables["resultado4"].Rows.Count > 0)
                        {
                            dtMedidasAdmin3 = dtMedidasAdmin2.Clone();
                            dtMedidasAdmin2.Select("dmed_cumplimiento_espontaneo = 0 or dmed_cumplimiento_espontaneo is null").CopyToDataTable(dtMedidasAdmin3, LoadOption.OverwriteChanges);
                            dtMedidasAdmin2 = dtMedidasAdmin3.Copy();

                            if (dtMedidasAdmin2.Rows.Count > 0)
                                dtMedidasAdmin2.Columns.Add("i_index");

                            i = 1;
                            foreach (DataRow row in dtMedidasAdmin2.Rows)
                            {
                                row["i_index"] = i.ToString();
                                dtMedidasAdmin2.AcceptChanges();
                                i++;
                            }
                        }
                        //medidas del recorrido
                        try
                        {
                            ds = miComponente.IndMedida_ObtenerSubmateria2(1, midtoB.desahogo_id, -1);
                        }
                        catch (Exception ex)
                        {
                            utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                            utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                            return;
                        }

                        if (ds.Tables["resultado"].Rows.Count > 0)
                        {
                            dtMedidasRecorr = ds.Tables["resultado"];
                            dtMedidasRecorr.Columns.Add("i_index2");
                        }
                        //k = 1;
                        foreach (DataRow row in ds.Tables["resultado"].Rows)
                        {
                            row["i_index2"] = k.ToString();
                            dtMedidasRecorr.AcceptChanges();
                            k++;
                        }

                        dtMedidasRecorr2 = dtMedidasRecorr.Clone();
                        if (dtMedidasRecorr.Rows.Count > 0) dtMedidasRecorr.Select("cumplimiento_espontaneo = 'NO CUMPLE'").CopyToDataTable(dtMedidasRecorr2, LoadOption.OverwriteChanges);
                        dtMedidasRecorr = dtMedidasRecorr2.Copy();


                        if (dtMedidasRecorr.Rows.Count > 0)
                        {
                            medidas2 = "MEDIDAS DE RECORRIDO";
                            //dtMedidasRecorr = ds.Tables["resultado"];
                            dtMedidasRecorr.Columns.Add("i_index");
                        }
                        foreach (DataRow row in dtMedidasRecorr.Rows)
                        {
                            row["i_index"] = i.ToString();
                            dtMedidasRecorr.AcceptChanges();
                            i++;
                        }
                        dtMedidasRecorr = dtMedidasRecorr.Copy();

                    }
                    else
                    {
                        //medidas del recorrido
                        try
                        {
                            ds = miComponente.MedidasRecorridoParaEmplazamiento_Obtener(midtoB.desahogo_id);
                        }
                        catch (Exception ex)
                        {
                            utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                            utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                            return;
                        }

                        if (ds.Tables["resultado"].Rows.Count > 0)
                        {
                            medidas2 = "MEDIDAS DE RECORRIDO";
                            dtMedidasRecorr = ds.Tables["resultado"];
                            dtMedidasRecorr.Columns.Add("i_index");
                        }
                        foreach (DataRow row in ds.Tables["resultado"].Rows)
                        {
                            row["i_index"] = i.ToString();
                            dtMedidasRecorr.AcceptChanges();
                            i++;

                        }
                        dtMedidasRecorr = dtMedidasRecorr.Copy();
                    }
                }

                //obtener medidas administrativas para emplazamiento documental
                if (tipo == 19)
                {
                    if (tipo == 9)
                        amp = 1;
                    else
                        amp = 0;

                    try
                    {
                        ds = miComponente.SubmateriaMedidasAdmin_ObtenerEmplazamientoDocumental(midtoB.desahogo_id, -1, amp);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        medidas1 = "MEDIDAS ADMINISTRATIVAS";
                        dtSubmaterias = ds.Tables["resultado"];
                    }

                    dtSubmaterias = dtSubmaterias.Copy();

                    //sacar las medidas de cada submateria
                    try
                    {
                        ds = miComponente.MedidasAdminPorSubmateriaDesahogo_ObtenerEmplazamientoDocumental(midtoB.desahogo_id, -1);
                    }
                    catch (Exception ex)
                    {
                        utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                        utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                        return;
                    }

                    if (ds.Tables["resultado"].Rows.Count > 0)
                    {
                        dtMedidasAdmin = ds.Tables["resultado"];
                        dtMedidasAdmin.Columns.Add("i_index");
                        dtMedidasAdmin.Columns.Add("raya");
                    }
                    i = 1;
                    foreach (DataRow row in ds.Tables["resultado"].Rows)
                    {
                        row["i_index"] = i.ToString();
                        row["raya"] = "";
                        dtMedidasAdmin.AcceptChanges();
                        i++;

                    }
                    dtMedidasAdmin = dtMedidasAdmin.Copy();
                }

                dtcopias.TableName = "seccion7";
                dtViolaciones.TableName = "violaciones";
                dtViolaciones2.TableName = "violaciones2";
                //dtSubmaterias.TableName = "seccion1";
                dtMedidasRecorr.TableName = "seccion2";
                dtMedidasAdmin2.TableName = "seccion3";

                if (tipo == 9 || tipo == 13 || tipo == 19)
                {
                    if (dtSubmaterias.Rows.Count > 0 && dtMedidasAdmin.Rows.Count > 0)
                    {
                        dtSubmaterias.TableName = "seccion1";
                        dtMedidasAdmin.TableName = "medidas";
                        dset.Tables.Add(dtSubmaterias);
                        dset.Tables.Add(dtMedidasAdmin);
                        dset.Relations.Add(
                                new DataRelation("relacion1", dtSubmaterias.Columns["submateria_id"], dtMedidasAdmin.Columns["submateria_id"])
                                );

                    }
                    //dset.Tables.Add(dtMedidasAdmin);
                    dset.Tables.Add(dtMedidasRecorr);
                }

                if ((tipo == 14 || tipo == 15) && midtoB.subtipo_inspeccion_id == 3)
                {
                    dset.Tables.Add(dtMedidasRecorr);
                    dset.Tables.Add(dtMedidasAdmin2);
                }
                dset.Tables.Add(dtcopias);
                dset.Tables.Add(dtViolaciones);
                DtoDoctoBusqueda dtoBusqueda = new DtoDoctoBusqueda();
                
                dtoBusqueda.documento_id = documento_id;
                try
                {
                    ds = miComponente.CalifDoctoVariableValores_Obtener(dtoBusqueda);
                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }

                string[] variable = new string[ds.Tables["resultado"].Rows.Count];
                object[] valor = new object[ds.Tables["resultado"].Rows.Count];


                for (int indice = 0; indice < ds.Tables["resultado"].Rows.Count; indice++)
                {
                    variable[indice] = ds.Tables["resultado"].Rows[indice]["var_variable"].ToString();
                    valor[indice] = ds.Tables["resultado"].Rows[indice]["dv_valor"].ToString();
                }

                doc.MailMerge.Execute(variable, valor);


                doc.MailMerge.Execute(
                            new string[] {
                        "med_admin",
                        "med_recor"

                    },
                            new object[] {
                         medidas1,medidas2
                    });
                dtoBusqueda.dp_variable = String.Empty;

                try
                {
                    ds = miComponente.CalifDoctoParrafoTexto_Obtener(dtoBusqueda);
                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }

                Hashtable mihash = new Hashtable();

                for (i = 0; i < doc.Range.Bookmarks.Count; i++)
                {

                    mihash.Add(doc.Range.Bookmarks[i].Name, doc.Range.Bookmarks[i].Name);

                }

                DocumentBuilder builder = new DocumentBuilder(doc);

                foreach (DataRow row in ds.Tables[1].Rows)
                {

                    if (mihash.ContainsKey(row["variablesintags"].ToString()))
                    {

                        Bookmark bookmark = doc.Range.Bookmarks[row["variablesintags"].ToString()];
                        builder.MoveToBookmark(bookmark.Name);
                        if (bookmark.Text == "")
                        {
                            //if (row["variablesintags"].ToString() == "FIRMANTE_FUNDAMENTO_ORDEN" || row["variablesintags"].ToString() == "MOTIVACIÓN_TIPO" || row["variablesintags"].ToString() == "HORA_ACTUACIÓN")
                            //{
                            //    builder.InsertHtml("<span style='text-transform:uppercase; font-family:Arial'>" + row["parrafovariables"].ToString() + "</span>");

                            //}
                            //else
                            builder.InsertHtml("<span style='font-family:Arial;font-size:x-small'>" + row["parrafovariables_replace"].ToString() + "</span>");
                        }
                        //  bookmark.Text = doc.GetText();
                        // bookmark.Text = row["parrafovariables"].ToString();

                        //if (row["variablesintags"].ToString() == "ACTUACIÓN_CONJUNTA" && numinsp == 1)
                        //{
                        //    bookmark.Text = "";
                        //}
                        //if (row["variablesintags"].ToString() == "PARTICIPACIÓN_EXPERTOS" && numexp == 0)
                        //{
                        //    bookmark.Text = "";
                        //}
                    }

                }

                //doc.MailMerge.CleanupOptions = MailMergeCleanupOptions.RemoveUnusedRegions;




                doc.MailMerge.ExecuteWithRegions(dset);
                //doc.Save("InformeComision.doc", SaveFormat.Doc, SaveType.OpenInWord, Response);
                switch (tipo)
                {
                    case 9:
                        doc.Save(Response, "AmpliacionTermino.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                    case 10:
                        doc.Save(Response, "AcuerdodeReprogramacion.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                    case 11:
                        doc.Save(Response, "AcuerdodeArchivo.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                    case 12:
                        doc.Save(Response, "AcuerdodeTermino.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                    case 13:
                        doc.Save(Response, "EmplazamientodeMedidas.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                    case 14:
                        doc.Save(Response, "SIPASC.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                    case 15:
                        doc.Save(Response, "SIPAS.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                    case 19:
                        doc.Save(Response, "EmplazamientoDocumental.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                    case 20:
                        doc.Save(Response, "AcuerdoModificacionDNE.doc", ContentDisposition.Attachment, SaveOptions.CreateSaveOptions(SaveFormat.Doc));
                        break;
                }
            }
            #endregion
            //Context.Items["DtoDFT"] = miDtf;
            //Server.Transfer("~/DFT/DFTConsultarExpediente.aspx");
            //documento de emplazamiento
            #region documentos emplazamiento
            if (tipo ==9)
            {
                DataTable dtcopias = new DataTable();
                DataTable dtSubmaterias = new DataTable();
                DataTable dtMedidasAdmin = new DataTable();
                DataTable dtMedidasRecorr = new DataTable();
                DataSet dset = new DataSet();
                DataSet ds = new DataSet();
                Document doc = new Document(Server.MapPath(plantilla));
                int i;
                String medidas1 = String.Empty;
                String medidas2 = String.Empty;
                //obtener las copias
                try
                {
                    ds = miComponente.InspeccionCopia_ObtenerPorInspeccionID(midtoB.inspeccion_id);
                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }

                if (ds.Tables["resultado"].Rows.Count > 0)
                {
                    dtcopias = ds.Tables["resultado"];
                    dtcopias.Columns.Add("ccp");
                    dtcopias.AcceptChanges();
                }
                i = 1;
                foreach (DataRow row in ds.Tables["resultado"].Rows)
                {
                    if (i == 1)
                        row["ccp"] = "C.c.p.";
                    else row["ccp"] = "";
                    dtcopias.AcceptChanges();
                    i++;

                }
                dtcopias = dtcopias.Copy();

                //obtener medidas administrativas para ampliacion de término
               
                try
                {
                    ds = miComponente.SubmateriaMedidasAdmin_ObtenerEmplazamiento(midtoB.emplazamiento_id, -1);
                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }

                if (ds.Tables["resultado"].Rows.Count > 0)
                {
                    medidas1 = "MEDIDAS ADMINISTRATIVAS";
                    dtSubmaterias = ds.Tables["resultado"];
                }
                dtSubmaterias = dtSubmaterias.Copy();

                //sacar las medidas de cada submateria
                try
                {
                    ds = miComponente.MedidasAdminPorSubmateriaEmplazamiento_Obtener(midtoB.emplazamiento_id, -1);
                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }

                if (ds.Tables["resultado"].Rows.Count > 0)
                {
                    dtMedidasAdmin = ds.Tables["resultado"];
                    dtMedidasAdmin.Columns.Add("i_index");
                    dtMedidasAdmin.Columns.Add("raya");
                }
                i = 1;
                char car = '\n';
                foreach (DataRow row in ds.Tables["resultado"].Rows)
                {
                    row["i_index"] = i.ToString();
                    row["raya"] = "";
                    dtMedidasAdmin.AcceptChanges();
                    i++;

                }
                dtMedidasAdmin = dtMedidasAdmin.Copy();

                //medidas del recorrido
                try
                {
                    ds = miComponente.Emplazamiento_ObtenerMedidasRecorrido(midtoB.emplazamiento_id);

                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos, intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }

                if (ds.Tables["resultado"].Rows.Count > 0)
                {
                    medidas2 = "MEDIDAS DE RECORRIDO";
                    dtMedidasRecorr = ds.Tables["resultado"];
                    dtMedidasRecorr.Columns.Add("i_index");
                }
                i = 1;
                foreach (DataRow row in ds.Tables["resultado"].Rows)
                {
                    row["i_index"] = i.ToString();
                    dtMedidasRecorr.AcceptChanges();
                    i++;

                }
                dtMedidasRecorr = dtMedidasRecorr.Copy();

                dtSubmaterias.TableName = "seccion1";
                dtMedidasAdmin.TableName = "medidas";
                dtMedidasRecorr.TableName = "seccion2";
                dtcopias.TableName = "seccion7";

                if (dtSubmaterias.Rows.Count > 0 && dtMedidasAdmin.Rows.Count > 0)
                {

                    dset.Tables.Add(dtSubmaterias);
                    dset.Tables.Add(dtMedidasAdmin);
                    dset.Relations.Add(
                            new DataRelation("relacion1", dtSubmaterias.Columns["submateria_id"], dtMedidasAdmin.Columns["submateria_id"])
                            );

                }
                dset.Tables.Add(dtMedidasRecorr);
                dset.Tables.Add(dtcopias);

                DtoDoctoBusqueda dtoBusqueda = new DtoDoctoBusqueda();

                dtoBusqueda.documento_id = documento_id;


                try
                {
                    ds = miComponente.DoctoVariableValores_Obtener(dtoBusqueda);
                }
                catch (Exception ex)
                {
                    utilerias.web.alerta.mensaje("No se pudo conectar con la base de datos intente de nuevo más tarde", Page);
                    utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                    return;
                }


                foreach (DataRow row in ds.Tables["resultado"].Rows)
                {

                    doc.MailMerge.Execute(
                            new string[] {
                        row["var_variable"].ToString()

                    },
                            new object[] {
                         row["dv_valor"].ToString()
                    });
                }

                doc.MailMerge.Execute(
                            new string[] {
                        "MEDIDAS_ADMIN",
                        "MEDIDAS_RECORR"

                    },
                            new object[] {
                         medidas1,medidas2
                    });

                doc.MailMerge.CleanupOptions = MailMergeCleanupOptions.RemoveUnusedRegions;

                doc.MailMerge.ExecuteWithRegions(dset);
                doc.Save(Response, "AmpliacionTermino.doc", ContentDisposition.Attachment, Aspose.Words.Saving.SaveOptions.CreateSaveOptions(SaveFormat.Doc));
            }
             #endregion

        }

        int obtenerCVEURInspeccion(int inspeccion_id)
        {
            DtoInspeccion miinspeccion = new DtoInspeccion();
            miinspeccion.inspeccion_id = inspeccion_id;
            int cve_ur = -1;
            DataSet ds;
            try
            {
                ds = miComponente.Inspeccion_Obtener(miinspeccion);
            }
            catch (Exception ex)
            {
                utilerias.log.error((new System.Diagnostics.StackFrame()).GetMethod().Name, Page.AppRelativeVirtualPath, ex.Message);
                return 0;
            }

            if (ds.Tables["resultado"].Rows.Count > 0)
            {
                int.TryParse(ds.Tables["resultado"].Rows[0]["cve_ur"].ToString(), out cve_ur);
            }

            return cve_ur;
        }

        protected void lbdescarga2_Click(object sender, CommandEventArgs e)
        {

            //DtoDFT miDtf = new DtoDFT();

            //String[] info = e.CommandArgument.ToString().Split('|');
            //int.TryParse(info[0], out miDtf.centro_trabajo_id);

            //miDtf.PageCaller.Push("~/Inspector/InspectorDesahogoInspeccion.aspx");
            //miDtf.dtoBusqueda.fecha_inicio = tbFechaini.Text;
            //miDtf.dtoBusqueda.nombre = txtNombre.Text;
            //miDtf.dtoBusqueda.num_expediente = txtNoInspeccion.Text;
            ////miDtoDshgo.BuscarFechaprogramada = tbFechaini.Text;
            ////miDtoDshgo.BuscarNombreRazonSocial = txtNombre.Text;
            ////miDtoDshgo.BuscarNoinspeccion = txtNoInspeccion.Text;
            //Context.Items["DtoDFT"] = miDtf;
            //Server.Transfer("~/DFT/DFTConsultarExpediente.aspx");

        }
        protected void btnAdjuntar_Click(object sender, EventArgs e)
        {
            Context.Items["DtoBusqueda"] = ViewState["DtoBusqueda"];
            Server.Transfer("~/Generales/ConsultaInspeccionAdjuntarArchivos.aspx");
        }
    }
}