namespace GestionDeStock
{
    partial class FormNuevoArtículo
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
            comboBoxCategoria = new ComboBox();
            label2 = new Label();
            comboBoxSubcategoria = new ComboBox();
            label3 = new Label();
            textBoxDescription = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBoxMarca = new ComboBox();
            label7 = new Label();
            comboBoxUM = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnAgregar = new Button();
            btnCancelar = new Button();
            numericUpDownStock = new NumericUpDown();
            btnCrearCategoria = new Button();
            btnCrearSubcategoria = new Button();
            btnCrearMarca = new Button();
            btnCrearUM = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(72, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Categoría";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.Font = new Font("Segoe UI", 11.25F);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.ImeMode = ImeMode.On;
            comboBoxCategoria.Location = new Point(187, 87);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(287, 28);
            comboBoxCategoria.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(49, 67);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Subcategoría";
            // 
            // comboBoxSubcategoria
            // 
            comboBoxSubcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubcategoria.Font = new Font("Segoe UI", 11.25F);
            comboBoxSubcategoria.FormattingEnabled = true;
            comboBoxSubcategoria.Location = new Point(187, 150);
            comboBoxSubcategoria.Name = "comboBoxSubcategoria";
            comboBoxSubcategoria.Size = new Size(287, 28);
            comboBoxSubcategoria.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(55, 134);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 4;
            label3.Text = " Descripción";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 11.25F);
            textBoxDescription.Location = new Point(187, 217);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(628, 27);
            textBoxDescription.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F);
            textBox2.Location = new Point(187, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 27);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(113, 201);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 6;
            label4.Text = "MN";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11.25F);
            textBox3.Location = new Point(431, 284);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(134, 27);
            textBox3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(364, 287);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 8;
            label5.Text = "Modelo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(601, 287);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 10;
            label6.Text = "Stock inicial";
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMarca.Font = new Font("Segoe UI", 11.25F);
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(187, 419);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(238, 28);
            comboBoxMarca.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(96, 336);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 12;
            label7.Text = "Marca";
            // 
            // comboBoxUM
            // 
            comboBoxUM.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUM.Font = new Font("Segoe UI", 11.25F);
            comboBoxUM.FormattingEnabled = true;
            comboBoxUM.Location = new Point(187, 351);
            comboBoxUM.Name = "comboBoxUM";
            comboBoxUM.Size = new Size(238, 28);
            comboBoxUM.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(13, 268);
            label8.Name = "label8";
            label8.Size = new Size(133, 20);
            label8.TabIndex = 14;
            label8.Text = "Unidad de Medida";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(27, 20);
            label9.Name = "label9";
            label9.Size = new Size(152, 30);
            label9.TabIndex = 16;
            label9.Text = "Nuevo Artículo";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 5);
            tableLayoutPanel1.Location = new Point(32, 86);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RightToLeft = RightToLeft.Yes;
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6693344F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(149, 408);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.RosyBrown;
            btnAgregar.Font = new Font("Segoe UI", 12F);
            btnAgregar.Location = new Point(314, 496);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(111, 40);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.RosyBrown;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(472, 496);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 40);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDownStock.Location = new Point(695, 284);
            numericUpDownStock.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(120, 27);
            numericUpDownStock.TabIndex = 20;
            // 
            // btnCrearCategoria
            // 
            btnCrearCategoria.FlatStyle = FlatStyle.System;
            btnCrearCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearCategoria.Location = new Point(506, 83);
            btnCrearCategoria.Name = "btnCrearCategoria";
            btnCrearCategoria.Size = new Size(197, 35);
            btnCrearCategoria.TabIndex = 21;
            btnCrearCategoria.Text = "Crear nueva categoría";
            btnCrearCategoria.UseVisualStyleBackColor = true;
            btnCrearCategoria.Click += btnCrearCategoria_Click;
            // 
            // btnCrearSubcategoria
            // 
            btnCrearSubcategoria.FlatStyle = FlatStyle.System;
            btnCrearSubcategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearSubcategoria.Location = new Point(506, 146);
            btnCrearSubcategoria.Name = "btnCrearSubcategoria";
            btnCrearSubcategoria.Size = new Size(197, 35);
            btnCrearSubcategoria.TabIndex = 22;
            btnCrearSubcategoria.Text = "Crear nueva subcategoría";
            btnCrearSubcategoria.UseVisualStyleBackColor = true;
            // 
            // btnCrearMarca
            // 
            btnCrearMarca.FlatStyle = FlatStyle.System;
            btnCrearMarca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearMarca.Location = new Point(472, 415);
            btnCrearMarca.Name = "btnCrearMarca";
            btnCrearMarca.Size = new Size(231, 35);
            btnCrearMarca.TabIndex = 23;
            btnCrearMarca.Text = "Crear nueva marca";
            btnCrearMarca.UseVisualStyleBackColor = true;
            // 
            // btnCrearUM
            // 
            btnCrearUM.FlatStyle = FlatStyle.System;
            btnCrearUM.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCrearUM.Location = new Point(472, 347);
            btnCrearUM.Name = "btnCrearUM";
            btnCrearUM.Size = new Size(231, 35);
            btnCrearUM.TabIndex = 24;
            btnCrearUM.Text = "Crear nueva unidad de medida";
            btnCrearUM.UseVisualStyleBackColor = true;
            // 
            // FormNuevoArtículo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 567);
            Controls.Add(btnCrearUM);
            Controls.Add(btnCrearMarca);
            Controls.Add(btnCrearSubcategoria);
            Controls.Add(btnCrearCategoria);
            Controls.Add(numericUpDownStock);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(textBoxDescription);
            Controls.Add(comboBoxCategoria);
            Controls.Add(label9);
            Controls.Add(comboBoxUM);
            Controls.Add(comboBoxMarca);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(comboBoxSubcategoria);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormNuevoArtículo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar artículo";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxCategoria;
        private Label label2;
        private ComboBox comboBoxSubcategoria;
        private Label label3;
        private TextBox textBoxDescription;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxMarca;
        private Label label7;
        private ComboBox comboBoxUM;
        private Label label8;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAgregar;
        private Button btnCancelar;
        private NumericUpDown numericUpDownStock;
        private Button btnCrearCategoria;
        private Button btnCrearSubcategoria;
        private Button btnCrearMarca;
        private Button btnCrearUM;
    }
}