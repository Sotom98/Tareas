using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            double v1, v2, rs;

            if (radioButton1.Checked == true) {
                v1 = double.Parse(textBox1.Text);
                v2 = double.Parse(textBox2.Text);

                rs = v1 + v2;
                textBox3.Text = rs.ToString();
            }

            if (radioButton2.Checked == true) {
                v1 = double.Parse(textBox1.Text);
                v2 = double.Parse(textBox2.Text);

                rs = v1 - v2;
                textBox3.Text = rs.ToString();
            }

            if (radioButton3.Checked == true) {
                v1 = double.Parse(textBox1.Text);
                v2 = double.Parse(textBox2.Text);

                rs = v1 * v2;
                textBox3.Text = rs.ToString();
            }

            if (radioButton4.Checked == true) {
                v1 = double.Parse(textBox1.Text);
                v2 = double.Parse(textBox2.Text);

                rs = v1 / v2;
                textBox3.Text = rs.ToString();
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
