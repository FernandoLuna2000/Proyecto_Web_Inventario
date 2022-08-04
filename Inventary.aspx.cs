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
        List<c_entidades.Ubicacion> Lista_Ubica = new List<c_entidades.Ubicacion>();
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
            //*Dando el número de inventario del equipo, que diga en que laboratorio se encuentra y muestre los detalles de sus actualizaciones.*
            ListBox1.Items.Clear();

            string msj = "", msjc = "", conector = "", ubi = "", numin = "", lab = "", act = "";
            numin = DropDownList1.SelectedItem.Text;

            Lista_CompuFinal = LN.L_ComputadoraFinal(ref msj, ref msjc);
            ListaLab = LN.L_Lab(ref msj, ref msjc);
            ListaActualizacion = LN.L_Actualizacion(ref msj, ref msjc);
            Lista_Ubica = LN.L_Ubicacion(ref msj, ref msjc);

            conector = Lista_CompuFinal.Where(x=>x.NumInv == numin).FirstOrDefault().NumInv;
            ubi = Lista_Ubica.Where(x => x.NombreLaboratorio == conector).FirstOrDefault().NombreLaboratorio;
            lab = ListaLab.Where(x => x.NombreLaboratorio == ubi).FirstOrDefault().NombreLaboratorio;
            act = ListaActualizacion.Where(x => x.NumInv == ubi).FirstOrDefault().NumInv;

            ListBox1.Items.Add("Prueba = " + ubi + "Prueba = " + act);

        }
    }
}