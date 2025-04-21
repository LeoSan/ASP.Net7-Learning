<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPageIPA.Master" AutoEventWireup="true" CodeBehind="ConsultaInspeccion.aspx.cs" Inherits="Inspeccion_PA.Generales.ConsultaInspeccion" Theme="Tema1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%@ Register  Src="~/UserControls/Navegador.ascx" TagName="Navegador" TagPrefix="uc" %>
<%@ register src="~/UserControls/wucCentroTrabajo.ascx" tagprefix="uc" tagname="wucCentroTrabajo" %>
<%@ Register Src="~/UserControls/wucMessageBox.ascx" TagPrefix="uc1" TagName="wucMessageBox" %>
<!--@ Contenedor Busqueda General @--> 
    <div id="divBusqueda" runat="server">
    <h3 class="titulo-seccion principal"> <asp:Literal ID="ltTitulo" runat="server">Seguimiento de inspecciones</asp:Literal></h3>
    <div class="row">
        <div class="form-group form-element-siapi col-md-4">
            <label for="cvNombre" class="label-form mb-2">
                Nombre o razón social
            </label>
            <asp:TextBox ID="tbNombre" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:CustomValidator ID="cvNombre" runat="server" Display="Dynamic" ValidationGroup="validar" ErrorMessage="El nombre debe tener al menos 4 letras" ForeColor="Red" OnServerValidate="cvNombre_ServerValidate"></asp:CustomValidator>            
        </div>
        <div class="form-group form-element-siapi col-md-4" id="trRFC" runat="server">
            <label for="cvRFC" class="label-form mb-2" >
                RFC
            </label>
                    <asp:TextBox ID="tbRFC" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:CustomValidator ID="cvRFC" runat="server" Display="Dynamic" ValidationGroup="validar"
                        ErrorMessage="Debe Ingresar el RFC Completo" ForeColor="Red" OnServerValidate="cvRFC_ServerValidate"></asp:CustomValidator>
        </div>
        <div class="form-group form-element-siapi col-md-4" id="trExp" runat="server">
            <label for="tbExpediente"  class="label-form mb-2">
                No. de expediente
            </label>
            <asp:TextBox ID="tbExpediente" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group form-element-siapi col-md-4">
            <label>
                Periodo
            </label>
           <div class="row"> 
               <div class="form-group form-element-siapi col-md-6">
                    <asp:TextBox ID="tbFechaDe" runat="server" CssClass="form-control flatpickr js-flatpickr-date-dmY-Diag" placeholder="Del"></asp:TextBox>
                    
                        <asp:RegularExpressionValidator ID="revFechade" runat="server" 
                        CssClass ="msg-alert"
                        ControlToValidate="tbFechaDe" ErrorMessage="Formato de fecha inválido" 
                        ForeColor="Red"  ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$" 
                        ValidationGroup="validar"></asp:RegularExpressionValidator>
                   
                </div>
                <div class="form-group form-element-siapi col-md-6">
                   
                    <asp:TextBox ID="tbFechaA" runat="server"  CssClass="form-control flatpickr js-flatpickr-date-dmY-Diag" placeholder="Al"></asp:TextBox>
                   
                        <asp:RegularExpressionValidator ID="valide_tbFechaA" runat="server" 
                            CssClass="msg-alert"
                            ControlToValidate="tbFechaA" ErrorMessage="Formato de fecha inválido" 
                            ForeColor="Red" 
                            ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$" 
                            ValidationGroup="validar"></asp:RegularExpressionValidator>
                    <br />
                        <asp:CompareValidator ID="valide_tbFechaA2" runat="server" 
                            CssClass="msg-alert"
                            ControlToCompare="tbFechaDe" ControlToValidate="tbFechaA" 
                            Display="Dynamic" 
                            ErrorMessage="Fecha final debe ser mayor o igual a fecha inicial" 
                            ForeColor="Red" Operator="GreaterThanEqual" Type="Date" 
                            ValidationGroup="validar"></asp:CompareValidator>
                   
               </div>
           </div>
        </div>
    </div>
