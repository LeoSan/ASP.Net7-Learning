<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPageIPA.Master" Theme ="Tema1" AutoEventWireup="true" CodeBehind="ConsultaMedidasViolaciones.aspx.cs" Inherits="Inspeccion_PA.Generales.ConsultaMedidasViolaciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h3 align="left" class="titulo"><asp:Image ID="Image4" ImageUrl="~/App_Themes/Tema1/imagenes/titlebullet.gif" runat="server" width="18" height="15"></asp:Image>
    <asp:Literal ID="ltTitulo" runat="server"></asp:Literal><br/><br/>
  <br/>
  <br/>  
  	</h3>  


<div id="MedidasAdmin" runat ="server" visible="false">

<table align="center" width="751" cellspacing="5" border="0">
  <tbody><tr>
    <td class="contenido_bold"><b>Medidas administrativas</b></td>

  </tr>
  </tbody></table>
    
	<br/>
	
	<asp:Repeater ID="rptMedidasAdm" runat="server">
    <HeaderTemplate>
    <table align="center" width="750" cellspacing="0" cellpadding="0" border="0" id="tab5" class="tabla3">
          <tr>
            <th width="4"> </th>
            <th width="575">Medidas</th>

            <th width="86">Plazo</th>
          </tr>
        </HeaderTemplate>
        <ItemTemplate>
          <tr id ="trSub" runat="server" visible='<%#Sub(Eval("sub").ToString()) %>'>
            <td colspan="3">
                <b><%#Eval("sub").ToString() %></b>
            </td>
          </tr>
          <tr>
            <td width="10"><%#Container.ItemIndex + 1 %>&nbsp; </td>

            <td>
                <%#Eval("medidatags") %>
            </td>
            <td width="92" class="alt">
			<%#Eval("plazos")%></td>
          </tr>
          </ItemTemplate>


 <FooterTemplate>
 </table></FooterTemplate>    

</asp:Repeater>
</div>
<br />
<br />

<div id="MedidasRecorrido" runat ="server" visible="false">

<table align="center" width="751" cellspacing="5" border="0">
  <tbody><tr>
    <td class="contenido_bold"><b>Medidas de recorrido</b></td>

  </tr>
  </tbody></table>
    
	<br/>
	
	<asp:Repeater ID="rptMedidasRec" runat="server">
    <HeaderTemplate>
    <table align="center" width="750" cellspacing="0" cellpadding="0" border="0" id="tab5" class="tabla3">
          <tr>
            <th width="4"> </th>
            <th width="490">Medidas</th>
             <th width="85">Areas</th>

            <th width="86">Plazo</th>
          </tr>
        </HeaderTemplate>
        <ItemTemplate>
          <tr id ="trSub" runat="server" visible='<%#Sub1(Eval("sub").ToString()) %>'>
            <td colspan="4">
                <b><%#Eval("sub").ToString() %></b>
            </td>
          </tr>
          <tr>
            <td width="10"><%#Container.ItemIndex + 1 %>&nbsp;  </td>

            <td>
                <%#Eval("medida") %>
            </td>

            <td>
                <%#Eval("darea_area")%>
            </td>


            <td>
			<%#Eval("plazos")%></td>
          </tr>
          </ItemTemplate>


 <FooterTemplate>
 </table></FooterTemplate>    

</asp:Repeater>
    <br />
    <br />
</div>
    <br />
    <br />


<div id="Violaciones" runat ="server" visible="false">
	<asp:Repeater ID="rptViolacion" runat="server">
    <HeaderTemplate>
        <table align="center" width="750" cellspacing="0" cellpadding="0" border="0" id="tab5" class="tabla3">
        <tr>
                    <th width="4"> </th>
                    <th width="702">Violaciones</th>
                  </tr>
    </HeaderTemplate>
    <ItemTemplate>
           <tr id ="trSub" runat="server" visible='<%#Sub2(Eval("sub").ToString())&&!Eval("sub").ToString().Equals("") %>'>
            <td colspan="3">
                <b><%#Eval("sub").ToString() %></b>
            </td>
          </tr>

          <tr>
              <td width="10"><%#Container.ItemIndex + 1 %>&nbsp;  </td>
            <td><%#Eval("medida_violacion").ToString()%></td>
          </tr>
          </ItemTemplate>
<FooterTemplate>
</table>
</FooterTemplate>
</asp:Repeater>

</div>

<br />
<br />
	<table align="center" width="634" cellspacing="7" cellpadding="0" border="0">
		<tbody><tr>
			<td align="right" width="620" valign="top">
                <asp:Button ID="btnRegresar" runat="server" Text="Regresar" 
                    onclick="btnRegresar_Click" />
            </td>
		</tr>
	</tbody></table><br/><br/>

    
</asp:Content>