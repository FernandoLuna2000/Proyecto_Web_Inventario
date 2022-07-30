﻿using c_dal;
using c_entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace c_dll
{
    public class Logica_Negocio
    {
        private Acceso_Datos AC = null;
        public Logica_Negocio(string connection)
        {
            AC = new Acceso_Datos(connection);
        }

        public List<Actualizacion> ListaActualizacion(ref string mensaje, ref string mensajeC)//Metodo de la Lista Actualización
        {
            string comandoSql = "select * from actualizacion;", etiqueta = "InventarioPCsLabs";//Variables y Utilidades
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Actualizacion> actualizacion = new List<Actualizacion>();//Creacion de una lista del tipo Actualizacion para trabajar

            dataSet = AC.LecturaSet(comandoSql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);//Se llena el DataSet con los datos de la BD
            if (dataSet != null)//Si e DataSet tiene datos entonces
            {
                dataTable = dataSet.Tables[0];//Se crea un DataTable y se llena con la informacion del DataSet
                actualizacion = dataTable.AsEnumerable().Select(row => new Actualizacion//El datatable es como un numerable y se hace una seleccion, cada row será igual a un nuevo objeto de a clase seleccionada
                {//Por cada iterancia vamos a pasar los parámetros de mi objeto
                    IdAct = row.Field<int>("id_act"),
                    NumInv = row.Field<string>("num_inv"),
                    NumSerie = row.Field<string>("num_serie"),
                    Descripcion = row.Field<string>("descripcion"),
                    Fecha = row.Field<DateTime>("fecha"),
                }).ToList();//Se añade la información a la Lista
            }
            return actualizacion;//Se retorna la Lista 
        }
        public List<CantDisc> ListaCantDisc(ref string mensaje, ref string mensajeC)//Metodo de la Lista CantDisc
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
                }).ToList();
            }
            return cantDiscs;
        }
        public List<Categoria> ListaCategoria(ref string mensaje, ref string mensajeC)//Metodo de la Lista Categoria
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
                }).ToList();
            }
            return categoria;
        }
        public List<CatMar> ListaCatMar(ref string mensaje, ref string mensajeC)//Metodo de la Lista CatMar
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
                }).ToList();
            }
            return CatMar;
        }
        public List<Computadorafinal> ListaComputadoraFinal(ref string mensaje, ref string mensajeC)//Metodo de la Lista ComputadoraFinal
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
                }).ToList();
            }
            return CompuFinal;
        }
        public List<CpuGenerico> ListaCpuGenerico(ref string mensaje, ref string mensajeC)//Metodo de la Lista CpuGenerico
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
                }).ToList();
            }
            return CpuGenerico;
        }
        public List<CpuTipoMod> ListaCpuTipoMod(ref string mensaje, ref string mensajeC)//Metodo de la Lista CpuTipoMod
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
                }).ToList();
            }
            return CpuTipoMod;
        }
        public List<DiscoDuro> ListaDiscoDuro(ref string mensaje, ref string mensajeC)//Metodo de la Lista DiscoDuro
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
                }).ToList();
            }
            return DiscoDuro;
        }
        public List<Estatus> ListaEstatus(ref string mensaje, ref string mensajeC)//Metodo de la Lista Estatus
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
                }).ToList();
            }
            return estatus;
        }
        public List<Evidencia> ListaEvidencia(ref string mensaje, ref string mensajeC)//Metodo de la Lista Evidencia
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
                }).ToList();
            }
            return evidencia;
        }
        public List<Gabinete> ListaGabinete(ref string mensaje, ref string mensajeC)//Metodo de la Lista Gabinete
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
                }).ToList();
            }
            return gabinete;
        }
        public List<Laboratorio> ListaLab(ref string mensaje, ref string mensajeC)//Metodo de la Lista Laboratorio
        {
            string comandoMySql = "select * from Laboratorio;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Laboratorio> LLab = new List<Laboratorio>();

            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                LLab = dataTable.AsEnumerable().Select(row => new Laboratorio
                {
                    NombreLaboratorio = row.Field<string>("nombre_laboratorio"),
                }).ToList();
            }
            return LLab;
        }
        public List<Marca> ListaMarca(ref string mensaje, ref string mensajeC)//Metodo de la Lista Marca
        {
            string comandoMySql = "select * from Marca;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<Marca> LMarca = new List<Marca>();

            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                LMarca = dataTable.AsEnumerable().Select(row => new Marca
                {
                    IdMarca = row.Field<int>("Id_Marca"),
                    Marca1 = row.Field<string>("Marca"),
                    IdComponente = row.Field<short>("Id_Componente"),
                }).ToList();
            }
            return LMarca;
        }
        public List<ModeloCpu> ListaModeloCpu(ref string mensaje, ref string mensajeC)//Metodo de la Lista ModeloCpu revisar como trae la informacion
        {
            string comandoMySql = "select * from ModeloCPU;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;

            List<ModeloCpu> LModeloCpu = new List<ModeloCpu>();

            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                LModeloCpu = dataTable.AsEnumerable().Select(row => new ModeloCpu
                {
                    IdModcpu = row.Field<int>("id_modcpu"),
                    ModeloCpu1 = row.Field<string>("modeloCPU"),
                    //FMarca = row.Field<int>("f_marca"),
                }).ToList();
            }
            return LModeloCpu;
        }
        public List<Monitor> ListaMonitor(ref string mensaje, ref string mensajeC)//Metodo de la Lista Monitor
        {
            string comandoMySql = "select * from Monitor;", etiqueta = "InventarioPCsLabs";//cambio
            DataSet dataSet = null;
            DataTable dataTable = null;
            List<Monitor> LMonitor = new List<Monitor>();

            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                LMonitor = dataTable.AsEnumerable().Select(row => new Monitor
                {
                    IdMonitor = row.Field<int>("id_monitor"),
                    FMarcam = row.Field<int>("f_marcam"),
                    Conectores = row.Field<string>("conectores"),
                    Tamano = row.Field<string>("tamano"),
                }).ToList();
            }
            return LMonitor; 
        }
        public List<Mouse> ListaMouse(ref string mensaje, ref string mensajeC)//Metodo de la Lista Mouse
        {
            string comandoMySql = "select * from Mouse;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;
            List<Mouse> LMouse = new List<Mouse>();

            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                LMouse = dataTable.AsEnumerable().Select(row => new Mouse
                {
                    IdMouse = row.Field<int>("id_mouse"),
                    FMarcamouse = row.Field<int>("f_marcamouse"),
                    Conector = row.Field<string>("conector"),
                }).ToList();
            }
            return LMouse;
        }
        public List<Ram> ListaRam(ref string mensaje, ref string mensajeC)//Metodo de la Lista Ram
        {
            string comandoMySql = "select * from Ram;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;
            List<Ram> LRam = new List<Ram>();

            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                LRam = dataTable.AsEnumerable().Select(row => new Ram
                {
                    IdRam = row.Field<int>("id_RAM"),
                    Capacidad = row.Field<short>("Capacidad"),
                    Velocidad = row.Field<string>("Velocidad"),
                    FTipoR = row.Field<int>("F_TipoR"),
                }).ToList();
            }
            return LRam; 
        }
        public List<Teclado> ListaTeclado(ref string mensaje, ref string mensajeC)//Metodo de la Lista Teclado
        {
            string comandoMySql = "select * from Teclado;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;
            List<Teclado> LTeclado = new List<Teclado>();

            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                LTeclado = dataTable.AsEnumerable().Select(row => new Teclado
                {
                    IdTeclado = row.Field<int>("id_teclado"),
                    FMarcat = row.Field<int>("f_marcat"),
                    Conector = row.Field<string>("conector"),
                }).ToList();
            }
            return LTeclado; 
        }
        public List<TipoCpu> ListaTipoCpu(ref string mensaje, ref string mensajeC)//Metodo de la Lista TipoCpu
        {
            string comandoMySql = "select * from Tipo_Cpu;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;
            List<TipoCpu> LTipoCpu = new List<TipoCpu>();

            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                LTipoCpu = dataTable.AsEnumerable().Select(row => new TipoCpu
                {
                    IdTcpu = row.Field<int>("id_Tcpu"),
                    Tipo = row.Field<string>("Tipo"),
                    Familia = row.Field<string>("Familia"),
                    //Velocidad = row.Field<string>("Velocidad"),
                }).ToList();
            }
            return LTipoCpu;
        }
        public List<TipoRam> ListaTipoRam(ref string mensaje, ref string mensajeC)//Metodo de la Lista TipoRam
        {
            string comandoMySql = "select * from TipoRAM;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;
            List<TipoRam> LTipoRam = new List<TipoRam>();

            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                LTipoRam = dataTable.AsEnumerable().Select(row => new TipoRam
                {
                    IdTipoRam = row.Field<int>("id_tipoRam"),
                    Tipo = row.Field<string>("Tipo"),
                }).ToList();
            }
            return LTipoRam;
        }
        public List<Ubicacion> ListaUbicacion(ref string mensaje, ref string mensajeC)//Metodo de la Lista Ubicación
        {
            string comandoMySql = "select * from Ubicacion;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;
            List<Ubicacion> LUbicacion = new List<Ubicacion>();

            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                LUbicacion = dataTable.AsEnumerable().Select(row => new Ubicacion
                {
                    NumInv = row.Field<string>("num_inv"),
                    NombreLaboratorio = row.Field<string>("nombre_laboratorio"),
                }).ToList();
            }
            return LUbicacion;
        }
        public List<Usuario> ListaUsuario(ref string mensaje, ref string mensajeC)//Metodo de la Lista Usuario
        {
            string comandoMySql = "select * from Usuario;", etiqueta = "InventarioPCsLabs";
            DataSet dataSet = null;
            DataTable dataTable = null;
            List<Usuario> LUsuario = new List<Usuario>();

            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
                LUsuario = dataTable.AsEnumerable().Select(row => new Usuario
                {
                    IdUsuario = row.Field<int>("id_usuario"),
                    Nombre = row.Field<string>("nombre"),
                    ApP = row.Field<string>("ap_p"),
                    ApM = row.Field<string>("ap_m"),
                    NomUsuario = row.Field<string>("nom_usuario"),
                    Password = row.Field<string>("password"),
                    TipoUsuario = row.Field<string>("tipo_usuario"),
                }).ToList();
            }
            return LUsuario;
        }
        public bool Insertar(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO ModeloCPU(modeloCPU, f_marca)" +
                "values (@modeloCPU, @f_marca)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@modeloCPU",SqlDbType.VarChar, 50),
                new SqlParameter("@f_marca",SqlDbType.Int),
            };
            info[0].Value = nuevoDatos[0];
            info[1].Value = Convert.ToInt32(nuevoDatos[1]);

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
                return respuesta;
        }
        //aqui ira el insertar de actualizacion //






        //----------------------------------//

        //----------------inicia la tabla cantDisc-----------------------//
        public bool InsertarcantDisc(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO cantDisc(num_inv, id_Disco)" +
                "values (@num_inv, @id_Disco)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@num_inv",SqlDbType.VarChar, 10),
                new SqlParameter("@id_Disco",SqlDbType.Int),
            };
            info[0].Value = nuevoDatos[0];
            info[1].Value = Convert.ToInt32(nuevoDatos[1]);

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        //---------------Fin de cantDisc-----------------------------------//

        //----------------inicia la tabla Categoria-----------------------//

        public bool InsertarCategoria(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO Categoria(Descripcion)" +
                "values (@Descripcion)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@Descripcion",SqlDbType.VarChar, 100),
            };
            info[0].Value = nuevoDatos[0];

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }

        //---------------fin de la tabla Categoria----------------------//

        //---------------inicia la tabla catMar------------------------//

        public bool InsertarCatMar(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO CatMar(id_Categoria, id_Marca)" +
                "values (@id_Categoria, @id_Marca)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@id_Categoria",SqlDbType.Int),
                new SqlParameter("@id_Marca",SqlDbType.Int),
            };
            info[0].Value = Convert.ToInt32(nuevoDatos[0]);
            info[1].Value = Convert.ToInt32(nuevoDatos[1]);

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }

        //---------------Fin de la tabla catMar-----------------------//

        //--------------Inicio de la tabla Computadora final---------//

        public bool InsertarComputadoraFinal(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO computadorafinal(num_inv, num_scpu, id_cpug, num_steclado, id_tecladog, num_smonitor, id_mong, num_smouse, id_mousg, estado, id_Estatus)" +
                "values (@num_inv, @num_scpu, @id_cpug, @num_steclado, @id_tecladog, @num_smonitor, @id_mong, @num_smouse, @id_mousg, @estado, @id_Estatus)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@num_inv",SqlDbType.VarChar, 10),
                new SqlParameter("@num_scpu",SqlDbType.VarChar, 11),
                new SqlParameter("@id_cpug",SqlDbType.Int),
                new SqlParameter("@num_steclado",SqlDbType.VarChar, 11),
                new SqlParameter("@id_tecladog",SqlDbType.Int),
                new SqlParameter("@num_smonitor",SqlDbType.VarChar, 11),
                new SqlParameter("@id_mong",SqlDbType.Int),
                new SqlParameter("@num_smouse",SqlDbType.VarChar, 11),
                new SqlParameter("@id_mousg",SqlDbType.Int),
                new SqlParameter("@estado",SqlDbType.VarChar, 64),
                new SqlParameter("@id_Estatus",SqlDbType.Int),
            };
            info[0].Value = nuevoDatos[0];
            info[1].Value = nuevoDatos[1];
            info[2].Value = Convert.ToInt32(nuevoDatos[2]);
            info[3].Value = nuevoDatos[3];
            info[4].Value = Convert.ToInt32(nuevoDatos[4]);
            info[5].Value = nuevoDatos[5];
            info[6].Value = Convert.ToInt32(nuevoDatos[6]);
            info[7].Value = nuevoDatos[7];
            info[8].Value = Convert.ToInt32(nuevoDatos[8]);
            info[9].Value = nuevoDatos[9];
            info[10].Value = Convert.ToInt32(nuevoDatos[10]);

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        //--------------Fin  de la tabla Computadora final---------//

        //--------------Inicio de la tabla CPU generico---------//

        public bool InsertarCPUgenerico(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO CPU_Generico(f_Tcpu, f_MarcaCpu, Modelo, Descripcion, f_tipoRam, id_Gabinete)" +
                "values (@f_Tcpu, @f_MarcaCpu, @Modelo, @Descripcion, @f_tipoRam, @id_Gabinete)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@f_Tcpu",SqlDbType.Int),
                new SqlParameter("@f_MarcaCpu",SqlDbType.Int),
                new SqlParameter("@Modelo",SqlDbType.VarChar, 20),
                new SqlParameter("@Descripcion",SqlDbType.VarChar, 40),
                new SqlParameter("@f_tipoRam",SqlDbType.Int),
                new SqlParameter("@id_Gabinete",SqlDbType.Int),
            };
            info[0].Value = Convert.ToInt32(nuevoDatos[0]);
            info[1].Value = Convert.ToInt32(nuevoDatos[1]);
            info[2].Value = nuevoDatos[2];
            info[3].Value = nuevoDatos[3];
            info[4].Value = Convert.ToInt32(nuevoDatos[4]);
            info[5].Value = Convert.ToInt32(nuevoDatos[5]);

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        //--------------Fin  de la tabla Cpu generico -----------//

        //--------------Inicio de la tabla CPU tipo mod---------//

        public bool InsertarCPUTipoMod(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO CPU_TipoMod(id_Tcpu, id_modcpu, nucleos)" +
                "values (@id_Tcpu, @id_modcpu, @nucleos)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@id_Tcpu",SqlDbType.Int),
                new SqlParameter("@id_modcpu",SqlDbType.Int),
                new SqlParameter("@nucleos",SqlDbType.VarChar, 10),
            };
            info[0].Value = Convert.ToInt32(nuevoDatos[0]);
            info[1].Value = Convert.ToInt32(nuevoDatos[1]);
            info[2].Value = nuevoDatos[2];
            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        //--------------Fin  de la tabla Cpu tipo mod -----------//

        //--------------Inicio de la tabla Disco Duro (checar tabla no inserta datos)---------//

        public bool InsertarDiscoDuro(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO DiscoDuro(TipoDisco, conector, Capasidad, F_MarcaDisco, Extra)" +
                "values (@TipoDisco, @conector, @Capasidad, @F_MarcaDisco, @Extra)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@TipoDisco",SqlDbType.VarChar, 20),
                new SqlParameter("@conector",SqlDbType.VarChar, 10),
                new SqlParameter("@Capacidad",SqlDbType.VarChar, 12),
                new SqlParameter("@F_MarcaDisco",SqlDbType.Int),
                new SqlParameter("@Extra",SqlDbType.VarChar, 25),
            };
            info[0].Value = nuevoDatos[0];
            info[1].Value = nuevoDatos[1];
            info[2].Value = nuevoDatos[2];
            info[3].Value = Convert.ToInt32(nuevoDatos[3]);
            //info[4].Value = nuevoDatos[4];

            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        //--------------Fin  de la tabla disco duro  -----------//

        public bool InsertarEstatus(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO Estatus(Estado)" +
                "values (@Estado)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@Estado",SqlDbType.VarChar, 50),
            };

            info[0].Value = nuevoDatos[0];
            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        //--------------Fin  de la tabla Cpu tipo mod -----------//

        //--------------Fin  de la tabla disco duro  -----------//

        public bool InsertarEvidencia(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            bool respuesta = false;

            string instrccion = "INSERT INTO Evidencia(Evidencia1, num_inv)" +
                "values (@evidencia1 , @num_inv)";
            SqlParameter[] info = new SqlParameter[]
            {
                new SqlParameter("@Evidencia1",SqlDbType.VarChar, 50),
                new SqlParameter("@num_inv",SqlDbType.Int),
            };

            info[0].Value = nuevoDatos[0];
            info[1].Value = Convert.ToInt32(nuevoDatos[1]);
            respuesta = AC.BaseSegura(instrccion, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, info);
            return respuesta;
        }
        //--------------Fin  de la tabla Cpu tipo mod -----------//
    }
}
