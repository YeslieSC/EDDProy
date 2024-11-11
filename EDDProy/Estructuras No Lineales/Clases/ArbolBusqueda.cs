using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }
        //Insertar//
        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (!Busqueda(Dato, Raiz))
            {
                if (Nodo == null)
                {
                    Nodo = new NodoBinario(Dato);
                    if (Raiz == null)
                        Raiz = Nodo;
                }
                else if (Dato < Nodo.Dato)
                    InsertaNodo(Dato, ref Nodo.Izq);
                else if (Dato > Nodo.Dato)
                    InsertaNodo(Dato, ref Nodo.Der);
            }
            else
            {
                MessageBox.Show($"El valor {Dato} ya existe en el árbol");
            }
        }

        public void MuestraArbolAcostado(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }
        //Busqueda//
        public bool Busqueda(int valor, NodoBinario nodo)
        {
            if (nodo == null)
            {
                return false;
            }
            if (nodo.Dato == valor)
            {
                return true;
            }
            else if (valor < nodo.Dato)
            {
                return Busqueda(valor, nodo.Izq);
            }
            else
            {
                return Busqueda(valor, nodo.Der);
            }
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }
        //Eliminar un nodo del árbol PREDECESOR//
        public NodoBinario EliminarPredecesor(NodoBinario nodo, int valor)
        {
            if (nodo == null) return nodo;

            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarPredecesor(nodo.Izq, valor);
            }
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarPredecesor(nodo.Der, valor);
            }
            else
            {
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario predecesor = EncontrarMaximo(nodo.Izq);
                    nodo.Dato = predecesor.Dato;
                    nodo.Izq = EliminarPredecesor(nodo.Izq, predecesor.Dato);
                }
                else
                {
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;
                }
            }

            return nodo;
        }
        private NodoBinario EncontrarMaximo(NodoBinario nodo)
        {
            while (nodo.Der != null)
            {
                nodo = nodo.Der;
            }
            return nodo;
        }
        //Eliminar un nodo del árbol SUCESOR//
        public NodoBinario EliminarSucesor(NodoBinario nodo, int valor)
        {
            if (nodo == null) return nodo;

            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarSucesor(nodo.Izq, valor);
            }
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarSucesor(nodo.Der, valor);
            }
            else
            {
                if (nodo.Izq != null && nodo.Der != null)
                {
                    NodoBinario sucesor = EncontrarMinimo(nodo.Der);
                    nodo.Dato = sucesor.Dato;
                    nodo.Der = EliminarSucesor(nodo.Der, sucesor.Dato);
                }
                else
                {
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;
                }
            }

            return nodo;
        }
        //Eliminar Arbol//
        public void EliminarArbol(ref NodoBinario nodo)
        {
            if (nodo != null)
            {
                EliminarArbol(ref nodo.Izq);
                EliminarArbol(ref nodo.Der);
                nodo = null;
            }
        }
        //Recorrer por niveles//
        public void RecorridoPorNiveles(NodoBinario nodo)
        {
            if (nodo == null) return;

            Queue<NodoBinario> queue = new Queue<NodoBinario>();
            queue.Enqueue(nodo);

            while (queue.Count > 0)
            {
                NodoBinario actual = queue.Dequeue();
                strRecorrido = strRecorrido + actual.Dato + ", ";

                if (actual.Izq != null)
                    queue.Enqueue(actual.Izq);
                if (actual.Der != null)
                    queue.Enqueue(actual.Der);
            }
        }
        //Obtener altura//
        public int Altura(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            int alturaIzq = Altura(nodo.Izq);
            int alturaDer = Altura(nodo.Der);

            return Math.Max(alturaIzq, alturaDer) + 1;
        }
        //Cantidad de hojas del arbol//
        public int CantidadHojas(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            if (nodo.Izq == null && nodo.Der == null)
                return 1;

            return CantidadHojas(nodo.Izq) + CantidadHojas(nodo.Der);
        }
        //Cantidad de nodos del arbol//
        public int CantidadNodos(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            return CantidadNodos(nodo.Izq) + CantidadNodos(nodo.Der) + 1;
        }
        //Revisa si es un arbol binario completo//
        public bool EsCompleto(NodoBinario nodo)
        {
            if (nodo == null)
                return true;

            Queue<NodoBinario> queue = new Queue<NodoBinario>();
            queue.Enqueue(nodo);
            bool bandera = false;

            while (queue.Count > 0)
            {
                NodoBinario actual = queue.Dequeue();

                if (actual.Izq != null)
                {
                    if (bandera)
                        return false;
                    queue.Enqueue(actual.Izq);
                }
                else
                {
                    bandera = true;
                }

                if (actual.Der != null)
                {
                    if (bandera)
                        return false;
                    queue.Enqueue(actual.Der);
                }
                else
                {
                    bandera = true;
                }
            }

            return true;
        }
        //Revisa si es un árbol binario lleno//
        public bool EsLleno(NodoBinario nodo)
        {
            if (nodo == null)
                return true;

            Queue<NodoBinario> queue = new Queue<NodoBinario>();
            queue.Enqueue(nodo);

            while (queue.Count > 0)
            {
                NodoBinario actual = queue.Dequeue();

                if (actual.Izq == null && actual.Der == null)
                    continue;

                if (actual.Izq == null || actual.Der == null)
                    return false;

                queue.Enqueue(actual.Izq);
                queue.Enqueue(actual.Der);
            }

            return true;
        }
        private NodoBinario EncontrarMinimo(NodoBinario nodo)
        {
            while (nodo.Izq != null)
            {
                nodo = nodo.Izq;
            }
            return nodo;
        }
        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
            
            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo )
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
         }

    }
}
