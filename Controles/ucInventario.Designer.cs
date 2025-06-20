namespace GestionDeStock.Controles
{
    partial class ucInventario
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grilla = new DataGridView();
            btnAgregarArt = new Button();
            textBoxBusqueda = new TextBox();
            btnEditar = new Button();
            labelFiltros = new Label();
            comboBoxCategoria = new ComboBox();
            comboBoxSubcategoria = new ComboBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // grilla
            // 
            grilla.AllowUserToAddRows = false;
            grilla.AllowUserToDeleteRows = false;
            grilla.AllowUserToResizeColumns = false;
            grilla.AllowUserToResizeRows = false;
            grilla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            grilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(0, 47);
            grilla.Name = "grilla";
            grilla.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grilla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grilla.Size = new Size(1259, 557);
            grilla.TabIndex = 0;
            // 
            // btnAgregarArt
            // 
            btnAgregarArt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarArt.Location = new Point(0, 0);
            btnAgregarArt.Name = "btnAgregarArt";
            btnAgregarArt.Size = new Size(165, 41);
            btnAgregarArt.TabIndex = 1;
            btnAgregarArt.Text = "Agregar artículo";
            btnAgregarArt.UseVisualStyleBackColor = true;
            btnAgregarArt.Click += btnAgregarArt_Click;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBusqueda.ForeColor = Color.Gray;
            textBoxBusqueda.Location = new Point(944, 7);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(267, 27);
            textBoxBusqueda.TabIndex = 2;
            textBoxBusqueda.Text = "Buscar por código, descripción, etc.";
            textBoxBusqueda.TextChanged += textBoxBusqueda_TextChanged;
            textBoxBusqueda.Enter += textBoxBusqueda_Enter;
            textBoxBusqueda.Leave += textBoxBusqueda_Leave;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(171, 0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(165, 41);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // labelFiltros
            // 
            labelFiltros.AutoSize = true;
            labelFiltros.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFiltros.Location = new Point(361, 10);
            labelFiltros.Name = "labelFiltros";
            labelFiltros.Size = new Size(52, 20);
            labelFiltros.TabIndex = 4;
            labelFiltros.Text = "Filtros:";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.Font = new Font("Segoe UI", 11.25F);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(419, 8);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(252, 28);
            comboBoxCategoria.TabIndex = 5;
            // 
            // comboBoxSubcategoria
            // 
            comboBoxSubcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubcategoria.Font = new Font("Segoe UI", 11.25F);
            comboBoxSubcategoria.FormattingEnabled = true;
            comboBoxSubcategoria.Location = new Point(677, 8);
            comboBoxSubcategoria.Name = "comboBoxSubcategoria";
            comboBoxSubcategoria.Size = new Size(252, 28);
            comboBoxSubcategoria.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(1217, 6);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(76, 29);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // ucInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnLimpiar);
            Controls.Add(comboBoxSubcategoria);
            Controls.Add(comboBoxCategoria);
            Controls.Add(labelFiltros);
            Controls.Add(btnEditar);
            Controls.Add(textBoxBusqueda);
            Controls.Add(btnAgregarArt);
            Controls.Add(grilla);
            Name = "ucInventario";
            Size = new Size(1259, 604);
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grilla;
        private Button btnAgregarArt;
        private TextBox textBoxBusqueda;
        private Button btnEditar;
        private Label labelFiltros;
        private ComboBox comboBoxCategoria;
        private ComboBox comboBoxSubcategoria;
        private Button btnLimpiar;
    }
}
