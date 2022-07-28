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
        List<Marca> Lista_Marca = new List<Marca>();
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
            string mensaje = "", mensajeC = "";

            //GridView1.DataSource = LN.tablaMarcas(ref mensaje, ref mensajeC);
            //GridView1.DataBind();
            GridView2.DataSource = LN.tablacomputadorafinal(ref mensaje, ref mensajeC);
            GridView2.DataBind();


            ListBox1.Items.Clear();

            Lista_Marca = LN.ListaMarca(ref mensaje, ref mensajeC);

            for (int i = 0; i < Lista_Marca.Count(); i++)
            {
                ListBox1.Items.Add(Lista_Marca[i].IdMarca.ToString());
                ListBox1.Items.Add(Lista_Marca[i].Marca1.ToString());
                ListBox1.Items.Add(Lista_Marca[i].IdComponente.ToString());
                //ListBox1.Items.Add(Lista_Marca[i].Extra.ToString());
            }

            Lista_Actualizacion = LN.ListaActualizacion(ref mensaje, ref mensajeC);

            for (int i = 0; i < Lista_Actualizacion.Count(); i++)
            {
                ListBox2.Items.Add(Lista_Actualizacion[i].IdAct.ToString());
                ListBox2.Items.Add(Lista_Actualizacion[i].NumInv.ToString());
                ListBox2.Items.Add(Lista_Actualizacion[i].NumSerie.ToString());
                ListBox2.Items.Add(Lista_Actualizacion[i].Descripcion.ToString());
                ListBox2.Items.Add(Lista_Actualizacion[i].Fecha.ToString());
            }

            Lista_CantDisc = LN.ListaCantDisc(ref mensaje, ref mensajeC);

            for (int i = 0; i < Lista_CantDisc.Count(); i++)
            {
                ListBox3.Items.Add(Lista_CantDisc[i].IdCant.ToString());
                ListBox3.Items.Add(Lista_CantDisc[i].NumInv.ToString());
                ListBox3.Items.Add(Lista_CantDisc[i].IdDisco.ToString());

            }

            Lista_Categoria = LN.ListaCategoria(ref mensaje, ref mensajeC);

            for (int i = 0; i < Lista_Categoria.Count(); i++)
            {
                ListBox4.Items.Add(Lista_Categoria[i].IdCategoria.ToString());
                ListBox4.Items.Add(Lista_Categoria[i].Descripcion.ToString());

            }

            Lista_CatMar = LN.ListaCatMar(ref mensaje, ref mensajeC);

            for (int i = 0; i < Lista_CatMar.Count(); i++)
            {
                ListBox5.Items.Add(Lista_CatMar[i].IdCatMar.ToString());
                ListBox5.Items.Add(Lista_CatMar[i].IdCategoria.ToString());
                ListBox5.Items.Add(Lista_CatMar[i].IdMarca.ToString());


            }

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

            Lista_CpuTipoMod = LN.ListaCpuTipoMod(ref mensaje, ref mensajeC);

            for (int i = 0; i < Lista_CpuTipoMod.Count(); i++)
            {
                ListBox8.Items.Add(Lista_CpuTipoMod[i].IdTipoMod.ToString());
                ListBox8.Items.Add(Lista_CpuTipoMod[i].IdTcpu.ToString());
                ListBox8.Items.Add(Lista_CpuTipoMod[i].IdModcpu.ToString());
                ListBox8.Items.Add(Lista_CpuTipoMod[i].Nucleos.ToString());
            }

            Lista_DiscoDuro = LN.ListaDiscoDuro(ref mensaje, ref mensajeC);

            for (int i = 0; i < Lista_DiscoDuro.Count(); i++)
            {
                ListBox9.Items.Add(Lista_DiscoDuro[i].IdDisco.ToString());
                ListBox9.Items.Add(Lista_DiscoDuro[i].TipoDisco.ToString());
                ListBox9.Items.Add(Lista_DiscoDuro[i].Conector.ToString());
                ListBox9.Items.Add(Lista_DiscoDuro[i].Capacidad.ToString());
                ListBox9.Items.Add(Lista_DiscoDuro[i].FMarcaDisco.ToString());
                //ListBox9.Items.Add(Lista_DiscoDuro[i].Extra.ToString());

            }

            Lista_Estatus = LN.ListaEstatus(ref mensaje, ref mensajeC);

            for (int i = 0; i < Lista_Estatus.Count(); i++)
            {
                ListBox10.Items.Add(Lista_Estatus[i].IdEstatus.ToString());
                ListBox10.Items.Add(Lista_Estatus[i].Estado.ToString());

            }

            Lista_Evidencia = LN.ListaEvidencia(ref mensaje, ref mensajeC);

            for (int i = 0; i < Lista_Evidencia.Count(); i++)
            {
                ListBox11.Items.Add(Lista_Evidencia[i].IdEvidencia.ToString());
                ListBox11.Items.Add(Lista_Evidencia[i].Evidencia1.ToString());
                ListBox11.Items.Add(Lista_Evidencia[i].NumInv.ToString());

            }

            Lista_Gabinete = LN.ListaGabinete(ref mensaje, ref mensajeC);

            for (int i = 0; i < Lista_Gabinete.Count(); i++)
            {
                ListBox12.Items.Add(Lista_Gabinete[i].IdGabinete.ToString());
                ListBox12.Items.Add(Lista_Gabinete[i].Modelo.ToString());
                ListBox12.Items.Add(Lista_Gabinete[i].TipoForma.ToString());
                ListBox12.Items.Add(Lista_Gabinete[i].FMarca.ToString());

            }

            TextBox1.Text = mensajeC + " " + mensaje;
        }
    }
}