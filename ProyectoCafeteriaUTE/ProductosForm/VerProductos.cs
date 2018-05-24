using System;
using System.Windows.Forms;
using CapaNegocios;

namespace ProyectoCafeteriaUTE.ProductosForm
{
    public partial class VerProductos : Form
    {
        public VerProductos()
        {
            InitializeComponent();
        }
        ConsultaProductos marcar = new ConsultaProductos();
        private void VerProductos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = marcar.vistaProductos("");
            marcar.autoCompletar(buscar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = marcar.vistaProductos(buscar.Text);
        }
    }
}
