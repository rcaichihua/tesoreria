using BE_Tesoreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Tesoreria
{
    public interface ITituloNicho
    {
        int AgregarTituloNicho(TituloNicho cliente);
        int EditarTituloNicho(TituloNicho cliente);
        int AnularTituloNicho(int IdTituloNicho,int Usuario);
        TituloNicho BuscarTituloNicho(int IdTituloNicho);
        TituloNicho BuscarTituloNichoPorNicho(string CodCuartel,string LetraNicho,int ColumNicho);
        List<TituloNicho> ListarTituloNicho();
        bool ExisteTituloNichoPorNicho(string CodCuartel, string Letra, int Numero);
        bool ExisteTituloNichoPorId(int IdTituloNicho);
    }
}
