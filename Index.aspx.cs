using c_dll;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using c_entidades;

namespace Proyecto_Web_Inventario
{
    public partial class Index : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        
        List<Actualizacion> Lista_Actualizacion = new List<Actualizacion>();
        List<CantDisc> Lista_CantDisc = new List<CantDisc>();
        List<Categoria> Lista_Categoria = new List<Categoria>();
        List<CatMar> Lista_CatMar = new List<CatMar>();
        List<Computadorafinal> Lista_CompuFinal = new List<Computadorafinal>();
        List<CpuGenerico> Lista_CpuGenerico = new List<CpuGenerico>();
        List<CpuTipoMod> Lista_CpuTipoMod = new List<CpuTipoMod>();
        List<DiscoDuro> Lista_DiscoDuro = new List<DiscoDuro>();
        List<Estatus> Lista_Estatus = new List<Estatus>();
        List<Evidencia> Lista_Evidencia = new List<Evidencia>();
        List<Gabinete> Lista_Gabinete = new List<Gabinete>();
        List<Laboratorio> Lista_Laboratorio = new List<Laboratorio>();
        List<Marca> Lista_Marca = new List<Marca>();
        List<ModeloCpu> Lista_ModeloCpu = new List<ModeloCpu>();
        List<Monitor> Lista_Monitor = new List<Monitor>();
        List<Mouse> Lista_Mouse = new List<Mouse>();
        List<Ram> Lista_Ram = new List<Ram>();
        List<Teclado> Lista_Teclado = new List<Teclado>();
        List<TipoCpu> Lista_TipoCpu = new List<TipoCpu>();
        List<TipoRam> Lista_TipoRam = new List<TipoRam>();
        List<Ubicacion> Lista_Ubicacion = new List<Ubicacion>();
        List<Usuario> Lista_Usuario = new List<Usuario>();

        string mensaje = "", mensajeC = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;
            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            //Lista Actualizacion --->INICIO
            Lista_Actualizacion = LN.ListaActualizacion(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Actualizacion.Count(); i++)
            {
                ListBox2.Items.Add(Lista_Actualizacion[i].IdAct.ToString());
                ListBox2.Items.Add(Lista_Actualizacion[i].NumInv.ToString());
                ListBox2.Items.Add(Lista_Actualizacion[i].NumSerie.ToString());
                ListBox2.Items.Add(Lista_Actualizacion[i].Descripcion.ToString());
                ListBox2.Items.Add(Lista_Actualizacion[i].Fecha.ToString());
            }
            //Lista Actualizacion --->FINAL

            //Lista CantDisc --->INICIO
            Lista_CantDisc = LN.ListaCantDisc(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_CantDisc.Count(); i++)
            {
                ListBox3.Items.Add(Lista_CantDisc[i].IdCant.ToString());
                ListBox3.Items.Add(Lista_CantDisc[i].NumInv.ToString());
                ListBox3.Items.Add(Lista_CantDisc[i].IdDisco.ToString());
            }
            //Lista CantDisc --->FINAL

            //Lista Categoria --->INICIO
            Lista_Categoria = LN.ListaCategoria(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Categoria.Count(); i++)
            {
                ListBox4.Items.Add(Lista_Categoria[i].IdCategoria.ToString());
                ListBox4.Items.Add(Lista_Categoria[i].Descripcion.ToString());
            }
            //Lista Categoria --->FINAL

            //Lista CatMar --->INICIO
            Lista_CatMar = LN.ListaCatMar(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_CatMar.Count(); i++)
            {
                ListBox5.Items.Add(Lista_CatMar[i].IdCatMar.ToString());
                ListBox5.Items.Add(Lista_CatMar[i].IdCategoria.ToString());
                ListBox5.Items.Add(Lista_CatMar[i].IdMarca.ToString());
            }
            //Lista CatMar --->FINAL

