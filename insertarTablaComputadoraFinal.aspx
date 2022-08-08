<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insertarTablaComputadoraFinal.aspx.cs" Inherits="Proyecto_Web_Inventario.insertarTablaComputadoraFinal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            insertar datos
            <br />
            <br />
            Escribe el numero de inventario<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Escribe el numero de cpu<br />
            <asp:TextBox ID="TextBox2" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
            selcciona el id del cpu<br />
            <asp:DropDownList ID="DropDownList3" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Escribe el numero del teclado<br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            Selecciona el id del teclado
            <br />
            <asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Escribe el numero del monitor
            <br />
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            selecciona el id del monitor<br />
            <asp:DropDownList ID="DropDownList5" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            Escribe el numero del mouse<br />
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            <br />
            selecciona el id del mouse
            <br />
            <asp:DropDownList ID="DropDownList6" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            selecciona el laboratorio<br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            selecciona el estatus<br />
            <asp:DropDownList ID="DropDownList2" runat="server">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar Datos" />
&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
