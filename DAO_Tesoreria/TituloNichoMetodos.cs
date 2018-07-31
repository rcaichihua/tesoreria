using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE_Tesoreria;
using I_Tesoreria;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using SharpCore.Data;

namespace DAO_Tesoreria
{
    public class TituloNichoMetodos : ITituloNicho,IDisposable
    {
        string cnx = Properties.Settings.Default.BDTESORERIAConnectionString;

        public int AgregarTituloNicho(TituloNicho tITULONICHO)
        {          
            SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@IDTITULONICHO", tITULONICHO.IDTITULONICHO),
                new SqlParameter("@ESTADO", tITULONICHO.ESTADO),
                new SqlParameter("@NUMEROTITULO", tITULONICHO.NUMEROTITULO),
                new SqlParameter("@NUMERODOCUMENTOVENTA", tITULONICHO.NUMERODOCUMENTOVENTA),
                new SqlParameter("@NOMBRERESPONSABLE", tITULONICHO.NOMBRERESPONSABLE),
                new SqlParameter("@FECHAINHUMACION", tITULONICHO.FECHAINHUMACION),
                new SqlParameter("@FECHACONCESION", tITULONICHO.FECHACONCESION),
                new SqlParameter("@IDMOTIVO", tITULONICHO.IDMOTIVO),
                new SqlParameter("@OBSERVACIONMOTIVO", tITULONICHO.OBSERVACIONMOTIVO),
                new SqlParameter("@GENEROTITULO", tITULONICHO.GENEROTITULO),
                new SqlParameter("@RECOGIOTITULO", tITULONICHO.RECOGIOTITULO),
                new SqlParameter("@CEMENTERIO", tITULONICHO.CEMENTERIO),
                new SqlParameter("@NOMBRECUARTEL", tITULONICHO.NOMBRECUARTEL),
                new SqlParameter("@LETRAFILANICHO", tITULONICHO.LETRAFILANICHO),
                new SqlParameter("@NUMEROCOLNICHO", tITULONICHO.NUMEROCOLNICHO),
                new SqlParameter("@CODCUARTEL", tITULONICHO.CODCUARTEL),
                new SqlParameter("@ANULADO", tITULONICHO.ANULADO),
                new SqlParameter("@USUARIOING", tITULONICHO.USUARIOING),
                new SqlParameter("@FECHAING", tITULONICHO.FECHAING),
                new SqlParameter("@USUARIOMOD", tITULONICHO.USUARIOMOD),
                new SqlParameter("@FECHAMOD", tITULONICHO.FECHAMOD)
             };

            return SqlHelper.ExecuteNonQuery(cnx, CommandType.StoredProcedure, "TITULONICHOInsert", parameters);
        }

