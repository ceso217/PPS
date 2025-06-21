namespace GestionDeStock.Formularios
{
    partial class NuevaMarca
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
            textBox1 = new TextBox();
            btnCancelar = new Button();
            btnCrear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 35);
            label1.Name = "label1";
            label1.Size = new Size(155, 32);
            label1.TabIndex = 0;
            label1.Text = "Nueva Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(26, 120);
            label2.Name = "label2";
            label2.Size = new Size(244, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre de la nueva marca:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F);
            textBox1.Location = new Point(267, 116);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(234, 32);
            textBox1.TabIndex = 2;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(286, 200);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 45);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI", 11.25F);
            btnCrear.Location = new Point(121, 200);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(112, 45);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // FormNuevaMarca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 283);
            Controls.Add(btnCrear);
            Controls.Add(btnCancelar);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormNuevaMarca";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear nueva marca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button btnCancelar;
        private Button btnCrear;
    }
}