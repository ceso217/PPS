namespace GestionDeStock.Controles
{
    partial class ucSalida
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            grillaSalida = new DataGridView();
            btnNuevaSalida = new Button();
            label1 = new Label();
            comboBoxCategoria = new ComboBox();
            comboBoxSubcategoria = new ComboBox();
            comboBoxDeposito = new ComboBox();
            textBoxBusqueda = new TextBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaSalida).BeginInit();
            SuspendLayout();
            // 
            // grillaSalida
            // 
            grillaSalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaSalida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grillaSalida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaSalida.Location = new Point(0, 47);
            grillaSalida.Name = "grillaSalida";
            grillaSalida.RowHeadersWidth = 51;
            grillaSalida.Size = new Size(1524, 610);
            grillaSalida.TabIndex = 1;
            grillaSalida.CellDoubleClick += grillaSalida_CellDoubleClick;
            // 
            // btnNuevaSalida
            // 
            btnNuevaSalida.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaSalida.Location = new Point(0, 0);
            btnNuevaSalida.Margin = new Padding(3, 2, 3, 2);
            btnNuevaSalida.Name = "btnNuevaSalida";
            btnNuevaSalida.Size = new Size(153, 41);
            btnNuevaSalida.TabIndex = 2;
            btnNuevaSalida.Text = "Nueva Salida";
            btnNuevaSalida.UseVisualStyleBackColor = true;
            btnNuevaSalida.Click += btnNuevaSalida_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(477, 10);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Filtros:";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(535, 7);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(208, 28);
            comboBoxCategoria.TabIndex = 5;
            // 
            // comboBoxSubcategoria
            // 
            comboBoxSubcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubcategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxSubcategoria.FormattingEnabled = true;
            comboBoxSubcategoria.Location = new Point(749, 7);
            comboBoxSubcategoria.Name = "comboBoxSubcategoria";
            comboBoxSubcategoria.Size = new Size(208, 28);
            comboBoxSubcategoria.TabIndex = 6;
            // 
            // comboBoxDeposito
            // 
            comboBoxDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeposito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDeposito.FormattingEnabled = true;
            comboBoxDeposito.Location = new Point(963, 6);
            comboBoxDeposito.Name = "comboBoxDeposito";
            comboBoxDeposito.Size = new Size(208, 28);
            comboBoxDeposito.TabIndex = 7;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBusqueda.ForeColor = Color.Gray;
            textBoxBusqueda.Location = new Point(1181, 6);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(269, 27);
            textBoxBusqueda.TabIndex = 8;
            textBoxBusqueda.Text = "Buscar por código, descripción, etc.";
            textBoxBusqueda.TextChanged += textBoxBusqueda_TextChanged;
            textBoxBusqueda.Enter += textBoxBusqueda_Enter;
            textBoxBusqueda.Leave += textBoxBusqueda_Leave;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(1456, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(76, 29);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(318, -1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(153, 41);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(159, -1);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(153, 41);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // ucSalida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(textBoxBusqueda);
            Controls.Add(comboBoxDeposito);
            Controls.Add(comboBoxSubcategoria);
            Controls.Add(comboBoxCategoria);
            Controls.Add(label1);
            Controls.Add(btnNuevaSalida);
            Controls.Add(grillaSalida);
            Name = "ucSalida";
            Size = new Size(1524, 657);
            ((System.ComponentModel.ISupportInitialize)grillaSalida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaSalida;
        private Button btnNuevaSalida;
        private Label label1;
        private ComboBox comboBoxCategoria;
        private ComboBox comboBoxSubcategoria;
        private ComboBox comboBoxDeposito;
        private TextBox textBoxBusqueda;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnEditar;
    }
}
