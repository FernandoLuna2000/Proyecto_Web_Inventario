<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarTablaTipoRam.aspx.cs" Inherits="Proyecto_Web_Inventario.InsertarTablaTipoRam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Agregar Datos</h2>
            Escribe el tipo de Ram<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Agregar Datos" OnClick="Button1_Click" />
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
