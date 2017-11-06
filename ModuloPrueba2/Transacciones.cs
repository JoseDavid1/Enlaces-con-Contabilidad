using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ModuloPrueba2
{
    public partial class Transacciones : Form
    {
        public Transacciones()
        {
            InitializeComponent();
            llenarDataGridPrincipal();
        }

        public void llenarDataGridPrincipal()
        {
            MyDBEntity mdb = new MyDBEntity();
            string sql = "select *from transacciones;";
            DataTable tbl = new DataTable();
            
            try
            {

                tbl = mdb.CargarTabla(sql);

                //llama al método de la clase para conectar
                //MyDBEntity mienty = new MyDBEntity();
                mdb.conectar();

                MySqlCommand cmd = new MySqlCommand(sql, mdb.conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvtransacciones.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transacciones_Load(object sender, EventArgs e)
        {

        }
    }
}
