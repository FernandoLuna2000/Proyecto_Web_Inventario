<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informacion_Equipos.aspx.cs" Inherits="Proyecto_Web_Inventario.Informacion_Equipos" %>

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
            Informacion acerca de los equipos de computo
            <br />
            <br />
            *Dando un número de inventario de un equipo que salga toda la información de componentes de ese equipo
            <br />
            (que mouse, teclado, monitor, memoria ram, procesador, e incluso número de discos duros tiene ese equipo)*<br />
            <br />
            Seleccione el Numero de inventario del equipo:
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" Height="26px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="305px">
            </asp:DropDownList>
            <br />
            <br />
            Sus componentes son: <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="221px" Width="647px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
