<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoComentariosLQ.aspx.cs" 
    Inherits="TP_parcial.ListadoComentariosLQ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listado de comentarios - LinQ</title>
    <link href="Estilos.css" rel="stylesheet" />
</head>
<body>
    <h1 class="centrado">Listado de comentarios</h1>
    <form id="form1" runat="server">
        <div class="divCentrado">
            <asp:GridView runat="server" ID="gridViewComentarios" HorizontalAlign="Center"></asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
