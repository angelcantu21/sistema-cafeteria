using System;
using System.Windows.Forms;
using CapaNegocios;

namespace ProyectoCafeteriaUTE.HerramientasForm
{
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }
        public static string id, nombre, apellido, edad, estado, ciudad, cp, direccion, telefono, correo, comentarios, usuario, contra, tipo;
        Empleados cnE = new Empleados();
        public void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtEstado.Clear();
            txtCiudad.Clear();
            txtCP.Clear();
            txtDir.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtComentarios.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            comboTipo.Text = "";
        }


        private void ModificarUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cnE.verEmpleados("");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            apellido = dataGridView1.Rows[e.RowIndex].Cells["APELLIDO"].Value.ToString();
            edad = dataGridView1.Rows[e.RowIndex].Cells["EDAD"].Value.ToString();
            estado = dataGridView1.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString();
            ciudad = dataGridView1.Rows[e.RowIndex].Cells["CIUDAD"].Value.ToString();
            cp = dataGridView1.Rows[e.RowIndex].Cells["CODIGO_POSTAL"].Value.ToString();
            direccion = dataGridView1.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString();
            telefono = dataGridView1.Rows[e.RowIndex].Cells["TELEFONO"].Value.ToString();
            correo = dataGridView1.Rows[e.RowIndex].Cells["CORREO"].Value.ToString();
            comentarios = dataGridView1.Rows[e.RowIndex].Cells["COMENTARIOS"].Value.ToString();
            usuario = dataGridView1.Rows[e.RowIndex].Cells["USUARIO"].Value.ToString();
            contra = dataGridView1.Rows[e.RowIndex].Cells["CONTRASENA"].Value.ToString();
            tipo = dataGridView1.Rows[e.RowIndex].Cells["TIPO_ACCESO"].Value.ToString();
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (id == "")
            {
                MessageBox.Show("Por favor selecciona una fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lblId.Text = id;
                txtId.Text = id;
                txtNombre.Text = nombre;
                txtApellido.Text = apellido;
                txtEdad.Text = edad;
                txtEstado.Text = estado;
                txtCiudad.Text = ciudad;
                txtCP.Text = cp;
                txtDir.Text = direccion;
                txtTelefono.Text = telefono;
                txtCorreo.Text = correo;
                txtComentarios.Text = comentarios;
                txtUsuario.Text = usuario;
                txtContra.Text = contra;
                comboTipo.Text = tipo;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cnE.modificarEmpleados(txtId.Text, txtNombre.Text, txtApellido.Text, txtEdad.Text, txtEstado.Text, txtCiudad.Text, txtCP.Text, txtDir.Text, txtTelefono.Text, txtCorreo.Text, txtComentarios.Text, txtUsuario.Text, txtContra.Text, comboTipo.SelectedItem.ToString(),lblId.Text);
            LimpiarCampos();
            dataGridView1.DataSource = cnE.verEmpleados("");
        }

    }
}
