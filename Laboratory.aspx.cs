using c_dll;
using c_entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Web_Inventario
{
    public partial class Laboratory : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<Computadorafinal> Lista_CompuFinal = new List<Computadorafinal>();
        List<Laboratorio> ListaLab = new List<Laboratorio>();
        List<Ubicacion> ubiList = new List<Ubicacion>();
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

            string msj = "", msjc = "", equipos = "", numin = "";
            numin = DropDownList1.SelectedItem.Text;

            Lista_CompuFinal = LN.L_ComputadoraFinal(ref msj, ref msjc);
            ListaLab = LN.L_Lab(ref msj, ref msjc);
            ubiList = LN.L_Ubicacion(ref msj, ref msjc);

            //el conector es igual a la lisa teclado donde el id de teclado sea = a la lista de computadora final donde el num_inv sea = al numero de inventario que ya tengo 
            //el fistrordefault es para que me traiga el primer dato y el .idteclado es lo que estoy buscando (sub consulta de una consulta)
            //equipos = Lista_CompuFinal.Where(x => x.NumInv == ListaLab.Where(y => y.NombreLaboratorio == numin).FirstOrDefault().NombreLaboratorio).FirstOrDefault().Estado;

            equipos = Lista_CompuFinal.Where(x => x.NumInv == ubiList.Where(y => y.NombreLaboratorio == numin).FirstOrDefault().NumInv).FirstOrDefault().NumInv;

            ListBox1.Items.Add("Equipos = " + equipos);
        }
    }
}