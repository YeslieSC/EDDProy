using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales.Metodos_de_Busqueda
{
        public class HashTable
        {
            private List<int>[] table;

            public HashTable(int size)
            {
                table = new List<int>[size];
                for (int i = 0; i < size; i++)
                {
                    table[i] = new List<int>();
                }
            }

            private int HashFunction(int key)
            {
                return key % table.Length;
            }

            public void Insert(int key)
            {
                int hash = HashFunction(key);
                if (!table[hash].Contains(key))
                {
                    table[hash].Add(key);
                }
            }

            public bool Search(int key)
            {
                int hash = HashFunction(key);
                return table[hash].Contains(key);
            }
            
        }
    }