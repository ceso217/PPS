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
            label2 = new Label();
            grilla = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
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
            // btnElegirArticulo
            // 
            btnElegirArticulo.Location = new Point(623, 309);
            btnElegirArticulo.Margin = new Padding(3, 4, 3, 4);
            btnElegirArticulo.Name = "btnElegirArticulo";
            btnElegirArticulo.Size = new Size(141, 48);
            btnElegirArticulo.TabIndex = 3;
            btnElegirArticulo.Text = "Elegir artículo";
            btnElegirArticulo.UseVisualStyleBackColor = true;
            btnElegirArticulo.Click += btnElegirArticulo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(65, 125);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 4;
            label2.Text = "Artículo";
            // 
            // grilla
            // 
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(161, 125);
            grilla.Name = "grilla";
            grilla.RowHeadersWidth = 51;
            grilla.Size = new Size(1082, 94);
            grilla.TabIndex = 5;
            // 
            // FormNuevoIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 576);
            Controls.Add(grilla);
            Controls.Add(label2);
            Controls.Add(btnElegirArticulo);
            Controls.Add(label1);
            Name = "FormNuevoIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Ingreso";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnElegirArticulo;
        private Label label2;
        private DataGridView grilla;
    }
}