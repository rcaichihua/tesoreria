using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Tesoreria
{
    public static class Databases
    {
        /// <summary>
        /// Exporta una expresión Sql a formato Dbf (dBase III)
        /// </summary>
        /// <param name="cadenaConexion">Cadena de conexión con el servidor SQL</param>
        /// <param name="sql">Secuencia Select SQL para exportar</param>
        /// <param name="ficheroSalida">Nombre completo del fichero que se creará</param>
        /// <returns>true si la exportación es correcta</returns>
        public static bool Sql2Dbf(string cadenaConexion, string sql, string ficheroSalida,string tipo)
        {
            DbProviderFactory factoria = DbProviderFactories.GetFactory("System.Data.SqlClient");
            return Databases.Db2Dbf(factoria, cadenaConexion, sql, ficheroSalida,tipo);
        }


        /// <summary>
        /// Exporta una expresión Sql a formato Dbf (dBase III)
        /// </summary>
        /// <param name="factoria">Factoría de System.Data.Common en el que se encuentra el formato de origen</param>
        /// <param name="cadenaConexion">Cadena de conexión con la base de datos de origen</param>
        /// <param name="sql">Secuencia Select SQL para exportar</param>
        /// <param name="ficheroSalida">Nombre completo del fichero que se creará</param>
        /// <returns>true si la exportación es correcta</returns>
        public static bool Db2Dbf(DbProviderFactory factoria, string cadenaConexion, string sql, string ficheroSalida,string tipo)
        {
            bool retval;
            DatabaseToDbf export = new DatabaseToDbf(factoria, cadenaConexion, sql, ficheroSalida,tipo);
            retval = export.Exporta(tipo);
            return retval;
        }
    }
}
