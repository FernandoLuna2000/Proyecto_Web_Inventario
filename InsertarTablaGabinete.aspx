﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertarTablaGabinete.aspx.cs" Inherits="Proyecto_Web_Inventario.InsertarTablaGabinete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Agregar Datos<br />
            <br />
            Escribe el Modelo del Gabinete<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Escribe el tipo de Forma que Tiene el Gabinete<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Selecciona el id de la Marca<br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar Datos" />
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
