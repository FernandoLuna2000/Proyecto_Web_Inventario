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
            string comandoSql = "select * from computadorafinal;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;
        }
        public List<Marca> ListaMarca(ref string mensaje, ref string mensajeC)//método principal
        {
            //bloque variables y utilidades
            string comandoSql = "select * from Marca;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            //Creacion de una lista del tipo de la clase que vamos a trabajar
            List<Marca> LMarca = new List<Marca>();

            //Se llena el DataSet con datos de la BD
            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
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
        public List<Actualizacion> ListaActualizacion(ref string mensaje, ref string mensajeC)//método principal
        {
           
            string comandoSql = "select * from actualizacion;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Actualizacion> actualizacion = new List<Actualizacion>();

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                actualizacion = dataTable.AsEnumerable().Select(row => new Actualizacion
                {
                    IdAct = row.Field<int>("id_act"),
                    NumInv = row.Field<string>("num_inv"),
                    NumSerie = row.Field<string>("num_serie"),
                    Descripcion = row.Field<string>("descripcion"),
                    Fecha = row.Field<DateTime>("fecha"),
                }).ToList();//se añade a la Lista
            }
            return actualizacion;//se returna la Lista 
        }
        public List<CantDisc> ListaCantDisc(ref string mensaje, ref string mensajeC)//método principal
        {

            string comandoSql = "select * from cantDisc;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<CantDisc> cantDiscs = new List<CantDisc>();

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                cantDiscs = dataTable.AsEnumerable().Select(row => new CantDisc
                {
                    IdCant = row.Field<int>("id_cant"),
                    NumInv = row.Field<string>("num_inv"),
                    IdDisco = row.Field<int>("id_Disco"),
                }).ToList();//se añade a la Lista
            }
            return cantDiscs;//se returna la Lista 
        }

        public List<Categoria> ListaCategoria(ref string mensaje, ref string mensajeC)//método principal
        {

            string comandoSql = "select * from Categoria;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Categoria> categoria = new List<Categoria>();

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                categoria = dataTable.AsEnumerable().Select(row => new Categoria
                {
                    IdCategoria = row.Field<int>("id_Categoria"),
                    Descripcion = row.Field<string>("Descripcion"),
                }).ToList();//se añade a la Lista
            }
            return categoria;//se returna la Lista 
        }

        public List<CatMar> ListaCatMar(ref string mensaje, ref string mensajeC)//método principal
        {

            string comandoSql = "select * from CatMar;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<CatMar> CatMar = new List<CatMar>();

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                CatMar = dataTable.AsEnumerable().Select(row => new CatMar
                {
                    IdCatMar = row.Field<int>("id_CatMar"),
                    IdCategoria = row.Field<int>("id_Categoria"),
                    IdMarca = row.Field<int>("id_Marca"),
                }).ToList();//se añade a la Lista
            }
            return CatMar;//se returna la Lista 
        }

        public List<Computadorafinal> ListaComputadoraFinal(ref string mensaje, ref string mensajeC)//método principal
        {

            string comandoSql = "select * from computadorafinal;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Computadorafinal> CompuFinal = new List<Computadorafinal>();

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                CompuFinal = dataTable.AsEnumerable().Select(row => new Computadorafinal
                {
                    NumInv = row.Field<string>("num_inv"),
                    NumScpu = row.Field<string>("num_scpu"),
                    IdCpug = row.Field<int>("id_cpug"),
                    NumSteclado = row.Field<string>("num_steclado"),
                    IdTecladog = row.Field<int>("id_tecladog"),
                    NumSmonitor = row.Field<string>("num_smonitor"),
                    IdMong = row.Field<int>("id_mong"),
                    NumSmouse = row.Field<string>("num_smouse"),
                    IdMousg = row.Field<int>("id_mousg"),
                    Estado = row.Field<string>("estado"),
                    IdEstatus = row.Field<int>("id_Estatus"),
                }).ToList();//se añade a la Lista
            }
            return CompuFinal;//se returna la Lista 
        }
        public List<CpuGenerico> ListaCpuGenerico(ref string mensaje, ref string mensajeC)//método principal
        {

            string comandoSql = "select * from Cpu_Generico;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<CpuGenerico> CpuGenerico = new List<CpuGenerico>();

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                CpuGenerico = dataTable.AsEnumerable().Select(row => new CpuGenerico
                {
                    IdCpu = row.Field<int>("id_CPU"),
                    FTcpu = row.Field<int>("f_Tcpu"),
                    FMarcaCpu = row.Field<int>("f_MarcaCpu"),
                    Modelo = row.Field<string>("Modelo"),
                    Descripcion = row.Field<string>("Descripcion"),
                    FTipoRam = row.Field<int>("f_tipoRam"),
                    IdGabinete = row.Field<int>("id_Gabinete"),

                }).ToList();//se añade a la Lista
            }
            return CpuGenerico;//se returna la Lista 
        }

        public List<CpuTipoMod> ListaCpuTipoMod(ref string mensaje, ref string mensajeC)//método principal
        {

            string comandoSql = "select * from CPU_TipoMod ;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<CpuTipoMod> CpuTipoMod = new List<CpuTipoMod>();

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                CpuTipoMod = dataTable.AsEnumerable().Select(row => new CpuTipoMod
                {
                    IdTipoMod = row.Field<int>("id_TipoMod"),
                    IdTcpu = row.Field<int>("id_Tcpu"),
                    IdModcpu = row.Field<int>("id_modcpu"),
                    Nucleos = row.Field<string>("nucleos"),
                }).ToList();//se añade a la Lista
            }
            return CpuTipoMod;//se returna la Lista 
        }

        public List<DiscoDuro> ListaDiscoDuro(ref string mensaje, ref string mensajeC)//método principal
        {

            string comandoSql = "select * from DiscoDuro ;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<DiscoDuro> DiscoDuro = new List<DiscoDuro>();

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                DiscoDuro = dataTable.AsEnumerable().Select(row => new DiscoDuro
                {
                    IdDisco = row.Field<int>("id_Disco"),
                    TipoDisco = row.Field<string>("TipoDisco"),
                    Conector = row.Field<string>("conector"),
                    Capacidad = row.Field<string>("Capacidad"),
                    FMarcaDisco = row.Field<int>("F_MarcaDisco"),
                    //Extra = row.Field<string>("Extra"),

                }).ToList();//se añade a la Lista
            }
            return DiscoDuro;//se returna la Lista 
        }

        public List<Estatus> ListaEstatus(ref string mensaje, ref string mensajeC)//método principal
        {

            string comandoSql = "select * from Estatus ;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Estatus> estatus = new List<Estatus>();

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                estatus = dataTable.AsEnumerable().Select(row => new Estatus
                {
                    IdEstatus = row.Field<int>("id_Estatus"),
                    Estado = row.Field<string>("Estado"),
                }).ToList();//se añade a la Lista
            }
            return estatus;//se returna la Lista 
        }

        public List<Evidencia> ListaEvidencia(ref string mensaje, ref string mensajeC)//método principal
        {

            string comandoSql = "select * from Evidencia ;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Evidencia> evidencia = new List<Evidencia>();

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                evidencia = dataTable.AsEnumerable().Select(row => new Evidencia
                {
                    IdEvidencia = row.Field<int>("id_Evidencia"),
                    Evidencia1 = row.Field<string>("Evidencia1"),
                    NumInv = row.Field<string>("num_inv"),
                }).ToList();//se añade a la Lista
            }
            return evidencia;//se returna la Lista 
        }

        public List<Gabinete> ListaGabinete(ref string mensaje, ref string mensajeC)//método principal
        {

            string comandoSql = "select * from Gabinete ;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Gabinete> gabinete = new List<Gabinete>();

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                gabinete = dataTable.AsEnumerable().Select(row => new Gabinete
                {
                    IdGabinete = row.Field<int>("id_Gabinete"),
                    Modelo = row.Field<string>("Modelo"),
                    TipoForma = row.Field<string>("TipoForma"),
                    FMarca = row.Field<int>("F_Marca"),
                }).ToList();//se añade a la Lista
            }
            return gabinete;//se returna la Lista 
        }
    }
}
