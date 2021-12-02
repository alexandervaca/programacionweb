<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IngresoAlumnoLQ.aspx.cs" 
    Inherits="TP_parcial.IngresoAlumnoLQ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Ingresar Alumno - LinQ</title>
    <link href="Estilos.css" rel="stylesheet" />
    <script src="JavaScript.js"></script>
    </head>
<body>
    <h1 class="centrado">Bienvenido al sistema de ingreso de alumnos</h1>
    <form id="form1" runat="server">
        <table class="centerTable">
            <tbody>
                <tr>
                    <td colspan="5" style="text-align:center;"><asp:Label CssClass="enfocada" Text="Datos Personales" runat="server" ID="Label3" /></td>
                </tr>
                <tr>
                    <td rowspan="2"><asp:Label CssClass="labels_obligatorio" Text="Datos Obligatorios" runat="server" ID="Label4" /></td>
                    <td><asp:Label CssClass="labels_obligatorio" Text="Apellido" runat="server" ID="Label2" /></td>
                    <td><asp:TextBox runat="server" ID="txtApellido" /></td>
                    <td><asp:Label CssClass="labels_obligatorio" Text="Nombre" runat="server" ID="Label1" /></td>
                    <td><asp:TextBox runat="server" ID="txtNombre" /></td>
                </tr>
                <tr >
                    <td><asp:Label CssClass="labels_obligatorio" Text="DNI" runat="server" ID="Label5" /></td>
                    <td><asp:TextBox runat="server" ID="txtDni" /></td>
                    <td><asp:Label CssClass="labels_obligatorio" Text="E-Mail" runat="server" ID="Label6" /></td>
                    <td ><asp:TextBox runat="server" ID="txtEmail" /></td>
                </tr>
                <tr>
                    <td><asp:Label CssClass="labels_preferencias" Text="Preferencias" runat="server" ID="Label7" /></td>
                    <td><asp:Label  CssClass="labels_preferencias" Text="Turno" runat="server" ID="Label8" /></td>
                    <td colspan="3">
                        <asp:DropDownList CssClass="desenfocada" runat="server" ID="txtTurno">        
                            <asp:ListItem Value="-" Text="-">Seleccione Turno</asp:ListItem>
                            <asp:ListItem Value="Mañana" Text="Mañana">Mañana</asp:ListItem>
                            <asp:ListItem Value="Tarde" Text="Tarde">Tarde</asp:ListItem>
                            <asp:ListItem Value="Noche" Text="Noche">Noche</asp:ListItem>
                        </asp:DropDownList>

                    </td>
                </tr>
                <tr>
                    <td colspan="5" style="text-align:right">
                        <asp:Button Text="Enviar" runat="server" ID="btnEnviar" OnClientClick="return validarFormulario()" OnClick="BtnEnviar_Click" />

                        <input type="reset" value="Limpiar" id="btnReset" runat="server"/>
                    </td>
                </tr>
            </tbody>
        </table>
    </form>
</body>
</html>