            //Lista CompuFinal --->INICIO
            Lista_CompuFinal = LN.ListaComputadoraFinal(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_CompuFinal.Count(); i++)
            {
                ListBox6.Items.Add(Lista_CompuFinal[i].NumInv.ToString());
                ListBox6.Items.Add(Lista_CompuFinal[i].NumScpu.ToString());
                ListBox6.Items.Add(Lista_CompuFinal[i].IdCpug.ToString());
                ListBox6.Items.Add(Lista_CompuFinal[i].NumSteclado.ToString());
                ListBox6.Items.Add(Lista_CompuFinal[i].IdTecladog.ToString());
                ListBox6.Items.Add(Lista_CompuFinal[i].NumSmonitor.ToString());
                ListBox6.Items.Add(Lista_CompuFinal[i].IdMong.ToString());
                ListBox6.Items.Add(Lista_CompuFinal[i].NumSmonitor.ToString());
                ListBox6.Items.Add(Lista_CompuFinal[i].IdMousg.ToString());
                ListBox6.Items.Add(Lista_CompuFinal[i].Estado.ToString());
                ListBox6.Items.Add(Lista_CompuFinal[i].IdEstatus.ToString());
            }
            //Lista CompuFinal --->FINAL

            //Lista CPUGenerico --->INICIO
            Lista_CpuGenerico = LN.ListaCpuGenerico(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_CpuGenerico.Count(); i++)
            {
                ListBox7.Items.Add(Lista_CpuGenerico[i].IdCpu.ToString());
                ListBox7.Items.Add(Lista_CpuGenerico[i].FTcpu.ToString());
                ListBox7.Items.Add(Lista_CpuGenerico[i].FMarcaCpu.ToString());
                ListBox7.Items.Add(Lista_CpuGenerico[i].Modelo.ToString());
                ListBox7.Items.Add(Lista_CpuGenerico[i].Descripcion.ToString());
                ListBox7.Items.Add(Lista_CpuGenerico[i].FTipoRam.ToString());
                ListBox7.Items.Add(Lista_CpuGenerico[i].IdGabinete.ToString());
            }
            //Lista CPUGenerico --->FINAL

            //Lista CpuTipoMod --->INICIO
            Lista_CpuTipoMod = LN.ListaCpuTipoMod(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_CpuTipoMod.Count(); i++)
            {
                ListBox8.Items.Add(Lista_CpuTipoMod[i].IdTipoMod.ToString());
                ListBox8.Items.Add(Lista_CpuTipoMod[i].IdTcpu.ToString());
                ListBox8.Items.Add(Lista_CpuTipoMod[i].IdModcpu.ToString());
                ListBox8.Items.Add(Lista_CpuTipoMod[i].Nucleos.ToString());
            }
            //Lista CpuTipoMod --->FINAL

            //Lista DiscoDuro --->INICIO
            Lista_DiscoDuro = LN.ListaDiscoDuro(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_DiscoDuro.Count(); i++)
            {
                ListBox9.Items.Add(Lista_DiscoDuro[i].IdDisco.ToString());
                ListBox9.Items.Add(Lista_DiscoDuro[i].TipoDisco.ToString());
                ListBox9.Items.Add(Lista_DiscoDuro[i].Conector.ToString());
                ListBox9.Items.Add(Lista_DiscoDuro[i].Capacidad.ToString());
                ListBox9.Items.Add(Lista_DiscoDuro[i].FMarcaDisco.ToString());
            }
            //Lista DiscoDuro --->FINAL

            //Lista Estatus --->INICIO
            Lista_Estatus = LN.ListaEstatus(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Estatus.Count(); i++)
            {
                ListBox10.Items.Add(Lista_Estatus[i].IdEstatus.ToString());
                ListBox10.Items.Add(Lista_Estatus[i].Estado.ToString());
            }
            //Lista Estatus --->FINAL

