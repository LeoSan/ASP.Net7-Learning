<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPageIPA.Master" AutoEventWireup="true" CodeBehind="ConsultaInspeccionDocumentos.aspx.cs" Inherits="Inspeccion_PA.Generales.ConsultaInspeccionDocumentos"  Theme="Tema1"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="div1"> <br>
  <br>
  <h3 class="titulo">
  <asp:Image ID="Image1" ImageUrl="~/App_Themes/Tema1/imagenes/titlebullet.gif" runat="server" width="18" height="15"></asp:Image>
  Obtener 
	e incorporar documentos</h3><br>

  <br>
  <table height="51" border="0" cellpadding="0" cellspacing="8" width="517" align="center">
            <tbody><tr>
              <td height="14" width="200">Nombre o razón social:</td>
              <td height="14">
                  <asp:Literal ID="ltnombre" runat="server"></asp:Literal>
                </td>
            </tr>
            
            <tr>
              <td height="13" width="200">Tipo de actuación:</td>
              <td width="293" height="13">
                  <asp:Literal ID="lttipo" runat="server"></asp:Literal>
                </td>
            </tr>
            
            <tr>
              <td height="13" width="200">Subtipo de actuación:</td>
              <td width="293" height="13">
                  <asp:Literal ID="ltsubtipo" runat="server"></asp:Literal>
                </td>
            </tr>
            
            
            <tr>
              <td height="13" width="200">Materia:</td>
              <td width="293" height="13">
                  <asp:Literal ID="ltmateria" runat="server"></asp:Literal>
                </td>
            </tr>
            
            
            <tr>
              <td height="13" width="200">Fecha:</td>
              <td width="293" height="13">
                  <asp:Literal ID="ltfecha" runat="server"></asp:Literal>
                </td>
            </tr>
            
            <tr>
              <td height="13" width="200">No. de expediente:</td>
              <td width="293" height="13">
                  <asp:Literal ID="ltnumexpediente" runat="server"></asp:Literal>
                </td>
            </tr>
            
            </tbody></table>
            <br>
  <br>  
 
  <div class="tabla3">
  
    <table border="0" cellpadding="0" cellspacing="0" id="tab3" align="center" width="599">
          <tbody>
    <asp:Repeater ID="rptDocumentos" runat="server">
    <HeaderTemplate>  
          <tr>
            <th width="255">Documento</th>
            <th width="137">Generó</th>
            <th width="99">Fecha del documento</th>
            <th width="52">Obtener archivo</th>
          </tr>
    </HeaderTemplate>
    <ItemTemplate>
          <tr>
            <td width="255"><%#Eval("td_tipo_documento")%></td>
            <td class="alt" width="137"><%#Eval("usuario")%></td>
            <td class="alt" width="99"><%#Eval("fecha") %></td>
            <td class="alt" width="52">
             <asp:LinkButton ID="lbdescarga" runat="server" CommandArgument='<%#Eval("documento_id")+"|"+Eval("tipo")+"|"+Eval("td_url_plantilla")+"|"+Eval("calificacion_id")+"|"+Eval("emplazamiento_id")%>' OnCommand="lbdescarga_Click">
					<asp:Image ID="Image6" ImageUrl="~/App_Themes/Tema1/imagenes/descarga.gif" runat="server" width="16" height="16"></asp:Image>
				</asp:LinkButton>
            </td>
          </tr>
     </ItemTemplate>
    </asp:Repeater>     
    <asp:Repeater ID="rptDocumentosOtros" runat="server">
    <HeaderTemplate>       
          <tr>
            <th width="585" colspan="4">Otros documentos</th></tr>
    </HeaderTemplate>
    <ItemTemplate>
           <tr>
            <td width="255"><%#Eval("nombre") %></td>
            <td class="alt" width="137"><%#Eval("usuario")%></td>
            <td class="alt" width="99"><%#Eval("fecha") %></td>
            <td class="alt" width="52">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#Eval("ddoc_url_documento") %>'>
                    <asp:Image ID="Image2" runat="server" ImageUrl="~/App_Themes/Tema1/Imagenes/descarga.gif" /></asp:HyperLink>
            </td>
          </tr>
       </ItemTemplate>
    </asp:Repeater>      
     </tbody></table>
  </div>

    <br>
    <br>
    <table align="center" width="605">
            <tbody><tr>
              
            <td height="20" align="right">
            <asp:Button ID="btnAdjuntar" runat="server"  Text="Adjuntar archivo" 
                    onclick="btnAdjuntar_Click"/>
            </td>

            <td height="20" align="right" width="102">
            <asp:Button ID="btnRegresar" runat="server"  Text="Regresar" 
                    onclick="btnRegresar_Click"/>
            </td>

            </tr>
            </tbody></table>
  <br>
  <br>
</div>
</asp:Content>
