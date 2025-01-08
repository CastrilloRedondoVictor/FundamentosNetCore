namespace FundamentosNetCore
{
    partial class Form14TiendaProductos
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
            btnNuevo = new Button();
            label1 = new Label();
            txtProducto = new TextBox();
            lstTienda = new ListBox();
            label2 = new Label();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            lstAlmacen = new ListBox();
            btnSeleccion = new Button();
            btnTodos = new Button();
            btnSubir = new Button();
            btnBajar = new Button();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(6, 61);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 32);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(6, 32);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 2;
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(112, 44);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(208, 364);
            lstTienda.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 14);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Tienda";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(6, 99);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(6, 135);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(100, 33);
            btnBorrarTodo.TabIndex = 6;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(424, 44);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(214, 364);
            lstAlmacen.TabIndex = 7;
            lstAlmacen.SelectedIndexChanged += lstAlmacen_SelectedIndexChanged;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(326, 135);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(92, 37);
            btnSeleccion.TabIndex = 8;
            btnSeleccion.Text = "Seleccion";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(326, 201);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(92, 42);
            btnTodos.TabIndex = 9;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(658, 135);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(89, 37);
            btnSubir.TabIndex = 10;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(658, 201);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(89, 42);
            btnBajar.TabIndex = 11;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // Form14TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(lstAlmacen);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(lstTienda);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Controls.Add(btnNuevo);
            Name = "Form14TiendaProductos";
            Text = "Form14TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Label label1;
        private TextBox txtProducto;
        private ListBox lstTienda;
        private Label label2;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private ListBox lstAlmacen;
        private Button btnSeleccion;
        private Button btnTodos;
        private Button btnSubir;
        private Button btnBajar;
    }
}