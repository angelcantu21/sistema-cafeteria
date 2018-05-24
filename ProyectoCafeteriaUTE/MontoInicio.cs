using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoCafeteriaUTE.CorteForm;

namespace ProyectoCafeteriaUTE
{
    public partial class MontoInicio : Form
    {
        public MontoInicio()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventana = new VentanaPrincipal();
            ventana.txtIngresoInicial.Text = txtMontoInicial.Text;
            ventana.productosToolStripMenuItem.Visible = false;
            ventana.herramientasToolStripMenuItem.Visible = false;
            ventana.productosToolStripMenuItem.Visible = false;
            ventana.ayudaToolStripMenuItem.Visible = false;
            ventana.reportesToolStripMenuItem.Visible = false;
            ventana.baseDeDatosToolStripMenuItem.Visible = false;
            ventana.Show();
            this.Close();
        }
    }
}
