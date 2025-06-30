namespace GestionDeStock.Formularios
{
    partial class EditarArticulo
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
            btnElegirArticulo = new Button();
            grilla = new DataGridView();
            label3 = new Label();
            textBoxDescripcion = new TextBox();
            textBoxMN = new TextBox();
            label4 = new Label();
            textBoxModelo = new TextBox();
            label5 = new Label();
            comboBoxMarca = new ComboBox();
            label7 = new Label();
            comboBoxUM = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            btnEditar = new Button();
            btnCancelar = new Button();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(84, 226);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Nueva categoría:";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.Font = new Font("Segoe UI", 10.2F);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.ImeMode = ImeMode.On;
            comboBoxCategoria.Location = new Point(218, 224);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(295, 27);
            comboBoxCategoria.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(586, 226);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 2;
            label2.Text = "Nueva subcategoría:";
            // 
            // comboBoxSubcategoria
            // 
            comboBoxSubcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSubcategoria.Font = new Font("Segoe UI", 10.2F);
            comboBoxSubcategoria.FormattingEnabled = true;
            comboBoxSubcategoria.Location = new Point(751, 224);
            comboBoxSubcategoria.Name = "comboBoxSubcategoria";
            comboBoxSubcategoria.Size = new Size(287, 27);
            comboBoxSubcategoria.TabIndex = 3;
            // 
            // btnElegirArticulo
            // 
            btnElegirArticulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnElegirArticulo.Location = new Point(506, 157);
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
            grilla.Location = new Point(151, 93);
            grilla.Margin = new Padding(3, 2, 3, 2);
            grilla.Name = "grilla";
            grilla.RowHeadersWidth = 51;
            grilla.Size = new Size(887, 43);
            grilla.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(84, 310);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 4;
            label3.Text = "Descripción:";
            // 
            // textBoxDescription
            // 
            textBoxDescripcion.Font = new Font("Segoe UI", 10.2F);
            textBoxDescripcion.Location = new Point(218, 310);
            textBoxDescripcion.Name = "textBoxDescription";
            textBoxDescripcion.Size = new Size(820, 26);
            textBoxDescripcion.TabIndex = 5;
            // 
            // textBoxMN
            // 
            textBoxMN.Font = new Font("Segoe UI", 10.2F);
            textBoxMN.Location = new Point(218, 394);
            textBoxMN.Name = "textBoxMN";
            textBoxMN.Size = new Size(253, 26);
            textBoxMN.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(84, 396);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 6;
            label4.Text = "Nuevo MN:";
            // 
            // textBoxModelo
            // 
            textBoxModelo.Font = new Font("Segoe UI", 10.2F);
            textBoxModelo.Location = new Point(785, 394);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(253, 26);
            textBoxModelo.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(663, 396);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 8;
            label5.Text = "Nuevo modelo:";
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMarca.Font = new Font("Segoe UI", 10.2F);
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(751, 480);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(287, 27);
            comboBoxMarca.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(631, 480);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 12;
            label7.Text = "Nueva marca:";
            // 
            // comboBoxUM
            // 
            comboBoxUM.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUM.Font = new Font("Segoe UI", 10.2F);
            comboBoxUM.FormattingEnabled = true;
            comboBoxUM.Location = new Point(288, 480);
            comboBoxUM.Name = "comboBoxUM";
            comboBoxUM.Size = new Size(287, 27);
            comboBoxUM.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(84, 480);
            label8.Name = "label8";
            label8.Size = new Size(180, 20);
            label8.TabIndex = 14;
            label8.Text = "Nueva unidad de medida:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label9.Location = new Point(27, 20);
            label9.Name = "label9";
            label9.Size = new Size(144, 30);
            label9.TabIndex = 16;
            label9.Text = "Editar Artículo";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.RosyBrown;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.Location = new Point(411, 570);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(111, 40);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.RosyBrown;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(606, 570);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 40);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.Location = new Point(84, 93);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 21;
            label10.Text = "Artículo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(84, 116);
            label11.Name = "label11";
            label11.Size = new Size(63, 20);
            label11.TabIndex = 22;
            label11.Text = "a editar:";
            // 
            // EditarArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 639);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(textBoxDescripcion);
            Controls.Add(comboBoxCategoria);
            Controls.Add(label9);
            Controls.Add(comboBoxUM);
            Controls.Add(comboBoxMarca);
            Controls.Add(textBoxModelo);
            Controls.Add(grilla);
            Controls.Add(btnElegirArticulo);
            Controls.Add(label5);
            Controls.Add(textBoxMN);
            Controls.Add(comboBoxSubcategoria);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EditarArticulo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar artículo";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxCategoria;
        private Label label2;
        private ComboBox comboBoxSubcategoria;
        private Label label3;
        private TextBox textBoxDescripcion;
        private TextBox textBoxMN;
        private Label label4;
        private TextBox textBoxModelo;
        private Label label5;
        private ComboBox comboBoxMarca;
        private Label label7;
        private ComboBox comboBoxUM;
        private Label label8;
        private Label label9;
        private Button btnEditar;
        private Button btnCancelar;
        private Button btnElegirArticulo;
        private DataGridView grilla;
        private Label label10;
        private Label label11;
    }
}