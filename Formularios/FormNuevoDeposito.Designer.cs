namespace GestionDeStock.Formularios
{
    partial class FormNuevoDeposito
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
            textBoxNuevoDeposito = new TextBox();
            btnCrearDeposito = new Button();
            label1 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // textBoxNuevoDeposito
            // 
            textBoxNuevoDeposito.Font = new Font("Segoe UI", 11.25F);
            textBoxNuevoDeposito.Location = new Point(250, 96);
            textBoxNuevoDeposito.Name = "textBoxNuevoDeposito";
            textBoxNuevoDeposito.Size = new Size(219, 27);
            textBoxNuevoDeposito.TabIndex = 0;
            textBoxNuevoDeposito.KeyDown += textBoxNuevaDeposito_KeyDown;
            // 
            // btnCrearDeposito
            // 
            btnCrearDeposito.Font = new Font("Segoe UI", 11.25F);
            btnCrearDeposito.Location = new Point(143, 174);
            btnCrearDeposito.Name = "btnCrearDeposito";
            btnCrearDeposito.Size = new Size(95, 35);
            btnCrearDeposito.TabIndex = 1;
            btnCrearDeposito.Text = "Crear";
            btnCrearDeposito.UseVisualStyleBackColor = true;
            btnCrearDeposito.Click += btnCrearDeposito_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 22);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 2;
            label1.Text = "Nuevo Depósito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(45, 99);
            label2.Name = "label2";
            label2.Size = new Size(199, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre del nuevo depósito:";
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
            // FormNuevoDeposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 232);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrearDeposito);
            Controls.Add(textBoxNuevoDeposito);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormNuevoDeposito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear nuevo depósito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNuevoDeposito;
        private Button btnCrearDeposito;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
    }
}