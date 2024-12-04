using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace EDDemo.Estructuras_No_Lineales.Metodos_de_Busqueda
{
    public class BusquedaSecuencial
    {
        public int Buscar(int[] lista, int elemento)
        {
            for (int i = 0; i < lista.Length; i++)
            {
                if (lista[i] == elemento)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
