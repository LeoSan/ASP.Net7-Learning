<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPageIPA.Master" AutoEventWireup="true" CodeBehind="ConsultarHistorialInspeccionesCentroTrabajo.aspx.cs" Inherits="Inspeccion_PA.Generales.ConsultarHistorialInspeccionesCentroTrabajo" Theme="Tema1" %>

<%@ Register Src="~/UserControls/wucMessageBox.ascx" TagPrefix="uc1" TagName="wucMessageBox" %>
<%@ Register Src="~/UserControls/wucCentroTrabajo.ascx" TagPrefix="uc1" TagName="wucCentroTrabajo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <ul class="breadcrumb">
        <li><u>
            <asp:LinkButton ID="lbRegresar" runat="server" CssClass="center-vertical-element" OnCommand="lbRegresar_Click">Centro de trabajo</asp:LinkButton></u></li>
        <li>Historial de inspecciones</li>
    </ul>
    <h3 class="titulo-seccion principal">Historial de inspecciones de <a runat="server" id="lblrazonsocial"></a></h3>
    <div class="container">
        <div class="row  border-green bg-green-light h-100 mb-4">
            <div class="row mt-4">
                <div class="h-100 mb-4 small">
                    <div class="col-12">
                        <label class="label-form fw-bold">Empresa: </label>
                        <label runat="server" id="lblrazon_social" cssclass=" text-black-50"></label>
                        <asp:LinkButton ID="lbCentroTrabajo" CssClass="titulo-ver detalle" runat="server" OnClick="lbCentroTrabajo_Click" Text="Ver detalle del centro de trabajo" />
                    </div>
                    <div class="col-12">
                        <label class="label-form fw-bold">Domicilio del centro de trabajo: </label>
                        <label runat="server" id="lbldireccion" cssclass=" text-black-50"></label>
                    </div>
                </div>
            </div>
        </div>
        <center>
            <div class="row col-lg-7 col-xl-7  small" id="contadores" runat="server" visible="false">
                <div class="col-lg-2 col-md-2">
                    <div class="mb-2">
                        <h1><span class="grey-light ">3</span></h1>
                    </div>
                    <div class="mt-3"><b>Inspecciones realizadas</b></div>
                </div>
                <div class="col-lg-2 col-md-2">
                    <div class="mb-2">
                        <h1><span class="green">2</span></h1>
                    </div>
                    <div class="mt-3">
                        <p>Resolucion positiva</p>
                    </div>
                </div>
                <div class="col-lg-2 col-md-2">
                    <div class="mb-2">
                        <h1><span class="red">1</span></h1>
                    </div>
                    <div class="mt-3">
                        <p>Violaciones</p>
                    </div>
                </div>
                <div class="col-lg-2 col-md-2">
                    <div class="mb-2">
                        <h1><span class="yellow ">1</span></h1>
                    </div>
                    <div class="mt-3">
                        <p>Multas</p>
                    </div>
                </div>
                <div class="col-lg-2 col-md-2 ">
                    <div class="mb-2">
                        <h1><span class="grey ">0</span></h1>
                    </div>
                    <div class="mt-3">
                        <p>Juicios de nulidad</p>
                    </div>
                </div>
            </div>
        </center>

        <div class="row table-responsive mt-3 justify-content-center td-align-vertical mt-4" id="div1" runat="server">
            <div class="row border border-light rounded div_odd h-100" id="buscador" runat="server" visible="false">
                <div class="row mt-4">
                    <div class="form-group form-element-siapi col-md-6">
                        <asp:TextBox ID="txtBuscar" runat="server" placeholder="Busca por número de expediente"></asp:TextBox>
                    </div>
                    <div class="form-group form-element-siapi col-md-6 text-left ">
                        <asp:LinkButton ID="imgbtnBuscar" runat="server" CssClass="btn btn-primary rounded" OnClick="imgbtnBuscar_Click">
                            <asp:Image ID="icon_eye" ImageUrl="../App_Themes/Tema1/img/search_white.svg" runat="server"></asp:Image></asp:LinkButton>
                    </div>
                </div>
            </div>
            <div class="border-green mb-2">
                <br />
                <asp:Repeater ID="rephistorialinspecciones" runat="server">
                    <HeaderTemplate>
                        <table class="table" border="0" align="center" cellpadding="0" cellspacing="0" id="tab5">
                            <thead>
                                <tr>
                                    
                                    <th class="text-start">Número expediente</th>
                                    <th class="text-center">Fecha</th>                                    
                                    <th class="text-center">Etapa</th>                                    
                                    <th class="text-center">Resolución</th>
                                    <th class="text-center" >Sentido Resolución</th>
                                    <th class="text-center">Multas</th>
                                    <th class="text-center">Inspector</th>
                                    <th class="text-center">Revisar</th>
                                </tr>
                            </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td class="text-start">
                                <asp:Literal ID="Literal7" runat="server" Text='<%#Eval("numero_expediente")%>'></asp:Literal></td>
                            <td class="text-center">
                                <asp:Literal ID="Literal8" runat="server" Text='<%#DateTime.Parse(Eval("fecha_inspeccion").ToString()).ToString("d MMMM yyyy")%>'></asp:Literal></td>
                            <td class="text-center"><span><%#Eval("etapa")%></span></td>                            
                            <td class="text-center">
                                <asp:Literal ID="Literal10" runat="server" Text='<%#revisarResolucion(Eval("resolucion").ToString()) %>'></asp:Literal></td>
                             <td class="text-center">
                                <asp:Literal ID="Literal2" runat="server"  Text='<%# revisarSentidoResolucion(Eval("multa").ToString()) %>'></asp:Literal></td>
                              <td class="text-center">
                                <asp:Literal ID="Literal1" runat="server"  Text='<%# revisarMulta(revisarSentidoResolucion(Eval("multa").ToString())) %>'></asp:Literal></td>
                            <td class="text-center">
                                <asp:Literal ID="Literal12" runat="server" Text='<%#Eval("inspector")%>'></asp:Literal>
                            </td>
                            <td class="text-center">
                                <asp:HyperLink ID="hlRevisar" runat="server" CssClass="center-vertical-element" Target="_blank" Visible='<%#Eval("estatus_notificacion").ToString()=="No aplica"?true:false %>'                                    
                                    NavigateUrl='<%#Eval("inspeccionid","~/Expedientes/ExpedientesProgramacion.aspx?inspeccion_id={0}")%>'> 
                                    <asp:Image ID="Image1" CssClass="me-2" ImageUrl="~/App_Themes/Tema1/img/icon-eye.svg" runat="server" />
                                    Consultar
                                </asp:HyperLink>

                                <%-- Para mandar varios valores por Navigate URL                                    
                                    NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.inspeccionid", "~/Expedientes/ExpedientesProgramacion.aspx?inspeccion_id={0}") + DataBinder.Eval(Container, "DataItem.num_solicitud", "&num_solicitud={0}" ) + DataBinder.Eval(Container, "DataItem.codigo_documento", "&codigo_documento={0}" ) %>'>--%>

                                 
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
                 <p class="text-center without-records" id="notice" runat="server">No se encontraron resultados.</p>
               <%-- <div class="row message-alert" id="alerta_inspeccion" visible="false" runat="server">
                    <div class="col-lg-12 pt-1">
                        <div class="alert alert-status alert-dismissable small">                            
                             <asp:Image ID="Image1" CssClass="me-2" ImageUrl="~/App_Themes/Tema1/img/alert-circle-fill.svg" runat="server" />
                            <strong>Nota:</strong> Actualmente no existe historial de inspecciones.
                        </div>                        
                    </div>                    
                </div>     --%>           
            </div>
        </div>
    </div>
    <uc1:wucmessagebox runat="server" id="wucMessageBox" />
    <uc1:wuccentrotrabajo runat="server" id="wucCentroTrabajo" />
</asp:Content>
