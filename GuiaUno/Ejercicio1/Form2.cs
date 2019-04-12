using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string usu, pass;

            usu = textBox1.Text.TrimEnd();
            pass = textBox2.Text.TrimEnd();

            if ((usu == "UTEC") && (pass == "programacion1")) {
                MessageBox.Show("Bienvenido al sistema 0te");
            }
            else {
                MessageBox.Show("Nel perru, verifica el usuario o el password");
            }
        }
    }
}
