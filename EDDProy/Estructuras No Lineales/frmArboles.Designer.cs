
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarArbol = new System.Windows.Forms.Button();
            this.btnEliminarPredecesor = new System.Windows.Forms.Button();
            this.btnEliminarSucesor = new System.Windows.Forms.Button();
            this.btnCantidadNodos = new System.Windows.Forms.Button();
            this.btnRecorridoPorNiveles = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnEsLleno = new System.Windows.Forms.Button();
            this.btnCantidadHojas = new System.Windows.Forms.Button();
            this.btnEsCompleto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarSecuencial = new System.Windows.Forms.Button();
            this.btnBuscarBinaria = new System.Windows.Forms.Button();
            this.btnBuscarHash = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbOrdenamiento = new System.Windows.Forms.ComboBox();
            this.lblOrdenamiento = new System.Windows.Forms.Label();
            this.btnEjecutarOrdenamiento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(57, 19);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(68, 31);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(138, 19);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(83, 29);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(8, 288);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(729, 326);
            this.txtArbol.TabIndex = 2;
            this.txtArbol.TextChanged += new System.EventHandler(this.txtArbol_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(63, 226);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 29);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.Location = new System.Drawing.Point(63, 195);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(83, 29);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(138, 104);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(83, 40);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(8, 26);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(42, 16);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.Location = new System.Drawing.Point(138, 59);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(83, 42);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = true;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(54, 66);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(80, 28);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.Location = new System.Drawing.Point(238, 87);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(74, 16);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(329, 87);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoPostOrden.TabIndex = 10;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.Location = new System.Drawing.Point(255, 57);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(57, 16);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.Location = new System.Drawing.Point(244, 25);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(68, 16);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(329, 57);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoInOrden.TabIndex = 13;
            this.lblRecorridoInOrden.Text = "PostOrden";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(329, 25);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(71, 16);
            this.lblRecorridoPreOrden.TabIndex = 14;
            this.lblRecorridoPreOrden.Text = "PostOrden";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(138, 156);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 35);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(57, 162);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(68, 22);
            this.txtValor.TabIndex = 16;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nodo:";
            // 
            // btnEliminarArbol
            // 
            this.btnEliminarArbol.Location = new System.Drawing.Point(308, 209);
            this.btnEliminarArbol.Name = "btnEliminarArbol";
            this.btnEliminarArbol.Size = new System.Drawing.Size(100, 23);
            this.btnEliminarArbol.TabIndex = 18;
            this.btnEliminarArbol.Text = "Arbol";
            this.btnEliminarArbol.UseVisualStyleBackColor = true;
            this.btnEliminarArbol.Click += new System.EventHandler(this.btnEliminarArbol_Click);
            // 
            // btnEliminarPredecesor
            // 
            this.btnEliminarPredecesor.Location = new System.Drawing.Point(308, 180);
            this.btnEliminarPredecesor.Name = "btnEliminarPredecesor";
            this.btnEliminarPredecesor.Size = new System.Drawing.Size(100, 23);
            this.btnEliminarPredecesor.TabIndex = 19;
            this.btnEliminarPredecesor.Text = "Predecesor";
            this.btnEliminarPredecesor.UseVisualStyleBackColor = true;
            this.btnEliminarPredecesor.Click += new System.EventHandler(this.btnEliminarPredecesor_Click);
            // 
            // btnEliminarSucesor
            // 
            this.btnEliminarSucesor.Location = new System.Drawing.Point(308, 238);
            this.btnEliminarSucesor.Name = "btnEliminarSucesor";
            this.btnEliminarSucesor.Size = new System.Drawing.Size(100, 23);
            this.btnEliminarSucesor.TabIndex = 20;
            this.btnEliminarSucesor.Text = "Sucesor";
            this.btnEliminarSucesor.UseVisualStyleBackColor = true;
            this.btnEliminarSucesor.Click += new System.EventHandler(this.btnEliminarSucesor_Click);
            // 
            // btnCantidadNodos
            // 
            this.btnCantidadNodos.Location = new System.Drawing.Point(513, 168);
            this.btnCantidadNodos.Name = "btnCantidadNodos";
            this.btnCantidadNodos.Size = new System.Drawing.Size(91, 23);
            this.btnCantidadNodos.TabIndex = 21;
            this.btnCantidadNodos.Text = "Nodos";
            this.btnCantidadNodos.UseVisualStyleBackColor = true;
            this.btnCantidadNodos.Click += new System.EventHandler(this.btnCantidadNodos_Click);
            // 
            // btnRecorridoPorNiveles
            // 
            this.btnRecorridoPorNiveles.Location = new System.Drawing.Point(308, 142);
            this.btnRecorridoPorNiveles.Name = "btnRecorridoPorNiveles";
            this.btnRecorridoPorNiveles.Size = new System.Drawing.Size(100, 23);
            this.btnRecorridoPorNiveles.TabIndex = 22;
            this.btnRecorridoPorNiveles.Text = "Niveles";
            this.btnRecorridoPorNiveles.UseVisualStyleBackColor = true;
            this.btnRecorridoPorNiveles.Click += new System.EventHandler(this.btnRecorridoPorNiveles_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(308, 116);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(100, 23);
            this.btnAltura.TabIndex = 23;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnEsLleno
            // 
            this.btnEsLleno.Location = new System.Drawing.Point(513, 205);
            this.btnEsLleno.Name = "btnEsLleno";
            this.btnEsLleno.Size = new System.Drawing.Size(91, 23);
            this.btnEsLleno.TabIndex = 24;
            this.btnEsLleno.Text = "Lleno";
            this.btnEsLleno.UseVisualStyleBackColor = true;
            this.btnEsLleno.Click += new System.EventHandler(this.btnEsLleno_Click);
            // 
            // btnCantidadHojas
            // 
            this.btnCantidadHojas.Location = new System.Drawing.Point(513, 138);
            this.btnCantidadHojas.Name = "btnCantidadHojas";
            this.btnCantidadHojas.Size = new System.Drawing.Size(91, 23);
            this.btnCantidadHojas.TabIndex = 25;
            this.btnCantidadHojas.Text = " Hojas";
            this.btnCantidadHojas.UseVisualStyleBackColor = true;
            this.btnCantidadHojas.Click += new System.EventHandler(this.btnCantidadHojas_Click);
            // 
            // btnEsCompleto
            // 
            this.btnEsCompleto.Location = new System.Drawing.Point(513, 234);
            this.btnEsCompleto.Name = "btnEsCompleto";
            this.btnEsCompleto.Size = new System.Drawing.Size(91, 23);
            this.btnEsCompleto.TabIndex = 26;
            this.btnEsCompleto.Text = "Completo";
            this.btnEsCompleto.UseVisualStyleBackColor = true;
            this.btnEsCompleto.Click += new System.EventHandler(this.btnEsCompleto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Eliminar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Recorrido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Obtener:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Arbol Binario:";
            // 
            // btnBuscarSecuencial
            // 
            this.btnBuscarSecuencial.Location = new System.Drawing.Point(619, 91);
            this.btnBuscarSecuencial.Name = "btnBuscarSecuencial";
            this.btnBuscarSecuencial.Size = new System.Drawing.Size(91, 23);
            this.btnBuscarSecuencial.TabIndex = 32;
            this.btnBuscarSecuencial.Text = "Secuencial";
            this.btnBuscarSecuencial.UseVisualStyleBackColor = true;
            this.btnBuscarSecuencial.Click += new System.EventHandler(this.btnBuscarSecuencial_Click);
            // 
            // btnBuscarBinaria
            // 
            this.btnBuscarBinaria.Location = new System.Drawing.Point(619, 119);
            this.btnBuscarBinaria.Name = "btnBuscarBinaria";
            this.btnBuscarBinaria.Size = new System.Drawing.Size(91, 23);
            this.btnBuscarBinaria.TabIndex = 33;
            this.btnBuscarBinaria.Text = "Binaria";
            this.btnBuscarBinaria.UseVisualStyleBackColor = true;
            this.btnBuscarBinaria.Click += new System.EventHandler(this.btnBuscarBinaria_Click);
            // 
            // btnBuscarHash
            // 
            this.btnBuscarHash.Location = new System.Drawing.Point(619, 148);
            this.btnBuscarHash.Name = "btnBuscarHash";
            this.btnBuscarHash.Size = new System.Drawing.Size(91, 23);
            this.btnBuscarHash.TabIndex = 34;
            this.btnBuscarHash.Text = "Hash";
            this.btnBuscarHash.UseVisualStyleBackColor = true;
            this.btnBuscarHash.Click += new System.EventHandler(this.btnBuscarHash_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(616, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Busqueda:";
            // 
            // cbOrdenamiento
            // 
            this.cbOrdenamiento.FormattingEnabled = true;
            this.cbOrdenamiento.Location = new System.Drawing.Point(619, 206);
            this.cbOrdenamiento.Name = "cbOrdenamiento";
            this.cbOrdenamiento.Size = new System.Drawing.Size(92, 24);
            this.cbOrdenamiento.TabIndex = 36;
            // 
            // lblOrdenamiento
            // 
            this.lblOrdenamiento.AutoSize = true;
            this.lblOrdenamiento.Location = new System.Drawing.Point(616, 187);
            this.lblOrdenamiento.Name = "lblOrdenamiento";
            this.lblOrdenamiento.Size = new System.Drawing.Size(95, 16);
            this.lblOrdenamiento.TabIndex = 37;
            this.lblOrdenamiento.Text = "Ordenamiento:";
            // 
            // btnEjecutarOrdenamiento
            // 
            this.btnEjecutarOrdenamiento.Location = new System.Drawing.Point(619, 236);
            this.btnEjecutarOrdenamiento.Name = "btnEjecutarOrdenamiento";
            this.btnEjecutarOrdenamiento.Size = new System.Drawing.Size(92, 23);
            this.btnEjecutarOrdenamiento.TabIndex = 38;
            this.btnEjecutarOrdenamiento.Text = "Ejecutar";
            this.btnEjecutarOrdenamiento.UseVisualStyleBackColor = true;
            this.btnEjecutarOrdenamiento.Click += new System.EventHandler(this.btnEjecutarOrdenamiento_Click);
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 620);
            this.Controls.Add(this.btnEjecutarOrdenamiento);
            this.Controls.Add(this.lblOrdenamiento);
            this.Controls.Add(this.cbOrdenamiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscarHash);
            this.Controls.Add(this.btnBuscarBinaria);
            this.Controls.Add(this.btnBuscarSecuencial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEsCompleto);
            this.Controls.Add(this.btnCantidadHojas);
            this.Controls.Add(this.btnEsLleno);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnRecorridoPorNiveles);
            this.Controls.Add(this.btnCantidadNodos);
            this.Controls.Add(this.btnEliminarSucesor);
            this.Controls.Add(this.btnEliminarPredecesor);
            this.Controls.Add(this.btnEliminarArbol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarArbol;
        private System.Windows.Forms.Button btnEliminarPredecesor;
        private System.Windows.Forms.Button btnEliminarSucesor;
        private System.Windows.Forms.Button btnCantidadNodos;
        private System.Windows.Forms.Button btnRecorridoPorNiveles;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnEsLleno;
        private System.Windows.Forms.Button btnCantidadHojas;
        private System.Windows.Forms.Button btnEsCompleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarSecuencial;
        private System.Windows.Forms.Button btnBuscarBinaria;
        private System.Windows.Forms.Button btnBuscarHash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbOrdenamiento;
        private System.Windows.Forms.Label lblOrdenamiento;
        private System.Windows.Forms.Button btnEjecutarOrdenamiento;
    }
}