            //Lista Evidencia --->INICIO
            Lista_Evidencia = LN.ListaEvidencia(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Evidencia.Count(); i++)
            {
                ListBox11.Items.Add(Lista_Evidencia[i].IdEvidencia.ToString());
                ListBox11.Items.Add(Lista_Evidencia[i].Evidencia1.ToString());
                ListBox11.Items.Add(Lista_Evidencia[i].NumInv.ToString());
            }
            //Lista Evidencia --->FINAL

            //Lista Gabinete --->INICIO
            Lista_Gabinete = LN.ListaGabinete(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Gabinete.Count(); i++)
            {
                ListBox12.Items.Add(Lista_Gabinete[i].IdGabinete.ToString());
                ListBox12.Items.Add(Lista_Gabinete[i].Modelo.ToString());
                ListBox12.Items.Add(Lista_Gabinete[i].TipoForma.ToString());
                ListBox12.Items.Add(Lista_Gabinete[i].FMarca.ToString());
            }
            //Lista Gabinete --->FINAL

            //Lista Laboratorio --->INICIO
            Lista_Laboratorio = LN.ListaLab(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Laboratorio.Count(); i++)
            {
                ListBox13.Items.Add(Lista_Laboratorio[i].NombreLaboratorio.ToString());
            }
            //Lista Laboratorio --->FINAL

            //Lista Marca --->INICIO
            Lista_Marca = LN.ListaMarca(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Marca.Count(); i++)
            {
                ListBox1.Items.Add(Lista_Marca[i].IdMarca.ToString());
                ListBox1.Items.Add(Lista_Marca[i].Marca1.ToString());
                ListBox1.Items.Add(Lista_Marca[i].IdComponente.ToString());
            }
            //Lista Marca --->FINAL

            //Lista ModeloCpu --->INICIO
            Lista_ModeloCpu = LN.ListaModeloCpu(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_ModeloCpu.Count(); i++)
            {
                ListBox14.Items.Add(Lista_ModeloCpu[i].IdModcpu.ToString());
                ListBox14.Items.Add(Lista_ModeloCpu[i].IdModcpu.ToString());
                //ListBox14.Items.Add(Lista_ModeloCpu[i].FMarca.ToString());
            }
            //Lista ModeloCpu --->FINAL

            //Lista Monitor --->INICIO
            Lista_Monitor = LN.ListaMonitor(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Monitor.Count(); i++)
            {
                ListBox15.Items.Add(Lista_Monitor[i].IdMonitor.ToString());
                ListBox15.Items.Add(Lista_Monitor[i].FMarcam.ToString());
                ListBox15.Items.Add(Lista_Monitor[i].Conectores.ToString());
                ListBox15.Items.Add(Lista_Monitor[i].Tamano.ToString());
            }
            //Lista Monitor --->FINAL

            //Lista Mouse --->INICIO
            Lista_Mouse = LN.ListaMouse(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Mouse.Count(); i++)
            {
                ListBox16.Items.Add(Lista_Mouse[i].IdMouse.ToString());
                ListBox16.Items.Add(Lista_Mouse[i].FMarcamouse.ToString());
                ListBox16.Items.Add(Lista_Mouse[i].Conector.ToString());
            }
            //Lista Mouse --->FINAL

            //Lista Ram --->INICIO
            Lista_Ram = LN.ListaRam(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Ram.Count(); i++)
            {
                ListBox17.Items.Add(Lista_Ram[i].IdRam.ToString());
                ListBox17.Items.Add(Lista_Ram[i].Capacidad.ToString());
                ListBox17.Items.Add(Lista_Ram[i].Velocidad.ToString());
                ListBox17.Items.Add(Lista_Ram[i].FTipoR.ToString());
            }
            //Lista Ram --->FINAL

