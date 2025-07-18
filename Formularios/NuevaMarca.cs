﻿using GestionDeStock.DBContext;
using GestionDeStock.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionDeStock.Formularios
{
    public partial class NuevaMarca : Form
    {
        public Marca MarcaCreada { get; private set; }
        public NuevaMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            using (var context = new StockBDContext())
            {
                var marcas = context.Marcas.ToList();

                bool existe = false;

                foreach (Marca m in marcas)
                {

                    if (m.Nombre == textBox1.Text)
                    {
                        MessageBox.Show("La marca \"" + textBox1.Text + "\" ya existe.", "Marca existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        existe = true;
                        break;
                    }
                }

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("El campo \"Nombre de la nueva marca\" esta incompleto.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!existe)
                {
                    MarcaCreada = new Marca()
                    {
                        Nombre = textBox1.Text
                    };

                    context.Marcas.Add(MarcaCreada);
                    context.SaveChanges();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCrear.PerformClick();
                e.Handled = true;
            }
        }
    }
}
