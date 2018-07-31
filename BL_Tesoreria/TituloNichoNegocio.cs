using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using I_Tesoreria;
using BE_Tesoreria;
using DAO_Tesoreria;

namespace BL_Tesoreria
{

    public class TituloNichoNegocio : ITituloNicho
    {
        public int AgregarTituloNicho(TituloNicho tituloNicho)
        {
            try
            {
                using (TituloNichoMetodos TiNiMe = new TituloNichoMetodos())
                {
                    if (!TiNiMe.ExisteTituloNichoPorNicho(tituloNicho.CODCUARTEL, tituloNicho.LETRAFILANICHO, tituloNicho.NUMEROCOLNICHO))
                    {
                        return TiNiMe.AgregarTituloNicho(tituloNicho);
                    }
                    else
                    {
                        throw new Exception("Titulo nicho ya existe existe");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TituloNicho BuscarTituloNicho(int IdTituloNicho)
        {
            try
            {
                using (TituloNichoMetodos TiNiMe = new TituloNichoMetodos())
                {
                    return TiNiMe.BuscarTituloNicho(IdTituloNicho);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public TituloNicho BuscarTituloNichoPorNicho(string CodCuartel, string LetraNicho, int ColumNicho)
        {
            try
            {
                using (TituloNichoMetodos TiNiMe = new TituloNichoMetodos())
                {
                    return TiNiMe.BuscarTituloNichoPorNicho(CodCuartel,LetraNicho,ColumNicho);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int EditarTituloNicho(TituloNicho tituloNicho)
        {
            try
            {
                using (TituloNichoMetodos TiNiMe = new TituloNichoMetodos())
                {
                    if (TiNiMe.ExisteTituloNichoPorNicho(tituloNicho.CODCUARTEL, tituloNicho.LETRAFILANICHO, tituloNicho.NUMEROCOLNICHO))
                    {
                        if (tituloNicho.FECHAINHUMACION == null)
                        {
                            tituloNicho.FECHAINHUMACION = null;
                        }
                        return TiNiMe.EditarTituloNicho(tituloNicho);
                    }
                    else
                    {
                        throw new Exception("Titulo nicho no existe");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AnularTituloNicho(int IdTituloNicho,int Usuario)
        {
            try
            {
                using (TituloNichoMetodos tiNi = new TituloNichoMetodos())
                {
                    return tiNi.AnularTituloNicho(IdTituloNicho, Usuario);
                }
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
                using (TituloNichoMetodos tiNi = new TituloNichoMetodos())
                {
                    return tiNi.ExisteTituloNichoPorId(IdTituloNicho);
                }
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
                using (TituloNichoMetodos tiNi = new TituloNichoMetodos())
                {
                    return tiNi.ExisteTituloNichoPorNicho(CodCuartel, Letra, Numero);
                }
            }
            catch (Exception)
            {
                throw;
            }         
        }

        public List<TituloNicho> ListarTituloNicho()
        {
            try
            {
                using (TituloNichoMetodos TiNiMet = new TituloNichoMetodos())
                {
                    return TiNiMet.ListarTituloNicho();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
