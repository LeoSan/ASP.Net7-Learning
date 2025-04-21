<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPageIPA.Master" AutoEventWireup="true" CodeBehind="Cuenta.aspx.cs" Inherits="Inspeccion_PA.Generales.Cuenta" Theme="Tema1" %>
<%@ register src="~/UserControls/wucMessageBox.ascx" tagprefix="uc1" tagname="wucMessageBox"   %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<h3 class="titulo-seccion principal">Datos de cuenta de usuario</h3>

<div class="row form-group">
    <div class="col-md-4 form-element-siapi">
        <label for="ltfechainicio" class="label-form">Nombre</label>
        <p><asp:Literal ID="ltNombre" runat="server"></asp:Literal></p>
    </div>
    <div class="col-md-4 form-element-siapi">
        <label for="lthora" class="label-form">Puesto</label>
        <p><asp:Literal ID="ltPuesto" runat="server"></asp:Literal></p>
    </div>
	<div class="col-md-4 form-element-siapi">
        <label for="lthora" class="label-form">Teléfono <data class="requiredfield">*</data></label>
        <p><asp:TextBox ID="tbTelefono" runat="server" MaxLength="50" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ControlToValidate="tbTelefono" ErrorMessage="Campo requerido" ValidationGroup="validar" Display="Dynamic"></asp:RequiredFieldValidator></p>
    </div>
	<div class="col-md-4 form-element-siapi">
        <label for="lthora" class="label-form">Correo electrónico <data class="requiredfield"></data></label>
        <p><asp:Literal ID="ltCorreo" runat="server"></asp:Literal></p>
        <asp:HiddenField ID="tbEmail" runat="server" Value="" />
    </div>
	<%-- <div class="col-md-4 form-element-siapi">
        <label for="tbPassActual">Contraseña actual</label>
        <p><asp:TextBox ID="tbPassActual" runat="server" TextMode="Password" MaxLength="10" CssClass="form-control"></asp:TextBox>
    </div>
	 <div class="col-md-4 form-element-siapi">
        <label for="ltfechainicio" class="label-form"><label for="tbPassNuevo1">Nueva contraseña</label></label>
        <p><asp:TextBox ID="tbPassNuevo1" runat="server" TextMode="Password" MaxLength="10" CssClass="form-control"></asp:TextBox><br />
			<asp:CustomValidator ID="cvPasssNuevo1" runat="server" ForeColor="Red" ErrorMessage="Las contrase&#241;as no coinciden" Display="Dynamic" ValidationGroup="validar" Width="170px" OnServerValidate="cvPasssNuevo1_ServerValidate"></asp:CustomValidator>
		</p>
    </div>
	<div class="col-md-4 form-element-siapi">
        <label for="tbPassNuevo2">Confirmar contraseña</label>
        <p><asp:TextBox ID="tbPassNuevo2" runat="server" TextMode="Password" MaxLength="10" CssClass="form-control"></asp:TextBox><br />
            <asp:CustomValidator ID="cvPassNuevo2" runat="server" ForeColor="Red" ErrorMessage="Las contrase&#241;as no coinciden" Display="Dynamic" ValidationGroup="validar" Width="171px" OnServerValidate="cvPasssNuevo1_ServerValidate"></asp:CustomValidator></p>
    </div>--%>
    <div class="form-element-siapi col-md-12">
            <asp:Button ID="Aceptar" runat="server" Text="Aceptar" OnClick="Aceptar_Click" CssClass="btn btn-primary float-end mb-3 ms-3" ValidationGroup="validar" />
            <asp:Button ID="Cancelar" runat="server" Text="Cancelar" OnClick="Cancelar_Click" CssClass="btn btn-cancelar float-end mb-3 ms-3" />
        </div>
</div>
    <uc1:wucmessagebox runat="server" id="wucMessageBox" />
</asp:Content>
