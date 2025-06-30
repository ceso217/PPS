namespace GestionDeStock.Controles
{
    partial class ucMovimientos
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
            grillaMovimientos = new DataGridView();
            label1 = new Label();
            comboBoxCategoria = new ComboBox();
            comboBoxSubcategoria = new ComboBox();
            comboBoxDeposito = new ComboBox();
            textBoxBusqueda = new TextBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaMovimientos).BeginInit();
            SuspendLayout();
            // 
            // grillaMovimientos
            // 
            grillaMovimientos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grillaMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaMovimientos.Location = new Point(0, 47);
            grillaMovimientos.Name = "grillaMovimientos";
            grillaMovimientos.RowHeadersWidth = 51;
            grillaMovimientos.Size = new Size(805, 434);
            grillaMovimientos.TabIndex = 1;
            grillaMovimientos.CellMouseDoubleClick += grillaMovimientos_CellMouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 10);
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
            comboBoxCategoria.Location = new Point(74, 7);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(208, 28);
            comboBoxCategoria.TabIndex = 5;
            // 
            // comboBoxSubcategoria
            // 
            comboBoxSubcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubcategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxSubcategoria.FormattingEnabled = true;
            comboBoxSubcategoria.Location = new Point(288, 7);
            comboBoxSubcategoria.Name = "comboBoxSubcategoria";
            comboBoxSubcategoria.Size = new Size(208, 28);
            comboBoxSubcategoria.TabIndex = 6;
            // 
            // comboBoxDeposito
            // 
            comboBoxDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeposito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDeposito.FormattingEnabled = true;
            comboBoxDeposito.Location = new Point(502, 6);
            comboBoxDeposito.Name = "comboBoxDeposito";
            comboBoxDeposito.Size = new Size(208, 28);
            comboBoxDeposito.TabIndex = 7;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBusqueda.ForeColor = Color.Gray;
            textBoxBusqueda.Location = new Point(720, 6);
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
            btnLimpiar.Location = new Point(995, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(76, 29);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // ucMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grillaMovimientos);
            Controls.Add(btnLimpiar);
            Controls.Add(textBoxBusqueda);
            Controls.Add(comboBoxDeposito);
            Controls.Add(comboBoxSubcategoria);
            Controls.Add(comboBoxCategoria);
            Controls.Add(label1);
            Name = "ucMovimientos";
            Size = new Size(805, 481);
            ((System.ComponentModel.ISupportInitialize)grillaMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaMovimientos;
        private Label label1;
        private ComboBox comboBoxCategoria;
        private ComboBox comboBoxSubcategoria;
        private ComboBox comboBoxDeposito;
        private TextBox textBoxBusqueda;
        private Button btnLimpiar;
    }
}
