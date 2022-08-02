using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using c_dll;
using c_entidades;


namespace Proyecto_Web_Inventario
{
    public partial class ActualizarEliminarTablaCategoria : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<Categoria> lista_categoria = new List<Categoria>();
        string mensaje = "", mensajeC = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                lista_categoria = LN.L_Categoria(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < lista_categoria.Count; i++)
                {
                    DropDownList1.Items.Add(lista_categoria[i].IdCategoria.ToString());
                }
            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(DropDownList1.SelectedItem.Text);
            lista_categoria = LN.L_Categoria(ref mensaje, ref mensajeC);
            string[] datos = new string[1];

            datos[0] = TextBox2.Text;

            LN.Act_Categoria(datos, ref mensaje, ref mensajeC, Id);

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(DropDownList1.SelectedItem.Text);

                LN.Elim_Categoria(ref mensaje, ref mensajeC, Id);

                Label1.Text = "se elimino";
            }
            catch
            {
                Label1.Text = "error checa tus datos";
            }
        }
    }
}