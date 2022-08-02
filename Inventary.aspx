<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventary.aspx.cs" Inherits="Proyecto_Web_Inventario.Inventary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BRegresar_Index" runat="server" OnClick="BRegresar_Index_Click" Text="Regresar" />
            <br />
            Inventario de Computadoras<br />
            <br />
            *Dando el número de inventario del equipo, que diga en que laboratorio se encuentra y muestre los detalles de sus actualizaciones.*<br />
            <br />
            Selecciona el equipo:
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPosBack="true" Height="16px" Width="298px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            Detalles<br />
            <asp:ListBox ID="ListBox1" runat="server" Height="255px" Width="724px"></asp:ListBox>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
