<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/MasterPageIPA.Master" AutoEventWireup="true" CodeBehind="ConsultaCatalogosSHXLS.aspx.cs" Inherits="Inspeccion_PA.Generales.ConsultaCatalogosSHXLS" Theme="Tema1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="divExcel" runat="server" style="font-size:12px; font-family:Arial">
<br/>
	<h3>Catálogo de medidas y violaciones de Seguridad e higiene</h3>
    <br />
    <h4>Normatividad: <asp:Literal ID="ltTituloNormatividad" runat="server" ></asp:Literal></h4>
    <br />
    <asp:Repeater ID="rptSubmaterias" runat="server" >
    <HeaderTemplate>
      <table style="font-size:12px; font-family:Arial"  align="center" cellspacing="8" cellpadding="0" border="0">
    </HeaderTemplate>
    <ItemTemplate>
      <tr>
        <td>
        <b><%#Eval("nombre").ToString().ToUpper()%></b>
        </td>
      </tr>
        <tr><td>
        
        <asp:Repeater ID="rptMedidas" runat="server" DataSource='<%#  ObtenerMedidas(Eval("submateria_id").ToString()) %>'>
         <HeaderTemplate>
           <table style="font-size:12px; font-family:Arial"  align="center" cellspacing="8" cellpadding="0" border="1">
             <tr>
                <th align="center" valign="top" style="background-color:#93CDDD; width:30;" ><b>No.</b></th>
                <th align="center" valign="top" style="background-color:#93CDDD"><b>Tipo de incumplimiento</b></th>
                <th align="center" valign="top" style="background-color:#93CDDD"><b>Descripción</b></th>
                <th align="center" valign="top" style="background-color:#93CDDD"><b>Fundamento</b></th>
                <th align="center" valign="top" style="background-color:#93CDDD"><b>Plazo</b></th>
                <th align="center" valign="top" style="background-color:#93CDDD"><b>Tema medidas por NOM</b></th>
                <th align="center" valign="top" style="background-color:#93CDDD"><b>Temas medidas frecuentes</b></th>
            </tr>
         </HeaderTemplate>
         <ItemTemplate>
            <tr>
                <td align="center"  valign="top" style="width:30;"><%#Eval("Row")%></td>
                <td align="center" valign="top" ><%#Eval("incumplimiento")%></td>
                <td align="center" valign="top" ><%#Eval("medidatags")%></td>
                <td align="center" valign="top" ><%#Eval("fundamento")%></td>
                <td align="center" valign="top" ><%#Eval("plazo")%></td>
                <td align="center" valign="top" ><%#Eval("indtnom_tema")%></td>
                <td align="center" valign="top" ><%#Eval("indtfrec_tema")%></td>
            </tr>
         </ItemTemplate>
         <FooterTemplate>
          </table>
         </FooterTemplate>
        </asp:Repeater>
          </td></tr>

         <tr>
            <td >
            &nbsp;
            </td>
        </tr> 
          
        </ItemTemplate>
        <FooterTemplate>
         </table>
        </FooterTemplate>
        </asp:Repeater>

    

  </div>
</asp:Content>
