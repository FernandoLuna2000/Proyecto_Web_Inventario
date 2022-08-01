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
    public partial class InsertarTablaUbicacion : System.Web.UI.Page
    {
        Logica_Negocio LN = null;

        List<Computadorafinal> Lista_CompuFinal = new List<Computadorafinal>();
        List<Laboratorio> Lista_Laboratorio = new List<Laboratorio>();

        string mensaje = "", mensajeC = "";


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                Lista_CompuFinal = LN.L_ComputadoraFinal(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < Lista_CompuFinal.Count; i++)
                {
                    DropDownList1.Items.Add(Lista_CompuFinal[i].NumInv.ToString());
                }

                Lista_Laboratorio = LN.L_Lab(ref mensaje, ref mensajeC);
                DropDownList2.Items.Add("");
                for (int i = 0; i < Lista_Laboratorio.Count; i++)
                {
                    DropDownList2.Items.Add(Lista_Laboratorio[i].NombreLaboratorio.ToString());
                }

            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] datos = new string[2];

            datos[0] = DropDownList1.SelectedItem.Text;
            datos[1] = DropDownList2.SelectedItem.Text;

            try
            {
                LN.Insert_Ubicacion(datos, ref mensaje, ref mensajeC);
                Label1.Text = "Los Datos se Agregaron Correctamente";
            }
            catch
            {
                Label1.Text = "Error Al Agregar los Datos";
            }
        }
    }
}