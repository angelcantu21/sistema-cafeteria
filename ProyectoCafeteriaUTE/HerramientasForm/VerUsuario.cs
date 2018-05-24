using System;
using System.Windows.Forms;
using CapaNegocios;

namespace ProyectoCafeteriaUTE.HerramientasForm
{
    public partial class VerUsuario : Form
    {
        public VerUsuario()
        {
            InitializeComponent();
        }
        Empleados cnE = new Empleados();

        private void VerUsuario_Load(object sender, EventArgs e)
        {
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
    }
}
