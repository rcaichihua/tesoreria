using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Transactions;

namespace DAO_Tesoreria
{
    public class CDatos
    {
        //public string TraerServidor(string ser, string bd, string usu, string pas)
        //{
        //    return conectar.conexionXml = @"Server=" + ser + ";Database=" + bd + ";Uid=" + usu + ";pwd=" + pas;
        //}
        public string TraerServidor()
        {
            return conectar.conexionXml = ConfigurationManager.ConnectionStrings["BDTesoreria"].ConnectionString;//@"Server=" + ser + ";Database=" + bd + ";Uid=" + usu + ";pwd=" + pas;
        }
        public string TraerServidorSGI()
        {
            return conectar.conexionXmlSGI = ConfigurationManager.ConnectionStrings["BDSGI"].ConnectionString;//@"Server=" + ser + ";Database=" + bd + ";Uid=" + usu + ";pwd=" + pas;
        }

        protected IDbCommand Comando(string ProcedimientoAlmacenado)
        { //ConfigurationManager.ConnectionStrings["conStrTeso"].ConnectionString
            try
            {
                var cn = new SqlConnection(conectar.conexionXml);
                var mComando = new SqlCommand(ProcedimientoAlmacenado, cn);

                cn.Open();
                mComando.Connection = cn;
                mComando.CommandType = CommandType.StoredProcedure;
                SqlCommandBuilder.DeriveParameters(mComando);
                cn.Close();
                return mComando;
            }
            catch (Exception ex) { throw ex; }
        }
        protected void CargarParametros(IDbCommand Comando, params object[] Args)
        {
            int i;
            for (i = 0; (i <= Args.GetUpperBound(0)); i++)
            {
                try
                {
                    if (Args.GetValue(i) == null)
                    {
                        Args[i] = DBNull.Value;
                    }
                    ((SqlParameter)(Comando.Parameters[(i + 1)])).Value = Args.GetValue(i);
                }
                catch (Exception Qex)
                {
                    throw Qex;
                }
            }
        }
        public DataSet TraerDataset(string ProcedimientoAlmacenado, params object[] Args)
        {
            var mDataset = new DataSet();
            try
            {
                using (var cn = new SqlConnection(conectar.conexionXml))
                {
                    using (var mComando = new SqlCommand(ProcedimientoAlmacenado, cn))
                    {
                        cn.Open();
                        mComando.CommandTimeout = 2700;
                        mComando.Connection = cn;
                        mComando.CommandType = CommandType.StoredProcedure;

                        SqlCommandBuilder.DeriveParameters(mComando);
                        
                        if ((Args != null))
                        {
                            CargarParametros(mComando, Args);
                        }

                        //mComando.Parameters.RemoveAt("@RETURN_VALUE");
                        new SqlDataAdapter(mComando).Fill(mDataset);

                        return mDataset;
                    }
                }
            }
            catch (Exception ex) { throw ex; }

        }
        public DataSet TraerDataset(string ProcedimientoAlmacenado)
        {
            var mDataset = new DataSet();
            try
            {
                using (var cn = new SqlConnection(conectar.conexionXml))
                {
                    using (var mComando = new SqlCommand(ProcedimientoAlmacenado, cn))
                    {
                        cn.Open();
                        mComando.CommandTimeout = 2700;
                        mComando.Connection = cn;
                        mComando.CommandType = CommandType.StoredProcedure;

                        //SqlCommandBuilder.DeriveParameters(mComando);

                        new SqlDataAdapter(mComando).Fill(mDataset);

                        return mDataset;
                    }
                }
            }
            catch (Exception ex) { throw ex; }

        }
        public int EjecutarSP(string ProcedimientoAlmacenado, params Object[] Argumentos)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conectar.conexionXml))
                {
                    using (SqlCommand mCom = (SqlCommand)Comando(ProcedimientoAlmacenado))
                    {
                        int Resp = 0;
                        cn.Open();
                        mCom.Connection = cn;
                        mCom.CommandType = CommandType.StoredProcedure;
                        CargarParametros(mCom, Argumentos);
                        Resp = mCom.ExecuteNonQuery();
                        return Resp;
                    }
                }
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }
        public DataSet EjecutarSqlDTS(string SQL)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conectar.conexionXml))
                {
                    SqlDataAdapter da = new SqlDataAdapter(SQL, cn);
                    DataSet dtx = new DataSet();
                    da.Fill(dtx);

                    return dtx;
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public DataSet EjecutarSqlDTSSGI(string SQL)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conectar.conexionXmlSGI))
                {
                    SqlDataAdapter da = new SqlDataAdapter(SQL, cn);
                    DataSet dtx = new DataSet();
                    da.Fill(dtx);

                    return dtx;
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public int EjecutarUD(string SQL)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conectar.conexionXml))
                {
                    using (SqlCommand command = new SqlCommand(SQL, connection))
                    {
                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception Ex)
            {
                throw (Ex);
            }
        }

        public int EjecutarTransaccionDoble(string ProcedimientoAlmacenado1, string ProcedimientoAlmacenado2, params Object[] Argumentos)
        {
            var txOption = new System.Transactions.TransactionOptions();
            txOption.IsolationLevel = System.Transactions.IsolationLevel.Serializable;

            using (TransactionScope trans = new TransactionScope())
            {
                try
                {
                    EjecutarSP(ProcedimientoAlmacenado1, Argumentos[0]);
                    EjecutarSP(ProcedimientoAlmacenado2, Argumentos);
                    trans.Complete();
                    return 1;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    trans.Dispose();
                }
            }
        }

        public int EjecutarTransaccionSimple(string ProcedimientoAlmacenado1, params Object[] Argumentos)
        {
            var txOption = new System.Transactions.TransactionOptions();
            txOption.IsolationLevel = System.Transactions.IsolationLevel.Serializable;

            using (TransactionScope trans = new TransactionScope())
            {
                try
                {
                    EjecutarSP(ProcedimientoAlmacenado1, Argumentos[0]);

                    trans.Complete();
                    return 1;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    trans.Dispose();
                }
            }
        }

        public int IngresaAperturaCierreCaja(string ProcedimientoAlmacenado, int id,DataTable dt)
        {
            using (var cn = new SqlConnection(conectar.conexionXml))
            {
                using (var mComando = new SqlCommand(ProcedimientoAlmacenado, cn))
                {
                    var mDataset = new DataSet();
                    cn.Open();
                    mComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter tvpParam2 = mComando.Parameters.AddWithValue("@id", id);

                    SqlParameter tvpParam1 = mComando.Parameters.AddWithValue("@TablaTmp", dt);
                    tvpParam1.SqlDbType = SqlDbType.Structured;

                    return mComando.ExecuteNonQuery();

                }
            }
        }

        public DataSet IngresaRecibo(string ProcedimientoAlmacenado, bool estado, DataTable dtCabecera, DataTable dtCabeceraDetalle)
        {
            using (var cn = new SqlConnection(conectar.conexionXml))
            {
                using (var mComando = new SqlCommand(ProcedimientoAlmacenado, cn))
                {
                    var mDataset = new DataSet();
                    cn.Open();
                    mComando.CommandType = CommandType.StoredProcedure;

                    SqlParameter tvpParam2 = mComando.Parameters.AddWithValue("@estadoMov", estado);

                    SqlParameter tvpParam1 = mComando.Parameters.AddWithValue("@TablaCabeceraTmp", dtCabecera);
                    tvpParam1.SqlDbType = SqlDbType.Structured;

                    SqlParameter tvpParam3 = mComando.Parameters.AddWithValue("@TablaCabeceraDetalleTmp", dtCabeceraDetalle);
                    tvpParam3.SqlDbType = SqlDbType.Structured;

                    new SqlDataAdapter(mComando).Fill(mDataset);

                    return mDataset;
                    //return mComando.ExecuteNonQuery();
                }
            }
        }
        public DataSet IngresaTituloNicho(string ProcedimientoAlmacenado, string CodPabellon, string LetraFila, int NumeroCol
            , int Usuario,string EstadoTitulo, string NroTitutlo, string NroDocVenta, string NomResponsable,
           DateTime? FechaInhumacion, DateTime? FechaConcesion, int? MotivoAnulacion, string Observacion,
           bool GeneroTitulo, bool RecogioTitulo, string Cementerio, string NombreCuartel, int anios, char perpetuo
            , DataTable dtDifuntos, string Material)
        {
            try
            {
                //if (FechaInhumacion.Value.ToShortDateString() == "1/01/0001")
                //{
                //    FechaInhumacion = null;
                //}
                using (var cn = new SqlConnection(conectar.conexionXml))
                {
                    using (var mComando = new SqlCommand(ProcedimientoAlmacenado, cn))
                    {
                        var mDataset = new DataSet();
                        cn.Open();
                        mComando.CommandType = CommandType.StoredProcedure;

                        SqlParameter tvpParam2 = mComando.Parameters.AddWithValue("@CodPabellon", CodPabellon);
                        SqlParameter tvpParam4 = mComando.Parameters.AddWithValue("@LETRAFILANICHO", LetraFila);
                        SqlParameter tvpParam5 = mComando.Parameters.AddWithValue("@NUMEROCOLNICHO", NumeroCol);
                        SqlParameter tvpParam6 = mComando.Parameters.AddWithValue("@Usuario", Usuario);
                        SqlParameter tvpParam7 = mComando.Parameters.AddWithValue("@ESTADO", EstadoTitulo);
                        SqlParameter tvpParam8 = mComando.Parameters.AddWithValue("@NUMEROTITULO", NroTitutlo);
                        SqlParameter tvpParam9 = mComando.Parameters.AddWithValue("@NUMERODOCUMENTOVENTA", NroDocVenta);
                        SqlParameter tvpParam10 = mComando.Parameters.AddWithValue("@NOMBRERESPONSABLE", NomResponsable);

                        if (FechaInhumacion == null)
                        {
                            SqlParameter tvpParam11 = mComando.Parameters.AddWithValue("@FECHAINHUMACION_CAB", DBNull.Value);
                        }
                        else { SqlParameter tvpParam11 = mComando.Parameters.AddWithValue("@FECHAINHUMACION_CAB", FechaInhumacion); }

                        if (FechaConcesion == null)
                        {
                            SqlParameter tvpParam12 = mComando.Parameters.AddWithValue("@FECHACONCESION_CAB", DBNull.Value);
                        }
                        else { SqlParameter tvpParam12 = mComando.Parameters.AddWithValue("@FECHACONCESION_CAB", FechaConcesion); }

                        //SqlParameter tvpParam12 = mComando.Parameters.AddWithValue("@FECHACONCESION_CAB", FechaConcesion);

                        if (MotivoAnulacion == null)
                        {
                            SqlParameter tvpParam13 = mComando.Parameters.AddWithValue("@IDMOTIVO", DBNull.Value);
                        }
                        else
                        {
                            SqlParameter tvpParam13 = mComando.Parameters.AddWithValue("@IDMOTIVO", MotivoAnulacion);
                        }
                        SqlParameter tvpParam14 = mComando.Parameters.AddWithValue("@OBSERVACIONMOTIVO", Observacion);
                        SqlParameter tvpParam15 = mComando.Parameters.AddWithValue("@GeneroTitulo", GeneroTitulo);
                        SqlParameter tvpParam16 = mComando.Parameters.AddWithValue("@RecogioTitulo", RecogioTitulo);
                        SqlParameter tvpParam17 = mComando.Parameters.AddWithValue("@Cementerio", Cementerio);
                        SqlParameter tvpParam18 = mComando.Parameters.AddWithValue("@NombreCuartel", NombreCuartel);
                        SqlParameter tvpParam19 = mComando.Parameters.AddWithValue("@ANIOSTEMPORAL", anios);
                        SqlParameter tvpParam20 = mComando.Parameters.AddWithValue("@PERPETUO", perpetuo); 
                        SqlParameter tvpParam21 = mComando.Parameters.AddWithValue("@MATERIALNICHO", Material);

                        SqlParameter tvpParam1 = mComando.Parameters.AddWithValue("@TablaCabeceraDetalleTmp", dtDifuntos);
                        tvpParam1.SqlDbType = SqlDbType.Structured;

                        new SqlDataAdapter(mComando).Fill(mDataset);

                        return mDataset;
                        //return mComando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
