namespace GestionDeStock.Formularios
{
    partial class EliminarSeleccionar
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
            labelTitulo = new Label();
            labelElemento = new Label();
            grilla = new DataGridView();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnSeleccionar = new Button();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(52, 40);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(63, 25);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "label1";
            // 
            // labelElemento
            // 
            labelElemento.AutoSize = true;
            labelElemento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelElemento.Location = new Point(85, 122);
            labelElemento.Name = "labelElemento";
            labelElemento.Size = new Size(50, 20);
            labelElemento.TabIndex = 1;
            labelElemento.Text = "label2";
            // 
            // grilla
            // 
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(176, 110);
            grilla.Margin = new Padding(3, 2, 3, 2);
            grilla.Name = "grilla";
            grilla.RowHeadersWidth = 51;
            grilla.Size = new Size(961, 43);
            grilla.TabIndex = 5;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 11.25F);
            btnEliminar.Location = new Point(457, 248);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 37);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F);
            btnCancelar.Location = new Point(642, 248);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 37);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Font = new Font("Segoe UI", 11.25F);
            btnSeleccionar.Location = new Point(498, 168);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(204, 37);
            btnSeleccionar.TabIndex = 8;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // EliminarSeleccionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 306);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(labelElemento);
            Controls.Add(labelTitulo);
            Controls.Add(grilla);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "EliminarSeleccionar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EliminarSeleccionar";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelElemento;
        private DataGridView grilla;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnSeleccionar;
    }
}