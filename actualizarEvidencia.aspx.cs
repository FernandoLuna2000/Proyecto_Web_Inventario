﻿using System;
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
    public partial class actualizarEvidencia : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<Evidencia> lista_evidencia = new List<Evidencia>();
        string mensaje = "", mensajeC = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                lista_evidencia = LN.L_Evidencia(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < lista_evidencia.Count; i++)
                {
                    DropDownList1.Items.Add(lista_evidencia[i].IdEvidencia.ToString());
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
            lista_evidencia = LN.L_Evidencia(ref mensaje, ref mensajeC);
            string[] datos = new string[2];

            datos[0] = TextBox2.Text;
            datos[1] = lista_evidencia.Where(x => x.IdEvidencia == Id).FirstOrDefault().NumInv.ToString();

            LN.Act_Evidencia(datos, ref mensaje, ref mensajeC, Id);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(DropDownList1.SelectedItem.Text);

                LN.Elim_Evidencia(ref mensaje, ref mensajeC, Id);

                Label1.Text = "se elimino";
            }
            catch
            {
                Label1.Text = "error checa tus datos";
            }
        }
    }
}