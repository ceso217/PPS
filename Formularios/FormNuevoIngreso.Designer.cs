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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 36);
            label1.Name = "label1";
            label1.Size = new Size(162, 31);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Ingreso";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(674, 27);
            textBox1.TabIndex = 1;
            textBox1.Click += textBox1_Click;
            // 
            // FormNuevoIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 576);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormNuevoIngreso";
            Text = "FormNuevoIngreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
    }
}