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
    public partial class actualizarCPUtipomod : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<CpuTipoMod> lista_cpumod = new List<CpuTipoMod>();
        string mensaje = "", mensajeC = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                lista_cpumod = LN.L_CpuTipoMod(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < lista_cpumod.Count; i++)
                {
                    DropDownList1.Items.Add(lista_cpumod[i].IdTipoMod.ToString());
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
            lista_cpumod = LN.L_CpuTipoMod(ref mensaje, ref mensajeC);
            string[] datos = new string[3];

            datos[0] = lista_cpumod.Where(x => x.IdTipoMod == Id).FirstOrDefault().IdTcpu.ToString();
            datos[1] = lista_cpumod.Where(x => x.IdTipoMod == Id).FirstOrDefault().IdModcpu.ToString();
            datos[2] = TextBox1.Text;

            LN.Act_Cpu_tipomod(datos, ref mensaje, ref mensajeC, Id);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(DropDownList1.SelectedItem.Text);

                LN.Elim_CPU_TipoMod(ref mensaje, ref mensajeC, Id);

                Label1.Text = "se elimino";
            }
            catch
            {
                Label1.Text = "error checa tus datos";
            }
        }
    }
}