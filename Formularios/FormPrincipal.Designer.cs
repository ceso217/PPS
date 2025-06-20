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
            btnSalida = new Button();
            btnIngreso = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.Location = new Point(147, 3);
            panel.Name = "panel";
            panel.Size = new Size(1049, 565);
            panel.TabIndex = 0;
            // 
            // btnInventario
            // 
            btnInventario.FlatStyle = FlatStyle.System;
            btnInventario.Font = new Font("Segoe UI", 11.25F);
            btnInventario.Location = new Point(3, 3);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(123, 41);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            btnInventario.Click += btnInventario_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnSalida);
            panel1.Controls.Add(btnIngreso);
            panel1.Controls.Add(btnInventario);
            panel1.Location = new Point(12, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(129, 568);
            panel1.TabIndex = 1;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Font = new Font("Segoe UI", 11.25F);
            button4.Location = new Point(3, 144);
            button4.Name = "button4";
            button4.Size = new Size(123, 41);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnSalida
            // 
            btnSalida.FlatStyle = FlatStyle.System;
            btnSalida.Font = new Font("Segoe UI", 11.25F);
            btnSalida.Location = new Point(3, 97);
            btnSalida.Name = "btnSalida";
            btnSalida.Size = new Size(123, 41);
            btnSalida.TabIndex = 3;
            btnSalida.Text = "Salida";
            btnSalida.UseVisualStyleBackColor = true;
            btnSalida.Click += btnSalida_Click;
            // 
            // btnIngreso
            // 
            btnIngreso.FlatStyle = FlatStyle.System;
            btnIngreso.Font = new Font("Segoe UI", 11.25F);
            btnIngreso.Location = new Point(3, 50);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(123, 41);
            btnIngreso.TabIndex = 2;
            btnIngreso.Text = "Ingreso";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 580);
            Controls.Add(panel1);
            Controls.Add(panel);
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
        private Button btnSalida;
        private Button btnIngreso;
    }
}
