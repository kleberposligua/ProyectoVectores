﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVectores
{
    public partial class Form1 : Form
    {
        const int MAX = 100; 
        private int[] vector = new int[MAX];
        private int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(this.txtNumero.Text, out int num))
                {
                    //TODO: asignar cada entero al vector
                    if (contador < MAX)
                    {
                        vector[contador] = num;
                        contador++;
                        this.lstVector.Items.Add(num);
                    }
                    this.txtNumero.Text = "";
                }
                else
                {
                    MessageBox.Show("Por favor ingresa solo valores numéricos...");
                    this.txtNumero.Focus();
                }
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Funciones.Operaciones op = new Funciones.Operaciones();
            int[] x = clases.Ordenacion.ordenaSeleccion(vector, contador);
            // en los métodos estáticos no se necesita crear una instancia de la
            // clase para llamarlo.

            // TODO: mostrar el vector ordenado en un ListBox
            this.lstVector.Items.Clear();
            for(int i=0; i<contador; i++)
            {
                this.lstVector.Items.Add(x[i]);
            }
        }
    }
}
