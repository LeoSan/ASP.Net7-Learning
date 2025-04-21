<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPageIPA.Master" AutoEventWireup="true" CodeBehind="ConsultaInspeccionEtapas.aspx.cs" Inherits="Inspeccion_PA.Generales.ConsultaInspeccionEtapas" Theme="Tema1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<br/>

<br/>
  <h3 class="titulo"><asp:Image ID="Image1" ImageUrl="~/App_Themes/Tema1/imagenes/titlebullet.gif" runat="server" width="18" height="15"></asp:Image>
      Información del expediente de inspección</h3><br/>

  <br/>
   <table  cellpadding="0" border="0">
            <tbody><tr>
              <td width="197" height="14">Nombre o razón social:</td>

              <td height="14">
                  <asp:Literal ID="ltNombre" runat="server"></asp:Literal></td>
            </tr>
            
            <tr>
              <td width="197" height="13">Domicilio:</td>
              <td width="370" height="13">
                  <asp:Literal ID="ltDomicilio" runat="server"></asp:Literal></td>
            </tr>
            <tr>
              <td width="197" height="13">Subtipo:</td>
              <td width="370" height="13">
                  <asp:Literal ID="ltSubtipo" runat="server"></asp:Literal></td>
            </tr>
            <tr>
              <td width="197" height="13">Materia:</td>
              <td width="370" height="13">
                  <asp:Literal ID="ltMateria" runat="server"></asp:Literal></td>
            </tr>
            
            </tbody></table>

	
  <br/>
  <br/>  
  

  <asp:Repeater ID="rptInspeccion" runat="server">
  <HeaderTemplate>
    <table  width="757" class="tabla3" cellspacing="0" cellpadding="0" border="0" id="tab5">
          <tr>
            <th style=" text-align:center">Proceso</th>
            <th style=" text-align:center">Resultado</th>
            <th style=" text-align:center">Fecha</th>
            <%--<th style=" text-align:center">Actualizó</th>--%>
            <th style=" text-align:center">Consultar</th>
        </tr>
    </HeaderTemplate>
    <ItemTemplate>
		<tr>
            <td><%#Eval("etapa")%>&nbsp;</td>
            <td><%#Eval("resultado")%>&nbsp;</td>
            <td><%#Eval("fec_actualizacion")%>&nbsp;</td>
            <%--<td><%#Eval("actualizo")%>&nbsp;</td>--%>
            <td class="alt"><%#!Eval("in_etapa").ToString().Equals("7")?"":"&nbsp;" %>
                <asp:LinkButton ID="LinkButton1" runat="server" OnCommand="lbConsultar_Click" CommandArgument='<%#Eval("in_etapa") + ","  + Eval("tipo_documento_id") + "," + Eval("emplazamiento_id")  + "," + Eval("subtipo_inspeccion_id") %>'
                 Visible='<%#!Eval("in_etapa").ToString().Equals("7")?true:false %>'>
					<asp:Image ID="Image2" ImageUrl="~/App_Themes/Tema1/imagenes/ver.gif" runat="server" width="16" height="16"></asp:Image>
				</asp:LinkButton></td>
          </tr>
    </ItemTemplate>
    <FooterTemplate>
		  </table>
    </FooterTemplate>
    </asp:Repeater>

	<table  width="757" cellspacing="10" cellpadding="0" border="0">
		<tbody><tr>

			<td align="right" width="830">
                <asp:Button ID="btnRegresar" runat="server" Text="Regresar" 
                    onclick="btnRegresar_Click" /></td>	
	    </tr>
   </tbody></table>

  <br/>
  <br/>
</asp:Content>
