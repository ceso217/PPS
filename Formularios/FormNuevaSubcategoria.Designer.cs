namespace GestionDeStock.Formularios
{
    partial class FormNuevaSubcategoria
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
            textBoxNuevaSubcategoria = new TextBox();
            btnCrearSubcategoria = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            comboBoxCategoria = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 22);
            label1.Name = "label1";
            label1.Size = new Size(182, 25);
            label1.TabIndex = 0;
            label1.Text = "Nueva Subcategoría";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(12, 144);
            label2.Name = "label2";
            label2.Size = new Size(237, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre de la nueva subcategoría:";
            // 
            // textBoxNuevaSubcategoria
            // 
            textBoxNuevaSubcategoria.Font = new Font("Segoe UI", 11.25F);
            textBoxNuevaSubcategoria.Location = new Point(274, 141);
            textBoxNuevaSubcategoria.Margin = new Padding(3, 2, 3, 2);
            textBoxNuevaSubcategoria.Name = "textBoxNuevaSubcategoria";
            textBoxNuevaSubcategoria.Size = new Size(240, 27);
            textBoxNuevaSubcategoria.TabIndex = 2;
            // 
            // btnCrearSubcategoria
            // 
            btnCrearSubcategoria.Font = new Font("Segoe UI", 11.25F);
            btnCrearSubcategoria.Location = new Point(155, 199);
            btnCrearSubcategoria.Margin = new Padding(3, 2, 3, 2);
            btnCrearSubcategoria.Name = "btnCrearSubcategoria";
            btnCrearSubcategoria.Size = new Size(94, 35);
            btnCrearSubcategoria.TabIndex = 3;
            btnCrearSubcategoria.Text = "Crear";
            btnCrearSubcategoria.UseVisualStyleBackColor = true;
            btnCrearSubcategoria.Click += btnCrearSubcategoria_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(274, 199);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 85);
            label3.Name = "label3";
            label3.Size = new Size(200, 20);
            label3.TabIndex = 5;
            label3.Text = "Perteneciente a la categoría: ";
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(274, 85);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(240, 28);
            comboBoxCategoria.TabIndex = 6;
            // 
            // FormNuevaSubcategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 263);
            Controls.Add(comboBoxCategoria);
            Controls.Add(label3);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrearSubcategoria);
            Controls.Add(textBoxNuevaSubcategoria);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormNuevaSubcategoria";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Nueva Subcategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNuevaSubcategoria;
        private Button btnCrearSubcategoria;
        private Button btnCancelar;
        private Label label3;
        private ComboBox comboBoxCategoria;
    }
}