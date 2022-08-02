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
    public partial class Monitor_Lab : System.Web.UI.Page
    {
        Logica_Negocio LN = null;

        List<Computadorafinal> Lista_CompuFinal = new List<Computadorafinal>();
        List<Monitor> ListaMonitor = new List<Monitor>();
        List<Laboratorio> ListaLab = new List<Laboratorio>();

        string msj = "", msjc = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;
                ListaMonitor = LN.L_Monitor(ref msj, ref msjc);
                DropDownList1.Items.Add("");
                for (int i = 0; i < ListaMonitor.Count; i++)
                {
                    DropDownList1.Items.Add(Convert.ToString(ListaMonitor[i].IdMonitor));
                }
            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }
        }

        protected void BRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();

            

            string msj = "", msjc = "", conector = "", marca = "", numin = "", mause = "", Mmouse = "", Monitor = "", MMonitor = "", CPU = "", MCPU = "", Disc = "";
            numin = DropDownList1.SelectedItem.Text;

            Lista_CompuFinal = LN.L_ComputadoraFinal(ref msj, ref msjc);
            ListaMonitor = LN.L_Monitor(ref msj, ref msjc);
            ListaLab = LN.L_Lab(ref msj, ref msjc);


            //el conector es igual a la lisa teclado donde el id de teclado sea = a la lista de computadora final donde el num_inv sea = al numero de inventario que ya tengo 
            //el fistrordefault es para que me traiga el primer dato y el .idteclado es lo que estoy buscando (sub consulta de una consulta)

            //conector = Lista_CompuFinal.Where(x => x.NumInv == ListaMonitor.Where(y => y.IdMonitor.ToString() == numin).FirstOrDefault().IdMonitor.ToString()).FirstOrDefault().IdMong;

            ListBox1.Items.Add("Equipos con ese tipo de Monitor = " + numin);
            ListBox1.Items.Add("Los equipos pertenecen al laboratorio = " + conector);

        }
    }
}