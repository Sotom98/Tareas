using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Fomulario1 {
    class CSQL {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter dap;
        DataTable dat;

        public CSQL() {
            string aviso;

            try {
                cnx = new SqlConnection("Data Source=.;Initial Catalog=DetalleFactura;Integrated Security=True");
                cnx.Open();
                aviso = "Conectado";
            }
            catch (Exception Ex) {
                aviso = "Error" + Ex.ToString();
            }
        }

        public void IngresarProductos(int a, string b, double c, int d) {
            cmd = new SqlCommand("insert into Productos values(" + a + ",'" + b + "'," + c + "," + c + ")", cnx);
            cmd.ExecuteNonQuery();
        }

        public void LlenarProductos(DataGridView dvg) {
            dap = new SqlDataAdapter("select * from Productos", cnx);
            dat = new DataTable();
            dap.Fill(dat);
            dvg.DataSource = dat;
        }

        public void LlenarClientes(DataGridView dvg) {
            dap = new SqlDataAdapter("select * from Clientes", cnx);
            dat = new DataTable();
            dap.Fill(dat);
            dvg.DataSource = dat;
        }
    }
}
