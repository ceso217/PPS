namespace GestionDeStock.Formularios
{
    partial class EditarMovimiento
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
            btnElegirIngreso = new Button();
            label2 = new Label();
            grilla = new DataGridView();
            btnCancelar = new Button();
            label3 = new Label();
            numericUpDownCantidad = new NumericUpDown();
            comboBoxDeposito = new ComboBox();
            comboBoxTransportista = new ComboBox();
            label6 = new Label();
            textBoxNotas = new TextBox();
            btnEditar = new Button();
            comboBoxProveedor = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label4 = new Label();
            grillaCambio = new DataGridView();
            btnCambioArticulo = new Button();
            label5 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaCambio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 21);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 0;
            label1.Text = "Editar Ingreso";
            // 
            // btnElegirIngreso
            // 
            btnElegirIngreso.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnElegirIngreso.Location = new Point(553, 145);
            btnElegirIngreso.Name = "btnElegirIngreso";
            btnElegirIngreso.Size = new Size(123, 36);
            btnElegirIngreso.TabIndex = 3;
            btnElegirIngreso.Text = "Elegir ingreso";
            btnElegirIngreso.UseVisualStyleBackColor = true;
            btnElegirIngreso.Click += btnElegirArticulo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 81);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 4;
            label2.Text = "Ingreso";
            // 
            // grilla
            // 
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(177, 81);
            grilla.Margin = new Padding(3, 2, 3, 2);
            grilla.Name = "grilla";
            grilla.RowHeadersWidth = 51;
            grilla.Size = new Size(975, 43);
            grilla.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(687, 653);
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
            label3.Location = new Point(821, 414);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 7;
            label3.Text = "Nueva cantidad:";
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownCantidad.Location = new Point(943, 410);
            numericUpDownCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(120, 27);
            numericUpDownCantidad.TabIndex = 8;
            // 
            // comboBoxDeposito
            // 
            comboBoxDeposito.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDeposito.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDeposito.FormattingEnabled = true;
            comboBoxDeposito.Location = new Point(302, 334);
            comboBoxDeposito.Name = "comboBoxDeposito";
            comboBoxDeposito.Size = new Size(365, 28);
            comboBoxDeposito.TabIndex = 10;
            // 
            // comboBoxTransportista
            // 
            comboBoxTransportista.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransportista.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTransportista.FormattingEnabled = true;
            comboBoxTransportista.Location = new Point(302, 492);
            comboBoxTransportista.Name = "comboBoxTransportista";
            comboBoxTransportista.Size = new Size(365, 28);
            comboBoxTransportista.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(96, 580);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 13;
            label6.Text = "Notas";
            // 
            // textBoxNotas
            // 
            textBoxNotas.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNotas.Location = new Point(179, 576);
            textBoxNotas.Name = "textBoxNotas";
            textBoxNotas.Size = new Size(973, 27);
            textBoxNotas.TabIndex = 16;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(452, 653);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(123, 36);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // comboBoxProveedor
            // 
            comboBoxProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProveedor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxProveedor.FormattingEnabled = true;
            comboBoxProveedor.Location = new Point(302, 413);
            comboBoxProveedor.Name = "comboBoxProveedor";
            comboBoxProveedor.Size = new Size(365, 28);
            comboBoxProveedor.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(96, 338);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 22;
            label8.Text = "Nuevo depósito:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(96, 414);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 23;
            label9.Text = "Nuevo proveedor:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(96, 496);
            label10.Name = "label10";
            label10.Size = new Size(142, 20);
            label10.TabIndex = 24;
            label10.Text = "Nuevo transportista:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 203);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 25;
            label4.Text = "Cambiar";
            // 
            // grillaCambio
            // 
            grillaCambio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCambio.Location = new Point(177, 203);
            grillaCambio.Margin = new Padding(3, 2, 3, 2);
            grillaCambio.Name = "grillaCambio";
            grillaCambio.RowHeadersWidth = 51;
            grillaCambio.Size = new Size(975, 43);
            grillaCambio.TabIndex = 27;
            // 
            // btnCambioArticulo
            // 
            btnCambioArticulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambioArticulo.Location = new Point(553, 267);
            btnCambioArticulo.Name = "btnCambioArticulo";
            btnCambioArticulo.Size = new Size(123, 36);
            btnCambioArticulo.TabIndex = 26;
            btnCambioArticulo.Text = "Elegir artículo";
            btnCambioArticulo.UseVisualStyleBackColor = true;
            btnCambioArticulo.Click += btnCambioArticulo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(99, 226);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 28;
            label5.Text = "artículo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(98, 104);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 29;
            label7.Text = "a editar:";
            // 
            // EditarMovimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 714);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(grillaCambio);
            Controls.Add(label4);
            Controls.Add(btnCambioArticulo);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(comboBoxProveedor);
            Controls.Add(btnEditar);
            Controls.Add(textBoxNotas);
            Controls.Add(comboBoxTransportista);
            Controls.Add(comboBoxDeposito);
            Controls.Add(numericUpDownCantidad);
            Controls.Add(btnCancelar);
            Controls.Add(grilla);
            Controls.Add(btnElegirIngreso);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "EditarMovimiento";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Ingreso";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaCambio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnElegirIngreso;
        private Label label2;
        private DataGridView grilla;
        private Button btnCancelar;
        private Label label3;
        private NumericUpDown numericUpDownCantidad;
        private ComboBox comboBoxDeposito;
        private ComboBox comboBoxTransportista;
        private Label label6;
        private TextBox textBoxNotas;
        private Button btnEditar;
        private ComboBox comboBoxProveedor;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label4;
        private DataGridView grillaCambio;
        private Button btnCambioArticulo;
        private Label label5;
        private Label label7;
    }
}