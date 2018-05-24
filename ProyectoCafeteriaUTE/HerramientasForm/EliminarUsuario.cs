using System;
using System.Windows.Forms;
using CapaNegocios;

namespace ProyectoCafeteriaUTE.HerramientasForm
{
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }
        Empleados cnE = new Empleados();
        String id;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToShortDateString();
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 60;
            tablaEmpleados.DataSource = cnE.verEmpleados("");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (radioNombre.Checked)
            {
                tablaEmpleados.DataSource = cnE.verEmpleados(txtBuscar.Text);
            }
            if (radioNumero.Checked)
            {
                tablaEmpleados.DataSource = cnE.verEmpleadosNumero(txtBuscar.Text);
            }
        }

        private void tablaEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = tablaEmpleados.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        }

        private void tablaEmpleados_MouseClick(object sender, MouseEventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Por favor selecciona una fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblId.Text = id;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnE.eliminarEmpleados(lblId.Text);
            lblId.Text = "ID";
            tablaEmpleados.DataSource = cnE.verEmpleados("");
        }
    }
}
