using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCafeteriaUTE.CorteForm
{
    public partial class CorteGanancias : Form
    {
        public CorteGanancias()
        {
            InitializeComponent();
        }

        private void CorteGanancias_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 60; //Intervalos de 60 segundos
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss"); //Hora actual
            lblfecha.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }
    }
}
