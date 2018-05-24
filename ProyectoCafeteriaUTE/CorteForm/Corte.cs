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
    public partial class Corte : Form
    {
        public Corte()
        {
            InitializeComponent();
        }
        //metodo para para crear formularios hijos en el panelContenedor
        private void addPanelCorte(object formHijo)
        {
            if (this.vistaVentanas.Controls.Count > 0)
                this.vistaVentanas.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.vistaVentanas.Controls.Add(fh);
            this.vistaVentanas.Tag = fh;
            fh.Show();
        }

        //metodo para para crear formularios hijos en el panelContenedor
        private void addPanelGanancias(object formHijo)
        {
            if (this.vistaVentanas.Controls.Count > 0)
                this.vistaVentanas.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.vistaVentanas.Controls.Add(fh);
            this.vistaVentanas.Tag = fh;
            fh.Show();
        }

        private void observarGananciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPanelGanancias(new ProyectoCafeteriaUTE.CorteForm.CorteGanancias());
        }

        private void realizarCorteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPanelCorte(new ProyectoCafeteriaUTE.CorteForm.CorteCaja());
        }

        private void Corte_Load(object sender, EventArgs e)
        {
        }
    }
}
