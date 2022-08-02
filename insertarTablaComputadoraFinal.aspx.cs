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
    public partial class insertarTablaComputadoraFinal : System.Web.UI.Page
    {
        Logica_Negocio LN = null;

        List<Laboratorio> Lista_Laboratorio = new List<Laboratorio>();
        List<Estatus> Lista_Estatus = new List<Estatus>();

        string mensaje = "", mensajeC = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                Lista_Laboratorio = LN.L_Lab(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < Lista_Laboratorio.Count; i++)
                {
                    DropDownList1.Items.Add(Lista_Laboratorio[i].NombreLaboratorio.ToString());
                }

                Lista_Estatus = LN.L_Estatus(ref mensaje, ref mensajeC);
                DropDownList2.Items.Add("");
                for (int i = 0; i < Lista_Estatus.Count; i++)
                {
                    DropDownList2.Items.Add(Lista_Estatus[i].IdEstatus.ToString());
                }

            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] datos = new string[11];

            datos[0] = TextBox1.Text;
            datos[1] = TextBox2.Text;
            datos[2] = TextBox3.Text;
            datos[3] = TextBox4.Text;
            datos[4] = TextBox5.Text;
            datos[5] = TextBox6.Text;
            datos[6] = TextBox7.Text;
            datos[7] = TextBox8.Text;
            datos[8] = TextBox9.Text;
            datos[9] = DropDownList1.SelectedItem.Text;
            datos[10] = DropDownList2.SelectedItem.Text;
            try
            {
                LN.Insert_ComputadoraFinal(datos, ref mensaje, ref mensajeC);
                Label1.Text = "Se agregaron los datos correctamente";
            }
            catch
            {
                Label1.Text = "Error al agregar los datos";
            }

        }
    }
}