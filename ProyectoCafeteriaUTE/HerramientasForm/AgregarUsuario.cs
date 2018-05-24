using System;
using System.Windows.Forms;
using CapaNegocios;

namespace ProyectoCafeteriaUTE.HerramientasForm
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }
        Empleados cE = new Empleados();
        public void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContra.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEstado.Clear();
            txtCiudad.Clear();
            txtCP.Clear();
            txtDir.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtComentarios.Clear();
            txtEdad.Clear();
            txtId.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lblhora.Text = DateTime.Now.ToLongTimeString(); //Hora actual
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 60;
            txtContra.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtContra.UseSystemPasswordChar = false;
            }
            else
            {
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cE.insertarEmpleados(txtId.Text, txtNombre.Text, txtApellido.Text,txtEdad.Text,txtEstado.Text,txtCiudad.Text,txtCP.Text,txtDir.Text,lblfecha.Text +" "+lblhora.Text,txtTelefono.Text,txtCorreo.Text,txtComentarios.Text,txtUsuario.Text,txtContra.Text,comboTipo.SelectedItem.ToString());
            LimpiarCampos();
        }
    }
}
