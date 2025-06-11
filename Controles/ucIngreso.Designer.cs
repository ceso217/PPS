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
            ((System.ComponentModel.ISupportInitialize)grillaIngreso).BeginInit();
            SuspendLayout();
            // 
            // grillaIngreso
            // 
            grillaIngreso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grillaIngreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grillaIngreso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaIngreso.Location = new Point(0, 47);
            grillaIngreso.Name = "grillaIngreso";
            grillaIngreso.Size = new Size(805, 434);
            grillaIngreso.TabIndex = 1;
            // 
            // ucIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grillaIngreso);
            Name = "ucIngreso";
            Size = new Size(805, 481);
            ((System.ComponentModel.ISupportInitialize)grillaIngreso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaIngreso;
    }
}
