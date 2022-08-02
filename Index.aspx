<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Proyecto_Web_Inventario.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title></title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" integrity="sha384-9gVQ4dYFwwWSjIDZnLEWnxCjeSWFphJiwGPXr1jddIhOegiu1FwO5qRGvFXOdJZ4" crossorigin="anonymous" />
    <link rel="stylesheet" href="StyleSheet1.css" />

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section>
    <!-- jQuery CDN - Slim version (=without AJAX) -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <!-- Popper.JS -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.0/umd/popper.min.js" integrity="sha384-cs/chFZiN24E4KMATLdqdvsezGxaGsi4hLGOzlXwp5UZB1LY//20VyM2taTB4QvJ" crossorigin="anonymous"></script>
    <!-- Bootstrap JS -->
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.0/js/bootstrap.min.js" integrity="sha384-uefMccjFJAIv6A+rW+L4AHf99KvxDjWSu1z9VI8SKNVmz4sk7buKt/6v9KI65qnm" crossorigin="anonymous"></script>
    <script src="https://code.jquery-1.12.0.min.js"></script>
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <script src="https://maxcdn.bootstrampcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('#sidebarCollapse').on('click', function () {
                $('#sidebar').toggleClass('active');
                $(this).toggleClass('active');
            });
        });


        $("#Botones").click(function () {
            Swal.fire(
                'Good job!',
                'You clicked the button!',
                'success'
            )
        });
    </script>

    <div class="wrapper">
        <nav id="sidebar">
            <%--<--sidebar header -->--%>
            <div class="sidebar-header">
                <h3>inventario de computadoras</h3>
            </div>
             <ul class="list-unstyled components">
            <li class="active">
                <a href="#homeSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">
                    <i class="fas fa-home"></i>
                    CRUD INSERTAR
                </a>
                <ul class="collapse list-unstyled" id="homeSubmenu">
                    <li>
                        <a href="insertarTablaActualizar.aspx">TABLA ACTUALIZAR</a>
                    </li>
                    <li>
                        <a href="insertarTablaCantDisc.aspx">TABLA CANT DISC</a>
                    </li>
                    <li>
                        <a href="InsertarTablaCategoria.aspx">TABLA CATEGORIA</a>
                    </li>
                    <li>
                        <a href="InsertarTablaCatMar.aspx">TABLA CAT MAR</a>
                    </li>
                    <li>
                        <a href="InsertarTablaComputadoraFinal.aspx">TABLA COMPUTADORA FINAL</a>
                    </li>
                    <li>
                        <a href="InsertarTablaCPUgenerico.aspx">TABLA CPU GENERICO</a>
                    </li>
                    <li>
                        <a href="InsertarTablaCPUTipoGenerico.aspx">TABLA CPU TIPO MOD</a>
                    </li>
                    <li>
                        <a href="InsertarTablaDiscoDuro.aspx">TABLA DISCO DURO</a>
                    </li>
                    <li>
                        <a href="InsertarTablaEstatus.aspx">TABLA ESTATUS</a>
                    </li>
                    <li>
                        <a href="InsertarTablaEvidencia.aspx">TABLA EVIDENCIA</a>
                    </li>
                    <li>
                        <a href="InsertarTablaGabinete.aspx">TABLA GABINETE</a>
                    </li>
                    <li>
                        <a href="InsertarTablaLaboratorio.aspx">TABLA LABORATORIO</a>
                    </li>
                    <li>
                        <a href="InsertarTablaMarca.aspx">TABLA MARCA</a>
                    </li>
                    <li>
                        <a href="InsertarTablaModelocpu.aspx">TABLA MODELO CPU</a>
                    </li>
                    <li>
                        <a href="InsertarTablaMonitor.aspx">TABLA MONITOR</a>
                    </li>
                    <li>
                        <a href="InsertarTablaMouse.aspx">TABLA MOUSE</a>
                    </li>
                    <li>
                        <a href="InsertarTablaRam.aspx">TABLA RAM</a>
                    </li>
                    <li>
                        <a href="InsertarTablaTeclado.aspx">TABLA TECLADO</a>
                    </li>
                    <li>
                        <a href="InsertarTablaTipoCpu.aspx">TABLA TIPO CPU</a>
                    </li>
                    <li>
                        <a href="InsertarTablaTipoRam.aspx">TABLA TIPO RAM</a>
                    </li>
                    <li>
                        <a href="InsertarTablaUbicacion.aspx">TABLA UBICACION</a>
                    </li>
                    <li>
                        <a href="InsertarTablaUsuario.aspx">TABLA USUARIO</a>
                    </li>
                    </ul>
                </li>
                </ul>
             <a href="#pageSubmenu" data-toggle="collapse" aria-expanded="false" class="dropdown-toggle">
                    <i class="fas fa-copy"></i>
                    CRUD ACTUALIZAR Y ELIMINAR
                </a>
                <ul class="collapse list-unstyled" id="pageSubmenu">
                   <li>
                        <a href="actualizarTabActualizar.aspx">TABLA ACTUALIZAR</a>
                    </li>
                    <li>
                        <a href="actualizarCantDisc.aspx">TABLA CANT DISC</a>
                    </li>
                    <li>
                        <a href="actualizarCategoria.aspx">TABLA CATEGORIA</a>
                    </li>
                    <li>
                        <a href="actualizarCantMar.aspx">TABLA CAT MAR</a>
                    </li>
                    <li>
                        <a href="actualizarComputadoraFinal.aspx">TABLA COMPUTADORA FINAL</a>
                    </li>
                    <li>
                        <a href="ActualizarCPUgenerico.aspx">TABLA CPU GENERICO</a>
                    </li>
                    <li>
                        <a href="actualizarCPUtipomod.aspx">TABLA CPU TIPO MOD</a>
                    </li>
                    <li>
                        <a href="actualizarDiscoDuro.aspx">TABLA DISCO DURO</a>
                    </li>
                    <li>
                        <a href="actualizarEstatus.aspx">TABLA ESTATUS</a>
                    </li>
                    <li>
                        <a href="actualizarEvidencia.aspx">TABLA EVIDENCIA</a>
                    </li>
                    <li>
                        <a href="actualizarGabinete.aspx">TABLA GABINETE</a>
                    </li>
                    <li>
                        <a href="actualizarMarca.aspx">TABLA MARCA</a>
                    </li>
                    <li>
                        <a href="actualizarModeloCPU.aspx">TABLA MODELO CPU</a>
                    </li>
                    <li>
                        <a href="actualizarMonitor.aspx">TABLA MONITOR</a>
                    </li>
                    <li>
                        <a href="ActualizarMouse.aspx">TABLA MOUSE</a>
                    </li>
                    <li>
                        <a href="actualizarRam.aspx">TABLA RAM</a>
                    </li>
                    <li>
                        <a href="ActualizarTeclado.aspx">TABLA TECLADO</a>
                    </li>
                    <li>
                        <a href="actualizarTipocpu.aspx">TABLA TIPO CPU</a>
                    </li>
                    <li>
                        <a href="actualizarTipoRam.aspx">TABLA TIPO RAM</a>
                    </li>
                    <li>
                        <a href="actualizarUbicacion.aspx">TABLA UBICACION</a>
                    </li>
                    <li>
                        <a href="actualizarUsuario.aspx">TABLA USUARIO</a>
                    </li>
                    </ul>
            <br />
            <br />
                 <div>
            <asp:Button ID="Botones" class="botones" runat="server"  Text="Informacion_Equipos" PostBackUrl="~/Informacion_Equipos.aspx"  />
                     <br />
           <asp:Button ID="Button2" class="botones"  runat="server" Text="Laboratorio" PostBackUrl="~/Laboratory.aspx" />
                     <br />
            <asp:Button ID="Button3" class="botones"  runat="server" Text="Inventario" PostBackUrl="~/Inventary.aspx" />
                      <br />
            <asp:Button ID="Button4" class="botones"  runat="server" Text="Equipo_lab" PostBackUrl="~/Equipo_lab.aspx" />
                      <br />
            <asp:Button ID="Button5" class="botones"  runat="server" Text="Monitor_Lab" PostBackUrl="~/Monitor_Lab.aspx" />
        </div>
        </nav>
        <div id="content">
            <button type="button" id="sidebarCollapse" class="navbar-btn">
                <span></span>
                <span></span>
                <span></span>
            </button>
        </div>
         <section>
                <div>
                   <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Mostrar tablas" />
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
                </div>
            </section>
    </div>
            </section>
        </div>
    </form> 
</body>
</html>