            //Lista Teclado --->INICIO
            Lista_Teclado = LN.ListaTeclado(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Teclado.Count(); i++)
            {
                ListBox18.Items.Add(Lista_Teclado[i].IdTeclado.ToString());
                ListBox18.Items.Add(Lista_Teclado[i].FMarcat.ToString());
                ListBox18.Items.Add(Lista_Teclado[i].Conector.ToString());
            }
            //Lista Teclado --->FINAL

            //Lista TipoCpu --->INICIO
            Lista_TipoCpu = LN.ListaTipoCpu(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_TipoCpu.Count(); i++)
            {
                ListBox19.Items.Add(Lista_TipoCpu[i].IdTcpu.ToString());
                ListBox19.Items.Add(Lista_TipoCpu[i].Tipo.ToString());
                ListBox19.Items.Add(Lista_TipoCpu[i].Familia.ToString());
            }
            //Lista TipoCpu --->FINAL

            //Lista TipoRam --->INICIO
            Lista_TipoRam = LN.ListaTipoRam(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_TipoRam.Count(); i++)
            {
                ListBox20.Items.Add(Lista_TipoRam[i].IdTipoRam.ToString());
                ListBox20.Items.Add(Lista_TipoRam[i].Tipo.ToString());
            }
            //Lista TipoRam --->FINAL

            //Lista Ubicacion --->INICIO
            Lista_Ubicacion = LN.ListaUbicacion(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Ubicacion.Count(); i++)
            {
                ListBox21.Items.Add(Lista_Ubicacion[i].NumInv.ToString());
                ListBox21.Items.Add(Lista_Ubicacion[i].NombreLaboratorio.ToString());
            }
            //Lista Ubicacion --->FINAL

            //Lista Usuario --->INICIO
            Lista_Usuario = LN.ListaUsuario(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Usuario.Count(); i++)
            {
                ListBox22.Items.Add(Lista_Usuario[i].IdUsuario.ToString());
                ListBox22.Items.Add(Lista_Usuario[i].Nombre.ToString());
                ListBox22.Items.Add(Lista_Usuario[i].ApP.ToString());
                ListBox22.Items.Add(Lista_Usuario[i].ApM.ToString());
                ListBox22.Items.Add(Lista_Usuario[i].NomUsuario.ToString());
                ListBox22.Items.Add(Lista_Usuario[i].Password.ToString());
                ListBox22.Items.Add(Lista_Usuario[i].TipoUsuario.ToString());
            }
            //Lista Usuario --->FINAL
            TextBox1.Text = mensajeC + " " + mensaje;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //string[] datos = new string[2];

            //datos[0] = TextBox2.Text;
            //datos[1] = TextBox3.Text;

            //try
            //{
            //    LN.Insertar(datos, ref mensaje, ref mensajeC);
            //    TextBox4.Text = "Chido";
            //}
            //catch
            //{
            //    TextBox4.Text = "MamaWebo.... digo glugluglu :3";
            //}

            //----------------inicia la tabla cantDisc-----------------------//
            //string[] datos = new string[2];

            //datos[0] = "1234567892";
            //datos[1] = "6";

            //try
            //{
            //    LN.InsertarcantDisc(datos, ref mensaje, ref mensajeC);
            //    TextBox6.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox6.Text = "nelson";
            //}
            //---------------fin de la tabla cantDisc----------------------//

            //----------------inicia la tabla Categoria-----------------------//

            //string[] datos = new string[1];

            //datos[0] = "hola mundo";

            //try
            //{
            //    LN.InsertarCategoria(datos, ref mensaje, ref mensajeC);
            //    TextBox7.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox7.Text = "nelson";
            //}

            //---------------fin de la tabla Categoria----------------------//

            //--------------inicio Tabla CatMar---------------------------//

            //string[] datos = new string[2];

            //datos[0] = "1";
            //datos[1] = "25";

            //try
            //{
            //    LN.InsertarCatMar(datos, ref mensaje, ref mensajeC);
            //    TextBox8.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox8.Text = "nelson";
            //}

