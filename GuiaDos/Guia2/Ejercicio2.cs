using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia2 {
    public partial class Ejercicio2 : Form {
        public Ejercicio2() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

            this.Text = string.Concat("Visor de Imagenes(" + openFileDialog1.FileName + ")");
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("Calc");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("Chrome", "https://www.utec.edu.sv"); //me gusta mas Google Chrome :3
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\");
        }
    }
}
