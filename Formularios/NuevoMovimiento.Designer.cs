namespace GestionDeStock.Formularios
{
    partial class NuevoMovimiento
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
            label1 = new Label();
            label2 = new Label();
            btnElegirArticulo = new Button();
            grilla = new DataGridView();
            btnCancelar = new Button();
            label3 = new Label();
            numericUpDownCantidad = new NumericUpDown();
            label4 = new Label();
            comboBoxDeposito = new ComboBox();
            btnNuevoDeposito = new Button();
            btnNuevoTransp = new Button();
            comboBoxTransportista = new ComboBox();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            textBoxNotas = new TextBox();
            btnAgregar = new Button();
            btnNuevoProveedor = new Button();
            comboBoxProveedor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 21);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Ingreso";
            // 
            // btnElegirArticulo
            // 
            btnElegirArticulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnElegirArticulo.Location = new Point(559, 158);
            btnElegirArticulo.Name = "btnElegirArticulo";
            btnElegirArticulo.Size = new Size(123, 36);
            btnElegirArticulo.TabIndex = 3;
            btnElegirArticulo.Text = "Elegir artículo";
            btnElegirArticulo.UseVisualStyleBackColor = true;
            btnElegirArticulo.Click += btnElegirArticulo_Click;
            // 
            // grilla
            // 
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(171, 95);
            grilla.Margin = new Padding(3, 2, 3, 2);
            grilla.Name = "grilla";
            grilla.RowHeadersWidth = 51;
            grilla.Size = new Size(975, 43);
            grilla.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 4;
            label2.Text = "Artículo";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(679, 563);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 36);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 78);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 7;
            label3.Text = "Cantidad";
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownCantidad.Location = new Point(171, 181);
            numericUpDownCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(120, 27);
            numericUpDownCantidad.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 157);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Depósito";
            // 
            // comboBoxDeposito
            // 
            comboBoxDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeposito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDeposito.FormattingEnabled = true;
            comboBoxDeposito.Location = new Point(171, 259);
            comboBoxDeposito.Name = "comboBoxDeposito";
            comboBoxDeposito.Size = new Size(304, 28);
            comboBoxDeposito.TabIndex = 10;
            // 
            // btnNuevoDestino
            // 
            btnNuevoDeposito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoDeposito.Location = new Point(531, 255);
            btnNuevoDeposito.Name = "btnNuevoDestino";
            btnNuevoDeposito.Size = new Size(231, 35);
            btnNuevoDeposito.TabIndex = 11;
            btnNuevoDeposito.Text = "Nuevo depósito";
            btnNuevoDeposito.UseVisualStyleBackColor = true;
            btnNuevoDeposito.Click += btnNuevoDestino_Click;
            // 
            // btnNuevoTransp
            // 
            btnNuevoTransp.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoTransp.Location = new Point(531, 413);
            btnNuevoTransp.Name = "btnNuevoTransp";
            btnNuevoTransp.Size = new Size(231, 35);
            btnNuevoTransp.TabIndex = 14;
            btnNuevoTransp.Text = "Nuevo transportista";
            btnNuevoTransp.UseVisualStyleBackColor = true;
            btnNuevoTransp.Click += btnNuevoTransp_Click;
            // 
            // comboBoxTransportista
            // 
            comboBoxTransportista.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransportista.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTransportista.FormattingEnabled = true;
            comboBoxTransportista.Location = new Point(171, 417);
            comboBoxTransportista.Name = "comboBoxTransportista";
            comboBoxTransportista.Size = new Size(304, 28);
            comboBoxTransportista.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 315);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 12;
            label5.Text = "Transportista";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Location = new Point(49, 106);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666584F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(116, 474);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(65, 394);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 13;
            label6.Text = "Notas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(36, 236);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 14;
            label7.Text = "Proveedor";
            // 
            // textBoxNotas
            // 
            textBoxNotas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNotas.Location = new Point(171, 496);
            textBoxNotas.Name = "textBoxNotas";
            textBoxNotas.Size = new Size(975, 27);
            textBoxNotas.TabIndex = 16;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(444, 563);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(123, 36);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevoProveedor
            // 
            btnNuevoProveedor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevoProveedor.Location = new Point(531, 334);
            btnNuevoProveedor.Name = "btnNuevoProveedor";
            btnNuevoProveedor.Size = new Size(231, 35);
            btnNuevoProveedor.TabIndex = 19;
            btnNuevoProveedor.Text = "Nuevo proveedor";
            btnNuevoProveedor.UseVisualStyleBackColor = true;
            btnNuevoProveedor.Click += btnNuevoProveedor_Click;
            // 
            // comboBoxProveedor
            // 
            comboBoxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProveedor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxProveedor.FormattingEnabled = true;
            comboBoxProveedor.Location = new Point(171, 338);
            comboBoxProveedor.Name = "comboBoxProveedor";
            comboBoxProveedor.Size = new Size(304, 28);
            comboBoxProveedor.TabIndex = 18;
            // 
            // NuevoMovimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 620);
            Controls.Add(btnNuevoProveedor);
            Controls.Add(comboBoxProveedor);
            Controls.Add(btnAgregar);
            Controls.Add(textBoxNotas);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnNuevoTransp);
            Controls.Add(comboBoxTransportista);
            Controls.Add(btnNuevoDeposito);
            Controls.Add(comboBoxDeposito);
            Controls.Add(numericUpDownCantidad);
            Controls.Add(btnCancelar);
            Controls.Add(grilla);
            Controls.Add(btnElegirArticulo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "NuevoMovimiento";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Ingreso";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnElegirArticulo;
        private DataGridView grilla;
        private Button btnCancelar;
        private Label label3;
        private NumericUpDown numericUpDownCantidad;
        private Label label4;
        private ComboBox comboBoxDeposito;
        private Button btnNuevoDeposito;
        private Button btnNuevoTransp;
        private ComboBox comboBoxTransportista;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private TextBox textBoxNotas;
        private Button btnAgregar;
        private Button btnNuevoProveedor;
        private ComboBox comboBoxProveedor;
        private Label label7;
    }
}