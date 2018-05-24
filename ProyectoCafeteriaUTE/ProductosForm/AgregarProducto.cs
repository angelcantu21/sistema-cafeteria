using System;
using System.Windows.Forms;
using CapaNegocios;

namespace ProyectoCafeteriaUTE.ProductosForm
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        ConsultaProductos marcar = new ConsultaProductos();
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss"); //Hora actual
            lblfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 60; //Intervalos de 60 segundos
            marcar.comboCategorias(comboCategoria);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gramos.Checked == true)
            {
                marcar.insertarTabla(CodigoBarras.Text, nombreproducto.Text, descripcionproducto.Text, num.Value + gramos.Text, stock.Text, preciocompra.Text, precioventa.Text, lblfecha.Text+" "+lblhora.Text, comboCategoria);
            }
            else
            {
                if (mililitros.Checked == true)
                {
                    marcar.insertarTabla(CodigoBarras.Text, nombreproducto.Text, descripcionproducto.Text, num.Value + mililitros.Text, stock.Text, preciocompra.Text, precioventa.Text, lblfecha.Text+" "+lblhora.Text, comboCategoria);
                }
                else
                {
                    if (pieza.Checked == true)
                    {
                        marcar.insertarTabla(CodigoBarras.Text, nombreproducto.Text, descripcionproducto.Text, num.Value + pieza.Text, stock.Text, preciocompra.Text, precioventa.Text, lblfecha.Text+" "+lblhora.Text, comboCategoria);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar producto");
                    }
                }
            }
                 CodigoBarras.Text = "";
                 nombreproducto.Text = "";
                 descripcionproducto.Text = "";
                 proveedorproducto.Text = "";
                 proveedorproducto.Text = "";
                 preciocompra.Text = "";
                 precioventa.Text = "";
                 stock.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CodigoBarras.Text = "";
            nombreproducto.Text = "";
            descripcionproducto.Text = "";
            proveedorproducto.Text = "";
            proveedorproducto.Text = "";
            preciocompra.Text = "";
            precioventa.Text = "";
            stock.Text = "1";
        }
    }
}
