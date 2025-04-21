<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPageIPA.Master" AutoEventWireup="true" CodeBehind="ConsultaInspeccionAmpliacion.aspx.cs" Inherits="Inspeccion_PA.Generales.ConsultaInspeccionAmpliacion" Theme="Tema1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br />

<br />
  <h3 class="titulo"> <asp:Image ID="Image1" runat="server" ImageUrl="~/App_Themes/Tema1/Imagenes/titlebullet.gif" />
  Datos de la ampliación de término</h3>
  
  <br />
  <br />
  
  <div id="divAsignar" runat="server">
    <table id="tblAsignar" runat="server" align="center" border="0" cellpadding="0" cellspacing="10" height="67" width="759px">
            <tbody><tr>

              <td colspan="2" height="19"><b>Datos del centro de 
				trabajo</b></td>
              </tr>
			<tr><td style="width:200px;">Nombre o razón social:</td>
			<td><asp:Literal ID="ltRazon" runat="server" Text="ltRazon" /></td>
		</tr>
		<tr><td>Tipo de actuación:</td>
			<td><asp:Literal ID="ltTipo" runat="server" Text="ltTipo" /></td>
		</tr>
		<tr><td>Subtipo de actuación:</td>
			<td><asp:Literal ID="ltSubtipo" runat="server" Text="ltSubtipo" /></td>
		</tr>
		<tr><td>Materia:</td>
			<td><asp:Literal ID="ltMateria" runat="server" Text="ltMateria" /></td>
		</tr>
		<tr><td>Fecha de inspección:</td>
			<td><asp:Literal ID="ltFecha" runat="server" Text="ltFecha" /></td>
		</tr>
        
             </tbody></table>

    <br />

     <table border="0" cellpadding="0" cellspacing="10" width="759" align="center">
           <tr>
            <td colspan="2" height="17"><b>Medidas para las que se solicita ampliación de término</b></td>
              </tr>
    </table>

    <div class="tabla3">
    <asp:Repeater ID="repMedidas" runat="server">
			<HeaderTemplate>
		<table width="759" align="center" border="0" cellpadding="0" cellspacing="0">
			<tr><th style="width:25px;">No.</th>
				<th>Medida</th>
			</tr>
			</HeaderTemplate>
			<ItemTemplate>
			<tr><td><asp:Literal ID="ltNum" runat="server" Text='<%#Eval("en_consecutivo")%>' /></td>
				<td><%#Eval("en_medida")%></td>
			</tr>
			</ItemTemplate>
		</asp:Repeater>

    <asp:Repeater ID="rptRecorrido" runat="server">
        <ItemTemplate>
			<tr><td><asp:Literal ID="ltNum" runat="server" Text='<%#Eval("en_consecutivo")%>' /></td>
				<td><%#Eval("medida")%></td>
			</tr>
			</ItemTemplate>
			<FooterTemplate>
		</table>
			</FooterTemplate>
		</asp:Repeater>
    </div>

    <table border="0" cellpadding="0" cellspacing="10" width="759" align="center">
           <tr>
            <td colspan="2" height="17"><b>Datos de la ampliación de término</b></td>
              </tr>
			<tr><td>Resolución de ampliación:</td>
				<td>
                    <asp:Literal ID="ltOtorga" runat="server"></asp:Literal>
				</td>
			</tr>
            <tr>
              <td height="17" style="width: 207px">Tipo de documento:</td>
              <td height="17" width="349px">Ampliación de término</td>
            </tr>
             <tr>
              <td style="width: 207px">Fecha de emisión:</td>
              <td    width="349px"> 
				  <asp:Literal ID="ltFechaEmosion" runat="server"></asp:Literal>
                 </td>
            </tr>
            <tr>
              <td style="width: 207px">Firma alguno de los titulares:</td>
              <td    width="349px"> 
                  <asp:Literal ID="ltTitulares" runat="server"></asp:Literal>
                 </td>

            </tr>
             <tr>
              <td style="width: 207px">Nombre del firmante:</td>
              <td    width="349px"> 
                  <asp:Literal ID="ltFirmante" runat="server"></asp:Literal>
                 </td>

            </tr>
             <tr>
              <td height="17" style="width: 207px">Cargo:</td>

              <td height="17" width="349px"> 
				  <asp:Literal ID="ltCargo" runat="server"></asp:Literal>
                 </td>

            </tr>
    </table>

	<table align="center" border="0" cellpadding="0" cellspacing="10" height="45" width="598px">
             <tbody><tr>
			 <td align="right" height="25" style="width: 368px">
                 <asp:Button ID="btnRegresar" runat="server" Text="Regresar" 
                     onclick="btnRegresar_Click" /></td>

			 <td align="right" height="25">
                 &nbsp;</td>

            </tr>
 </tbody></table>
  
  </div>

</asp:Content>
