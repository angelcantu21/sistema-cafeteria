using System;
using System.Windows.Forms;
using System.Collections;
using CapaNegocios;

namespace ProyectoCafeteriaUTE
{
    public partial class Login : Form
    {
        Usuarios objeus = new Usuarios();
        MontoInicio vmonto = new MontoInicio();
        MetodoLogin DataBase = new MetodoLogin();

        public Login()
        {
            InitializeComponent();
        }

        public Usuarios enviar()
        {
            objeus.Us1 = user.Text;  //Encapsulamos objeus con el get del textbox
            objeus.Contra1 = password.Text; //Encapsulamos objeus con el get del textbox
            return objeus;
        }


        private void Login_Load(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList Datos = DataBase.LoginsAdmin(enviar());
            if (Datos.Count > 0)
            {
                if (radioButton1.Checked == true)
                {
                    VentanaPrincipal ingreso = new VentanaPrincipal();
                    ingreso.Show();
                    this.Hide();
                }
            }
            ArrayList DatosV = DataBase.LoginsVendedor(enviar());
            if (DatosV.Count > 0)
            {
                if (radioButton2.Checked == true)
                {
                    MontoInicio inicio = new MontoInicio();
                    inicio.Show();
                    this.Hide();
                }
            }
        }

        private void checkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMostrar.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           var salir =  MessageBox.Show("¿Seguro que quieres salir?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