<!--@ Contenedor Botones @--> 
    <div class="row">
        <div class="col-12">
            <asp:Button ID="btnBusqueda"    CssClass="btn btn-secondary float-end ms-2 "   runat="server" Text="Búsqueda avanzada" OnClick="btnBusqueda_Click" Visible="false" />
            <asp:Button ID="btnAceptar"     CssClass="btn btn-primary float-end ms-2"     runat="server" Text="Consultar" OnClick="btnAceptar_Click" ValidationGroup="validar" />
            <asp:Button ID="btnCancelar"    CssClass="btn btn-secondary float-end ms-2 "    runat="server" Text="Limpiar filtro" OnClick="btnLimpiar_Click" CausesValidation="False" />
        </div>
    </div>
</div>
<div class="row justify-content-center max-table-sm" id="msjUltimaInspeccion" runat="server">
        <div class="col-12 mt-3 ms-auto" >
            <span><p class="alert alert-primary mb-0"><img class="me-1" src="../App_Themes/Tema1/img/alert-circle-fill.svg"></span><strong>Información</strong>: Solo se muestran las fechas de las últimas inspecciones de CGT, SH y CA en estatus con Acta.</p>
        </div>
    </div>
<!--@ Contenedor filtros de busqueda @--> 
    <div id="divAvanzada" runat="server" visible="false" >
        
    <div class="row">
        <div class="form-group form-element-siapi col-md-3">
            <label for="ddlEstado" class="label-form mb-2">
                 Unidad responsable
            </label>
                    <asp:DropDownList ID="DropDownList1" CssClass="form-select" runat="server">
                    </asp:DropDownList>
        </div>
        <div class="form-group form-element-siapi col-md-3" id="Div1" runat="server">
            <label for="ddlEstado" class="label-form mb-2" >
                Tipo de inspección
            </label>
                    <asp:DropDownList ID="DropDownList2" CssClass="form-select" runat="server">
                    </asp:DropDownList>

        </div>
        <div class="form-group form-element-siapi col-md-3" id="Div2" runat="server">
            <label for="ddlEstado" class="label-form mb-2">
                Subtipo de inspección
            </label>
                    <asp:DropDownList ID="DropDownList3" CssClass="form-select" runat="server">
                    </asp:DropDownList>
        </div>        
        <div class="form-group form-element-siapi col-md-3" runat="server">
            <label for="ddlEstado" class="label-form mb-2">
                Materia de inspección
            </label>
                    <asp:DropDownList ID="DropDownList4" CssClass="form-select" runat="server">
                    </asp:DropDownList>
        </div>
    </div>        
    <div class="row">
        <div class="form-group form-element-siapi col-md-3">
            <label for="ddlEstado" class="label-form mb-2">
                 Operativo
            </label>
                    <asp:DropDownList ID="DropDownList5" CssClass="form-select" runat="server">
                    </asp:DropDownList>
        </div>
        <div class="form-group form-element-siapi col-md-3"  runat="server">
            <label for="ddlEstado" class="label-form mb-2" >
                Inspector
            </label>
                    <asp:DropDownList ID="DropDownList6" CssClass="form-select" runat="server">
                    </asp:DropDownList>

        </div>
        <div class="form-group form-element-siapi col-md-3"  runat="server">
            <label for="ddlEstado" class="label-form mb-2">
                No. de expediente
            </label>
            <asp:TextBox ID="tbExpediente0" runat="server"  CssClass="form-control"></asp:TextBox>
        </div>        
        <div class="form-group form-element-siapi col-md-3" runat="server">
            <label for="ddlEstado" class="label-form mb-2">
                Nombre o razón social
            </label>
                    <asp:TextBox ID="tbNombre0" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:CustomValidator ID="cvNombre0" runat="server" Display="Dynamic" ValidationGroup="validar"
                        ErrorMessage="El nombre debe tener al menos 4 letras" ForeColor="Red" OnServerValidate="cvNombre_ServerValidate"></asp:CustomValidator>
        </div>
    </div>        
    <div class="row">
        <div class="form-group form-element-siapi col-md-3">
            <label for="ddlEstado" class="label-form mb-2">
                 Calle y número
            </label>
            <asp:TextBox ID="tbNombre1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group form-element-siapi col-md-3"  runat="server">
            <label for="ddlEstado" class="label-form mb-2" >
                Entidad federativa
            </label>
                    <asp:DropDownList ID="DropDownList7" CssClass="form-select" runat="server">
                    </asp:DropDownList>

        </div>
        <div class="form-group form-element-siapi col-md-3"  runat="server">
            <label for="ddlEstado" class="label-form mb-2">
                Municipio
            </label>
            <asp:DropDownList ID="DropDownList8" CssClass="form-select" runat="server">  </asp:DropDownList>

        </div>        
        <div class="form-group form-element-siapi col-md-3" runat="server">
            <label for="ddlEstado" class="label-form mb-2">
                Etapa
            </label>
            <asp:DropDownList ID="DropDownList9" CssClass="form-select" runat="server">   </asp:DropDownList>
        </div>
    </div>        
    <div class="row">
        <div class="form-group form-element-siapi col-md-4">
            <label for="ddlEstado" class="label-form mb-2">
                Periodo
            </label>
            <asp:TextBox ID="tbFechaDe0" runat="server" CssClass="form-control flatpickr js-flatpickr-date-dmY-Diag"></asp:TextBox>
                    <asp:CompareValidator ID="validate_tbFechaDe0" runat="server" ControlToValidate="tbFechaDe0" ForeColor="Red" Display="Dynamic" Operator="DataTypeCheck" Type="Date" ValidationGroup="validar">El formato de fecha es incorrecto</asp:CompareValidator>
                    &nbsp;
                    <asp:RegularExpressionValidator ID="revFechade0" runat="server" 
                        ControlToValidate="tbFechaDe0" ErrorMessage="Formato de fecha inválido" 
                        ForeColor="Red"                     
                        ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$" 
                        ValidationGroup="validar"></asp:RegularExpressionValidator>
        </div>
        <div class="form-group form-element-siapi col-md-4" id="Div3" runat="server">
            <label for="ddlEstado" class="label-form mb-2">
                a
            </label>
            <asp:TextBox ID="tbFechaA0" runat="server" CssClass="form-control flatpickr js-flatpickr-date-dmY-Diag"></asp:TextBox>
            <asp:CompareValidator ID="valide_tbFechaA0" runat="server" ControlToValidate="tbFechaA" ForeColor="Red" Display="Dynamic" Operator="DataTypeCheck" Type="Date" ValidationGroup="validar">El formato de fecha es incorrecto</asp:CompareValidator>
            &nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="tbFechaA0" ErrorMessage="Formato de fecha inválido" 
                        ForeColor="Red"   ValidationGroup="validar"   
                        ValidationExpression="^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$">
                        </asp:RegularExpressionValidator>


        </div>
    </div>  
        
    <div class="row">
        <div class="col-12">
            <form id="form5" action="seguimiento.html">
            </form>

            <asp:Button ID="btnConsultar" CssClass="btn btn-primary float-end ms-2 mt-3"     runat="server" Text="Consultar" OnClick="btnConsultar_Click" ValidationGroup="validar" />
        </div>
    </div>
