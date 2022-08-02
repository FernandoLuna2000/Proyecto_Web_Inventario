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
    public partial class ActualizarCPUgenerico : System.Web.UI.Page
    {
        Logica_Negocio LN = null;
        List<CpuGenerico> lista_cpugenerico = new List<CpuGenerico>();
      
        string mensaje = "", mensajeC = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LN = new Logica_Negocio(ConfigurationManager.ConnectionStrings["BDInventario"].ConnectionString);
                Session["negocioServer"] = LN;

                lista_cpugenerico = LN.L_CpuGenerico(ref mensaje, ref mensajeC);
                DropDownList1.Items.Add("");
                for (int i = 0; i < lista_cpugenerico.Count; i++)
                {
                    DropDownList1.Items.Add(lista_cpugenerico[i].IdCpu.ToString());
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
            lista_cpugenerico = LN.L_CpuGenerico(ref mensaje, ref mensajeC);
            string[] datos = new string[6];

            datos[0] = lista_cpugenerico.Where(x => x.IdCpu == Id).FirstOrDefault().FTcpu.ToString();
            datos[1] = lista_cpugenerico.Where(x => x.IdCpu == Id).FirstOrDefault().FMarcaCpu.ToString();
            datos[2] = TextBox1.Text;
            datos[3] = TextBox2.Text;
            datos[4] = lista_cpugenerico.Where(x => x.IdCpu == Id).FirstOrDefault().FTipoRam.ToString();
            datos[5] = lista_cpugenerico.Where(x => x.IdCpu == Id).FirstOrDefault().IdGabinete.ToString();

            LN.Act_CPU_generico(datos, ref mensaje, ref mensajeC, Id);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(DropDownList1.SelectedItem.Text);

                LN.Elim_CPU_Generico(ref mensaje, ref mensajeC, Id);

                Label1.Text = "se elimino";
            }
            catch
            {
                Label1.Text = "error checa tus datos";
            }
        }
    }
}