<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Proyecto_Web_Inventario.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 276px">

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox3" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox4" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox5" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox6" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox7" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox8" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox9" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox10" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox11" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox12" runat="server"></asp:ListBox>
            <br />
            siguientes listas<br />
            <asp:ListBox ID="ListBox13" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox14" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox15" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox16" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox17" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox18" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox19" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox20" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox21" runat="server"></asp:ListBox>
            <asp:ListBox ID="ListBox22" runat="server"></asp:ListBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            insertar informacion<br />

        </div>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <br />
        Tabla Actualizacion<br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        Tabla canDisc<br />
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <br />
        Tabla Categoria<br />
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        Tabla CatMar<br />
        <asp:TextBox ID="TextBox8" runat="server" style="margin-top: 0px"></asp:TextBox>
        <br />
        <br />
        Tabla Computadora final<br />
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <br />
        <br />
        Tabla CPU generico<br />
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <br />
        <br />
        Tabla CPU tipo mod<br />
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <br />
        <br />
        Tabla DiscoDuro<br />
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        <br />
        <br />
        Tabla Estatus<br />
        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        <br />
        <br />
        Tabla Evidencia<br />
        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        <br />
        <br />
        ///////////<br />
        Tabla Gabinete<br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Tabla Laboratorio<br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Tabla Marca<br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Tabla ModeloCpu<br />
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Tabla Monitor<br />
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Tabla Mouse<br />
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Tabla Ram<br />
        <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Tabla Teclado<br />
        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Tabla TipoCpu<br />
        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Tabla TipoRam<br />
        <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Tabla Ubicacion<br />
        <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Tabla Usuario<br />
        <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        ///////////////////////<br />
        pruebas de editar tablas :v
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
        &nbsp;<asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
        </p>
        ////////////////////
        <br />
        pruebas de eliminar datos
        <br />
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
        <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
