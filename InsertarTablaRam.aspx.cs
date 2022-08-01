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
    public partial class InsertarTablaRam : System.Web.UI.Page
    {
        Logica_Negocio LN = null;

        List<TipoRam> Lista_TipoRam = new List<TipoRam>();
        
        string mensaje = "", mensajeC = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                Lista_TipoRam = LN.L_TipoRam(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < Lista_TipoRam.Count; i++)
                {
                    DropDownList1.Items.Add(Lista_TipoRam[i].IdTipoRam.ToString());
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

            datos[0] = TextBox1.Text;
            datos[1] = TextBox2.Text;
            datos[2] = DropDownList1.SelectedItem.Text;

            try
            {
                LN.Insert_Ram(datos, ref mensaje, ref mensajeC);
                Label1.Text = "Los Datos Se Agregaron Correctamente";
            }
            catch
            {
                Label1.Text = "Eror al Agregar los Datos";
            }
        }
    }
}