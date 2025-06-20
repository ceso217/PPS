namespace GestionDeStock.Controles
{
    partial class ucSalida
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            grillaSalida = new DataGridView();
            btnNuevaSalida = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaSalida).BeginInit();
            SuspendLayout();
            // 
            // grillaSalida
            // 
            grillaSalida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaSalida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grillaSalida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaSalida.Location = new Point(0, 47);
            grillaSalida.Name = "grillaSalida";
            grillaSalida.RowHeadersWidth = 51;
            grillaSalida.Size = new Size(805, 434);
            grillaSalida.TabIndex = 1;
            // 
            // btnNuevaSalida
            // 
            btnNuevaSalida.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaSalida.Location = new Point(3, 2);
            btnNuevaSalida.Margin = new Padding(3, 2, 3, 2);
            btnNuevaSalida.Name = "btnNuevaSalida";
            btnNuevaSalida.Size = new Size(165, 41);
            btnNuevaSalida.TabIndex = 2;
            btnNuevaSalida.Text = "Nueva Salida";
            btnNuevaSalida.UseVisualStyleBackColor = true;
            btnNuevaSalida.Click += btnNuevaSalida_Click;
            // 
            // ucSalida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNuevaSalida);
            Controls.Add(grillaSalida);
            Name = "ucSalida";
            Size = new Size(805, 481);
            ((System.ComponentModel.ISupportInitialize)grillaSalida).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaSalida;
        private Button btnNuevaSalida;
    }
}
