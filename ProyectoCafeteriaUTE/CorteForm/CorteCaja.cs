using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;

namespace ProyectoCafeteriaUTE.CorteForm
{
    public partial class CorteCaja : Form
    {
        public CorteCaja()
        {
            InitializeComponent();
        }
        ConsultaProductos con = new ConsultaProductos();
        private void CorteCaja_Load(object sender, EventArgs e)
        {
            con.CargarVentasDia(txtDineroTotal);
        }
    }
}
