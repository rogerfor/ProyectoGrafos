using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;



namespace ProyectoGrafos
{
    public partial class Grafos : Form
    {
        public Grafos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                StringBuilder grafo = new StringBuilder();
                grafo.AppendLine("digraph A{");
                foreach (Control num in this.Controls)
                {
                    if (num is TextBox)
                    {
                        if (string.IsNullOrEmpty(num.Text))
                        {
                            MessageBox.Show("Ingrese todos los valores.", "Error de validación",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            byte Valor;
                            byte.TryParse(num.Text, out Valor);
                            if (Valor.Equals(1))
                                grafo.AppendLine(num.Name.Substring(0, 1) + " -> " + num.Name.Substring(1, 1));
                            else
                                grafo.AppendLine();
                        }
                    }
                }
                grafo.AppendLine("}");
                File.WriteAllText(@"grafo.dot", grafo.ToString());

                #region Guardar y Crear la imagen

                saveFileDialog1.Filter = "Archivos de imagen (*.png)|*.png";

                saveFileDialog1.Title = "Nombre para el archivo";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ProcessStartInfo Grafo = new ProcessStartInfo(@"dot.exe");
                    Grafo.Arguments = "grafo.dot -o " + saveFileDialog1.FileName + " -Tpng -Grankdir=LR";
                    Grafo.UseShellExecute = true;
                    Process.Start(Grafo);

                }
                {
                    Thread.Sleep(1000);
                    pictureBox1.Image = Image.FromFile(saveFileDialog1.FileName);
                }

                #endregion


            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            acerca form = new acerca();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control resetear in this.Controls)
            {

                if (resetear is TextBox)
                {
                    resetear.Text = "0";
                    this.AA.Focus();
                    pictureBox1.Image = null;

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro que desea salir?", "GraphSoft", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }
    }
}
