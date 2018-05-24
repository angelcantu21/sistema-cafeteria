using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CapaNegocios;

namespace ProyectoCafeteriaUTE
{
    public partial class LlenarTextBox : Form
    {
        public LlenarTextBox()
        {
            InitializeComponent();
        }
        Empleados em = new Empleados();
        private void button1_Click(object sender, EventArgs e)
        {
            //em.CargarTextos(textBox1.Text,textBox2,textBox3,textBox4);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            em.CargarTextos(textBox1.Text, textBox2, textBox3, textBox4);
        }

        private void LlenarTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
