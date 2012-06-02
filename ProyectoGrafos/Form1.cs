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

            string fileName = "grafo.dot";
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter grafo = new StreamWriter(stream);

            grafo.WriteLine("digraph A {");
            /*A*/
            if (Convert.ToInt16(AA.Text).Equals(1))
            {
                grafo.WriteLine("A -> A;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(AB.Text).Equals(1))
            {
                grafo.WriteLine("A -> B;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(AC.Text).Equals(1))
            {

                grafo.WriteLine("A -> C;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(AD.Text).Equals(1))
            {

                grafo.WriteLine("A -> D;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(AE.Text).Equals(1))
            {

                grafo.WriteLine("A -> E;");
            }
            else
            {
                grafo.WriteLine("");
            }
            /*B*/
            if (Convert.ToInt16(BA.Text).Equals(1))
            {
                grafo.WriteLine("B -> A;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(BB.Text).Equals(1))
            {
                grafo.WriteLine("B -> B ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(BC.Text).Equals(1))
            {

                grafo.WriteLine("B -> C ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(BD.Text).Equals(1))
            {

                grafo.WriteLine("B -> D ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(BE.Text).Equals(1))
            {

                grafo.WriteLine("B -> E ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            /*C*/
            if (Convert.ToInt16(CA.Text).Equals(1))
            {
                grafo.WriteLine("C -> A;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(CB.Text).Equals(1))
            {
                grafo.WriteLine("C -> B ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(CC.Text).Equals(1))
            {

                grafo.WriteLine("C -> C ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(CD.Text).Equals(1))
            {

                grafo.WriteLine("C -> D ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(CE.Text).Equals(1))
            {

                grafo.WriteLine("C -> E ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            /*D*/
            if (Convert.ToInt16(DA.Text).Equals(1))
            {
                grafo.WriteLine("D -> A;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(DB.Text).Equals(1))
            {
                grafo.WriteLine("D -> B ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(DC.Text).Equals(1))
            {

                grafo.WriteLine("D -> C ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(DD.Text).Equals(1))
            {

                grafo.WriteLine("D -> D ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(DE.Text).Equals(1))
            {

                grafo.WriteLine("D -> E ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            /*E*/
            if (Convert.ToInt16(EA.Text).Equals(1))
            {
                grafo.WriteLine("E -> A;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(EB.Text).Equals(1))
            {
                grafo.WriteLine("E -> B ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(EC.Text).Equals(1))
            {

                grafo.WriteLine("E -> C ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(ED.Text).Equals(1))
            {

                grafo.WriteLine("E -> D ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            if (Convert.ToInt16(EE.Text).Equals(1))
            {

                grafo.WriteLine("E -> E ;");
            }
            else
            {
                grafo.WriteLine("");
            }
            grafo.WriteLine("}");
            grafo.Close();


            /**Guardar y Crear la Imagen*/
           
                ProcessStartInfo Grafo = new ProcessStartInfo("dot.exe");
                Grafo.Arguments = "grafo.dot -o grafo.png -Tpng -Grankdir=LR";
                Grafo.UseShellExecute = true;
                Process.Start(Grafo);
            
            
        }
    }
}
