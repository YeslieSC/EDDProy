using EDDemo;
using EDDemo.Algoritmos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;
        Busqueda miBusqueda; 
        Ordenamiento miOrdenamiento;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
            miBusqueda = new Busqueda(); 
            miOrdenamiento = new Ordenamiento();
            cbOrdenamiento.Items.AddRange(new string[] { "Intercalación", "Shellsort", "Mezcla Natural", "Burbuja", "QuickSort", "Radix", "Mezcla Directa" });
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";

 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos =1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }
        //BotonBuscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtValor.Text);
            bool encontrado = miArbol.Busqueda(valor, miArbol.RegresaRaiz());
            if (encontrado)
            {
                MessageBox.Show($"El {valor} SI se encuentra en el árbol");
            }
            else
            {
                MessageBox.Show($"El {valor} NO se encuentra en el árbol");
            }
        }
        //BotonBuscar
        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtArbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarArbol_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            miArbol.EliminarArbol(ref miRaiz);
            txtArbol.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
            MessageBox.Show("El árbol ha sido eliminado");
        }
        private void btnEliminarPredecesor_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtDato.Text);
            miArbol.EliminarPredecesor(miArbol.RegresaRaiz(), valor);
            miArbol.strArbol = "";
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }
        private void btnEliminarSucesor_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtDato.Text);
            miArbol.EliminarSucesor(miArbol.RegresaRaiz(), valor);
            miArbol.strArbol = "";
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
        }
        private void btnRecorridoPorNiveles_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";
            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El árbol está vacío";
                return;
            }
            miArbol.RecorridoPorNiveles(miRaiz);
            lblRecorridoPreOrden.Text = miArbol.strRecorrido;
        }
        private void btnAltura_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            int altura = miArbol.Altura(miRaiz);
            MessageBox.Show($"La altura del árbol es {altura}");
        }
        private void btnCantidadHojas_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            int hojas = miArbol.CantidadHojas(miRaiz);
            MessageBox.Show($"La cantidad de hojas es {hojas}");
        }
        private void btnCantidadNodos_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            int nodos = miArbol.CantidadNodos(miRaiz);
            MessageBox.Show($"La cantidad de nodos es {nodos}");
        }
        private void btnEsCompleto_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            bool esCompleto = miArbol.EsCompleto(miRaiz);
            MessageBox.Show(esCompleto ? "El árbol es completo" : "El árbol no es completo");
        }
        private void btnEsLleno_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            bool esLleno = miArbol.EsLleno(miRaiz);
            MessageBox.Show(esLleno ? "El árbol es lleno" : "El árbol no es lleno");
        }
        //Agregar Busqueda y Ordenamiento
        private int[] ObtenerArrayDeDatos()
        {
            List<int> datos = new List<int>();
            miArbol.strRecorrido = "";
            miArbol.InOrden(miRaiz);
            foreach (string strDato in miArbol.strRecorrido.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries))
            {
                datos.Add(int.Parse(strDato));
            }
            return datos.ToArray();
        }

        private void btnBuscarSecuencial_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDato.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.");
                return;
            }

            int valor = int.Parse(txtDato.Text);
            int[] arr = ObtenerArrayDeDatos(); // Método para obtener los datos del árbol en un array
            int resultado = miBusqueda.Secuencial(arr, valor);
            MessageBox.Show(resultado != -1 ? $"El {valor} se encuentra en la posición {resultado}" : $"El {valor} no se encuentra en el array");
        }

        private void btnBuscarBinaria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDato.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.");
                return;
            }

            int valor = int.Parse(txtDato.Text);
            int[] arr = ObtenerArrayDeDatos(); // Método para obtener los datos del árbol en un array
            Array.Sort(arr); // La búsqueda binaria requiere que el array esté ordenado
            int resultado = miBusqueda.Binaria(arr, valor);
            MessageBox.Show(resultado != -1 ? $"El {valor} se encuentra en la posición {resultado}" : $"El {valor} no se encuentra en el array");
        }

        private void btnBuscarHash_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDato.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor para buscar.");
                return;
            }

            int valor = int.Parse(txtDato.Text);
            int[] arr = ObtenerArrayDeDatos(); // Método para obtener los datos del árbol en un array
            int resultado = miBusqueda.Hash(arr, valor);
            MessageBox.Show(resultado != -1 ? $"El {valor} se encuentra en la posición {resultado}" : $"El {valor} no se encuentra en el array");
        }

        private void btnEjecutarOrdenamiento_Click(object sender, EventArgs e)
        {
            if (cbOrdenamiento.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un método de ordenamiento.");
                return;
            }

            int[] arrOriginal = ObtenerArrayDeDatos();
            string metodo = cbOrdenamiento.SelectedItem.ToString();
            var stopwatch = new Stopwatch();

            int[] arr = new int[arrOriginal.Length];
            Array.Copy(arrOriginal, arr, arrOriginal.Length);

            stopwatch.Start();
            switch (metodo)
            {
                case "Intercalación":
                    int[] arr1 = new int[arr.Length / 2];
                    int[] arr2 = new int[arr.Length - arr1.Length];
                    Array.Copy(arr, 0, arr1, 0, arr1.Length);
                    Array.Copy(arr, arr1.Length, arr2, 0, arr2.Length);
                    int[] resultado = new int[arr.Length];
                    miOrdenamiento.Intercalacion(arr1, arr2, resultado);
                    arr = resultado;
                    break;
                case "Shellsort":
                    miOrdenamiento.Shellsort(arr);
                    break;
                case "Mezcla Natural":
                    miOrdenamiento.MezclaNatural(arr);
                    break;
                case "Burbuja":
                    miOrdenamiento.Burbuja(arr);
                    break;
                case "QuickSort":
                    miOrdenamiento.QuickSort(arr, 0, arr.Length - 1);
                    break;
                case "Radix":
                    miOrdenamiento.RadixSort(arr);
                    break;
                case "Mezcla Directa":
                    miOrdenamiento.MezclaDirecta(arr);
                    break;
            }
            stopwatch.Stop();

            long ticks = stopwatch.ElapsedTicks;
            double timeInMilliseconds = (ticks * 1000.0) / Stopwatch.Frequency;

            string resultadoOrdenamiento = string.Join(", ", arr);
            MessageBox.Show($"Ordenamiento completado utilizando {metodo}.\n\nResultado: {resultadoOrdenamiento}\n\nTiempo de ejecución: {timeInMilliseconds:F6} ms");
        }
    }
}