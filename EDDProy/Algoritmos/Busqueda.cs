using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos
{
    public class Busqueda
    {
        // Búsqueda Secuencial
        public int Secuencial(int[] arr, int valor)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valor)
                    return i;
            }
            return -1;
        }

        // Búsqueda Binaria
        public int Binaria(int[] arr, int valor)
        {
            int izquierda = 0, derecha = arr.Length - 1;
            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;
                if (arr[medio] == valor)
                    return medio;
                if (arr[medio] < valor)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }
            return -1;
        }

        // Búsqueda Hash (Simple)
        public int Hash(int[] arr, int valor)
        {
            // Este es un ejemplo simple utilizando el hashcode del valor
            int hashCode = valor.GetHashCode();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetHashCode() == hashCode)
                    return i;
            }
            return -1;
        }
    }
}
