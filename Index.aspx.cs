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

            TextBox1.Text = mensajeC + " " + mensaje;
        }
    }
}