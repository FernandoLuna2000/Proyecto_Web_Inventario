<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Laboratory.aspx.cs" Inherits="Proyecto_Web_Inventario.Laboratory" %>

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
            Laboratorios
            <br />
            <br />
            *Que equipos tiene un laboratorio determinado*<br />
            <br />
            Seleccione el laboratorio:
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack ="true" Height="16px" Width="356px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            Equipos existentes en este laboratorio:<br />
            <asp:ListBox ID="ListBox1" runat="server" Height="235px" Width="427px"></asp:ListBox>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>