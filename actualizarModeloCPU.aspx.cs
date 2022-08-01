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
    public partial class actualizarModeloCPU : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<ModeloCpu> lista_modelocpu = new List<ModeloCpu>();
        List<Marca> lista_marca = new List<Marca>();
        string mensaje = "", mensajeC = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                lista_modelocpu = LN.L_ModeloCpu(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < lista_modelocpu.Count; i++)
                {
                    DropDownList1.Items.Add(lista_modelocpu [i].IdModcpu.ToString());
                }

                lista_marca = LN.L_Marca(ref mensaje, ref mensajeC);
                DropDownList2.Items.Add("");
                for (int i = 0; i < lista_marca.Count; i++)
                {
                    DropDownList2.Items.Add(lista_marca[i].IdMarca.ToString());
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
            lista_modelocpu = LN.L_ModeloCpu(ref mensaje, ref mensajeC);
            string[] datos = new string[2];

            datos[0] = TextBox2.Text;
            datos[1] = DropDownList2.SelectedItem.Text;

            LN.Act_ModeloCpu(datos, ref mensaje, ref mensajeC, Id);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(DropDownList1.SelectedItem.Text);

                LN.Elim_Modelo(ref mensaje, ref mensajeC, Id);

                Label1.Text = "se elimino";
            }
            catch
            {
                Label1.Text = "error checa tus datos";
            }
        }
    }
}