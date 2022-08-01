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
    public partial class actualizarComputadoraFinal : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<Computadorafinal> lista_compufinal = new List<Computadorafinal>();
        List<Laboratorio> lista_lab = new List<Laboratorio>();
        List<Estatus> lista_Estatus = new List<Estatus>();
        string mensaje = "", mensajeC = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                lista_compufinal = LN.L_ComputadoraFinal(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < lista_compufinal.Count; i++)
                {
                    DropDownList1.Items.Add(lista_compufinal[i].NumInv.ToString());
                }

                lista_lab = LN.L_Lab(ref mensaje, ref mensajeC);
                DropDownList2.Items.Add("");
                for (int i = 0; i < lista_lab.Count; i++)
                {
                    DropDownList2.Items.Add(lista_lab[i].NombreLaboratorio.ToString());
                }

                lista_Estatus = LN.L_Estatus(ref mensaje, ref mensajeC);
                DropDownList3.Items.Add("");
                for (int i = 0; i < lista_Estatus.Count; i++)
                {
                    DropDownList3.Items.Add(lista_Estatus[i].IdEstatus.ToString());
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
            
            lista_compufinal = LN.L_ComputadoraFinal(ref mensaje, ref mensajeC);

            string[] datos = new string[10];

            datos[0] = TextBox1.Text;
            datos[1] = TextBox3.Text;
            datos[2] = TextBox4.Text;
            datos[3] = TextBox5.Text;
            datos[4] = TextBox6.Text;
            datos[5] = TextBox7.Text;
            datos[6] = TextBox8.Text;
            datos[7] = TextBox9.Text;
            datos[8] = DropDownList2.SelectedItem.Text;
            datos[9] = DropDownList3.SelectedItem.Text;

            LN.Act_CompuFinal(datos, ref mensaje, ref mensajeC, Id);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(DropDownList1.SelectedItem.Text);

                LN.Elim_Computadorafinal(ref mensaje, ref mensajeC, Id);

                Label1.Text = "se elimino";
            }
            catch
            {
                Label1.Text = "error checa tus datos";
            }
        }
    }
}