using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Data;
using System.Reflection;
using System.Data.Linq;

namespace DAO_Tesoreria
{
    public class coneLinQ
    {
#region mantenimieto ta_zona

        public DataTable listarZonas(int idZona)
        {
            using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
            {
                var dt = new DataTable();
                try
                {
                    var query = (from zona in cone.ta_zona
                                 join cem in cone.cementerio on zona.intCeId equals cem.intCeId
                                 join tipZona in cone.tipoZona on zona.intTzId equals tipZona.intTzId
                                 where zona.intZId == idZona || 0 == idZona
                                 orderby zona.intZId descending
                                 select new
                                 {
                                     zona.intZId,
                                     tipZona.varTzDescripcion,
                                     zona.varZDescripcion,
                                     zona.bitZEstado,
                                     cem.varCeNombre,
                                     zona.intZnroFilas,
                                     zona.intZnroSepulturas,
                                     zona.intZNivel,
                                     zona.bitZConstruido
                                 });
                    return ToDataTable(query);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public byte insertarActualizarZonas(ta_zona oZona)
        {
            try
            {
                byte retorno = 0;
                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {

                    var matchedata = (from t in cone.GetTable<ta_zona>()
                                      where t.intZId == oZona.intZId
                                      select t).SingleOrDefault();
                    if (matchedata == null)
                    {
                        Table<ta_zona> tablaZona = cone.GetTable<ta_zona>();
                        ta_zona zona = new ta_zona();

                        zona.intTzId = oZona.intTzId;
                        zona.intCeId = oZona.intCeId;
                        zona.intZNivel = oZona.intZNivel;
                        zona.intZnroFilas = oZona.intZnroFilas;
                        zona.varZDescripcion = oZona.varZDescripcion;
                        zona.bitZConstruido = oZona.bitZConstruido;
                        zona.bitZEstado = oZona.bitZEstado;
                        zona.intZnroSepulturas = oZona.intZnroSepulturas;

                        tablaZona.InsertOnSubmit(zona);
                        tablaZona.Context.SubmitChanges();

                        retorno = 1;
                    }
                    else
                    {
                        matchedata.intZId = oZona.intZId;
                        matchedata.intTzId = oZona.intTzId;
                        matchedata.intCeId = oZona.intCeId;
                        matchedata.intZNivel = oZona.intZNivel;
                        matchedata.intZnroFilas = oZona.intZnroFilas;
                        matchedata.varZDescripcion = oZona.varZDescripcion;
                        matchedata.bitZConstruido = oZona.bitZConstruido;
                        matchedata.bitZEstado = oZona.bitZEstado;
                        matchedata.intZnroSepulturas = oZona.intZnroSepulturas;

                        cone.SubmitChanges();

                        retorno = 2;
                    }
                    return retorno;
                }  
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public byte eliminarZonas(ta_zona oZona)
        {
            try
            {
                byte retorno = 0;
                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {
                        ta_zona objZona = cone.ta_zona.Single(zonas => zonas.intZId == oZona.intZId);
                        cone.ta_zona.DeleteOnSubmit(objZona);
                        cone.SubmitChanges();

                        retorno = 1;
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
#endregion

#region mantenimieto ta_tipo_sepultura

        public DataTable listarTipoSepultura()
        {
            using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
            {
                var dt = new DataTable();
                try
                {
                    var query = (from s in cone.ta_tipo_sepultura
                                 orderby s.intTsId descending
                                 select new
                                 {
                                     s.intTsId,
                                     s.varTsDescripcion,
                                     s.varTsObservacion
                                 });
                    return ToDataTable(query);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public byte insertarActualizarTipoSepultura(ta_tipo_sepultura oTipSepultura)
        {
            try
            {
                byte retorno = 0;
                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {

                    var matchedata = (from t in cone.GetTable<ta_tipo_sepultura>()
                                      where t.intTsId == oTipSepultura.intTsId
                                      select t).SingleOrDefault();
                    if (matchedata == null)
                    {
                        Table<ta_tipo_sepultura> tablaZona = cone.GetTable<ta_tipo_sepultura>();
                        ta_tipo_sepultura tipSepultura = new ta_tipo_sepultura();

                        tipSepultura.intTsId = oTipSepultura.intTsId;
                        tipSepultura.varTsDescripcion = oTipSepultura.varTsDescripcion;
                        tipSepultura.varTsObservacion = oTipSepultura.varTsObservacion;

                        tablaZona.InsertOnSubmit(tipSepultura);
                        tablaZona.Context.SubmitChanges();

                        retorno = 1;
                    }
                    else
                    {
                        matchedata.intTsId = oTipSepultura.intTsId;
                        matchedata.varTsDescripcion = oTipSepultura.varTsDescripcion;
                        matchedata.varTsObservacion = oTipSepultura.varTsObservacion;

                        cone.SubmitChanges();

                        retorno = 2;
                    }
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte eliminarTipoSepultura(ta_tipo_sepultura oTipSepultura)
        {
            try
            {
                byte retorno = 0;

                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {
                    ta_tipo_sepultura objTipSepu = cone.ta_tipo_sepultura.Single(tipSepu => tipSepu.intTsId == oTipSepultura.intTsId);
                    cone.ta_tipo_sepultura.DeleteOnSubmit(objTipSepu);
                    cone.SubmitChanges();

                    retorno = 1;
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }      
#endregion

#region mantenimieto ta_tipoMausoleo

        public DataTable listarTipoMausoleo()
        {
            using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
            {
                var dt = new DataTable();
                try
                {
                    var query = (from s in cone.ta_TipoMausoleo
                                 orderby s.intTipMauId descending
                                 select new
                                 {
                                     s.intTipMauId,
                                     s.varTipMauDescripcion,
                                 });
                    return ToDataTable(query);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public byte insertarActualizarTipoMausoleo(ta_TipoMausoleo oTipoMauso)
        {
            try
            {
                byte retorno = 0;
                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {

                    var matchedata = (from t in cone.GetTable<ta_TipoMausoleo>()
                                      where t.intTipMauId == oTipoMauso.intTipMauId
                                      select t).SingleOrDefault();
                    if (matchedata == null)
                    {
                        Table<ta_TipoMausoleo> tablaTipoMau = cone.GetTable<ta_TipoMausoleo>();
                        ta_TipoMausoleo tipMausoleo = new ta_TipoMausoleo();

                        tipMausoleo.intTipMauId = oTipoMauso.intTipMauId;
                        tipMausoleo.varTipMauDescripcion = oTipoMauso.varTipMauDescripcion;

                        tablaTipoMau.InsertOnSubmit(tipMausoleo);
                        tablaTipoMau.Context.SubmitChanges();

                        retorno = 1;
                    }
                    else
                    {
                        matchedata.intTipMauId = oTipoMauso.intTipMauId;
                        matchedata.varTipMauDescripcion = oTipoMauso.varTipMauDescripcion;

                        cone.SubmitChanges();

                        retorno = 2;
                    }
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte eliminarTipoMausoleo(ta_TipoMausoleo oTipMau)
        {
            try
            {
                byte retorno = 0;

                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {
                    ta_TipoMausoleo objTipMau = cone.ta_TipoMausoleo.Single(tipSepu => tipSepu.intTipMauId == oTipMau.intTipMauId);
                    cone.ta_TipoMausoleo.DeleteOnSubmit(objTipMau);
                    cone.SubmitChanges();

                    retorno = 1;
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

#region mantenimieto ta_serviciosFunerarios

        public DataTable listarTipServFun()
        {
            using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
            {
                var dt = new DataTable();
                try
                {
                    var query = (from s in cone.ta_serviciosFunerarios
                                 orderby s.intServFunId descending
                                 select new
                                 {
                                     s.intServFunId,
                                     s.varServFunDescripcion,
                                 });
                    return ToDataTable(query);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public byte insertarActualizarlistarTipServFun(ta_serviciosFunerarios oTipoSerFun)
        {
            try
            {
                byte retorno = 0;
                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {

                    var matchedata = (from t in cone.GetTable<ta_serviciosFunerarios>()
                                      where t.intServFunId == oTipoSerFun.intServFunId
                                      select t).SingleOrDefault();
                    if (matchedata == null)
                    {
                        Table<ta_serviciosFunerarios> tablaTipoServFun = cone.GetTable<ta_serviciosFunerarios>();
                        ta_serviciosFunerarios tipServFun = new ta_serviciosFunerarios();

                        tipServFun.intServFunId = oTipoSerFun.intServFunId;
                        tipServFun.varServFunDescripcion = oTipoSerFun.varServFunDescripcion;

                        tablaTipoServFun.InsertOnSubmit(tipServFun);
                        tablaTipoServFun.Context.SubmitChanges();

                        retorno = 1;
                    }
                    else
                    {
                        matchedata.intServFunId = oTipoSerFun.intServFunId;
                        matchedata.varServFunDescripcion = oTipoSerFun.varServFunDescripcion;

                        cone.SubmitChanges();

                        retorno = 2;
                    }
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte eliminarTipServFun(ta_serviciosFunerarios oTipoSerFun)
        {
            try
            {
                byte retorno = 0;

                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {
                    ta_serviciosFunerarios objTipServFun = cone.ta_serviciosFunerarios.Single(tipServFun => tipServFun.intServFunId == oTipoSerFun.intServFunId);
                    cone.ta_serviciosFunerarios.DeleteOnSubmit(objTipServFun);
                    cone.SubmitChanges();

                    retorno = 1;
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

#region mantenimieto Ta_TipoDocVenta

        public DataTable listarTipDocVenta()
        {
            using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
            {
                var dt = new DataTable();
                try
                {
                    var query = (from s in cone.Ta_TipoDocVenta
                                 orderby s.Cod_TipoDocVenta descending
                                 select new
                                 {
                                     s.Cod_TipoDocVenta,
                                     s.Desc_TipoDocVenta,
                                     s.Flag_Comprob,
                                     s.Flag_Ruc,
                                     s.flag_impuesto,
                                     s.flag_autoimpresion,
                                     s.nro_serie_ult,
                                     s.nro_comprobante_ult
                                 });
                    return ToDataTable(query);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public byte insertarActualizarlistarTipDocVenta(Ta_TipoDocVenta oTipoDocVenta)
        {
            try
            {
                byte retorno = 0;
                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {

                    var matchedata = (from t in cone.GetTable<Ta_TipoDocVenta>()
                                      where t.Cod_TipoDocVenta == oTipoDocVenta.Cod_TipoDocVenta
                                      select t).SingleOrDefault();
                    if (matchedata == null)
                    {
                        Table<Ta_TipoDocVenta> tablaTipoServFun = cone.GetTable<Ta_TipoDocVenta>();
                        Ta_TipoDocVenta tipDocVenta = new Ta_TipoDocVenta();

                        tipDocVenta.Cod_TipoDocVenta = oTipoDocVenta.Cod_TipoDocVenta;
                        tipDocVenta.Desc_TipoDocVenta = oTipoDocVenta.Desc_TipoDocVenta;
                        tipDocVenta.Flag_Comprob = oTipoDocVenta.Flag_Comprob;
                        tipDocVenta.flag_autoimpresion = oTipoDocVenta.flag_autoimpresion;
                        tipDocVenta.flag_impuesto = oTipoDocVenta.flag_impuesto;
                        tipDocVenta.Flag_Ruc = oTipoDocVenta.Flag_Ruc;
                        tipDocVenta.nro_serie_ult = oTipoDocVenta.nro_serie_ult;
                        tipDocVenta.nro_comprobante_ult = oTipoDocVenta.nro_comprobante_ult;

                        tablaTipoServFun.InsertOnSubmit(tipDocVenta);
                        tablaTipoServFun.Context.SubmitChanges();

                        retorno = 1;
                    }
                    else
                    {
                        matchedata.Cod_TipoDocVenta = oTipoDocVenta.Cod_TipoDocVenta;
                        matchedata.Desc_TipoDocVenta = oTipoDocVenta.Desc_TipoDocVenta;
                        matchedata.Flag_Comprob = oTipoDocVenta.Flag_Comprob;
                        matchedata.flag_autoimpresion = oTipoDocVenta.flag_autoimpresion;
                        matchedata.flag_impuesto = oTipoDocVenta.flag_impuesto;
                        matchedata.Flag_Ruc = oTipoDocVenta.Flag_Ruc;
                        matchedata.nro_serie_ult = oTipoDocVenta.nro_serie_ult;
                        matchedata.nro_comprobante_ult = oTipoDocVenta.nro_comprobante_ult;

                        cone.SubmitChanges();

                        retorno = 2;
                    }
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte eliminarTipDocVenta(Ta_TipoDocVenta oTipoDocVenta)
        {
            try
            {
                byte retorno = 0;

                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {
                    Ta_TipoDocVenta objTipDocVenta = cone.Ta_TipoDocVenta.Single(tipDocVentas => tipDocVentas.Cod_TipoDocVenta == oTipoDocVenta.Cod_TipoDocVenta);
                    cone.Ta_TipoDocVenta.DeleteOnSubmit(objTipDocVenta);
                    cone.SubmitChanges();

                    retorno = 1;
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region mantenimieto ta_modalidad_pago

        public DataTable listarModPag()
        {
            using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
            {
                var dt = new DataTable();
                try
                {
                    var query = (from s in cone.ta_modalidad_pago
                                 orderby s.cod_mod_Pago descending
                                 select new
                                 {
                                     s.cod_mod_Pago,
                                     s.desc_mod_Pago,
                                     s.obs_mod_pagp,
                                     s.intMoId
                                 });
                    return ToDataTable(query);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public byte insertarActualizarModPago(ta_modalidad_pago oModPag)
        {
            try
            {
                byte retorno = 0;
                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {

                    var matchedata = (from t in cone.GetTable<ta_modalidad_pago>()
                                      where t.cod_mod_Pago == oModPag.cod_mod_Pago
                                      select t).SingleOrDefault();
                    if (matchedata == null)
                    {
                        Table<ta_modalidad_pago> tablaModPago = cone.GetTable<ta_modalidad_pago>();
                        ta_modalidad_pago ModPago = new ta_modalidad_pago();

                        ModPago.cod_mod_Pago = oModPag.cod_mod_Pago;
                        ModPago.desc_mod_Pago = oModPag.desc_mod_Pago;
                        ModPago.obs_mod_pagp = oModPag.obs_mod_pagp;

                        if (oModPag.intMoId == 0)
                        {
                            ModPago.intMoId = null;
                        }
                        else
                        {
                            ModPago.intMoId = oModPag.intMoId;
                        }

                        tablaModPago.InsertOnSubmit(ModPago);
                        tablaModPago.Context.SubmitChanges();

                        retorno = 1;
                    }
                    else
                    {
                        matchedata.cod_mod_Pago = oModPag.cod_mod_Pago;
                        matchedata.desc_mod_Pago = oModPag.desc_mod_Pago;
                        matchedata.obs_mod_pagp = oModPag.obs_mod_pagp;

                        if (oModPag.intMoId == 0)
                        {
                            matchedata.intMoId = null;
                        }
                        else
                        {
                            matchedata.intMoId = oModPag.intMoId;
                        }

                        cone.SubmitChanges();

                        retorno = 2;
                    }
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte eliminarModPago(ta_modalidad_pago oModPag)
        {
            try
            {
                byte retorno = 0;

                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {
                    ta_modalidad_pago objModPago = cone.ta_modalidad_pago.Single(ModPago => ModPago.cod_mod_Pago == oModPag.cod_mod_Pago);
                    cone.ta_modalidad_pago.DeleteOnSubmit(objModPago);
                    cone.SubmitChanges();

                    retorno = 1;
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region mantenimieto ta_entidad_financiera

        public DataTable listarEntFin()
        {
            using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
            {
                var dt = new DataTable();
                try
                {
                    var query = (from s in cone.ta_entidad_financiera
                                 orderby s.cod_entidad_financ descending
                                 select new
                                 {
                                     s.cod_entidad_financ,
                                     s.nombre_entidad,
                                     s.obs_entidad
                                 });
                    return ToDataTable(query);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public byte insertarActualizarEntFin(ta_entidad_financiera oEntFin)
        {
            try
            {
                byte retorno = 0;
                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {

                    var matchedata = (from t in cone.GetTable<ta_entidad_financiera>()
                                      where t.cod_entidad_financ == oEntFin.cod_entidad_financ
                                      select t).SingleOrDefault();
                    if (matchedata == null)
                    {
                        Table<ta_entidad_financiera> tablaEntFin = cone.GetTable<ta_entidad_financiera>();
                        ta_entidad_financiera EntFin = new ta_entidad_financiera();

                        EntFin.cod_entidad_financ = oEntFin.cod_entidad_financ;
                        EntFin.nombre_entidad = oEntFin.nombre_entidad;
                        EntFin.obs_entidad = oEntFin.obs_entidad;

                        tablaEntFin.InsertOnSubmit(EntFin);
                        tablaEntFin.Context.SubmitChanges();

                        retorno = 1;
                    }
                    else
                    {
                        matchedata.cod_entidad_financ = oEntFin.cod_entidad_financ;
                        matchedata.nombre_entidad = oEntFin.nombre_entidad;
                        matchedata.obs_entidad = oEntFin.obs_entidad;

                        cone.SubmitChanges();

                        retorno = 2;
                    }
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte eliminarEntFin(ta_entidad_financiera oEntFin)
        {
            try
            {
                byte retorno = 0;

                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {
                    ta_entidad_financiera objEntFin = cone.ta_entidad_financiera.Single(EntFin => EntFin.cod_entidad_financ == oEntFin.cod_entidad_financ);
                    cone.ta_entidad_financiera.DeleteOnSubmit(objEntFin);
                    cone.SubmitChanges();

                    retorno = 1;
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region mantenimieto tb_cuenta_bancaria

        public DataTable listarCtaBancaria(string filtro)
        {
            using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
            {
                var dt = new DataTable();
                try
                {
                    var query = (from ctaba in cone.tb_cuenta_bancaria join mo in cone.moneda on ctaba.intMoId equals mo.intMoId
                                 join ctable in cone.tb_cta_contable on ctaba.id_cuenta_contable equals ctable.id_cuenta_contable
                                 join banc in cone.ta_entidad_financiera on ctaba.cod_entidad_financ equals banc.cod_entidad_financ
                                 where ctable.codigoCuenta.Contains(filtro)
                                 orderby ctaba.cuenta_bancaria_id descending
                                 select new
                                 {
                                     ctaba.cuenta_bancaria_id,
                                     banc.nombre_entidad,
                                     ctaba.numero_cuenta,
                                     ctable.codigoCuenta,
                                     mo.varMoDescripcion
                                 });
                    return ToDataTable(query);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public byte insertarActualizarCtaBanc(tb_cuenta_bancaria oCtaBanc)
        {
            try
            {
                byte retorno = 0;
                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {
                    var matchedata = (from t in cone.GetTable<tb_cuenta_bancaria>()
                                      where t.cuenta_bancaria_id == oCtaBanc.cuenta_bancaria_id
                                      select t).SingleOrDefault();
                    if (matchedata == null)
                    {
                        Table<tb_cuenta_bancaria> tablaCtaBanc = cone.GetTable<tb_cuenta_bancaria>();
                        tb_cuenta_bancaria CtaBanc = new tb_cuenta_bancaria();

                        CtaBanc.cuenta_bancaria_id = oCtaBanc.cod_entidad_financ;
                        CtaBanc.cod_entidad_financ = oCtaBanc.cod_entidad_financ;
                        CtaBanc.numero_cuenta = oCtaBanc.numero_cuenta;
                        CtaBanc.id_cuenta_contable=oCtaBanc.id_cuenta_contable;
                        CtaBanc.intMoId = oCtaBanc.intMoId;
                        CtaBanc.usuario_ingresa = oCtaBanc.usuario_ingresa;
                        CtaBanc.fecha_ingresa = cone.GetSystemDate();
                        CtaBanc.nombre_host_ip_ing = oCtaBanc.nombre_host_ip_ing;

                        tablaCtaBanc.InsertOnSubmit(CtaBanc);
                        tablaCtaBanc.Context.SubmitChanges();

                        retorno = 1;
                    }
                    else
                    {
                        insertarAuditCtaBanc(consultaCtaBanc(oCtaBanc.cuenta_bancaria_id), oCtaBanc.usuario_modifica, oCtaBanc.nombre_host_ip_mod, "U");

                        matchedata.cuenta_bancaria_id = oCtaBanc.cuenta_bancaria_id;
                        matchedata.cod_entidad_financ = oCtaBanc.cod_entidad_financ;
                        matchedata.numero_cuenta = oCtaBanc.numero_cuenta;
                        matchedata.id_cuenta_contable = oCtaBanc.id_cuenta_contable;
                        matchedata.intMoId = oCtaBanc.intMoId;
                        matchedata.usuario_modifica = oCtaBanc.usuario_modifica;
                        matchedata.fecha_modifica = cone.GetSystemDate();
                        matchedata.nombre_host_ip_mod = oCtaBanc.nombre_host_ip_mod;

                        cone.SubmitChanges();

                        retorno = 2;
                    }
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte eliminarCtaBanc(tb_cuenta_bancaria oCtaBanc,string host)
        {
            try
            {
                byte retorno = 0;

                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {
                    insertarAuditCtaBanc(consultaCtaBanc(oCtaBanc.cuenta_bancaria_id),oCtaBanc.usuario_modifica,host,"D");

                    tb_cuenta_bancaria objCtaBanc = cone.tb_cuenta_bancaria.Single(EntFin => EntFin.cuenta_bancaria_id == oCtaBanc.cuenta_bancaria_id);
                    cone.tb_cuenta_bancaria.DeleteOnSubmit(objCtaBanc);
                    cone.SubmitChanges();

                    retorno = 1;
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte insertarAuditCtaBanc(DataTable dtCtaBanc,string usuarioElimina,string host,string accion)
        {
            try
            {
                byte retorno = 0;
                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {

                    Table<tb_cuenta_bancaria_audit> tablaCtaBancAudit = cone.GetTable<tb_cuenta_bancaria_audit>();
                    tb_cuenta_bancaria_audit CtaBancAudit = new tb_cuenta_bancaria_audit();
                    
                    DataRow dtr = dtCtaBanc.Rows[0];

                    CtaBancAudit.cuenta_bancaria_id = Convert.ToInt32(dtr["cuenta_bancaria_id"]);
                    CtaBancAudit.nombre_entidad = (dtr["nombre_entidad"] == System.DBNull.Value) ? "" : dtr["nombre_entidad"].ToString();
                    CtaBancAudit.numero_cuenta = (dtr["numero_cuenta"] == System.DBNull.Value) ? "" : dtr["numero_cuenta"].ToString();
                    CtaBancAudit.codigo_cuenta_contable = (dtr["codigoCuenta"] == System.DBNull.Value) ? "" : dtr["codigoCuenta"].ToString();
                    CtaBancAudit.varMoDescripcion = (dtr["varMoDescripcion"] == System.DBNull.Value) ? "" : dtr["varMoDescripcion"].ToString();
                    CtaBancAudit.usuario_ingresa = (dtr["usuario_ingresa"] == System.DBNull.Value) ? "" : dtr["usuario_ingresa"].ToString();
                    CtaBancAudit.usuario_modifica = (dtr["usuario_modifica"] == System.DBNull.Value) ? "" : dtr["usuario_modifica"].ToString();

                    if (dtr["fecha_ingresa"] != System.DBNull.Value)
                    {
                        CtaBancAudit.fecha_ingresa = Convert.ToDateTime(dtr["fecha_ingresa"]);
                    }
                    else
                    {
                        CtaBancAudit.fecha_ingresa = null;
                    }
                    if (dtr["fecha_modifica"] != System.DBNull.Value)
                    {
                        CtaBancAudit.fecha_modifica = Convert.ToDateTime(dtr["fecha_modifica"]);
                    }
                    else
                    {
                        CtaBancAudit.fecha_modifica = null;
                    }
                    CtaBancAudit.nombre_host_ip_ing = (dtr["nombre_host_ip_ing"] == System.DBNull.Value) ? "" : dtr["nombre_host_ip_ing"].ToString();
                    CtaBancAudit.nombre_host_ip_mod = (dtr["nombre_host_ip_mod"] == System.DBNull.Value) ? "" : dtr["nombre_host_ip_mod"].ToString();

                    if (dtr["actividad"] != System.DBNull.Value)
                    {
                        CtaBancAudit.actividad = Convert.ToChar(dtr["actividad"]);
                    }
                    else
                    {
                        CtaBancAudit.actividad = null;
                    }
                    CtaBancAudit.usuario_accion = usuarioElimina;
                    CtaBancAudit.nombre_host_ip_accion = host;
                    CtaBancAudit.fecha_accion = cone.GetSystemDate();
                    CtaBancAudit.accion = Convert.ToChar(accion);

                    tablaCtaBancAudit.InsertOnSubmit(CtaBancAudit);
                    tablaCtaBancAudit.Context.SubmitChanges();

                        retorno = 1;

                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable consultaCtaBanc(int ID)
        {
            using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
            {
                var dt = new DataTable();
                try
                {
                    var query = (from ctaba in cone.tb_cuenta_bancaria
                                 join mo in cone.moneda on ctaba.intMoId equals mo.intMoId
                                 join ctable in cone.tb_cta_contable on ctaba.id_cuenta_contable equals ctable.id_cuenta_contable
                                 join banc in cone.ta_entidad_financiera on ctaba.cod_entidad_financ equals banc.cod_entidad_financ
                                 where ctaba.cuenta_bancaria_id == ID
                                 orderby ctaba.cuenta_bancaria_id descending
                                 select new
                                 {
                                     ctaba.cuenta_bancaria_id,
                                     banc.nombre_entidad,
                                     ctaba.numero_cuenta,
                                     ctable.codigoCuenta,
                                     mo.varMoDescripcion,
                                     ctaba.actividad,
                                     ctaba.usuario_ingresa,
                                     ctaba.usuario_modifica,
                                     ctaba.fecha_ingresa,
                                     ctaba.fecha_modifica,
                                     ctaba.nombre_host_ip_ing,
                                     ctaba.nombre_host_ip_mod

                                 });
                    return ToDataTable(query);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        #endregion

        #region mantenimieto tb_cta_contable

        public DataTable listarCtaContable(string filtro)
        {
            using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
            {
                var dt = new DataTable();
                try
                {
                    var query = (from ctacon in cone.tb_cta_contable
                                 where ctacon.codigoCuenta.Contains(filtro)
                                 orderby ctacon.id_cuenta_contable descending
                                 select new
                                 {
                                     ctacon.id_cuenta_contable,
                                     ctacon.descripcionCuenta,
                                     ctacon.codigoCuenta
                                 });
                    return ToDataTable(query);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public byte insertarActualizarCtaContable(tb_cta_contable oCtaConta)
        {
            try
            {
                byte retorno = 0;
                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {
                    var matchedata = (from t in cone.GetTable<tb_cta_contable>()
                                      where t.id_cuenta_contable == oCtaConta.id_cuenta_contable
                                      select t).SingleOrDefault();
                    if (matchedata == null)
                    {
                        Table<tb_cta_contable> tablaCtaConta = cone.GetTable<tb_cta_contable>();
                        tb_cta_contable CtaConta = new tb_cta_contable();

                        CtaConta.id_cuenta_contable = oCtaConta.id_cuenta_contable;
                        CtaConta.codigoCuenta = oCtaConta.codigoCuenta;
                        CtaConta.descripcionCuenta = oCtaConta.descripcionCuenta;
                        CtaConta.usuario_ing = oCtaConta.usuario_ing;
                        CtaConta.fecha_ing = cone.GetSystemDate();
                        CtaConta.pc_ing = oCtaConta.pc_ing;

                        tablaCtaConta.InsertOnSubmit(CtaConta);
                        tablaCtaConta.Context.SubmitChanges();

                        retorno = 1;
                    }
                    else
                    {
                        insertarAuditCtaCont(consultaCtaCont(oCtaConta.id_cuenta_contable), oCtaConta.usuario_mod, oCtaConta.pc_mod, "U");

                        matchedata.id_cuenta_contable = oCtaConta.id_cuenta_contable;
                        matchedata.codigoCuenta = oCtaConta.codigoCuenta;
                        matchedata.descripcionCuenta = oCtaConta.descripcionCuenta;
                        matchedata.usuario_mod = oCtaConta.usuario_ing;
                        matchedata.fecha_mod = cone.GetSystemDate();
                        matchedata.pc_mod = oCtaConta.pc_ing;

                        cone.SubmitChanges();

                        retorno = 2;
                    }
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte eliminarCtaCont(tb_cta_contable oCtaCont, string host)
        {
            try
            {
                byte retorno = 0;

                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {
                    insertarAuditCtaCont(consultaCtaCont(oCtaCont.id_cuenta_contable), oCtaCont.usuario_mod, host, "D");

                    tb_cta_contable objCtaCont = cone.tb_cta_contable.Single(EntFin => EntFin.id_cuenta_contable == oCtaCont.id_cuenta_contable);
                    cone.tb_cta_contable.DeleteOnSubmit(objCtaCont);
                    cone.SubmitChanges();

                    retorno = 1;
                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public byte insertarAuditCtaCont(DataTable dtCtaCont, string usuarioAccion, string host, string accion)
        {
            try
            {
                byte retorno = 0;
                using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
                {

                    Table<tb_cuenta_contable_audit> tablaCtaContAudit = cone.GetTable<tb_cuenta_contable_audit>();
                    tb_cuenta_contable_audit CtaContcAudit = new tb_cuenta_contable_audit();

                    DataRow dtr = dtCtaCont.Rows[0];

                    CtaContcAudit.id_cuenta_contable = Convert.ToInt32(dtr["id_cuenta_contable"]);
                    CtaContcAudit.codigo_cuenta_contable = (dtr["codigoCuenta"] == System.DBNull.Value) ? "" : dtr["codigoCuenta"].ToString();
                    CtaContcAudit.descrip_cuenta_contable = (dtr["descrip_cuenta_contable"] == System.DBNull.Value) ? "" : dtr["descrip_cuenta_contable"].ToString();
                    CtaContcAudit.usuario_modi_cuenta_contable = (dtr["usuario_modi_cuenta_contable"] == System.DBNull.Value) ? "" : dtr["usuario_modi_cuenta_contable"].ToString();
                    CtaContcAudit.usuario_ing_cuenta_contable = (dtr["usuario_ing_cuenta_contable"] == System.DBNull.Value) ? "" : dtr["usuario_ing_cuenta_contable"].ToString();

                    if (dtr["fecha_modi_cuenta_contable"] != System.DBNull.Value)
                    {
                        CtaContcAudit.fecha_modi_cuenta_contable = Convert.ToDateTime(dtr["fecha_modi_cuenta_contable"]);
                    }
                    else
                    {
                        CtaContcAudit.fecha_modi_cuenta_contable = null;
                    }
                    if (dtr["fecha_ing_cuenta_contable"] != System.DBNull.Value)
                    {
                        CtaContcAudit.fecha_ing_cuenta_contable = Convert.ToDateTime(dtr["fecha_ing_cuenta_contable"]);
                    }
                    else
                    {
                        CtaContcAudit.fecha_ing_cuenta_contable = null;
                    }
                    CtaContcAudit.nombre_host_ip_ing = (dtr["nombre_host_ip_ing"] == System.DBNull.Value) ? "" : dtr["nombre_host_ip_ing"].ToString();
                    CtaContcAudit.nombre_host_ip_mod = (dtr["nombre_host_ip_mod"] == System.DBNull.Value) ? "" : dtr["nombre_host_ip_mod"].ToString();

                    CtaContcAudit.usuario_accion = usuarioAccion;
                    CtaContcAudit.nombre_host_ip_accion = host;
                    CtaContcAudit.fecha_accion = cone.GetSystemDate();
                    CtaContcAudit.accion = Convert.ToChar(accion);

                    tablaCtaContAudit.InsertOnSubmit(CtaContcAudit);
                    tablaCtaContAudit.Context.SubmitChanges();

                    retorno = 1;

                    return retorno;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable consultaCtaCont(int ID)
        {
            using (TesoreriaDBDataContext cone = new TesoreriaDBDataContext())
            {
                var dt = new DataTable();
                try
                {
                    var query = (from ctacon in cone.tb_cta_contable
                                 where ctacon.id_cuenta_contable==ID
                                 orderby ctacon.id_cuenta_contable descending
                                 select new
                                 {
                                     ctacon.id_cuenta_contable,
                                     ctacon.descripcionCuenta,
                                     ctacon.codigoCuenta,
                                     ctacon.usuario_mod,
                                     ctacon.fecha_mod,
                                     ctacon.usuario_ing,
                                     ctacon.fecha_ing,   
                                     ctacon.pc_ing,
                                     ctacon.pc_mod

                                 });
                    return ToDataTable(query);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        #endregion

        private DataTable ToDataTable<T>(IEnumerable<T> l_oItems)
        {
            DataTable oReturn = new DataTable(typeof(T).Name);
            object[] a_oValues;
            int i;

            PropertyInfo[] a_oProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo oProperty in a_oProperties)
            {
                oReturn.Columns.Add(oProperty.Name, BaseType(oProperty.PropertyType));
            }

            foreach (T oItem in l_oItems)
            {
                a_oValues = new object[a_oProperties.Length];

                for (i = 0; i < a_oProperties.Length; i++)
                {
                    a_oValues[i] = a_oProperties[i].GetValue(oItem, null);
                }

                oReturn.Rows.Add(a_oValues);
            }
            return oReturn;
        }

        public static Type BaseType(Type oType)
        {
            if (oType != null && oType.IsValueType &&
                oType.IsGenericType && oType.GetGenericTypeDefinition() == typeof(Nullable<>)
            )
            {
                return Nullable.GetUnderlyingType(oType);
            }
            else
            {
                return oType;
            }
        }
    }
}
