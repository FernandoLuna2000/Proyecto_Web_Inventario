using c_dll;
using c_entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Web_Inventario
{
    public partial class Inventary : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<Computadorafinal> Lista_CompuFinal = new List<Computadorafinal>();
        List<Laboratorio> ListaLab = new List<Laboratorio>();
        List<Actualizacion> ListaActualizacion = new List<Actualizacion>();
        string msj = "", msjc = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;
                Lista_CompuFinal = LN.L_ComputadoraFinal(ref msj, ref msjc);
                DropDownList1.Items.Add("");
                for (int i = 0; i < Lista_CompuFinal.Count; i++)
                {
                    DropDownList1.Items.Add(Lista_CompuFinal[i].NumInv);
                }
            }
            else
            {
                LN = (Logica_Negocio)Session["negocioServer"];
            }
        }

        protected void BRegresar_Index_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();

            string msj = "", msjc = "", conector = "", marca = "", numin = "";
            numin = DropDownList1.SelectedItem.Text;

            Lista_CompuFinal = LN.L_ComputadoraFinal(ref msj, ref msjc);
            ListaLab = LN.L_Lab(ref msj, ref msjc);
            ListaActualizacion = LN.L_Actualizacion(ref msj, ref msjc);

            //el conector es igual a la lisa teclado donde el id de teclado sea = a la lista de computadora final donde el num_inv sea = al numero de inventario que ya tengo 
            //el fistrordefault es para que me traiga el primer dato y el .idteclado es lo que estoy buscando (sub consulta de una consulta)

            //conector = ListaLab.Where(x => Convert.ToUInt32(x.NombreLaboratorio)  == Lista_CompuFinal.Where(y => y.NumInv == numin).FirstOrDefault()).FirstOrDefault();

            //marca es = a la lista de marcas donde  el id de la marca sea = a la lista del teclado donde el conector sea = al conector que ya tenemos

            //marca = Lista_Marca.Where(x => x.IdMarca == Lista_Teclado.Where(y => y.Conector == conector).FirstOrDefault().FMarcat).FirstOrDefault().Marca1.ToString();

            ListBox1.Items.Add("Numero de Inventario = " + numin);
            ListBox1.Items.Add("Conector del Teclado = " + conector);
            ListBox1.Items.Add("Marca del Teclado = " + marca);
        }
    }
}