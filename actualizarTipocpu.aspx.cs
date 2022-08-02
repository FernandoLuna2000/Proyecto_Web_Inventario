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
    public partial class actualizarTipocpu : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<TipoCpu> lista_tipocpu = new List<TipoCpu>();
        string mensaje = "", mensajeC = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                lista_tipocpu = LN.L_TipoCpu(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < lista_tipocpu.Count; i++)
                {
                    DropDownList1.Items.Add(lista_tipocpu[i].IdTcpu.ToString());
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
            lista_tipocpu = LN.L_TipoCpu(ref mensaje, ref mensajeC);
            string[] datos = new string[4];

            datos[0] = TextBox2.Text;
            datos[1] = TextBox3.Text;
            datos[2] = "";
            datos[3] = "";

            LN.Act_TipoCPU(datos, ref mensaje, ref mensajeC, Id);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(DropDownList1.SelectedItem.Text);

                LN.Elim_Tipocpu(ref mensaje, ref mensajeC, Id);

                Label1.Text = "se elimino";
            }
            catch
            {
                Label1.Text = "error checa tus datos";
            }
        }
    }
}