using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using c_entidades;
using c_dll;
using System.Configuration;

namespace Proyecto_Web_Inventario
{
    public partial class insertarTablaActualizar : System.Web.UI.Page
    {
        Logica_Negocio LN = null;

        List<Computadorafinal> Lista_compufinal = new List<Computadorafinal>();

        string mensaje = "", mensajeC = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                Lista_compufinal= LN.L_ComputadoraFinal(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < Lista_compufinal.Count; i++)
                {
                    DropDownList1.Items.Add(Lista_compufinal[i].NumInv);
                }

            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string[] datos = new string[4];

            datos[0] = DropDownList1.SelectedItem.Text;
            datos[1] = TextBox1.Text;
            datos[2] = TextBox2.Text;
            datos[3] = Calendar1.SelectedDate.ToString();

            try
            {
                LN.Insert_Actualizacion(datos, ref mensaje, ref mensajeC);
                Label1.Text = "Se agregaron los datos con exito";
            }
            catch
            {
                Label1.Text = "Error al insertar los datos ";
            }
        }
    }
}