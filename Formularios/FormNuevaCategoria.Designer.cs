namespace GestionDeStock.Formularios
{
    partial class FormNuevaCategoria
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
            textBoxNuevaCategoria = new TextBox();
            btnCrearCategoria = new Button();
            label1 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // textBoxNuevaCategoria
            // 
            textBoxNuevaCategoria.Font = new Font("Segoe UI", 11.25F);
            textBoxNuevaCategoria.Location = new Point(312, 125);
            textBoxNuevaCategoria.Margin = new Padding(3, 4, 3, 4);
            textBoxNuevaCategoria.Name = "textBoxNuevaCategoria";
            textBoxNuevaCategoria.Size = new Size(250, 32);
            textBoxNuevaCategoria.TabIndex = 0;
            // 
            // btnCrearCategoria
            // 
            btnCrearCategoria.Font = new Font("Segoe UI", 11.25F);
            btnCrearCategoria.Location = new Point(163, 232);
            btnCrearCategoria.Margin = new Padding(3, 4, 3, 4);
            btnCrearCategoria.Name = "btnCrearCategoria";
            btnCrearCategoria.Size = new Size(109, 47);
            btnCrearCategoria.TabIndex = 1;
            btnCrearCategoria.Text = "Crear";
            btnCrearCategoria.UseVisualStyleBackColor = true;
            btnCrearCategoria.Click += btnCrearCategoria_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(192, 32);
            label1.TabIndex = 2;
            label1.Text = "Nueva Categoría";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(35, 132);
            label2.Name = "label2";
            label2.Size = new Size(271, 25);
            label2.TabIndex = 3;
            label2.Text = "Nombre de la nueva categoría:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(323, 232);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 47);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormNuevaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 309);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrearCategoria);
            Controls.Add(textBoxNuevaCategoria);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormNuevaCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear nueva categoría";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNuevaCategoria;
        private Button btnCrearCategoria;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
    }
}