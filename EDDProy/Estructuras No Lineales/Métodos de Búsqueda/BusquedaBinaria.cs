using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace EDDemo.Estructuras_No_Lineales.Metodos_de_Busqueda
{
    public class BusquedaBinaria
    {
        public int Buscar(int[] lista, int elemento)
        {
            int inicio = 0;
            int fin = lista.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (lista[medio] == elemento)
                {
                    return medio;
                }
                else if (lista[medio] < elemento)
                {
                    inicio = medio + 1;
                }
                else
                {
                    fin = medio - 1;
                }
            }

            return -1;
        }
    }
}