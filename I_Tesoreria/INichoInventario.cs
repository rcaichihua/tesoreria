using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE_Tesoreria;

namespace I_Tesoreria
{
    public interface INichoInventario
    {
        int AgregarNichoInventario(NichoInventario nichoInventario);
        int EditarNichoInventario(NichoInventario nichoInventario);
        int ActualizaEstadoGabineteNichoInventario(int IdnichoInventario);
        NichoInventario BuscarNichoInventario(int IdnichoInventario);
        List<NichoInventario> ListaNichoInventario();
        bool ExisteNichoInventario(int IdnichoInventario);
    }
}
