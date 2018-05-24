using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCafeteriaUTE.CatalogoForm
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listaCatalogo.SelectedIndex == 0)
            {
                lblProducto.Text = listaCatalogo.SelectedItem.ToString();
            }
            if (listaCatalogo.SelectedIndex == 1)
            {
                lblProducto.Text = listaCatalogo.SelectedItem.ToString();
            }
            if (listaCatalogo.SelectedIndex == 2)
            {
                lblProducto.Text = listaCatalogo.SelectedItem.ToString();
            }
        }
    }
}
