<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertarTablaCantDisc.aspx.cs" Inherits="Proyecto_Web_Inventario.insertarTablaCantDisc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            insertar datos<br />
            <br />
            selecciona los datos de num_inv<br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            selecciona el numero de disco<br />
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
        </div>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar informacion" />
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
