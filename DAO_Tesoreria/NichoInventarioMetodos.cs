using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using I_Tesoreria;
using BE_Tesoreria;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace DAO_Tesoreria
{
    class NichoInventarioMetodos : INichoInventario, IDisposable
    {
        string cnx = Properties.Settings.Default.BDTESORERIAConnectionString;

        public int ActualizaEstadoGabineteNichoInventario(int IdnichoInventario)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@",IdnichoInventario)
            };
            return SqlHelper.ExecuteNonQuery(cnx,System.Data.CommandType.StoredProcedure, "", parameters);
        }

        public int AgregarNichoInventario(NichoInventario nichoInventario)
        {
            throw new NotImplementedException();
        }

        public NichoInventario BuscarNichoInventario(int IdnichoInventario)
        {
            throw new NotImplementedException();
        }

        public int EditarNichoInventario(NichoInventario nichoInventario)
        {
            throw new NotImplementedException();
        }

        public bool ExisteNichoInventario(int IdnichoInventario)
        {
            throw new NotImplementedException();
        }

        public List<NichoInventario> ListaNichoInventario()
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Para detectar llamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: elimine el estado administrado (objetos administrados).
                }

                // TODO: libere los recursos no administrados (objetos no administrados) y reemplace el siguiente finalizador.
                // TODO: configure los campos grandes en nulos.

                disposedValue = true;
            }
        }

        // TODO: reemplace un finalizador solo si el anterior Dispose(bool disposing) tiene código para liberar los recursos no administrados.
        // ~NichoInventarioMetodos() {
        //   // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
        //   Dispose(false);
        // }

        // Este código se agrega para implementar correctamente el patrón descartable.
        public void Dispose()
        {
            // No cambie este código. Coloque el código de limpieza en el anterior Dispose(colocación de bool).
            Dispose(true);
            // TODO: quite la marca de comentario de la siguiente línea si el finalizador se ha reemplazado antes.
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
