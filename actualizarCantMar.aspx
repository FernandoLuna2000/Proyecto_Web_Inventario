<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="actualizarCantMar.aspx.cs" Inherits="Proyecto_Web_Inventario.actualizarCantMar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Editar o Eliminar Tabla CatMar</h2>
        <p>Seleccione el id</p>

            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>

        <p>selecciona id categoria:</p>
             <asp:DropDownList ID="DropDownList2" runat="server">
             </asp:DropDownList>
             <br />
        <p>selecciona id de la marca </p>
             <asp:DropDownList ID="DropDownList3" runat="server">
             </asp:DropDownList>
             <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Editar" />
             <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Eliminar" />
         <br />
        
         &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
