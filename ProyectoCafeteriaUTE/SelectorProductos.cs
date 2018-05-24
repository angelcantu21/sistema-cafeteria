using System.Windows.Forms;
using System;
using CapaNegocios;
namespace ProyectoCafeteriaUTE
{
    public partial class SelectorProductos : Form
    {
        public SelectorProductos()
        {
            InitializeComponent();
        }
        ConsultaProductos marcar = new ConsultaProductos();

        private void SelectorProductos_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = marcar.buscarProductos("");
        }
    
        private void button2_Click(object sender, System.EventArgs e)
        {
          
        }

        private void buscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = marcar.buscarProductos(buscar.Text);
        }
    }
}
