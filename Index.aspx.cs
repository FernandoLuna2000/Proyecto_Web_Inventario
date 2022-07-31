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
            Lista_Actualizacion = LN.L_Actualizacion(ref mensaje, ref mensajeC);
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
            Lista_CantDisc = LN.L_CantDisc(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_CantDisc.Count(); i++)
            {
                ListBox3.Items.Add(Lista_CantDisc[i].IdCant.ToString());
                ListBox3.Items.Add(Lista_CantDisc[i].NumInv.ToString());
                ListBox3.Items.Add(Lista_CantDisc[i].IdDisco.ToString());
            }
            //Lista CantDisc --->FINAL

            //Lista Categoria --->INICIO
            Lista_Categoria = LN.L_Categoria(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Categoria.Count(); i++)
            {
                ListBox4.Items.Add(Lista_Categoria[i].IdCategoria.ToString());
                ListBox4.Items.Add(Lista_Categoria[i].Descripcion.ToString());
            }
            //Lista Categoria --->FINAL

            //Lista CatMar --->INICIO
            Lista_CatMar = LN.L_CatMar(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_CatMar.Count(); i++)
            {
                ListBox5.Items.Add(Lista_CatMar[i].IdCatMar.ToString());
                ListBox5.Items.Add(Lista_CatMar[i].IdCategoria.ToString());
                ListBox5.Items.Add(Lista_CatMar[i].IdMarca.ToString());
            }
            //Lista CatMar --->FINAL

            //Lista CompuFinal --->INICIO
            Lista_CompuFinal = LN.L_ComputadoraFinal(ref mensaje, ref mensajeC);
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
            Lista_CpuGenerico = LN.L_CpuGenerico(ref mensaje, ref mensajeC);
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
            Lista_CpuTipoMod = LN.L_CpuTipoMod(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_CpuTipoMod.Count(); i++)
            {
                ListBox8.Items.Add(Lista_CpuTipoMod[i].IdTipoMod.ToString());
                ListBox8.Items.Add(Lista_CpuTipoMod[i].IdTcpu.ToString());
                ListBox8.Items.Add(Lista_CpuTipoMod[i].IdModcpu.ToString());
                ListBox8.Items.Add(Lista_CpuTipoMod[i].Nucleos.ToString());
            }
            //Lista CpuTipoMod --->FINAL

            //Lista DiscoDuro --->INICIO
            Lista_DiscoDuro = LN.L_DiscoDuro(ref mensaje, ref mensajeC);
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
            Lista_Estatus = LN.L_Estatus(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Estatus.Count(); i++)
            {
                ListBox10.Items.Add(Lista_Estatus[i].IdEstatus.ToString());
                ListBox10.Items.Add(Lista_Estatus[i].Estado.ToString());
            }
            //Lista Estatus --->FINAL

            //Lista Evidencia --->INICIO
            Lista_Evidencia = LN.L_Evidencia(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Evidencia.Count(); i++)
            {
                ListBox11.Items.Add(Lista_Evidencia[i].IdEvidencia.ToString());
                ListBox11.Items.Add(Lista_Evidencia[i].Evidencia1.ToString());
                ListBox11.Items.Add(Lista_Evidencia[i].NumInv.ToString());
            }
            //Lista Evidencia --->FINAL

            //Lista Gabinete --->INICIO
            Lista_Gabinete = LN.L_Gabinete(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Gabinete.Count(); i++)
            {
                ListBox12.Items.Add(Lista_Gabinete[i].IdGabinete.ToString());
                ListBox12.Items.Add(Lista_Gabinete[i].Modelo.ToString());
                ListBox12.Items.Add(Lista_Gabinete[i].TipoForma.ToString());
                ListBox12.Items.Add(Lista_Gabinete[i].FMarca.ToString());
            }
            //Lista Gabinete --->FINAL

            //Lista Laboratorio --->INICIO
            Lista_Laboratorio = LN.L_Lab(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Laboratorio.Count(); i++)
            {
                ListBox13.Items.Add(Lista_Laboratorio[i].NombreLaboratorio.ToString());
            }
            //Lista Laboratorio --->FINAL

            //Lista Marca --->INICIO
            Lista_Marca = LN.L_Marca(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Marca.Count(); i++)
            {
                ListBox1.Items.Add(Lista_Marca[i].IdMarca.ToString());
                ListBox1.Items.Add(Lista_Marca[i].Marca1.ToString());
                ListBox1.Items.Add(Lista_Marca[i].IdComponente.ToString());
            }
            //Lista Marca --->FINAL

            //Lista ModeloCpu --->INICIO
            Lista_ModeloCpu = LN.L_ModeloCpu(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_ModeloCpu.Count(); i++)
            {
                ListBox14.Items.Add(Lista_ModeloCpu[i].IdModcpu.ToString());
                ListBox14.Items.Add(Lista_ModeloCpu[i].IdModcpu.ToString());
                //ListBox14.Items.Add(Lista_ModeloCpu[i].FMarca.ToString());
            }
            //Lista ModeloCpu --->FINAL

            //Lista Monitor --->INICIO
            Lista_Monitor = LN.L_Monitor(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Monitor.Count(); i++)
            {
                ListBox15.Items.Add(Lista_Monitor[i].IdMonitor.ToString());
                ListBox15.Items.Add(Lista_Monitor[i].FMarcam.ToString());
                ListBox15.Items.Add(Lista_Monitor[i].Conectores.ToString());
                ListBox15.Items.Add(Lista_Monitor[i].Tamano.ToString());
            }
            //Lista Monitor --->FINAL

            //Lista Mouse --->INICIO
            Lista_Mouse = LN.L_Mouse(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Mouse.Count(); i++)
            {
                ListBox16.Items.Add(Lista_Mouse[i].IdMouse.ToString());
                ListBox16.Items.Add(Lista_Mouse[i].FMarcamouse.ToString());
                ListBox16.Items.Add(Lista_Mouse[i].Conector.ToString());
            }
            //Lista Mouse --->FINAL

            //Lista Ram --->INICIO
            Lista_Ram = LN.L_Ram(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Ram.Count(); i++)
            {
                ListBox17.Items.Add(Lista_Ram[i].IdRam.ToString());
                ListBox17.Items.Add(Lista_Ram[i].Capacidad.ToString());
                ListBox17.Items.Add(Lista_Ram[i].Velocidad.ToString());
                ListBox17.Items.Add(Lista_Ram[i].FTipoR.ToString());
            }
            //Lista Ram --->FINAL

            //Lista Teclado --->INICIO
            Lista_Teclado = LN.L_Teclado(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Teclado.Count(); i++)
            {
                ListBox18.Items.Add(Lista_Teclado[i].IdTeclado.ToString());
                ListBox18.Items.Add(Lista_Teclado[i].FMarcat.ToString());
                ListBox18.Items.Add(Lista_Teclado[i].Conector.ToString());
            }
            //Lista Teclado --->FINAL

            //Lista TipoCpu --->INICIO
            Lista_TipoCpu = LN.L_TipoCpu(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_TipoCpu.Count(); i++)
            {
                ListBox19.Items.Add(Lista_TipoCpu[i].IdTcpu.ToString());
                ListBox19.Items.Add(Lista_TipoCpu[i].Tipo.ToString());
                ListBox19.Items.Add(Lista_TipoCpu[i].Familia.ToString());
            }
            //Lista TipoCpu --->FINAL

            //Lista TipoRam --->INICIO
            Lista_TipoRam = LN.L_TipoRam(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_TipoRam.Count(); i++)
            {
                ListBox20.Items.Add(Lista_TipoRam[i].IdTipoRam.ToString());
                ListBox20.Items.Add(Lista_TipoRam[i].Tipo.ToString());
            }
            //Lista TipoRam --->FINAL

            //Lista Ubicacion --->INICIO
            Lista_Ubicacion = LN.L_Ubicacion(ref mensaje, ref mensajeC);
            for (int i = 0; i < Lista_Ubicacion.Count(); i++)
            {
                ListBox21.Items.Add(Lista_Ubicacion[i].NumInv.ToString());
                ListBox21.Items.Add(Lista_Ubicacion[i].NombreLaboratorio.ToString());
            }
            //Lista Ubicacion --->FINAL

            //Lista Usuario --->INICIO
            Lista_Usuario = LN.L_Usuario(ref mensaje, ref mensajeC);
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

            //string[] datos = new string[4];

            //datos[0] = "1234567890";
            //datos[1] = "14651456136";
            //datos[2] = "prueba";
            //datos[3] = "2020-03-25";


            //try
            //{
            //    LN.Insert_cantDisc(datos, ref mensaje, ref mensajeC);
            //    TextBox5.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox5.Text = "nelson";
            //}















            ////----------------inicia la tabla cantDisc-----------------------//
            //string[] datos = new string[2];

            //datos[0] = "1234567892";
            //datos[1] = "6";

            //try
            //{
            //    LN.Insert_cantDisc(datos, ref mensaje, ref mensajeC);
            //    TextBox6.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox6.Text = "nelson";
            //}
            ////---------------fin de la tabla cantDisc----------------------//

            ////----------------inicia la tabla Categoria-----------------------//

            //string[] datos = new string[1];

            //datos[0] = "hola mundo";

            //try
            //{
            //    LN.Insert_Categoria(datos, ref mensaje, ref mensajeC);
            //    TextBox7.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox7.Text = "nelson";
            //}

            ////---------------fin de la tabla Categoria----------------------//

            ////--------------inicio Tabla CatMar---------------------------//

            //string[] datos = new string[2];

            //datos[0] = "1";
            //datos[1] = "25";

            //try
            //{
            //    LN.Insert_CatMar(datos, ref mensaje, ref mensajeC);
            //    TextBox8.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox8.Text = "nelson";
            //}

            ////-------------fin tabla CatMar-------------------------------//

            ////------------inicia tabla computadora final ----------------//

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
            //    LN.Insert_ComputadoraFinal(datos, ref mensaje, ref mensajeC);
            //    TextBox9.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox9.Text = "nelson";
            //}

            ////-------------fin tabla Computadora final---------------------//

            ////------------inicia tabla cpu generico ----------------//

            //string[] datos = new string[6];

            //datos[0] = "12";
            //datos[1] = "23";
            //datos[2] = "i5-5570";
            //datos[3] = "corre a 4.20Ghz";
            //datos[4] = "5";
            //datos[5] = "5";
            //try
            //{
            //    LN.Insert_CPUgenerico(datos, ref mensaje, ref mensajeC);
            //    TextBox10.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox10.Text = "nelson";
            //}

            ////-------------fin tabla Cpu generico---------------------//

            ////------------inicia tabla cpu tipo mod ----------------//

            //string[] datos = new string[3];

            //datos[0] = "12";
            //datos[1] = "2";
            //datos[2] = "prueba";
            //try
            //{
            //    LN.Insert_CPUTipoMod(datos, ref mensaje, ref mensajeC);
            //    TextBox11.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox11.Text = "nelson";
            //}

            ////-------------fin tabla Cpu tipo mod---------------------//

            //// ------------inicia tabla Disco Duro ----------------//

            //string[] datos = new string[5];

            //datos[0] = "SSD";
            //datos[1] = "SATA";
            //datos[2] = "1 TB";
            //datos[3] = "24";
            //datos[4] = "";
            //try
            //{
            //    LN.Insert_DiscoDuro(datos, ref mensaje, ref mensajeC);
            //    TextBox12.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox12.Text = "nelson";
            //}

            ////-------------fin tabla Disco Duro---------------------//

            ////-------------inicio tabla estatus ------------------//

            //string[] datos = new string[1];

            //datos[0] = "NUEVO";

            //try
            //{
            //    LN.Insert_Estatus(datos, ref mensaje, ref mensajeC);
            //    TextBox13.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox13.Text = "nelson";
            //}

            ////---------------fin de la tabla estatus----------//

            ////-------------inicio tabla evidencia ------------------//

            //string[] datos = new string[2];

            //datos[0] = "prueba";
            //datos[1] = "1234567890";

            //try
            //{
            //    LN.Insert_Evidencia(datos, ref mensaje, ref mensajeC);
            //    TextBox14.Text = "ahuevooo";
            //}
            //catch
            //{
            //    TextBox14.Text = "nelson";
            //}

            ////---------------fin de la tabla evidencia----------//

            ////Tabla Gabinete ------> Inicio
            //string[] datos = new string[3];

            //datos[0] = "Prueba";
            //datos[1] = "Prueba";
            //datos[2] = "25";

            //try
            //{
            //    LN.Insert_Gabinete(datos, ref mensaje, ref mensajeC);
            //    Label1.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label1.Text = "nelson";
            //}
            //// Tabla Gabinete ------>Fin

            ////Tabla Laboratorio ------> Inicio
            //string[] datos = new string[1];

            //datos[0] = "K5";

            //try
            //{
            //    LN.Insert_Laboratorio(datos, ref mensaje, ref mensajeC);
            //    Label2.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label2.Text = "nelson";
            //}
            //// Tabla Laboratorio ------>Fin

            //// Tabla Marca ------>Inicio
            //string[] datos = new string[3];

            //datos[0] = "Prueba";
            //datos[1] = "4";
            //datos[2] = "";

            //try
            //{
            //    LN.Insert_Marca(datos, ref mensaje, ref mensajeC);
            //    Label3.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label3.Text = "nelson";
            //}
            //// Tabla Marca ------>Fin

            //// Tabla ModeloCpu ------>Inicio
            //string[] datos = new string[2];

            //datos[0] = "Prueba";
            //datos[1] = "23";

            //try
            //{
            //    LN.Insert_ModeloCpu(datos, ref mensaje, ref mensajeC);
            //    Label4.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label4.Text = "nelson";
            //}
            //// Tabla ModeloCpu ------>Fin

            //// Tabla Monitor ------>Inicio
            //string[] datos = new string[3];

            //datos[0] = "26";
            //datos[1] = "Prueba";
            //datos[2] = "1900x300";

            //try
            //{
            //    LN.Insert_Monitor(datos, ref mensaje, ref mensajeC);
            //    Label5.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label5.Text = "nelson";
            //}
            //// Tabla Monitor ------>Fin

            //// Tabla Mouse ------>Inicio
            //string[] datos = new string[2];

            //datos[0] = "27";
            //datos[1] = "Prueba";

            //try
            //{
            //    LN.Insert_Mouse(datos, ref mensaje, ref mensajeC);
            //    Label6.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label6.Text = "nelson";
            //}
            //// Tabla Mouse ------>Fin

            //// Tabla Ram ------>Inicio
            //string[] datos = new string[3];

            //datos[0] = "9";
            //datos[1] = "Prueba";
            //datos[2] = "6";

            //try
            //{
            //    LN.Insert_Ram(datos, ref mensaje, ref mensajeC);
            //    Label7.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label7.Text = "nelson";
            //}
            //// Tabla Ram ------>Fin

            //// Tabla Teclado ------>Inicio
            //string[] datos = new string[2];

            //datos[0] = "25";
            //datos[1] = "USB";

            //try
            //{
            //    LN.Insert_Teclado(datos, ref mensaje, ref mensajeC);
            //    Label8.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label8.Text = "nelson";
            //}
            //// Tabla Teclado ------>Fin

            //// Tabla TipoCpu ------>Inicio
            //string[] datos = new string[4];

            //datos[0] = "Prueba";
            //datos[1] = "Prueba x2";
            //datos[2] = "";
            //datos[3] = "";

            //try
            //{
            //    LN.Insert_TipoCpu(datos, ref mensaje, ref mensajeC);
            //    Label9.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label9.Text = "nelson";
            //}
            //// Tabla TipoCpu ------>Fin

            //// Tabla TipoRam ------>Inicio
            //string[] datos = new string[2];

            //datos[0] = "Prueba";
            //datos[1] = "";

            //try
            //{
            //    LN.Insert_TipoRam(datos, ref mensaje, ref mensajeC);
            //    Label10.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label10.Text = "nelson";
            //}
            //// Tabla TipoRam ------>Fin

            //// Tabla Ubicacion ------>Inicio
            //string[] datos = new string[2];

            //datos[0] = "1234567892";
            //datos[1] = "k5";

            //try
            //{
            //    LN.Insert_Ubicacion(datos, ref mensaje, ref mensajeC);
            //    Label11.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label11.Text = "nelson";
            //}
            //// Tabla Ubicacion ------>Fin

            //// Tabla Usuario ------>Inicio
            //string[] datos = new string[6];

            //datos[0] = "Omar";
            //datos[1] = "Castillo";
            //datos[2] = "Morales";
            //datos[3] = "omarcin@hotmail.com";
            //datos[4] = "holasoyomar";
            //datos[5] = "";

            //try
            //{
            //    LN.Insert_Usuario(datos, ref mensaje, ref mensajeC);
            //    Label12.Text = "ahuevooo";
            //}
            //catch
            //{
            //    Label12.Text = "nelson";
            //}
            ////Tabla Usuario ------> Fin

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            //// Tabla Actualizacion ------>Inicio

            //string[] datos = new string[4];

            //string fecha = DateTime.Now.ToString();

            //datos[0] = "1234567899";
            //datos[1] = "1456234523";
            //datos[2] = "dhdhdh";
            //datos[3] = fecha;

            //try
            //{
            //    LN.Act_TabActualizacion(datos, ref mensaje, ref mensajeC, 1044);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error";
            //}

            ////Tabla Actualizacion -------------------------------------> Fin

            //// Tabla cantDisc------------------------------------------>Inicio

            //string[] datos = new string[2];

            //datos[0] = "1234567899";
            //datos[1] = "7";

            //try
            //{
            //    LN.Act_CabtDisc(datos, ref mensaje, ref mensajeC, 8);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla CantDisc-- -----------------------------------------> Fin

            //// Tabla Categoria ------------------------------------------>Inicio

            //string[] datos = new string[1];

            //datos[0] = "prueba";

            //try
            //{
            //    LN.Act_Categoria(datos, ref mensaje, ref mensajeC, 2);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla Cantegoria--------------------------------------------> Fin


            //// Tabla CatMar ------------------------------------------>Inicio

            //string[] datos = new string[2];

            //datos[0] = "2";
            //datos[1] = "23";

            //try
            //{
            //    LN.Act_CatMar(datos, ref mensaje, ref mensajeC, 3);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla CatMar--------------------------------------------> Fin

            //// Tabla Computadora final ------------------------------------------>Inicio

            //string[] datos = new string[10];

            //datos[0] = "12433634788";
            //datos[1] = "9";
            //datos[2] = "19241324230";
            //datos[3] = "6";
            //datos[4] = "13252133000";
            //datos[5] = "5";
            //datos[6] = "12413523595";
            //datos[7] = "5";
            //datos[8] = "K2";
            //datos[9] = "1";

            //try
            //{
            //    LN.Act_CompuFinal(datos, ref mensaje, ref mensajeC, 1234567899);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla Computadora final --------------------------------------------> Fin

            //// Tabla Cpu_generico ------------------------------------------>Inicio

            //string[] datos = new string[16];

            //datos[0] = "13";
            //datos[1] = "28";
            //datos[2] = "i5-5570";
            //datos[3] = "corre a 5.20Ghz";
            //datos[4] = "4";
            //datos[5] = "6";

            //try
            //{
            //    LN.Act_CPU_generico(datos, ref mensaje, ref mensajeC, 11);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla Cpu_generico --------------------------------------------> Fin

            //// Tabla Cpu_Tipomod ------------------------------------------>Inicio

            //string[] datos = new string[3];

            //datos[0] = "12";
            //datos[1] = "1";
            //datos[2] = "zzzzz";

            //try
            //{
            //    LN.Act_Cpu_tipomod(datos, ref mensaje, ref mensajeC, 1);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla Cpu_tipomod--------------------------------------------> Fin

            //// Tabla disco duro ------------------------------------------>Inicio

            //string[] datos = new string[5];

            //datos[0] = "SSD";
            //datos[1] = "SATA";
            //datos[2] = "1 TB";
            //datos[3] = "24";
            //datos[4] = "";

            //try
            //{
            //    LN.Act_DiscoDuro(datos, ref mensaje, ref mensajeC, 7);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla disco duro--------------------------------------------> Fin

            //// Tabla estatus ------------------------------------------>Inicio

            //string[] datos = new string[1];

            //datos[0] = "dañado";

            //try
            //{
            //    LN.Act_Estatus(datos, ref mensaje, ref mensajeC, 4);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla estatus--------------------------------------------> Fin

            ////Tabla disco duro--------------------------------------------> Fin

            //// Tabla esvidencia ------------------------------------------>Inicio

            //string[] datos = new string[2];

            //datos[0] = "cambio";
            //datos[1] = "1234567899";

            //try
            //{
            //    LN.Act_Evidencia(datos, ref mensaje, ref mensajeC, 1);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla evidencia--------------------------------------------> Fin

            //// Tabla gabinete ------------------------------------------>Inicio

            //string[] datos = new string[3];

            //datos[0] = "generico";
            //datos[1] = "Media Torre";
            //datos[2] = "25";

            //try
            //{
            //    LN.Act_Gabinete(datos, ref mensaje, ref mensajeC, 6);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla gabinete--------------------------------------------> Fin

            //// Tabla laboratorio ------------------------------------------>Inicio
            ////Tabla laboratorio--------------------------------------------> Fin

            //// Tabla Marca ------------------------------------------>Inicio

            //string[] datos = new string[3];

            //datos[0] = "hp";
            //datos[1] = "2";
            //datos[2] = "";

            //try
            //{
            //    LN.Act_Marca(datos, ref mensaje, ref mensajeC, 31);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla Marca--------------------------------------------> Fin

            //// Tabla Modelo CPU ------------------------------------------>Inicio

            //string[] datos = new string[2];

            //datos[0] = "Ryzen7";
            //datos[1] = "23";

            //try
            //{
            //    LN.Act_ModeloCpu(datos, ref mensaje, ref mensajeC, 18);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla ModeloCPU--------------------------------------------> Fin

            //// Tabla Monitor ------------------------------------------>Inicio

            //string[] datos = new string[3];

            //datos[0] = "26";
            //datos[1] = "vga";
            //datos[2] = "480x250";

            //try
            //{
            //    LN.Act_Monitor(datos, ref mensaje, ref mensajeC, 5);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla Monitor--------------------------------------------> Fin

            //// Tabla Mouse ------------------------------------------>Inicio

            //string[] datos = new string[2];

            //datos[0] = "27";
            //datos[1] = "ps27";

            //try
            //{
            //    LN.Act_Mouse(datos, ref mensaje, ref mensajeC, 6);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla Mouse--------------------------------------------> Fin

            //// Tabla Ram ------------------------------------------>Inicio

            //string[] datos = new string[3];

            //datos[0] = "4";
            //datos[1] = "500";
            //datos[2] = "5";

            //try
            //{
            //    LN.Act_Ram(datos, ref mensaje, ref mensajeC, 5);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla Ram--------------------------------------------> Fin

            //// Tabla teclado ------------------------------------------>Inicio

            //string[] datos = new string[2];

            //datos[0] = "25";
            //datos[1] = "usb";

            //try
            //{
            //    LN.Act_Teclado(datos, ref mensaje, ref mensajeC, 6);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla teclado--------------------------------------------> Fin

            //// Tabla TipoCPU ------------------------------------------>Inicio

            //string[] datos = new string[4];

            //datos[0] = "corei6";
            //datos[1] = "2ra.generacion";
            //datos[2] = "";
            //datos[3] = "";

            //try
            //{
            //    LN.Act_TipoCPU(datos, ref mensaje, ref mensajeC, 13);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla tipocpu--------------------------------------------> Fin

            //// Tabla TipoRAM ------------------------------------------>Inicio

            //string[] datos = new string[2];

            //datos[0] = "DIMM DDR2";
            //datos[1] = "";

            //try
            //{
            //    LN.Act_TipoRAM(datos, ref mensaje, ref mensajeC, 9);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla tipoRAM--------------------------------------------> Fin

            //// Tabla ubicacion ------------------------------------------>Inicio

            //string[] datos = new string[1];

            //datos[0] = "k1";

            //try
            //{
            //    LN.Act_Ubicaciones(datos, ref mensaje, ref mensajeC, 1234567892);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla ubicacion--------------------------------------------> Fin

            //// Tabla usuario ------------------------------------------>Inicio

            //string[] datos = new string[6];

            //datos[0] = "carlos";
            //datos[1] = "fernandez";
            //datos[2] = "torres";
            //datos[3] = "charly";
            //datos[4] = "124351";
            //datos[5] = "";

            //try
            //{
            //    LN.Act_Usuario(datos, ref mensaje, ref mensajeC, 1);
            //    Label13.Text = "se actualizo";
            //}
            //catch
            //{
            //    Label13.Text = "error checa tus datos";
            //}

            ////Tabla usuario--------------------------------------------> Fin
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            ////EliminarActualizacion--> Inicio
            //try
            //{
            //    LN.Elim_actualizacion(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarActualizacion--> Final

            ////EliminarCantDisc--> Inicio
            //try
            //{
            //    LN.Elim_CantDisc(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarCantDisc--> Final

            ////EliminarCategoria--> Inicio-------------------------------------------------------------------------------
            //try
            //{
            //    LN.Elim_Categoria(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarCategoria--> Final

            ////EliminarCatMar--> Inicio
            //try
            //{
            //    LN.Elim_CatMar(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarCatMar--> Final

            ////EliminarComputadoraFinal--> Inicio--------------------------------------------------------------------------------
            //try
            //{
            //    LN.Elim_Computadorafinal(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarComputadoraFinal--> Final

            ////EliminarCpuGenerico--> Inicio
            //try
            //{
            //    LN.Elim_CPU_Generico(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarCpuGenerico--> Final

            ////EliminarCpuTipoMod--> Inicio
            //try
            //{
            //    LN.Elim_CPU_TipoMod(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarCpuTipoMod--> Final

            ////EliminarDiscoDuro--> Inicio----------------------------------------------------------------------------------------------
            //try
            //{
            //    LN.Elim_DiscoDuro(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarDiscoDuro--> Final

            ////EliminarEstatus--> Inicio
            //try
            //{
            //    LN.Elim_Estatus(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////Eliminarstatus--> Final

            ////EliminarEvidencia--> Inicio
            //try
            //{
            //    LN.Elim_Evidencia(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarEvidencian--> Final

            ////EliminarGabinete--> Inicio-----------------------------------------------------------------------------------------------
            //try
            //{
            //    LN.Elim_Gabinete(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarGabinete--> Final

            ////EliminarLaboratorio--> Inicio---------------------------------------------------------------------------------------------------------------
            //try
            //{
            //    LN.Elim_Laboratorio(ref mensaje, ref mensajeC, 3);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarLaboratorio--> Final

            ////EliminarMarca--> Inicio
            //try
            //{
            //    LN.Elim_Marca(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarrMarca--> Final

            ////EliminarModelo--> Inicio
            //try
            //{
            //    LN.Elim_Modelo(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarModelo--> Final

            ////EliminarMonitor-> Inicio
            //try
            //{
            //    LN.Elim_Monitor(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarMonitor--> Final

            ////EliminarMouse--> Inicio
            //try
            //{
            //    LN.Elim_Mouse(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarMouse--> Final

            ////EliminarRam--> Inicio--------------------------------------------------------------------------------------------------------------------
            //try
            //{
            //    LN.Elim_Ram(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarRam--> Final

            ////EliminarTeclado--> Inicio
            //try
            //{
            //    LN.Elim_Teclado(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarTeclado--> Final

            ////EliminarTipoCpu-> Inicio-----------------------------------------------------------------------------------------------------------------------
            //try
            //{
            //    LN.Elim_Tipocpu(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarTipoCpu--> Final

            ////EliminarTipoRam--> Inicio
            //try
            //{
            //    LN.Elim_TipoRAM(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarTipoRam--> Final

            ////EliminarUbicacion--> Inicio
            //try
            //{
            //    LN.Elim_Ubicacion(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarUbicacion--> Final

            ////EliminarUsuario--> Inicio
            //try
            //{
            //    LN.Elim_Usuario(ref mensaje, ref mensajeC, 11);
            //    Label14.Text = "se elimino";
            //}
            //catch
            //{
            //    Label14.Text = "error checa tus datos";
            //}
            ////EliminarUsuario--> Final
        }
    }
}