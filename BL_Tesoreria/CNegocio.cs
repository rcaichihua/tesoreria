using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO_Tesoreria;
using System.Data;

namespace BL_Tesoreria
{
    public class CNegocio
    {
        private CDatos objx = new CDatos();
        private CDatos objxSGI = new CDatos();


        //public string TraerServidor(string ser, string bd, string usu, string pas)
        //{
        //    return objx.TraerServidor(ser, bd, usu, pas);
        //}
        public string TraerServidor()
        {
            return objx.TraerServidor();
        }
        public string TraerServidorSGI()
        {
            return objx.TraerServidorSGI();
        }
        public DataSet TraerDataset(string ProcedimientoAlmacenado, params object[] Argumentos)
        {
            try
            {
                if (ProcedimientoAlmacenado == "usp_mantenimiento_residente")
                {
                    if (Argumentos[7] == null || Argumentos[7].ToString() == string.Empty)
                    {
                        Argumentos[7] = DBNull.Value;
                    }
                    if (Argumentos[12] == null || Argumentos[12].ToString() == string.Empty)
                    {
                        Argumentos[12] = DBNull.Value;
                    }
                    if (Argumentos[13] == null || Argumentos[12].ToString() == string.Empty)
                    {
                        Argumentos[13] = DBNull.Value;
                    }
                    if (Argumentos[13] != DBNull.Value)
                    {
                        Argumentos[13] = Convert.ToInt32(Argumentos[13]);
                    }
                    if (Argumentos[19] == null || Argumentos[19].ToString() == string.Empty)
                    {
                        Argumentos[19] = DBNull.Value;
                    }
                    if (Argumentos[20] == null || Argumentos[20].ToString() == string.Empty)
                    {
                        Argumentos[20] = DBNull.Value;
                    }
                }
                return objx.TraerDataset(ProcedimientoAlmacenado, Argumentos);
            }
            catch (Exception ex) { throw ex; }
        }

        public int EjecutarSP(string ProcedimientoAlmacenado, params object[] Argumentos)
        {
            try
            {
                if (ProcedimientoAlmacenado == "usp_mantenimiento_residente")
                {
                    if (Argumentos[7] == null || Argumentos[7].ToString() == string.Empty)
                    {
                        Argumentos[7] = DBNull.Value;
                    }
                    if (Argumentos[12] == null || Argumentos[12].ToString() == string.Empty)
                    {
                        Argumentos[12] = DBNull.Value;
                    }
                    if (Argumentos[13] == null || Argumentos[12].ToString() == string.Empty)
                    {
                        Argumentos[13] = DBNull.Value;
                    }
                    if (Argumentos[13] != DBNull.Value)
                    {
                        Argumentos[13] = Convert.ToInt32(Argumentos[13]);
                    }
                    if (Argumentos[19] == null || Argumentos[19].ToString() == string.Empty)
                    {
                        Argumentos[19] = DBNull.Value;
                    }
                }
                if (ProcedimientoAlmacenado == "usp_mantenimiento_rubro")
                {
                    if (Argumentos[2] == null || Argumentos[2].ToString() == string.Empty)
                    {
                        Argumentos[2] = DBNull.Value;
                    }
                }
                //throw new System.InvalidOperationException("Logfile cannot be read-only");
                //return objx.EjecutarSP(ProcedimientoAlmacenado, Argumentos);
                return objx.EjecutarSP(ProcedimientoAlmacenado, Argumentos);
            }
            catch (Exception ex) { throw ex; }
        }

        public int EjecutarTransaccionDoble(string ProcedimientoAlmacenado1, string ProcedimientoAlmacenado2, params Object[] Argumentos)
        {
            try
            {
                return objx.EjecutarTransaccionDoble(ProcedimientoAlmacenado1,ProcedimientoAlmacenado2,Argumentos);
            }
            catch (Exception) { throw; }
        }

        public DataSet EjecutarSqlDTS(string SQL)
        {
            try
            {
                return objx.EjecutarSqlDTS(SQL);
            }
            catch (Exception) { throw ; }
        }

        public DataSet EjecutarSqlDTSSGI(string SQL)
        {
            try
            {
                return objx.EjecutarSqlDTSSGI(SQL);
            }
            catch (Exception) { throw; }
        }

        public int EjecutarUD(string SQL)
        {
            try
            {
                return objx.EjecutarUD(SQL);
            }
            catch (Exception) { throw; }
        }

        public int IngresaAperturaCierreCaja(string ProcedimientoAlmacenado, int id, DataTable dt)
        {
            try
            {
                return objx.IngresaAperturaCierreCaja(ProcedimientoAlmacenado, id,dt);
            }
            catch (Exception) { throw; }
        }

        public DataSet IngresaRecibo(string ProcedimientoAlmacenado, bool estado, DataTable dtCabecera,DataTable dtCabeceraDetalle)
        {
            try
            {
                return objx.IngresaRecibo(ProcedimientoAlmacenado, estado, dtCabecera, dtCabeceraDetalle);
            }
            catch (Exception) { throw; }
        }
        public DataSet IngresaTituloNicho(string ProcedimientoAlmacenado,string CodPabellon,string LetraFila, int NumeroCol,int Usuario,
            string EstadoTitulo, string NroTitutlo, string NroDocVenta,string NomResponsable, 
            DateTime? FechaInhumacion, DateTime? FechaConcesion, int? MotivoAnulacion, string Observacion,
            bool GeneroTitulo,bool RecogioTitulo,string Cementerio,string NombreCuartel,int anios,char perpetuo, DataTable dtDifuntos,String Material)
        {
            try
            {
                if (MotivoAnulacion == 0)
                {
                    MotivoAnulacion = null;
                }
                return objx.IngresaTituloNicho(ProcedimientoAlmacenado, CodPabellon, LetraFila, NumeroCol, Usuario,
            EstadoTitulo, NroTitutlo, NroDocVenta,NomResponsable, FechaInhumacion, FechaConcesion, MotivoAnulacion, Observacion,
            GeneroTitulo,RecogioTitulo,Cementerio,NombreCuartel,anios,perpetuo, dtDifuntos,Material);
            }
            catch (Exception) { throw; }
        }
    }
}
