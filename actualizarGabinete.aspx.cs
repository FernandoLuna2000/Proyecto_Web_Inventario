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
    public partial class actualizarGabinete : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<Gabinete> lista_gabinete = new List<Gabinete>();
        List<Marca> lista_marca = new List<Marca>();
        string mensaje = "", mensajeC = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                lista_gabinete = LN.L_Gabinete(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < lista_gabinete.Count; i++)
                {
                    DropDownList1.Items.Add(lista_gabinete[i].IdGabinete.ToString());
                }

                lista_gabinete = LN.L_Gabinete(ref mensaje, ref mensajeC);
                DropDownList2.Items.Add("");
                for (int i = 0; i < lista_gabinete.Count; i++)
                {
                    DropDownList2.Items.Add(lista_gabinete[i].Modelo.ToString());
                }


                lista_gabinete = LN.L_Gabinete(ref mensaje, ref mensajeC);
                DropDownList3.Items.Add("");
                for (int i = 0; i < lista_gabinete.Count; i++)
                {
                    DropDownList3.Items.Add(lista_gabinete[i].TipoForma.ToString());
                }


                lista_marca = LN.L_Marca(ref mensaje, ref mensajeC);
                DropDownList4.Items.Add("");
                for (int i = 0; i < lista_marca.Count; i++)
                {
                    DropDownList4.Items.Add(lista_marca[i].IdMarca.ToString());
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
            lista_gabinete = LN.L_Gabinete(ref mensaje, ref mensajeC);
            string[] datos = new string[3];

            datos[0] = DropDownList2.SelectedItem.Text;
            datos[1] = DropDownList3.SelectedItem.Text;
            datos[2] = DropDownList4.SelectedItem.Text;

            LN.Act_Gabinete(datos, ref mensaje, ref mensajeC, Id);
            try
            {

                Label1.Text = "se actualizo";
            }
            catch
            {
                Label1.Text = "error al actualizar";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(DropDownList1.SelectedItem.Text);

                LN.Elim_Gabinete(ref mensaje, ref mensajeC, Id);

                Label1.Text = "se elimino";
            }
            catch
            {
                Label1.Text = "error checa tus datos";
            }
        }
    }
}