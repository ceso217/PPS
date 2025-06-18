namespace GestionDeStock.Formularios
{
    partial class FormNuevoIngreso
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
            btnElegirArticulo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 27);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Ingreso";
            // 
            // btnElegirArticulo
            // 
            btnElegirArticulo.Location = new Point(341, 70);
            btnElegirArticulo.Name = "btnElegirArticulo";
            btnElegirArticulo.Size = new Size(123, 36);
            btnElegirArticulo.TabIndex = 3;
            btnElegirArticulo.Text = "Elegir artículo";
            btnElegirArticulo.UseVisualStyleBackColor = true;
            btnElegirArticulo.Click += btnElegirArticulo_Click;
            // 
            // FormNuevoIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 432);
            Controls.Add(btnElegirArticulo);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormNuevoIngreso";
            Text = "FormNuevoIngreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnElegirArticulo;
    }
}