<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inventario_Equipos.aspx.cs" Inherits="Proyecto_Web_Inventario.Inventario_Equipos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            Detalles<asp:ListBox ID="List_Info" runat="server"></asp:ListBox>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
