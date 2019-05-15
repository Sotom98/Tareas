using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fomulario1 {
    public partial class Form1 : Form {
        CSQL sql = new CSQL();
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'detalleFacturaDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.detalleFacturaDataSet.Productos);
            sql.LlenarProductos(dataGridView1);
            sql.LlenarClientes(dataGridView2);

        }

        private void button2_Click(object sender, EventArgs e) {
            int a = int.Parse(textBox1.Text);
            string b = textBox2.Text;
            double c = double.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);

            sql.IngresarProductos(a, b, c, d);
            sql.LlenarProductos(dataGridView1);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            int a = int.Parse(textBox5.Text);
            string b = textBox7.Text;
            double c = double.Parse(textBox3.Text);
            int d = int.Parse(textBox4.Text);

            sql.IngresarProductos(a, b, c, d);
            sql.LlenarProductos(dataGridView1);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
