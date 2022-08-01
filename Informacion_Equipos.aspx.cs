using c_dll;
using c_entidades;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Web_Inventario
{
    public partial class Informacion_Equipos : System.Web.UI.Page
    {
        Logica_Negocio LN = null;

        List<Computadorafinal> Lista_CompuFinal = new List<Computadorafinal>();
        List<Teclado> Lista_Teclado = new List<Teclado>();
        List<Marca> Lista_Marca = new List<Marca>();
        List<Mouse> ListaMouse = new List<Mouse>();
        List<c_entidades.Monitor> ListaMonitor = new List<c_entidades.Monitor>();
        List<Ram> ListaRam = new List<Ram>();
        List<CpuGenerico> ListaCpuGenerico = new List<CpuGenerico>();
        List<CantDisc> ListaCantDisc = new List<CantDisc>();

        string msj = "", msjc = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;
                Lista_CompuFinal = LN.L_ComputadoraFinal(ref msj, ref msjc);
                DropDownList1.Items.Add("");
                for (int i = 0; i < Lista_CompuFinal.Count; i++)
                {
                    DropDownList1.Items.Add(Lista_CompuFinal[i].NumInv);
                }
            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }
        }

        protected void BRegresar_Index_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();

            string msj = "", msjc = "", conector = "", marca = "", numin = "", mause = "", Mmouse = "", Monitor = "", MMonitor = "", CPU = "", MCPU = "", Disc = "";
            numin = DropDownList1.SelectedItem.Text;

            Lista_CompuFinal = LN.L_ComputadoraFinal(ref msj, ref msjc);
            Lista_Teclado = LN.L_Teclado(ref msj, ref msjc);
            Lista_Marca = LN.L_Marca(ref msj, ref msjc);
            ListaMouse = LN.L_Mouse(ref msj, ref msjc);
            ListaMonitor = LN.L_Monitor(ref msj, ref msjc);
            ListaRam = LN.L_Ram(ref msj, ref msjc);
            ListaCpuGenerico = LN.L_CpuGenerico(ref msj, ref msjc);
            ListaCantDisc = LN.L_CantDisc(ref msj, ref msjc);

            conector = Lista_Teclado.Where(x => x.IdTeclado == Lista_CompuFinal.Where(y => y.NumInv == numin).FirstOrDefault().IdTecladog).FirstOrDefault().Conector;
            marca = Lista_Marca.Where(x => x.IdMarca == Lista_Teclado.Where(y => y.Conector == conector).FirstOrDefault().FMarcat).FirstOrDefault().Marca1;
            mause = ListaMouse.Where(x => x.IdMouse == Lista_CompuFinal.Where(y => y.NumInv == numin).FirstOrDefault().IdMousg).FirstOrDefault().Conector;
            Mmouse = Lista_Marca.Where(x => x.IdMarca == ListaMouse.Where(y => y.Conector == conector).FirstOrDefault().FMarcamouse).FirstOrDefault().Marca1;
            Monitor = ListaMonitor.Where(x => x.IdMonitor == Lista_CompuFinal.Where(y => y.NumInv == numin).FirstOrDefault().IdMong).FirstOrDefault().Conectores;
            CPU = ListaCpuGenerico.Where(x => x.IdCpu == Lista_CompuFinal.Where(y => y.NumInv == numin).FirstOrDefault().IdCpug).FirstOrDefault().Modelo;
            //MCPU = Lista_Marca.Where(x => x.IdMarca == ListaCpuGenerico.Where(y => y.Modelo == conector).FirstOrDefault().FMarcaCpu).FirstOrDefault().Marca1;
            //Disc = ListaCantDisc.Where(x => x.NumInv == Lista_CompuFinal.Where(y => y.NumInv == numin).FirstOrDefault().NumInv).FirstOrDefault().IdDisco;


            ListBox1.Items.Add("Numero de Inventario = " + numin);
            ListBox1.Items.Add("Conector del Teclado = " + conector);
            ListBox1.Items.Add("Marca del Teclado = " + marca);
            ListBox1.Items.Add("Conector del Mouse = " + mause);
            ListBox1.Items.Add("Marca del Mouse = " + Mmouse);
            ListBox1.Items.Add("Conector del Monitor = " + Monitor);
            ListBox1.Items.Add("Modelo del CPU = " + CPU);
            //ListBox1.Items.Add("Marca del CPU = " + MCPU);
        }
    }
}