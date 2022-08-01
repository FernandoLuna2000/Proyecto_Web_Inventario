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
    public partial class insertarTablaCPUTipoGenerico : System.Web.UI.Page
    {
        Logica_Negocio LN = null;

        List<TipoCpu> Lista_TipoCPU = new List<TipoCpu>();
        List<ModeloCpu> Lista_ModeloCpu = new List<ModeloCpu>();

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

                Lista_ModeloCpu = LN.L_ModeloCpu(ref mensaje, ref mensajeC);
                DropDownList2.Items.Add("");
                for (int i = 0; i < Lista_ModeloCpu.Count; i++)
                {
                    DropDownList2.Items.Add(Lista_ModeloCpu[i].IdModcpu.ToString());
                }

            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] datos = new string[3];

            datos[0] = DropDownList1.SelectedItem.Text;
            datos[1] = DropDownList2.SelectedItem.Text;
            datos[2] = TextBox1.Text;
            try
            {
                LN.Insert_CPUTipoMod(datos, ref mensaje, ref mensajeC);
                Label1.Text = "Se agregaron los datos correctamente";
            }
            catch
            {
                Label1.Text = "Error al agregar los datos";
            }
        }
    }
}