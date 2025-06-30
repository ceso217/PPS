namespace GestionDeStock.Formularios
{
    partial class Eliminar
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
            labelElementoEliminar = new Label();
            comboBoxElemento = new ComboBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(55, 46);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(63, 25);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "label1";
            // 
            // labelElementoEliminar
            // 
            labelElementoEliminar.AutoSize = true;
            labelElementoEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelElementoEliminar.Location = new Point(78, 131);
            labelElementoEliminar.Name = "labelElementoEliminar";
            labelElementoEliminar.Size = new Size(50, 20);
            labelElementoEliminar.TabIndex = 1;
            labelElementoEliminar.Text = "label2";
            // 
            // comboBoxElemento
            // 
            comboBoxElemento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxElemento.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxElemento.FormattingEnabled = true;
            comboBoxElemento.Location = new Point(228, 128);
            comboBoxElemento.Name = "comboBoxElemento";
            comboBoxElemento.Size = new Size(305, 28);
            comboBoxElemento.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(193, 220);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(87, 32);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(331, 220);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 32);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Eliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 290);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(comboBoxElemento);
            Controls.Add(labelElementoEliminar);
            Controls.Add(labelTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Eliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelElementoEliminar;
        private ComboBox comboBoxElemento;
        private Button btnEliminar;
        private Button btnCancelar;
    }
}