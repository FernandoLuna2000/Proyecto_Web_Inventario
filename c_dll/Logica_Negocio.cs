using c_dal;
using c_entidades;
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
        private Acceso_Datos AC = null;
        public Logica_Negocio(string connection)
        {
            AC = new Acceso_Datos(connection);
        }
        //public DataTable tablaMarcas(ref string mensaje, ref string mensajeC)
        //{
        //    string comandoMySql = "select * from Marca;", etiqueta = "InventarioPCsLabs";
        //    DataSet dataSet = null;
        //    DataTable dataTable = null;


        //    dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
        //    if (dataSet != null)
        //    {
        //        dataTable = dataSet.Tables[0];
        //    }
        //    return dataTable;
        //}
        public DataTable tablacomputadorafinal(ref string mensaje, ref string mensajeC)
        {
            string comandoMySql = "select * from computadorafinal;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;
        }
        public List<Marca> ListaMarca(ref string mensaje, ref string mensajeC)//método principal
        {
            //bloque variables y utilidades
            string comandoMySql = "select * from Marca;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            //Creacion de una lista del tipo de la clase que vamos a trabajar
            List<Marca> LMarca = new List<Marca>();

            //Se llena el DataSet con datos de la BD
            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            //si e DataSet tiene datos pasa lo siguiente:
            if (dataSet != null)
            {
                //Creo una DataTable y lo lleno con la info que viene del DataSet
                dataTable = dataSet.Tables[0];
                //Aquí empieza la parte de LINQ
                //listaAlumno = el datatable como un numerable (algo que puedo contar y recorrer) y hago una seleccion(cada row será igual a un nuevo objeto de a clase seleccionada)
                LMarca = dataTable.AsEnumerable().Select(row => new Marca
                {
                    //por cada iterancia(cada rengón que exista) vamos a pasar los parámetros de mi objeto
                    //parámetro de la clase = el renglón.campo<Parse(convertir)al tipo de dato que se tiene registrado>("donde la columna contenga tal cosa")
                    IdMarca = row.Field<int>("Id_Marca"),
                    Marca1 = row.Field<string>("Marca"),
                    IdComponente = row.Field<short>("Id_Componente"),
                    //Extra = row.Field<string>("Extra"),
                    

                }).ToList();//se añade a la Lista
            }
            return LMarca;//se returna la Lista 
        }
    }
}
