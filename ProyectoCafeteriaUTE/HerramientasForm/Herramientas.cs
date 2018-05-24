using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCafeteriaUTE.HerramientasForm
{
    public partial class Herramientas : Form
    {
        public Herramientas()
        {
            InitializeComponent();
        }

        private void addPanelAgregarUsuario(object formHijo)
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

        private void addPanelModificarUsuario(object formHijo)
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

        private void addPanelEliminarUsuario(object formHijo)
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

        private void addPanelObservarUsuario(object formHijo)
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

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPanelAgregarUsuario(new ProyectoCafeteriaUTE.HerramientasForm.AgregarUsuario());
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPanelModificarUsuario(new ProyectoCafeteriaUTE.HerramientasForm.ModificarUsuario());
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPanelEliminarUsuario(new ProyectoCafeteriaUTE.HerramientasForm.EliminarUsuario());
        }

        private void verEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addPanelObservarUsuario(new ProyectoCafeteriaUTE.HerramientasForm.VerUsuario());
        }
    }
}
