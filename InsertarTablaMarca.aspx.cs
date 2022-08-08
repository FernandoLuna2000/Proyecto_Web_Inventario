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
    public partial class InsertarTablaMarca : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<Marca> Lista_Marca = new List<Marca>();
        string mensaje = "", mensajeC = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;


                Lista_Marca = LN.L_Marca(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < Lista_Marca.Count; i++)
                {
                    DropDownList1.Items.Add(Lista_Marca[i].Marca1.ToString());
                }

                Lista_Marca = LN.L_Marca(ref mensaje, ref mensajeC);
                DropDownList2.Items.Add("");
                for (int i = 0; i < Lista_Marca.Count; i++)
                {
                    DropDownList2.Items.Add(Lista_Marca[i].IdComponente.ToString());
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
            datos[2] = "";

            try
            {
                LN.Insert_Marca(datos, ref mensaje, ref mensajeC);
                Label1.Text = "Se agregaron los Datos Correctamente";
            }
            catch
            {
                Label1.Text = "Error al Agregar los Datos";
            }
        }
    }
}