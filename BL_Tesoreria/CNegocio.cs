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
        //public string TraerServidor()
        //{
        //    return objx.TraerServidor();
        //}
        public string TraerServidorSGI(string srv, string bd, string us, string pw)
        {
            return objx.TraerServidorSGI(srv, bd, us, pw);
        }
        public string TraerServidorSisIngresos(string srv, string bd, string us, string pw)
        {
            return objx.TraerServidor(srv, bd, us, pw);
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

        public DataSet IngresaRecibo(string ProcedimientoAlmacenado, bool estado, DataTable dtCabecera,DataTable dtCabeceraDetalle,DataTable modalidadPago)
        {
            try
            {
                return objx.IngresaRecibo(ProcedimientoAlmacenado, estado, dtCabecera, dtCabeceraDetalle, modalidadPago);
            }
            catch (Exception) { throw; }
        }

        public DataSet GeneraCuotasRecibosCaja(string ProcedimientoAlmacenado, DataTable dtDetalleCuotas)
        {
            try
            {
                return objx.GeneraCuotasRecibosCaja(ProcedimientoAlmacenado, dtDetalleCuotas);
            }
            catch (Exception) { throw; }
        }

        public DataSet ActualizaModalidadPago(string ProcedimientoAlmacenado,int ReciboId,int cod_mod_pago,int concep_cod,string FechaDeposito,
            string cod_entidad_financ,string cuenta_bancaria_id,decimal importe_voucher_pago,decimal TipoCambio,decimal importe_cambio,
            string NumeroDocumento_Voucher_cheque_pago,string ObservacionPago,string dtpFechaCancelacion,
            DataTable modalidadPago)
        {
            try
            {
                return objx.ActualizaModalidadPago(ProcedimientoAlmacenado,ReciboId,cod_mod_pago, concep_cod, FechaDeposito,
            cod_entidad_financ, cuenta_bancaria_id, importe_voucher_pago, TipoCambio, importe_cambio,
            NumeroDocumento_Voucher_cheque_pago, ObservacionPago, dtpFechaCancelacion, modalidadPago);
            }
            catch (Exception) { throw; }
        }

        public DataSet IngresaReciboPrincipal(string ProcedimientoAlmacenado, DataTable dtCabecera, DataTable dtCabeceraDetalle)
        {
            try
            {
                return objx.IngresaReciboPrincipal(ProcedimientoAlmacenado, dtCabecera, dtCabeceraDetalle);
            }
            catch (Exception) { throw; }
        }

        public DataSet ActualizaReciboPrincipal(string ProcedimientoAlmacenado, int IdRecibo, DataTable dtCabecera, DataTable dtCabeceraDetalle)
        {
            try
            {
                return objx.ActualizaReciboPrincipal(ProcedimientoAlmacenado, IdRecibo, dtCabecera, dtCabeceraDetalle);
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

        public DataSet IngresarLiquiApi(string ProcedimientoAlmacenado, int nroLiq,string usu ,string pc, DataTable dtLiqui,int idLiq)
        {
            try
            {
                return objx.IngresarLiquiApi(ProcedimientoAlmacenado, nroLiq,usu,pc,dtLiqui, idLiq);
            }
            catch (Exception) { throw; }
        }
    }
}
