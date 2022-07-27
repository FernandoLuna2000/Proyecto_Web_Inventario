using c_dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_dll
{
    public class Logica_Negocio
    {
        private Acceso_Datos llaveDatosServer = null;

        public Logica_Negocio(string connection)
        {
            llaveDatosServer = new Acceso_Datos(connection);
        }


        public DataTable tablaMarcas(ref string mensaje, ref string mensajeC)
        {
            string comandoMySql = "select * from Marca;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = llaveDatosServer.LecturaSet(comandoMySql, llaveDatosServer.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;
        }
        public DataTable tablacomputadorafinal(ref string mensaje, ref string mensajeC)
        {
            string comandoMySql = "select * from computadorafinal;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = llaveDatosServer.LecturaSet(comandoMySql, llaveDatosServer.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;
        }
    }
}
