<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Monitores_Laboratorios_2.aspx.cs" Inherits="Proyecto_Web_Inventario.Monitores_Laboratorios_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BRegresar" runat="server" Text="Regresar" OnClick="BRegresar_Click" />
            <br />
            Monitoreo de Monitores<br />
            <br />
            *Seleccionando un tipo de monitor que aparezcan los equipos que tienen ese tipo de monitor y a que laboratorio pertenecen*<br />
            <br />
            Selecciona el monitor
            <asp:DropDownList ID="DropDownList1" runat="server" Height="23px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="264px">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            Estos equipos tienen este monitor y son de este laboratorio<br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="276px" Width="558px"></asp:ListBox>
        </div>
</body>
</html>
