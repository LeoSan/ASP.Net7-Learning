<%@ Page Title="" Language="C#" theme ="Tema1" MasterPageFile="~/MasterPage/MasterPageIPA.Master" AutoEventWireup="true" CodeBehind="ConsultaDatosCalificacion.aspx.cs" Inherits="Inspeccion_PA.Generales.ConsultaDatosCalificacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <br/>
  <h3 class="titulo"><asp:Image ID="Image1" ImageUrl="~/App_Themes/Tema1/imagenes/titlebullet.gif" runat="server" width="18" height="15"></asp:Image>
      <asp:Literal ID="ltTitulo" Text ="Datos de la asignación de la calificación " runat="server"></asp:Literal></h3>
	 <br/>
     <table border="0" cellpadding="0" cellspacing="10" width="759" align="center">
		<tr>
			<td height="17" width="739" colspan="2"><b>Datos del centro de 
			trabajo</b></td>
		</tr>
		<tr>
			<td height="15" width="288">Nombre o razón social:</td>
			<td width="441" height="15">
                <asp:Literal ID="ltNombre" runat="server"></asp:Literal>
                </td>
		</tr>
		<tr>
			<td height="17" width="288">Domicilio:</td>
			<td width="441" height="17">
                <asp:Literal ID="ltDomicilio" runat="server"></asp:Literal>
                </td>
		</tr>
		<tr>
			<td height="17" width="739" colspan="2"><b>Datos de la actuación</b></td>
		</tr>
		<tr>
			<td height="17" width="288">Fecha de inspección:</td>
			<td width="441" height="17">
                <asp:Literal ID="ltFechaInsp" runat="server"></asp:Literal>
                </td>
		</tr>
		<tr>
			<td height="17" width="288">No. de expediente:</td>
			<td width="441" height="17">
                <asp:Literal ID="ltNumExp" runat="server"></asp:Literal>
                </td>
		</tr>
		<tr>
			<td height="17" width="288">Subtipo de actuación:<br></td>
			<td width="441" height="17">
                <asp:Literal ID="ltSubtipoAct" runat="server"></asp:Literal>
                </td>
		</tr>
		<tr>
			<td height="17" width="288">Materia:</td>
			<td width="441" height="17">
                <asp:Literal ID="ltMateria" runat="server"></asp:Literal>
                </td>
		</tr>
		<tr>
			<td height="17" ><b>Datos de la  
			calificación</b></td>
			<td height="17" width="441">
			</td>
		</tr>
		<tr id= "tr19" runat ="server"  visible = "false">
			<td height="17" >Nombre del responsable jurídico:</td>
			<td height="17" width="441">
                <asp:Literal ID="ltNombreResp" runat="server"></asp:Literal>
                </td>
		</tr>
		<tr id= "tr20" runat ="server"  visible = "false">
			<td height="17" >Puesto:</td>
			<td height="17" width="441">
                <asp:Literal ID="ltPuesto" runat="server"></asp:Literal>
                </td>
		</tr>
		<tr  id= "tr21" runat ="server"  visible = "false">
			<td height="17" >Área jurídica:</td>
			<td height="17" width="441">
                <asp:Literal ID="ltAreaJuridica" runat="server"></asp:Literal>
                </td>
		</tr>
		<tr >
              <td height="17" >Nombre del dictaminador:</td>
              <td height="17" width="441"> 
				  <asp:Literal ID="ltNombreDic" runat="server"></asp:Literal>
				</td>
            </tr>
		<tr>
              <td height="19" > 
                  <asp:Literal ID="ltNomFecha" runat="server"></asp:Literal>
                </td>
              <td width="441" height="19"> 
                  <asp:Literal ID="ltFechaCal" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr1" runat ="server">
              <td height="19" >Documento emitido:</td>
              <td width="441" height="19"> 
                  <asp:Literal ID="ltDocEmitido" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr2" runat ="server">
              <td height="19" >Número:</td>
              <td width="441" height="19"> 
                  <asp:Literal ID="ltNumero" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr3" runat ="server">
              <td height="19" >Fecha de documento:</td>
              <td width="441" height="19"> 
                  <asp:Literal ID="ltFechaDoc" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr4" runat ="server">
              <td height="19" >Firma alguno de los titulares:</td>
              <td width="441" height="19"> 
                  <asp:Literal ID="ltFirmoTitular" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr5" runat ="server">
              <td height="17" width="288">Nombre del firmante:</td>
              <td height="17" width="441">
                  <asp:Literal ID="ltFirmante" runat="server"></asp:Literal>
                  </td>
            </tr>
		<tr id= "tr6" runat ="server">
              <td height="17" width="288">Cargo:</td>
              <td height="17" width="441">
                  <asp:Literal ID="ltCargo" runat="server"></asp:Literal>
                  </td>
            </tr>
		<tr id= "tr7" runat ="server">
              <td height="19" >Observaciones:</td>
              <td width="441" height="19"> 
                  <asp:Literal ID="ltObs" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr8" runat ="server">
              <td style= "vertical-align:top" >Copias:</td>
              <td width="441" > 
                  <asp:Literal ID="ltCopias" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr11" runat ="server" visible = "false">
              <td style= "vertical-align:top">Rúbricas:</td>
              <td width="441" > 
                  <asp:Literal ID="ltRubricas" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr12" runat ="server"  visible = "false">
              <td><b>Escrito de comparecencia:</b></td>
              <td width="441" > 
                  &nbsp;</td>

            </tr>
		<tr id= "tr13" runat ="server"  visible = "false">
              <td >Se recibió escrito:</td>
              <td width="441" > 
                  <asp:Literal ID="ltRecibioEscrito" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr14" runat ="server"  visible = "false">
              <td >Dentro del plazo:</td>
              <td width="441" > 
                  <asp:Literal ID="ltDentrodelPlazo" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr15" runat ="server"  visible = "false">
              <td style= "vertical-align:top">Fecha de acuse de recibido:</td>
              <td width="441" > 
                  <asp:Literal ID="ltFechadeAcuse" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr16" runat ="server"  visible = "false">
              <td style= "vertical-align:top">No. de fojas:</td>
              <td width="441" > 
                  <asp:Literal ID="ltNodeFojas" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr17" runat ="server"  visible = "false">
              <td style= "vertical-align:top">Acredita personalidad:</td>
              <td width="441" > 
                  <asp:Literal ID="ltAcreditaPersonalidad" runat="server"></asp:Literal>
                </td>

            </tr>
		<tr id= "tr18" runat ="server"  visible = "false">
              <td style= "vertical-align:top">Solventa todas y cada una de las presuntas 
                  violaciones:</td>
              <td width="441" > 
                  <asp:Literal ID="ltSolventaViolaciones" runat="server"></asp:Literal>
                </td>

            </tr>
		</table>
  <br/>
	<table width="617" border="0" cellpadding="0" cellspacing="7" align="center">
		<tr>
			<td align="right" valign="top">
			
			&nbsp;<asp:Button ID="btnMedidas" runat="server" onclick="btnMedidas_Click" 
                    Text="Medidas" Height="26px" />&nbsp;&nbsp; </td>
			<td align="right" valign="top" width="90">
			
				<asp:Button ID="btnRegresar" runat="server" onclick="btnRegresar_Click" 
                    Text="Regresar" /></td>
		</tr>
	</table>
  <br/>
  <br/>


</asp:Content>
