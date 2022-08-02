<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertarTablaActualizar.aspx.cs" Inherits="Proyecto_Web_Inventario.insertarTablaActualizar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            insertar nuevos datos en la tabla Actualizar<br />
            <br />
            selecciona id de num inv<br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            escribe el Numero de serie<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Escribe una Descripcion<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Selecciona una Fecha<br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="insertar datos" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
