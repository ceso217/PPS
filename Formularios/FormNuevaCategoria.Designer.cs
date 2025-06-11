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
            textBoxNuevaCategoria.Location = new Point(255, 96);
            textBoxNuevaCategoria.Name = "textBoxNuevaCategoria";
            textBoxNuevaCategoria.Size = new Size(219, 27);
            textBoxNuevaCategoria.TabIndex = 0;
            // 
            // btnCrearCategoria
            // 
            btnCrearCategoria.Font = new Font("Segoe UI", 11.25F);
            btnCrearCategoria.Location = new Point(143, 174);
            btnCrearCategoria.Name = "btnCrearCategoria";
            btnCrearCategoria.Size = new Size(95, 35);
            btnCrearCategoria.TabIndex = 1;
            btnCrearCategoria.Text = "Crear";
            btnCrearCategoria.UseVisualStyleBackColor = true;
            btnCrearCategoria.Click += btnCrearCategoria_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 22);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 2;
            label1.Text = "Nueva Categoría";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(31, 99);
            label2.Name = "label2";
            label2.Size = new Size(214, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre de la nueva categoría:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(267, 174);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormNuevaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 232);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrearCategoria);
            Controls.Add(textBoxNuevaCategoria);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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