using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        if (string.IsNullOrEmpty(c.Text))
                        {
                            MessageBox.Show("Ingrese todos los valores.", "Error de validación",
                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            byte Valor;
                            byte.TryParse(c.Text, out Valor);
                            if (Valor.Equals(1))
                                grafo.AppendLine(c.Name.Substring(0, 1) + " -> " + c.Name.Substring(1, 1));
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

                #endregion


            }
        }
    }
}
