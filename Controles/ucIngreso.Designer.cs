namespace GestionDeStock.Controles
{
    partial class ucIngreso
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
            grillaIngreso = new DataGridView();
            btnNuevoIngreso = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaIngreso).BeginInit();
            SuspendLayout();
            // 
            // grillaIngreso
            // 
            grillaIngreso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaIngreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grillaIngreso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaIngreso.Location = new Point(0, 63);
            grillaIngreso.Margin = new Padding(3, 4, 3, 4);
            grillaIngreso.Name = "grillaIngreso";
            grillaIngreso.RowHeadersWidth = 51;
            grillaIngreso.Size = new Size(920, 579);
            grillaIngreso.TabIndex = 1;
            // 
            // btnNuevoIngreso
            // 
            btnNuevoIngreso.Location = new Point(3, 3);
            btnNuevoIngreso.Name = "btnNuevoIngreso";
            btnNuevoIngreso.Size = new Size(189, 55);
            btnNuevoIngreso.TabIndex = 2;
            btnNuevoIngreso.Text = "Nuevo Ingreso";
            btnNuevoIngreso.UseVisualStyleBackColor = true;
            btnNuevoIngreso.Click += btnNuevoIngreso_Click;
            // 
            // ucIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNuevoIngreso);
            Controls.Add(grillaIngreso);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ucIngreso";
            Size = new Size(920, 641);
            ((System.ComponentModel.ISupportInitialize)grillaIngreso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaIngreso;
        private Button btnNuevoIngreso;
    }
}
