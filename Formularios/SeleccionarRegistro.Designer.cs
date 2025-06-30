namespace GestionDeStock.Formularios
{
    partial class SeleccionarRegistro
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grilla = new DataGridView();
            textBoxBusqueda = new TextBox();
            labelFiltros = new Label();
            comboBoxDeposito = new ComboBox();
            comboBoxCategoria = new ComboBox();
            comboBoxSubcategoria = new ComboBox();
            btnLimpiar = new Button();
            btnSeleccionar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // grilla
            // 
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
            grilla.RowHeadersWidth = 51;
            grilla.Size = new Size(1254, 493);
            grilla.TabIndex = 0;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBusqueda.ForeColor = Color.Gray;
            textBoxBusqueda.Location = new Point(548, 7);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(267, 27);
            textBoxBusqueda.TabIndex = 2;
            textBoxBusqueda.Text = "Buscar por código, descripción, etc.";
            textBoxBusqueda.TextChanged += textBoxBusqueda_TextChanged;
            textBoxBusqueda.Enter += textBoxBusqueda_Enter;
            textBoxBusqueda.Leave += textBoxBusqueda_Leave;
            // 
            // labelFiltros
            // 
            labelFiltros.AutoSize = true;
            labelFiltros.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFiltros.Location = new Point(14, 10);
            labelFiltros.Name = "labelFiltros";
            labelFiltros.Size = new Size(52, 20);
            labelFiltros.TabIndex = 4;
            labelFiltros.Text = "Filtros:";
            // 
            // comboBoxDeposito
            // 
            comboBoxDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeposito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDeposito.FormattingEnabled = true;
            comboBoxDeposito.Location = new Point(903, 7);
            comboBoxDeposito.Name = "comboBoxDeposito";
            comboBoxDeposito.Size = new Size(208, 28);
            comboBoxDeposito.TabIndex = 7;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.Font = new Font("Segoe UI", 11.25F);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(72, 7);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(232, 28);
            comboBoxCategoria.TabIndex = 5;
            // 
            // comboBoxSubcategoria
            // 
            comboBoxSubcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubcategoria.Font = new Font("Segoe UI", 11.25F);
            comboBoxSubcategoria.FormattingEnabled = true;
            comboBoxSubcategoria.Location = new Point(310, 7);
            comboBoxSubcategoria.Name = "comboBoxSubcategoria";
            comboBoxSubcategoria.Size = new Size(232, 28);
            comboBoxSubcategoria.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(821, 6);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(76, 29);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSeleccionar.Location = new Point(442, 546);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(122, 39);
            btnSeleccionar.TabIndex = 8;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(682, 546);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 39);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // SeleccionarArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1254, 597);
            Controls.Add(btnCancelar);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnLimpiar);
            Controls.Add(comboBoxDeposito);
            Controls.Add(comboBoxSubcategoria);
            Controls.Add(comboBoxCategoria);
            Controls.Add(labelFiltros);
            Controls.Add(textBoxBusqueda);
            Controls.Add(grilla);
            Name = "SeleccionarArticulo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selección de artículo";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grilla;
        private TextBox textBoxBusqueda;
        private Label labelFiltros;
        private ComboBox comboBoxCategoria;
        private ComboBox comboBoxSubcategoria;
        private ComboBox comboBoxDeposito;
        private Button btnLimpiar;
        private Button btnSeleccionar;
        private Button btnCancelar;
    }
}