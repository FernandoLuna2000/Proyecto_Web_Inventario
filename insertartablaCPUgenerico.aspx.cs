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
    public partial class insertartablaCPUgenerico : System.Web.UI.Page
    {
        Logica_Negocio LN = null;

        List<TipoCpu> Lista_TipoCPU = new List<TipoCpu>();
        List<Marca> Lista_Marca = new List<Marca>();
        List<Ram> Lista_Ram = new List<Ram>();
        List<Gabinete> Lista_Gabinete = new List<Gabinete>();

        string mensaje = "", mensajeC = "";

        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                Lista_TipoCPU = LN.L_TipoCpu(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < Lista_TipoCPU.Count; i++)
                {
                    DropDownList1.Items.Add(Lista_TipoCPU[i].IdTcpu.ToString());
                }

                Lista_Marca = LN.L_Marca(ref mensaje, ref mensajeC);
                DropDownList2.Items.Add("");
                for (int i = 0; i < Lista_Marca.Count; i++)
                {
                    DropDownList2.Items.Add(Lista_Marca[i].IdMarca.ToString());
                }

                Lista_Ram = LN.L_Ram(ref mensaje, ref mensajeC);
                DropDownList3.Items.Add("");
                for (int i = 0; i < Lista_Ram.Count; i++)
                {
                    DropDownList3.Items.Add(Lista_Ram[i].IdRam.ToString());
                }

                Lista_Gabinete = LN.L_Gabinete(ref mensaje, ref mensajeC);
                DropDownList4.Items.Add("");
                for (int i = 0; i < Lista_Gabinete.Count; i++)
                {
                    DropDownList4.Items.Add(Lista_Gabinete[i].IdGabinete.ToString());
                }
            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] datos = new string[6];
            
            datos[0] = DropDownList1.SelectedItem.Text;
            datos[1] = DropDownList2.SelectedItem.Text;
            datos[2] = TextBox1.Text;
            datos[3] = TextBox2.Text;
            datos[4] = DropDownList3.SelectedItem.Text;
            datos[5] = DropDownList4.SelectedItem.Text;
            try
            {
                LN.Insert_CPUgenerico(datos, ref mensaje, ref mensajeC);
                Label1.Text = "Se agregaron los datos correctamente";
            }
            catch
            {
                Label1.Text = "Error al agregar los datos";
            }
        }
    }
}