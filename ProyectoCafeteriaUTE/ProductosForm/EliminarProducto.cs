using System;
using System.Windows.Forms;
using CapaNegocios;

namespace ProyectoCafeteriaUTE.ProductosForm
{
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        ConsultaProductos marcar = new ConsultaProductos();
        String id;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString(); //Hora actual
            lblfecha.Text = DateTime.Now.ToShortDateString(); //Fecha actual
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 60;
            tablaProductos.DataSource = marcar.vistaProductos("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmacion= MessageBox.Show("¿Seguro que quieres eliminar este producto?","Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            
            if(confirmacion == DialogResult.Yes)
            {
                marcar.eliminarTabla(lblID.Text);
                tablaProductos.DataSource = marcar.vistaProductos("");
                lblID.Text = "id";
            }
            else
            {
                MessageBox.Show("Producto no eliminado");
            }
        }

        private void tablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = tablaProductos.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

        private void tablaProductos_MouseClick(object sender, MouseEventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Elige un producto");
            }
            else
            {
                lblID.Text = id;
            }
        }
    }
}
