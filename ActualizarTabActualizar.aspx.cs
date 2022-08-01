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
    public partial class ActualizarEliminarTablaActualizacion : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<Actualizacion> lista_actualizacion = new List<Actualizacion>();
        List<Computadorafinal> lista_compufinal = new List<Computadorafinal>();
        string mensaje = "", mensajeC = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                lista_actualizacion = LN.L_Actualizacion(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < lista_actualizacion.Count; i++)
                {
                    DropDownList1.Items.Add(lista_actualizacion[i].IdAct.ToString());
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
            lista_actualizacion = LN.L_Actualizacion(ref mensaje, ref mensajeC);
            string[] datos = new string[4];

            string fecha = DateTime.Now.ToString();

            datos[0] = lista_actualizacion.Where(x=>x.IdAct == Id).FirstOrDefault().NumInv;
            datos[1] = TextBox2.Text;
            datos[2] = TextBox3.Text;
            datos[3] = fecha;

            LN.Act_TabActualizacion(datos, ref mensaje, ref mensajeC, Id);

            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(DropDownList1.SelectedItem.Text);

                LN.Elim_actualizacion(ref mensaje, ref mensajeC, Id);

                Label1.Text = "se elimino";
            }
            catch
            {
                Label1.Text = "error checa tus datos";
            }
        }
    }
}