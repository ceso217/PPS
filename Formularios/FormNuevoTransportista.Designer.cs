namespace GestionDeStock.Formularios
{
    partial class FormNuevoTransportista
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
            textBoxNuevoTransportista = new TextBox();
            btnCrearTransportista = new Button();
            label1 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // textBoxNuevoTransportista
            // 
            textBoxNuevoTransportista.Font = new Font("Segoe UI", 11.25F);
            textBoxNuevoTransportista.Location = new Point(283, 96);
            textBoxNuevoTransportista.Name = "textBoxNuevoTransportista";
            textBoxNuevoTransportista.Size = new Size(219, 27);
            textBoxNuevoTransportista.TabIndex = 0;
            textBoxNuevoTransportista.KeyDown += textBoxNuevaTransportista_KeyDown;
            // 
            // btnCrearTransportista
            // 
            btnCrearTransportista.Font = new Font("Segoe UI", 11.25F);
            btnCrearTransportista.Location = new Point(143, 174);
            btnCrearTransportista.Name = "btnCrearTransportista";
            btnCrearTransportista.Size = new Size(95, 35);
            btnCrearTransportista.TabIndex = 1;
            btnCrearTransportista.Text = "Crear";
            btnCrearTransportista.UseVisualStyleBackColor = true;
            btnCrearTransportista.Click += btnCrearTransportista_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 22);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 2;
            label1.Text = "Nuevo Transportista";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(31, 99);
            label2.Name = "label2";
            label2.Size = new Size(223, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre del nuevo transportista:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(283, 174);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormNuevoTransportista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 232);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrearTransportista);
            Controls.Add(textBoxNuevoTransportista);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormNuevoTransportista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear nuevo transportista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNuevoTransportista;
        private Button btnCrearTransportista;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
    }
}