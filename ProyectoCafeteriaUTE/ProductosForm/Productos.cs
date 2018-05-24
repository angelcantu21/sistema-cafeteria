using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProyectoCafeteriaUTE.ProductosForm;

namespace ProyectoCafeteriaUTE
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new ProyectoCafeteriaUTE.ProductosForm.AgregarProducto());
        }
        //metodo para para crear formularios hijos en el panelContenedor
        private void AddFormInPanel(object formHijo)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel.Controls.Add(fh);
            this.panel.Tag = fh;
            fh.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFormInPanel1(new ProyectoCafeteriaUTE.ProductosForm.EliminarProducto());
        }
        //metodo para para crear formularios hijos en el panelContenedor
        private void AddFormInPanel1(object formHijo)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel.Controls.Add(fh);
            this.panel.Tag = fh;
            fh.Show();
        }

        private void observarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFormInPanel2(new ProyectoCafeteriaUTE.ProductosForm.VerProductos());
        }
        private void AddFormInPanel2(object formHijo)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel.Controls.Add(fh);
            this.panel.Tag = fh;
            fh.Show();
        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFormInPanel3(new ProyectoCafeteriaUTE.ProductosForm.EditarProducto());
        }
        private void AddFormInPanel3(object formHijo)
        {
            if (this.panel.Controls.Count > 0)
                this.panel.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panel.Controls.Add(fh);
            this.panel.Tag = fh;
            fh.Show();
        }
    }
}