            //-------------fin tabla CatMar-------------------------------//

            //------------inicia tabla computadora final ----------------//

            //string[] datos = new string[11];

            //datos[0] = "1234567899";
            //datos[1] = "1243363473";
            //datos[2] = "8";
            //datos[3] = "1924132423";
            //datos[4] = "6";
            //datos[5] = "1325213324";
            //datos[6] = "5";
            //datos[7] = "1241352352";
            //datos[8] = "5";
            //datos[9] = "K1";
            //datos[10] = "1";
            //try
            //{
            //    LN.InsertarComputadoraFinal(datos, ref mensaje, ref mensajeC);
            //    TextBox9.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox9.Text = "nelson";
            //}

            //-------------fin tabla Computadora final---------------------//

            //------------inicia tabla cpu generico ----------------//

            //string[] datos = new string[6];

            //datos[0] = "12";
            //datos[1] = "23";
            //datos[2] = "i5-5570";
            //datos[3] = "corre a 4.20Ghz";
            //datos[4] = "5";
            //datos[5] = "5";
            //try
            //{
            //    LN.InsertarCPUgenerico(datos, ref mensaje, ref mensajeC);
            //    TextBox10.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox10.Text = "nelson";
            //}

            //-------------fin tabla Cpu generico---------------------//

            //------------inicia tabla cpu tipo mod ----------------//

            //string[] datos = new string[3];

            //datos[0] = "12";
            //datos[1] = "2";
            //datos[2] = "prueba";
            //try
            //{
            //    LN.InsertarCPUTipoMod(datos, ref mensaje, ref mensajeC);
            //    TextBox11.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox11.Text = "nelson";
            //}

            //-------------fin tabla Cpu tipo mod---------------------//

            // ------------inicia tabla Disco Duro ----------------//

            //string[] datos = new string[4];

            //datos[0] = "SSD";
            //datos[1] = "SATA";
            //datos[2] = "1 TB";
            //datos[3] = "24";
            ////datos[4] = "";
            //try
            //{
            //    LN.InsertarDiscoDuro(datos, ref mensaje, ref mensajeC);
            //    TextBox12.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox12.Text = "nelson";
            //}

            //-------------fin tabla Disco Duro---------------------//

            //-------------inicio tabla estatus ------------------//

            //string[] datos = new string[1];

            //datos[0] = "NUEVO";

            //try
            //{
            //    LN.InsertarEstatus(datos, ref mensaje, ref mensajeC);
            //    TextBox13.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox13.Text = "nelson";
            //}

            //---------------fin de la tabla estatus----------//

            //-------------inicio tabla evidencia ------------------//

            //string[] datos = new string[2];

            //datos[0] = "prueba";
            //datos[1] = "1234567890";

            //try
            //{
            //    LN.InsertarEvidencia(datos, ref mensaje, ref mensajeC);
            //    TextBox14.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox14.Text = "nelson";
            //}

            //---------------fin de la tabla evidencia----------//

            //Tabla Gabinete ------> Inicio
            //string[] datos = new string[3];

            //datos[0] = "Prueba";
            //datos[1] = "Prueba";
            //datos[2] = "25";

            //try
            //{
            //    LN.InsertarGabinete(datos, ref mensaje, ref mensajeC);
            //    Label1.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label1.Text = "nelson";
            //}
            // Tabla Gabinete ------>Fin

            // Tabla Laboratorio ------>Inicio
            //string[] datos = new string[1];

            //datos[0] = "K5";

            //try
            //{
            //    LN.InsertarLaboratorio(datos, ref mensaje, ref mensajeC);
            //    Label2.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label2.Text = "nelson";
            //}
            // Tabla Laboratorio ------>Fin

            // Tabla Marca ------>Inicio
            //string[] datos = new string[3];

            //datos[0] = "Prueba";
            //datos[1] = "4";
            //datos[2] = "";

