using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO_Tesoreria;

namespace BL_Tesoreria
{
    public class CapaNegocioLinQ
    {
        coneLinQ cn = new coneLinQ();
        
#region tabla ta_zona
    public DataTable listarZonas(int idZona)
    {
        return cn.listarZonas(idZona);
    }
    public byte insertarActualizarZonas(ta_zona zona)
    {
        return cn.insertarActualizarZonas(zona);
    }
    public byte eliminarZonas(ta_zona zona)
    {
        return cn.eliminarZonas(zona);
    }
#endregion

#region tabla ta_tipo_sepultura
    public DataTable listarTipoSepultura()
    {
        return cn.listarTipoSepultura();
    }
    public byte insertarActualizarTipoSepultura(ta_tipo_sepultura tipSepu)
    {
        return cn.insertarActualizarTipoSepultura(tipSepu);
    }
    public byte eliminarTipoSepultura(ta_tipo_sepultura tipSepu)
    {
        return cn.eliminarTipoSepultura(tipSepu);
    }
#endregion

#region tabla ta_tipo_Mausoleo
    public DataTable listarTipoMausoleo()
    {
        return cn.listarTipoMausoleo();
    }
    public byte insertarActualizarTipoMausoleo(ta_TipoMausoleo tipMau)
    {
        return cn.insertarActualizarTipoMausoleo(tipMau);
    }
    public byte eliminarTipoMausoleo(ta_TipoMausoleo tipMau)
    {
        return cn.eliminarTipoMausoleo(tipMau);
    }
#endregion

#region tabla ta_serviciosFunerarios
    public DataTable listarTipServFun()
    {
        return cn.listarTipServFun();
    }
    public byte insertarActualizarlistarTipServFun(ta_serviciosFunerarios tipSerFun)
    {
        return cn.insertarActualizarlistarTipServFun(tipSerFun);
    }
    public byte eliminarTipServFun(ta_serviciosFunerarios tipSerFun)
    {
        return cn.eliminarTipServFun(tipSerFun);
    }
#endregion

#region tabla Ta_TipoDocVenta
    public DataTable listarTipDocVenta()
    {
        return cn.listarTipDocVenta();
    }
    public byte insertarActualizarlistarTipDocVenta(Ta_TipoDocVenta tipDocVenta)
    {
        return cn.insertarActualizarlistarTipDocVenta(tipDocVenta);
    }
    public byte eliminarTipDocVenta(Ta_TipoDocVenta tipDocVenta)
    {
        return cn.eliminarTipDocVenta(tipDocVenta);
    }
#endregion

#region tabla ta_modalidad_pago
    public DataTable listarModPag()
    {
        return cn.listarModPag();
    }
    public byte insertarActualizarModPago(ta_modalidad_pago modPag)
    {
        return cn.insertarActualizarModPago(modPag);
    }
    public byte eliminarModPago(ta_modalidad_pago modPag)
    {
        return cn.eliminarModPago(modPag);
    }
#endregion

#region tabla ta_entidad_financiera
    public DataTable listarEntFin()
    {
        return cn.listarEntFin();
    }
    public byte insertarActualizarEntFin(ta_entidad_financiera entFin)
    {
        return cn.insertarActualizarEntFin(entFin);
    }
    public byte eliminarEntFin(ta_entidad_financiera entFin)
    {
        return cn.eliminarEntFin(entFin);
    }
#endregion

#region tabla tb_cuenta_bancaria
    public DataTable listarCtaBancaria(string filtro)
    {
        return cn.listarCtaBancaria(filtro);
    }
    public byte insertarActualizarCtaBanc(tb_cuenta_bancaria ctaBanc)
    {
        return cn.insertarActualizarCtaBanc(ctaBanc);
    }
    public byte eliminarCtaBanc(tb_cuenta_bancaria ctaBanc, string host)
    {
        return cn.eliminarCtaBanc(ctaBanc,host);
    }

#endregion

    #region tabla tb_cta_contable
    public DataTable listarCtaContable(string filtro)
    {
        return cn.listarCtaContable(filtro);
    }
    public byte insertarActualizarCtaContable(tb_cta_contable ctaCont)
    {
        return cn.insertarActualizarCtaContable(ctaCont);
    }
    public byte eliminarCtaCont(tb_cta_contable ctaCont, string host)
    {
        return cn.eliminarCtaCont(ctaCont, host);
    }

    #endregion

    }

}
