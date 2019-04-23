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
    public partial class Ejercicio3 : Form {
        public Ejercicio3() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            double x, y;

            x = double.Parse(textBox1.Text);
            y = x * 1.8 + 32;

            textBox2.Text = y.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            double x, y;

            x = double.Parse(textBox1.Text);
            y = (x - 32) / 1.8;

            textBox2.Text = y.ToString();
        }

        private void button3_Click(object sender, EventArgs e) {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
