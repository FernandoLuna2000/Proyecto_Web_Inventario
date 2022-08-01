<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Equipo_lab.aspx.cs" Inherits="Proyecto_Web_Inventario.Equipo_lab" %>

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
            Laboratorios, Monitores y Discos Duros<br />
            <br />
            *Cuales equipos de un determinado laboratorio tienen disco de estado sólido:*<br />
            <br />
            Selecciona el Laboratorio:
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" Height="27px" Width="246px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            Detalles<br />
            <asp:ListBox ID="ListBox1" runat="server" Height="186px" Width="461px"></asp:ListBox>
        </div>
    </form>
</body>
</html>

