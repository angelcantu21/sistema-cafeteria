using System;
using System.Windows.Forms;
using CapaNegocios;

namespace ProyectoCafeteriaUTE.ProductosForm
{
    public partial class EditarProducto : Form
    {
        public EditarProducto()
        {
            InitializeComponent();
        }

        ConsultaProductos marcar = new ConsultaProductos();

        public void LimpiarCampos()
        {
            CodigoBarras.Text = "";
            nombreproducto.Text = "";
            descripcionproducto.Text = "";
            proveedorproducto.Text = "";
            proveedorproducto.Text = "";
            preciocompra.Text = "";
            precioventa.Text = "";
            stock.Text = "";
            cantidad.Text = "";
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 60; //Intervalos de 60 segundos

            tableModificarP.DataSource = marcar.vistaProductos("");
            marcar.comboCategorias(comboCategoria);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss"); //Hora actual
            lblfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodigoBarras.Text = tableModificarP.CurrentRow.Cells[0].Value.ToString();
            nombreproducto.Text = tableModificarP.CurrentRow.Cells[1].Value.ToString();
            descripcionproducto.Text = tableModificarP.CurrentRow.Cells[2].Value.ToString();
            cantidad.Text = tableModificarP.CurrentRow.Cells[3].Value.ToString();
            stock.Text = tableModificarP.CurrentRow.Cells[4].Value.ToString();
            preciocompra.Text = tableModificarP.CurrentRow.Cells[5].Value.ToString();
            precioventa.Text = tableModificarP.CurrentRow.Cells[6].Value.ToString();
            comboCategoria.Text = tableModificarP.CurrentRow.Cells[8].Value.ToString();
        }

        #region BOTONES
        private void button1_Click(object sender, EventArgs e)
        {
            marcar.editarTabla(CodigoBarras.Text, nombreproducto.Text, descripcionproducto.Text, cantidad.Text, stock.Text, preciocompra.Text, precioventa.Text, comboCategoria);
            LimpiarCampos();
            tableModificarP.DataSource = marcar.vistaProductos("");
            MessageBox.Show("Los datos han sido editados", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        #endregion

    }
}
