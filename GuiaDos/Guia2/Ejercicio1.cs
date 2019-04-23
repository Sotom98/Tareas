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
    public partial class Ejercicio1 : Form {

        private MessageBoxButtons tipoDeBoton = MessageBoxButtons.OK;
        private MessageBoxIcon tipoDeIcono = MessageBoxIcon.Error;
        public Ejercicio1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void groupBox2_Enter(object sender, EventArgs e) {

        }

        private void tipoDeBoton_CheckedChange(object sender, EventArgs e) {
            if (sender == radioButton1) {
                tipoDeBoton = MessageBoxButtons.OK;
            }
            else if (sender == radioButton2) {
                tipoDeBoton = MessageBoxButtons.OKCancel;
            }
            else if (sender == radioButton3) {
                tipoDeBoton = MessageBoxButtons.YesNo;
            }
            else if (sender == radioButton4) {
                tipoDeBoton = MessageBoxButtons.YesNoCancel;
            }
            else if (sender == radioButton5) {
                tipoDeBoton = MessageBoxButtons.RetryCancel;
            }
            else {
                tipoDeBoton = MessageBoxButtons.AbortRetryIgnore;
            }
        }

        private void tipoDeIcono_CheckedChange(object sender, EventArgs e) {
            if (sender == radioButton7) {
                tipoDeIcono = MessageBoxIcon.Information;
            }
            else if (sender == radioButton8) {
                tipoDeIcono = MessageBoxIcon.Exclamation;
            }
            else if (sender == radioButton9) {
                tipoDeIcono = MessageBoxIcon.Question;
            }
            else {
                tipoDeIcono = MessageBoxIcon.Error;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Mensaje a desplegar", "Titulo de la ventana", tipoDeBoton, tipoDeIcono);
            
        }
    }
}
