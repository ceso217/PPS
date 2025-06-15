namespace GestionDeStock
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel = new Panel();
            btnInventario = new Button();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            btnIngreso = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.Location = new Point(168, 4);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(1199, 753);
            panel.TabIndex = 0;
            // 
            // btnInventario
            // 
            btnInventario.FlatStyle = FlatStyle.System;
            btnInventario.Font = new Font("Segoe UI", 11.25F);
            btnInventario.Location = new Point(3, 4);
            btnInventario.Margin = new Padding(3, 4, 3, 4);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(141, 55);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnIngreso);
            panel1.Controls.Add(btnInventario);
            panel1.Location = new Point(14, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 757);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Segoe UI", 11.25F);
            button4.Location = new Point(3, 192);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(141, 55);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Font = new Font("Segoe UI", 11.25F);
            button3.Location = new Point(3, 129);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(141, 55);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnIngreso
            // 
            btnIngreso.FlatStyle = FlatStyle.System;
            btnIngreso.Font = new Font("Segoe UI", 11.25F);
            btnIngreso.Location = new Point(3, 67);
            btnIngreso.Margin = new Padding(3, 4, 3, 4);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(141, 55);
            btnIngreso.TabIndex = 2;
            btnIngreso.Text = "Ingreso";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 773);
            Controls.Add(panel1);
            Controls.Add(panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Stock";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Button btnInventario;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button btnIngreso;
    }
}
