<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarDatosLQ.aspx.cs" 
    Inherits="TP_parcial.MostrarDatosLQ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mostrar Datos - LinQ</title>
    <link href="Estilos.css" rel="stylesheet" />
    <script src="JavaScript.js"></script>
</head>
<body>
    <h1 class="centrado">Datos ingresados</h1>
    <form id="form1" runat="server">
        <table class="centerTable">
            <tbody>
                <tr>
                    <td>
                        <asp:GridView runat="server" ID="gridViewAlumnos"></asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label CssClass="label_gral" Text="Comentario" runat="server" ID="Comentario" /><br />
                        <asp:TextBox runat="server" TextMode="MultiLine" Columns="50" Rows="5" ID="txtComentarios" placeholder="Ingresar un comentario"/>
                    </td>
                </tr>
                <tr>
                    <td>                        
                        <asp:Button ID="Button1" runat="server" Text="Enviar" OnClientClick="return validarComentario()" OnClick="Button1_Click" />                        
                    </td>
                </tr>
            </tbody>
        </table>
    </form>
</body>
</html>