            //try
            //{
            //    LN.InsertarMarca(datos, ref mensaje, ref mensajeC);
            //    Label3.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label3.Text = "nelson";
            //}
            // Tabla Marca ------>Fin

            // Tabla ModeloCpu ------>Inicio
            //string[] datos = new string[2];

            //datos[0] = "Prueba";
            //datos[1] = "23";

            //try
            //{
            //    LN.InsertarModeloCpu(datos, ref mensaje, ref mensajeC);
            //    Label4.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label4.Text = "nelson";
            //}
            // Tabla ModeloCpu ------>Fin

            // Tabla Monitor ------>Inicio---------------------------------------------------------------------------------------------
            //string[] datos = new string[3];

            //datos[0] = "26";
            //datos[1] = "Prueba";
            //datos[1] = "1900x300";

            //try
            //{
            //    LN.InsertarMonitor(datos, ref mensaje, ref mensajeC);
            //    Label5.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label5.Text = "nelson";
            //}
            // Tabla Monitor ------>Fin

            // Tabla Mouse ------>Inicio
            //string[] datos = new string[2];

            //datos[0] = "27";
            //datos[1] = "Prueba";

            //try
            //{
            //    LN.InsertarMouse(datos, ref mensaje, ref mensajeC);
            //    Label6.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label6.Text = "nelson";
            //}
            // Tabla Mouse ------>Fin

            // Tabla Ram ------>Inicio
            //string[] datos = new string[3];

            //datos[0] = "9";
            //datos[1] = "Prueba";
            //datos[2] = "6";

            //try
            //{
            //    LN.InsertarRam(datos, ref mensaje, ref mensajeC);
            //    Label7.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label7.Text = "nelson";
            //}
            // Tabla Ram ------>Fin

            // Tabla Teclado ------>Inicio--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //string[] datos = new string[2];

            //datos[0] = "25";
            //datos[1] = "Prueba";

            //try
            //{
            //    LN.InsertarTeclado(datos, ref mensaje, ref mensajeC);
            //    Label8.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label8.Text = "nelson";
            //}
            // Tabla Teclado ------>Fin

            // Tabla TipoCpu ------>Inicio--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //string[] datos = new string[4];

            //datos[0] = "Prueba";
            //datos[1] = "Prueba x2";
            //datos[2] = "Prueba x3";
            //datos[3] = "Prueba x4";

            //try
            //{
            //    LN.InsertarTipoCpu(datos, ref mensaje, ref mensajeC);
            //    Label9.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label9.Text = "nelson";
            //}
            // Tabla TipoCpu ------>Fin

            // Tabla TipoRam ------>Inicio
            //string[] datos = new string[2];

            //datos[0] = "Prueba";
            //datos[1] = "";

            //try
            //{
            //    LN.InsertarTipoRam(datos, ref mensaje, ref mensajeC);
            //    Label10.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label10.Text = "nelson";
            //}
            // Tabla TipoRam ------>Fin

            // Tabla Ubicacion ------>Inicio--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //string[] datos = new string[2];

            //datos[0] = "98765";
            //datos[1] = "k5";

            //try
            //{
            //    LN.InsertarUbicacion(datos, ref mensaje, ref mensajeC);
            //    Label11.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label11.Text = "nelson";
            //}
            // Tabla Ubicacion ------>Fin

            // Tabla Usuario ------>Inicio--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //string[] datos = new string[6];

            //datos[0] = "Omarr";
            //datos[1] = "Castillro";
            //datos[2] = "Moralesr";
            //datos[3] = "omarcrin@hotmail.com";
            //datos[4] = "holasoryomar";
            //datos[5] = "";

            //try
            //{
            //    LN.InsertarUsuario(datos, ref mensaje, ref mensajeC);
            //    Label12.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label12.Text = "nelson";
            //}
            //Tabla Usuario ------> Fin

        }
    }
}