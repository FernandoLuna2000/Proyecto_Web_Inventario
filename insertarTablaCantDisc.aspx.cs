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
    public partial class insertarTablaCantDisc : System.Web.UI.Page
    {
        Logica_Negocio LN = null;

        List<Computadorafinal> Lista_Compufinal = new List<Computadorafinal>();
        List<DiscoDuro> Lista_Disco = new List<DiscoDuro>();

        string mensaje = "", mensajeC = "";


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                Lista_Compufinal = LN.L_ComputadoraFinal(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < Lista_Compufinal.Count; i++)
                {
                    DropDownList1.Items.Add(Lista_Compufinal [i].NumInv);
                }

                Lista_Disco = LN.L_DiscoDuro(ref mensaje, ref mensajeC);
                DropDownList2.Items.Add("");
                for (int i = 0; i < Lista_Disco.Count; i++)
                {
                    DropDownList2.Items.Add(Lista_Disco[i].IdDisco.ToString());
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
                LN.Insert_cantDisc(datos, ref mensaje, ref mensajeC);
                Label1.Text = "Se agregaron los datos correctamente";
            }
            catch
            {
               Label1.Text = "Error al agregar los datos";
            }
        }

    }
}