</div>

<!--@ Contenedor Listado @--> 
    <div class="general table-responsive mt-5">
    <div id="divTablero" runat="server" visible="false" class="tabla5">
        <asp:Repeater ID="rptBusqueda" runat="server">
            <HeaderTemplate>
                <table width="740" align="center" cellspacing="0" cellpadding="0" border="0" id="mytable">
                <thead>
                    <tr>
                        <th>
                            Nombre o razón social
                        </th>
                        <th>
                            Domicilio
                        </th>
                        <th>
                            Última inspección CGT
                        </th>
                        <th>
                            Última inspección SH
                        </th>
                        <th >
                            Última inspección CA
                        </th>
                        <th>
                            Acciones
                        </th>
                    </tr>
                </thead>                  
                
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td width="219">
                        <%#Eval("nombre_empresa")%>&nbsp;
                    </td>
                    <td width="283">
                             <p class="tooltip-table">
                                  <%#(Eval("in_domicilio_inspeccion").ToString().Length > 15) ? ( (Eval("in_domicilio_inspeccion").ToString().Length <= 40)?Eval("in_domicilio_inspeccion").ToString():Eval("in_domicilio_inspeccion").ToString().Substring(0, 40) + "...") : Eval("in_domicilio_inspeccion").ToString()%>
						 <span><%#Eval("in_domicilio_inspeccion")%></span>
                             </p>
                    </td>
                    <td width="72" class="alt">
                        <asp:LinkButton ID="uiCGT" runat="server" CommandArgument='<%#Eval("inspeccion_id_cgt")+"|"+Eval("centro_trabajo_id")%>' OnCommand="btnUltimaICGT_Click" ><%# string.IsNullOrEmpty(Eval("ultima_inspeccion_cgt").ToString())?  "" : Convert.ToDateTime(Eval("ultima_inspeccion_cgt").ToString()).ToString("dd MMMM yyyy") %></asp:LinkButton>    
                    </td>
                    <td width="66" class="alt">
                        <asp:LinkButton ID="uiSH" runat="server" CommandArgument='<%#Eval("inspeccion_id_sh")+"|"+Eval("centro_trabajo_id")%>' OnCommand="btnUltimaISH_Click" ><%# string.IsNullOrEmpty(Eval("ultima_inspeccion_sh").ToString())?  "" : Convert.ToDateTime(Eval("ultima_inspeccion_sh").ToString()).ToString("dd MMMM yyyy") %></asp:LinkButton>   
                    </td>
                    <td width="66" class="alt">
                        <asp:LinkButton ID="iuCA" runat="server" CommandArgument='<%#Eval("inspeccion_id_ca")+"|"+Eval("centro_trabajo_id")%>' OnCommand="btnUltimaICA_Click" ><%# string.IsNullOrEmpty(Eval("ultima_inspeccion_ca").ToString())?  "" : Convert.ToDateTime(Eval("ultima_inspeccion_ca").ToString()).ToString("dd MMMM yyyy") %></asp:LinkButton>   
                    </td>
                    <td class="dropdown" style="text-align: center">
                            <button class="btn btn-acciones dropdown-toggle" type="button" id="dropdownMenuButton_<%#Eval("centro_trabajo_id") + "|" +  Eval("in_ct_razon_social") + "|" +  Eval("in_domicilio_inspeccion")%>" data-bs-toggle="dropdown" aria-expanded="false">
                                Seleccionar
                            </button>
                            <div class="dropdown-menu p-3" aria-labelledby="dropdownMenuButton<%#Eval("centro_trabajo_id") + "|" +  Eval("in_ct_razon_social") + "|" +  Eval("in_domicilio_inspeccion")%>">
                                
                                <asp:LinkButton ID="lbActuacion" runat="server" CommandArgument='<%#Eval("centro_trabajo_id") + "|" +  Eval("in_ct_razon_social") + "|" +  Eval("in_domicilio_inspeccion")+ "|" +  Eval("in_ct_rfc")%>' OnCommand="ibtnConsultar_Click" >
                                    <asp:Image ID="Image6" ImageUrl="~/App_Themes/Tema1/img/icon-eye.svg" runat="server"></asp:Image>
                                     Centro de trabajo
                                </asp:LinkButton>
                                
                                <asp:LinkButton ID="lbHistorial" runat="server" OnCommand="lbVer_Click" CommandArgument='<%#Eval("centro_trabajo_id") + "|" +  Eval("in_ct_razon_social") + "|" +  Eval("in_domicilio_inspeccion")%>' >
                                    <asp:Image ID="Image2" ImageUrl="~/App_Themes/Tema1/img/desahogo-dorado.svg" runat="server"></asp:Image>
                                    Historial
                                </asp:LinkButton>
                            </div>
                     </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <p class="text-center without-records" id="notice" runat="server">No se encontraron resultados.</p>
    </div>
    <div class="mt-3">
        <center>
            <uc:Navegador ID="navegador" runat="server" />                
        </center>
    </div>
</div>
    <uc:wuccentrotrabajo runat="server" id="wucCentroTrabajo" />
    <uc1:wucMessageBox runat="server" id="wucMessageBox" />
</asp:Content>

