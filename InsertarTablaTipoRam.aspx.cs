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
    public partial class InsertarTablaTipoRam : System.Web.UI.Page
    {
        Logica_Negocio LN = null;

        string mensaje = "", mensajeC = "";
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
            string[] datos = new string[2];

            datos[0] = TextBox1.Text;
            datos[1] = "";

            try
            {
                LN.Insert_TipoRam(datos, ref mensaje, ref mensajeC);
                Label1.Text = "Los Datos se Agregaron Correctamente";
            }
            catch
            {
                Label1.Text = "Error al Agregar Datos";
            }
        }
    }
}