        public TituloNicho BuscarTituloNicho(int IdTituloNicho)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDTITULONICHO", IdTituloNicho)
            };

            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(cnx, CommandType.StoredProcedure, "usp_TITULONICHOSelect", parameters))
            {
                if (dataReader.Read())
                {
                    return MakeTITULONICHO(dataReader);
                }
                else
                {
                    return null;
                }
            }
        }

        public TituloNicho BuscarTituloNichoPorNicho(string CodCuartel, string LetraNicho, int ColumNicho)
        {
            SqlParameter[] parameters = new SqlParameter[]
                 {
                new SqlParameter("@CODCUARTEL", CodCuartel),
                new SqlParameter("@LETRA",LetraNicho),
                new SqlParameter("@NUMERO",ColumNicho)
                     };

            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(cnx, CommandType.StoredProcedure, "usp_TITULONICHOSelect", parameters))
            {
                if (dataReader.Read())
                {
                    return MakeTITULONICHO(dataReader);
                }
                else
                {
                    return null;
                }
            }
        }

        public int EditarTituloNicho(TituloNicho tITULONICHO)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IDTITULONICHO", tITULONICHO.IDTITULONICHO),
                new SqlParameter("@ESTADO", tITULONICHO.ESTADO),
                new SqlParameter("@NUMEROTITULO", tITULONICHO.NUMEROTITULO),
                new SqlParameter("@NUMERODOCUMENTOVENTA", tITULONICHO.NUMERODOCUMENTOVENTA),
                new SqlParameter("@NOMBRERESPONSABLE", tITULONICHO.NOMBRERESPONSABLE),
                new SqlParameter("@FECHAINHUMACION", tITULONICHO.FECHAINHUMACION),
                new SqlParameter("@FECHACONCESION", tITULONICHO.FECHACONCESION),
                new SqlParameter("@IDMOTIVO", tITULONICHO.IDMOTIVO),
                new SqlParameter("@OBSERVACIONMOTIVO", tITULONICHO.OBSERVACIONMOTIVO),
                new SqlParameter("@GENEROTITULO", tITULONICHO.GENEROTITULO),
                new SqlParameter("@RECOGIOTITULO", tITULONICHO.RECOGIOTITULO),
                new SqlParameter("@CEMENTERIO", tITULONICHO.CEMENTERIO),
                new SqlParameter("@NOMBRECUARTEL", tITULONICHO.NOMBRECUARTEL),
                new SqlParameter("@LETRAFILANICHO", tITULONICHO.LETRAFILANICHO),
                new SqlParameter("@NUMEROCOLNICHO", tITULONICHO.NUMEROCOLNICHO),
                new SqlParameter("@CODCUARTEL", tITULONICHO.CODCUARTEL),
                new SqlParameter("@ANULADO", tITULONICHO.ANULADO),
                new SqlParameter("@USUARIOING", tITULONICHO.USUARIOING),
                new SqlParameter("@FECHAING", tITULONICHO.FECHAING),
                new SqlParameter("@USUARIOMOD", tITULONICHO.USUARIOMOD),
                new SqlParameter("@FECHAMOD", tITULONICHO.FECHAMOD)
            };

            return SqlHelper.ExecuteNonQuery(cnx, CommandType.StoredProcedure, "TITULONICHOUpdate", parameters);
        }

        public int AnularTituloNicho(int IdTituloNicho,int Usuario)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
             {
                new SqlParameter("@idNichoInventario", IdTituloNicho),
                new SqlParameter("@USUARIO",Usuario)
             };

                return Convert.ToInt32(SqlHelper.ExecuteScalar(cnx, CommandType.StoredProcedure, "usp_AnulaIngresoGabinete", parameters));
            }
            catch (Exception)
            {
                throw;
            }            
        }

        public bool ExisteTituloNichoPorId(int IdTituloNicho)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                 {
                new SqlParameter("@IDTITULONICHO", IdTituloNicho),
                     };

                return SqlHelper.ExecuteReader(cnx, CommandType.StoredProcedure, "usp_TITULONICHOSelect", parameters).HasRows;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ExisteTituloNichoPorNicho(string CodCuartel, string Letra, int Numero)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[]
                 {
                new SqlParameter("@CODCUARTEL", CodCuartel),
                new SqlParameter("@LETRA",Letra),
                new SqlParameter("@NUMERO",Numero)
                     };

                return SqlHelper.ExecuteReader(cnx, CommandType.StoredProcedure, "USP_VERIFICA_EXISTE_TITULO", parameters).HasRows;
            }
            catch (Exception)
            {
                throw;
            }         
        }

        public List<TituloNicho> ListarTituloNicho()
        {
            using (SqlDataReader dataReader = SqlHelper.ExecuteReader(cnx, CommandType.StoredProcedure, "TITULONICHOSelectAll"))
            {
                List<TituloNicho> tITULONICHOList = new List<TituloNicho>();
                while (dataReader.Read())
                {
                    TituloNicho tITULONICHO = MakeTITULONICHO(dataReader);
                    tITULONICHOList.Add(tITULONICHO);
                }

                return tITULONICHOList;
            }
        }

        protected virtual TituloNicho MakeTITULONICHO(SqlDataReader dataReader)
        {
            TituloNicho tITULONICHO = new TituloNicho();
            tITULONICHO.IDTITULONICHO = SqlClientUtility.GetInt32(dataReader, "IDTITULONICHO", 0);
            tITULONICHO.ESTADO = SqlClientUtility.GetString(dataReader, "ESTADO", String.Empty);
            tITULONICHO.NUMEROTITULO = SqlClientUtility.GetString(dataReader, "NUMEROTITULO", String.Empty);
            tITULONICHO.NUMERODOCUMENTOVENTA = SqlClientUtility.GetString(dataReader, "NUMERODOCUMENTOVENTA", String.Empty);
            tITULONICHO.NOMBRERESPONSABLE = SqlClientUtility.GetString(dataReader, "NOMBRERESPONSABLE", String.Empty);
            tITULONICHO.FECHAINHUMACION = SqlClientUtility.GetDateTime(dataReader, "FECHAINHUMACION", DateTime.Now);
            tITULONICHO.FECHACONCESION = SqlClientUtility.GetDateTime(dataReader, "FECHACONCESION", DateTime.Now);
            tITULONICHO.IDMOTIVO = SqlClientUtility.GetInt32(dataReader, "IDMOTIVO", 0);
            tITULONICHO.OBSERVACIONMOTIVO = SqlClientUtility.GetString(dataReader, "OBSERVACIONMOTIVO", String.Empty);
            tITULONICHO.GENEROTITULO = SqlClientUtility.GetBoolean(dataReader, "GENEROTITULO", false);
            tITULONICHO.RECOGIOTITULO = SqlClientUtility.GetBoolean(dataReader, "RECOGIOTITULO", false);
            tITULONICHO.CEMENTERIO = SqlClientUtility.GetString(dataReader, "CEMENTERIO", String.Empty);
            tITULONICHO.NOMBRECUARTEL = SqlClientUtility.GetString(dataReader, "NOMBRECUARTEL", String.Empty);
            tITULONICHO.LETRAFILANICHO = SqlClientUtility.GetString(dataReader, "LETRAFILANICHO", String.Empty);
            tITULONICHO.NUMEROCOLNICHO = SqlClientUtility.GetInt32(dataReader, "NUMEROCOLNICHO", 0);
            tITULONICHO.CODCUARTEL = SqlClientUtility.GetString(dataReader, "CODCUARTEL", String.Empty);
            tITULONICHO.ANULADO = SqlClientUtility.GetString(dataReader, "ANULADO", String.Empty);
            tITULONICHO.USUARIOING = SqlClientUtility.GetInt32(dataReader, "USUARIOING", 0);
            tITULONICHO.FECHAING = SqlClientUtility.GetDateTime(dataReader, "FECHAING", DateTime.Now);
            tITULONICHO.USUARIOMOD = SqlClientUtility.GetInt32(dataReader, "USUARIOMOD", 0);
            tITULONICHO.FECHAMOD = SqlClientUtility.GetDateTime(dataReader, "FECHAMOD", DateTime.Now);

            return tITULONICHO;
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
