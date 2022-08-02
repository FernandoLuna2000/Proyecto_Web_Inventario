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
    public partial class Equipo_lab : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<Computadorafinal> Lista_CompuFinal = new List<Computadorafinal>();
        List<Laboratorio> ListaLab = new List<Laboratorio>();
        List<DiscoDuro> ListaDiscoDuro = new List<DiscoDuro>();
        string msj = "", msjc = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;
                ListaLab = LN.L_Lab(ref msj, ref msjc);
                DropDownList1.Items.Add("");
                for (int i = 0; i < ListaLab.Count; i++)
                {
                    DropDownList1.Items.Add(ListaLab[i].NombreLaboratorio);
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

            string msj = "", msjc = "", conector = "", marca = "", numin = "";
            numin = DropDownList1.SelectedItem.Text;

            Lista_CompuFinal = LN.L_ComputadoraFinal(ref msj, ref msjc);
            ListaLab = LN.L_Lab(ref msj, ref msjc);
            ListaDiscoDuro = LN.L_DiscoDuro(ref msj, ref msjc);

            conector = Lista_CompuFinal.Where(x => x.NumInv == ListaLab.Where(y => y.NombreLaboratorio == numin).FirstOrDefault().NombreLaboratorio).FirstOrDefault().Estado;

            ListBox1.Items.Add("Conector del Teclado = " + conector);
        }
    }
}