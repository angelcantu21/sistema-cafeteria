using System;
using System.Windows.Forms;
using System.Diagnostics;
using CapaDatos;

namespace ProyectoCafeteriaUTE
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.timer1.Start();
        }
        Conectar cn = new Conectar();
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1); //La barra se ira incrementando de 1
            if (progressBar1.Value == 30)
            {
                label1.Text = "Cargando base de datos..";
                try
                {
                    cn.conexion();
                    cn.AbrirConexion();
                }catch (Exception)
                {
                    timer1.Stop();
                    var intentar = MessageBox.Show("Base de datos no conectada"+"\n¿Quieres intentar de nuevo?","Base de datos",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                    if (intentar == DialogResult.Retry)
                    {
                        SplashScreen splash = new SplashScreen();
                        splash.Show();
                        this.Hide();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            if(progressBar1.Value == 60)
            {
                    label1.Text = "Actualizando informacion..";
            }
            if(progressBar1.Value == 80)
            {
                    label1.Text = "Inicializando programa....";
            }
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Process.Start("www.facebook.com/profile.php?id=100008524755030");
        }
    }
}
