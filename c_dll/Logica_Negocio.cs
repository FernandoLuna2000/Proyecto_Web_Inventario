using c_dal;
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

        private CRUD OPC = null; 
        public Logica_Negocio(string connection)
        {
            AC = new Acceso_Datos(connection);
            OPC = new CRUD(connection);
        }

        //<--------------------------------------------------------------------------------------------Listas Mostrar-------------------------------------------------------------------------------------------->
        public List<Actualizacion> L_Actualizacion(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaActualizacion(ref mensaje, ref mensajeC);
        }
        public List<CantDisc> L_CantDisc(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaCantDisc(ref mensaje, ref mensajeC);
        }
        public List<Categoria> L_Categoria(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaCategoria(ref mensaje, ref mensajeC);
        }
        public List<CatMar> L_CatMar(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaCatMar(ref mensaje, ref mensajeC);
        }
        public List<Computadorafinal> L_ComputadoraFinal(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaComputadoraFinal(ref mensaje, ref mensajeC);
        }
        public List<CpuGenerico> L_CpuGenerico(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaCpuGenerico(ref mensaje, ref mensajeC);
        }
        public List<CpuTipoMod> L_CpuTipoMod(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaCpuTipoMod(ref mensaje, ref mensajeC);
        }
        public List<DiscoDuro> L_DiscoDuro(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaDiscoDuro(ref mensaje, ref mensajeC);
        }
        public List<Estatus> L_Estatus(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaEstatus(ref mensaje, ref mensajeC);
        }
        public List<Evidencia> L_Evidencia(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaEvidencia(ref mensaje, ref mensajeC);
        }
        public List<Gabinete> L_Gabinete(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaGabinete(ref mensaje, ref mensajeC);
        }
        public List<Laboratorio> L_Lab(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaLab(ref mensaje, ref mensajeC);
        }
        public List<Marca> L_Marca(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaMarca(ref mensaje, ref mensajeC);
        }
        public List<ModeloCpu> L_ModeloCpu(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaModeloCpu(ref mensaje, ref mensajeC);
        }
        public List<Monitor> L_Monitor(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaMonitor(ref mensaje, ref mensajeC);
        }
        public List<Mouse> L_Mouse(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaMouse(ref mensaje, ref mensajeC);
        }
        public List<Ram> L_Ram(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaRam(ref mensaje, ref mensajeC);
        }
        public List<Teclado> L_Teclado(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaTeclado(ref mensaje, ref mensajeC);
        }
        public List<TipoCpu> L_TipoCpu(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaTipoCpu(ref mensaje, ref mensajeC);
        }
        public List<TipoRam> L_TipoRam(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaTipoRam(ref mensaje, ref mensajeC);
        }
        public List<Ubicacion> L_Ubicacion(ref string mensaje, ref string mensajeC)
        {

            return OPC.ListaUbicacion(ref mensaje, ref mensajeC);
        }
        public List<Usuario> L_Usuario(ref string mensaje, ref string mensajeC)
        {
            return OPC.ListaUsuario(ref mensaje, ref mensajeC);
        }

        public DataTable tablaMarca(ref string mensaje, ref string mensajeC)
        {
            string comandoMySql = "select * from Marca;", etiqueta = "profesoresServer";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;
        }

        public DataTable tablagabinete(ref string mensaje, ref string mensajeC)
        {
            string comandoMySql = "select * from Gabinete;", etiqueta = "profesoresServer";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;
        }


        public DataTable tablacpugenerico(ref string mensaje, ref string mensajeC)
        {
            string comandoMySql = "select * from CPU_Generico;", etiqueta = "profesoresServer";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;
        }

        public DataTable tablacompu_fi(ref string mensaje, ref string mensajeC)
        {
            string comandoMySql = "select * from computadorafinal;", etiqueta = "profesoresServer";
            DataSet dataSet = null;
            DataTable dataTable = null;


            dataSet = AC.LecturaSet(comandoMySql, AC.ConnectionEstablecida(ref mensajeC), ref mensaje, etiqueta);
            if (dataSet != null)
            {
                dataTable = dataSet.Tables[0];
            }
            return dataTable;
        }

        //<--------------------------------------------------------------------------------------------Insertar-------------------------------------------------------------------------------------------->

        public string Insert_Actualizacion(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarActualizacion(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_cantDisc(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarcantDisc(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_Categoria(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarCategoria(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_CatMar(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarCatMar(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_ComputadoraFinal(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarComputadoraFinal(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;

        }
        public string Insert_CPUgenerico(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarCPUgenerico(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_CPUTipoMod(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarCPUTipoMod(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_DiscoDuro(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarDiscoDuro(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_Estatus(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarEstatus(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_Evidencia(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarEvidencia(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_Gabinete(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarGabinete(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_Laboratorio(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarLaboratorio(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_Marca(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarMarca(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_ModeloCpu(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarModeloCpu(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_Monitor(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarMonitor(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_Mouse(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarMouse(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_Ram(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarRam(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_Teclado(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarTeclado(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_TipoCpu(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarTipoCpu(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_TipoRam(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarTipoRam(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_Ubicacion(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarUbicacion(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Insert_Usuario(string[] nuevoDatos, ref string mensaje, ref string mensajeC)
        {
            string resp = "";
            if (!OPC.InsertarUsuario(nuevoDatos, ref mensaje, ref mensajeC))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }

        //<--------------------------------------------------------------------------------------------Modificar-------------------------------------------------------------------------------------------->

        public string Act_TabActualizacion(string[] nuevoDatos, ref string mensaje, ref string mensajeC, int id)
        {
            string resp = "";
            if (!OPC.ActualizarTabActualizacion(nuevoDatos, ref mensaje, ref mensajeC, id))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_CabtDisc(string[] nuevoDatos, ref string mensaje, ref string mensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarCantDisc(nuevoDatos, ref mensaje, ref mensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_Categoria(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarCategoria(nuevoDatos,ref Mensaje,ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_CatMar(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarCatMar(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_CompuFinal(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarCompuFinal(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_CPU_generico(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarCPU_generico(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_Cpu_tipomod(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarCpu_tipomod(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_DiscoDuro(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarDiscoDuro(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_Estatus(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarEstatus(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_Evidencia(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarEvidencia(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_Gabinete(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarGabinete(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_laboratorio(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.Actualizarlaboratorio(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_Marca(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarMarca(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_ModeloCpu(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarModeloCpu(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_Monitor(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarMonitor(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_Mouse(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarMouse(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_Ram(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarRam(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_Teclado(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarTeclado(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_TipoCPU(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarTipoCPU(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_TipoRAM(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarTipoRAM(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_Ubicaciones(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarUbicaciones(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Act_Usuario(string[] nuevoDatos, ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.ActualizarUsuario(nuevoDatos, ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";
            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }

        //<--------------------------------------------------------------------------------------------Eliminar-------------------------------------------------------------------------------------------->

        public string Elim_actualizacion(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.Eliminaractualizacion(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_CantDisc(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarCantDisc(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Categoria(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarCategoria(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_CatMar(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarCatMar(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Computadorafinal(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarComputadorafinal(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_CPU_Generico(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarCPU_Generico(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_CPU_TipoMod(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarCPU_TipoMod(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_DiscoDuro(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarDiscoDuro(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Estatus(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarEstatus(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Evidencia(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarEvidencia(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Gabinete(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarGabinete(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Laboratorio(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarLaboratorio(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Marca(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarMarca(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Modelo(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarModelo(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Monitor(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarMonitor(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Mouse(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarMouse(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Ram(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarRam(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Teclado(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarTeclado(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Tipocpu(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarTipocpu(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_TipoRAM(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarTipoRAM(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Ubicacion(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarUbicacion(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
        public string Elim_Usuario(ref string Mensaje, ref string MensajeC, int ID)
        {
            string resp = "";
            if (!OPC.EliminarUsuario(ref Mensaje, ref MensajeC, ID))
            {
                resp = "nu";

            }
            else
            {
                resp = "Viejo sabroso:3";
            }
            return resp;
        }
    }
}