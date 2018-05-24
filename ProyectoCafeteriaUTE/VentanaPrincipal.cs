using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using ProyectoCafeteriaUTE.CorteForm;
using ProyectoCafeteriaUTE.HerramientasForm;
using ProyectoCafeteriaUTE.CatalogoForm;
using CapaNegocios;
using System.Media;
using MySql.Data.MySqlClient;

namespace ProyectoCafeteriaUTE
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        Login log = new Login();
        MySqlConnection conexion = new MySqlConnection("Server=127.0.0.1;Database=cafebeta;UID=root;Password=");

        ConsultaProductos marcar = new ConsultaProductos();
        SoundPlayer sonido;
        int nota = 1, cantidad = 0;
        float precio = 0, total = 0, acumulador = 0, eliminado = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString(); //Hora actual
            label4.Text = DateTime.Now.ToString("yyyy-MM-dd"); //Fecha Actual
            //lblhora.Text = DateTime.Now.ToString("hh:mm:ss"); //Hora actual
            //lblfecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 60; //Intervalos de 60 segundos

            //Table Style
            this.tablaVenta.BackgroundColor = Color.FromArgb(255, 255, 255);
            tablaVenta.EnableHeadersVisualStyles = false;
            tablaVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            tablaVenta.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            this.tablaVenta.BorderStyle = BorderStyle.Fixed3D;
            tablaVenta.RowHeadersVisible = false;
            //
        }

        #region TEMAS PARA LA PANTALLA
        private void lucesEnMadridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(25, 25, 112);

            //color de las letras
            ForeColor = Color.FromArgb(255, 255, 255);
            label2.ForeColor = Color.White;
            label4.ForeColor = Color.White;

            //this.txtCodigo.ForeColor = Color.FromArgb(col1, col2, col3);
            //this.txtcantidad.ForeColor = Color.FromArgb(col1, col2, col3);
            //this.txtimporte.ForeColor = Color.FromArgb(col1, col2, col3);

            //Color de botones
            btnBuscar.BackColor = Color.Black;
            btnCobrar.BackColor = Color.Black;
            btnCancelarCompra.BackColor = Color.Black;
            btnAgregar.BackColor = Color.Black;
            btnBorrrar.BackColor = Color.Black;

            //Table Style
            this.tablaVenta.BackgroundColor = Color.FromArgb(255, 255, 255);
            tablaVenta.EnableHeadersVisualStyles = false;
            tablaVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
            tablaVenta.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            this.tablaVenta.BorderStyle = BorderStyle.Fixed3D;
            tablaVenta.RowHeadersVisible = false;
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //color de las letras
            this.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            linkLabel1.ForeColor = Color.Red;

            //this.txtCodigo.ForeColor = Color.FromArgb(col1, col2, col3);
            //this.txtcantidad.ForeColor = Color.FromArgb(col1, col2, col3);
            //this.txtimporte.ForeColor = Color.FromArgb(col1, col2, col3);

            //Color de botones
            btnBuscar.BackColor = DefaultBackColor;
            btnCobrar.BackColor = DefaultBackColor;
            btnCancelarCompra.BackColor = DefaultBackColor;
            btnAgregar.BackColor = DefaultBackColor;
            btnBorrrar.BackColor = DefaultBackColor;
            this.BackColor = DefaultBackColor;

            //Table Style
            this.tablaVenta.BackgroundColor = Color.FromArgb(255, 255, 255);
            tablaVenta.EnableHeadersVisualStyles = false;
            tablaVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
            tablaVenta.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            this.tablaVenta.BorderStyle = BorderStyle.Fixed3D;
            tablaVenta.RowHeadersVisible = false;
        }

        private void bosqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(234, 255, 220);

            //color de las letras
            ForeColor = Color.FromArgb(0, 0, 0);
            label2.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            linkLabel1.ForeColor = Color.Green;

            //this.txtCodigo.ForeColor = Color.FromArgb(col1, col2, col3);
            //this.txtcantidad.ForeColor = Color.FromArgb(col1, col2, col3);
            //this.txtimporte.ForeColor = Color.FromArgb(col1, col2, col3);

            btnBuscar.BackColor = Color.GreenYellow;
            btnCobrar.BackColor = Color.GreenYellow;
            btnCancelarCompra.BackColor = Color.GreenYellow;
            btnAgregar.BackColor = Color.GreenYellow;
            btnBorrrar.BackColor = Color.GreenYellow;

            //Table Style
            this.tablaVenta.BackgroundColor = Color.FromArgb(234, 255, 215);
            tablaVenta.EnableHeadersVisualStyles = false;
            tablaVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 128, 0);
            tablaVenta.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            this.tablaVenta.BorderStyle = BorderStyle.Fixed3D;
            tablaVenta.RowHeadersVisible = false;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Color del fondo del Form
            this.BackColor = System.Drawing.Color.FromArgb(0, 0, 0);

            //color de las letras
            ForeColor = Color.FromArgb(255, 255, 255);

            //this.txtCodigo.ForeColor = Color.FromArgb(col1, col2, col3);
            //this.txtcantidad.ForeColor = Color.FromArgb(col1, col2, col3);
            //this.txtimporte.ForeColor = Color.FromArgb(col1, col2, col3);

            //Color de botones
            btnBuscar.BackColor = Color.DarkSlateGray;
            btnCobrar.BackColor = Color.DarkSlateGray;
            btnCancelarCompra.BackColor = Color.DarkSlateGray;
            btnAgregar.BackColor = Color.DarkSlateGray;
            btnBorrrar.BackColor = Color.DarkSlateGray;
            label4.ForeColor = Color.White;
            label2.ForeColor = Color.White;

            //Table Style
            this.tablaVenta.BackgroundColor = Color.FromArgb(255, 255, 255);
            tablaVenta.EnableHeadersVisualStyles = false;
            tablaVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 128);
            tablaVenta.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            this.tablaVenta.BorderStyle = BorderStyle.Fixed3D;
            tablaVenta.RowHeadersVisible = false;
        }
        #endregion

        #region MENUS DE PANTALLA

        private void abrirVentanaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Catalogo cat = new Catalogo();
            cat.Show();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
        }

        private void abrirVentanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Corte corte = new Corte();
            corte.Show();
        }

        private void panelDeControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Herramientas herramientas = new Herramientas();
            herramientas.Show();
        }

        private void informacionDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estos son todos los atajos para utilizar el Punto de Venta"
                            + "\nAgregar producto [F1]"
                            + "\n"
                            + "\nBorrar producto [F3]"
                            + "\n"
                            + "\nBuscar producto [F4]"
                            + "\n"
                            + "\nCancelar la compra [F9]"
                            + "\n"
                            + "\nImprimir tickets [F11]"
                            + "\n"
                            + "\nRealizar la compra [F12]","COMANDOS BASICOS", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void informacionDelProgramaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESTE ES UN PUNTO DE VENTA CREADA POR <AngelRamirezSoftware's"
                + "\nEl PV se encuentra actualmente en desarrollo para despues implementarse,"
                + "\neste sistema contara con todas las funciones basicas que tiene un punto de venta."
                + "\n"
                + "\nEste sistema contara con:"
                + "\n- Control de inventario"
                + "\n- Corte de caja"
                + "\n- Control de productos"
                + "\n- Panel de control sobre los empleados"
                + "\n- Temas de pantalla"
                + "\n- Control de proveedores"
                + "\n-Reportes de ventas"
                + "\n"
                + "\nContacto: angelcanturamirez@gmail.com", "Acerca del programa");
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            log.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region BOTONES DE PANTALLA

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtCantidadP.Text == "Cantidad")
            {
                MessageBox.Show("Ingresa una cantidad");
                txtCantidadP.Focus();
            }
            else
            {
                cantidad = int.Parse(txtCantidadP.Text);
                precio = int.Parse(txtPrecioP.Text);
                total = (cantidad * precio);
                acumulador += total;
                textBox2.Text = "$" + acumulador.ToString();
                tablaVenta.Rows.Add(txtcodigobarras.Text, txtNombreP.Text, txtDescripcionP.Text, txtContenidoP.Text, txtCantidadP.Text, (cantidad * precio));
                txtBuscar.Clear();
                txtcodigobarras.Clear();
                txtNombreP.Clear();
                txtCantidadP.Text = "Cantidad";
                txtDescripcionP.Clear();
                txtContenidoP.Clear();
                txtPrecioP.Clear();
            }
        }
        private void btnBorrrar_Click(object sender, EventArgs e)
        {
            eliminado = int.Parse(txtPrecioP.Text);
            textBox2.Text = (acumulador - eliminado).ToString();
            acumulador = float.Parse(textBox2.Text);
            textBox2.Text = "$" + acumulador;
            tablaVenta.Rows.Remove(tablaVenta.CurrentRow);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SelectorProductos select = new SelectorProductos();
            select.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Estas seguro de realizar la venta?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                MySqlCommand agregar = new MySqlCommand("INSERT INTO ventas (num_venta,FkCodigoBarras,descripcion,cantidad,precio,fecha) VALUES (" + nota + ",?FKCodigoBarras,?descripcion,?cantidad,?precio,'"+label4.Text+" "+label2.Text+"');", conexion);
                conexion.Open();
                try
                {
                    MessageBox.Show("Numero de venta: " + nota + "\nNumero de productos: " + tablaVenta.RowCount + "\nTotal a pagar: " + acumulador, "INFORMACION DE VENTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sonido = new SoundPlayer(@"C:\Users\ANGEL CANTU\Desktop\ANGELCANTU\PROJECTS\C#\PROJECTS IN WORKING\ProyectoCafeteriaUTE\ProyectoCafeteriaUTE\Imagenes\caja.wav");
                    sonido.Play();
                    foreach (DataGridViewRow row in tablaVenta.Rows)
                    {
                        agregar.Parameters.Clear();

                        agregar.Parameters.Add("?FKCodigoBarras", MySqlDbType.Int16).Value = Convert.ToString(row.Cells["cBarras"].Value);
                        agregar.Parameters.Add("?descripcion", MySqlDbType.VarChar).Value = Convert.ToString(row.Cells["descripcionProducto"].Value);
                        agregar.Parameters.Add("?cantidad", MySqlDbType.Int16).Value = Convert.ToString(row.Cells["cantidadProducto"].Value);
                        agregar.Parameters.Add("?precio", MySqlDbType.Float).Value = Convert.ToString(row.Cells["precioProducto"].Value);

                        agregar.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conexion.Close();
                nota++;
                tablaVenta.Rows.Clear();
                textBox2.Text = "$0";
                acumulador = 0;
                label7.Text = "" + nota;
                }
            }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void tablaVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPrecioP.Text = tablaVenta.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Seguro que quieres cancelar la venta?", "Esperando respuesta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
            {
                try
                { 
                tablaVenta.Rows.Clear();
                MessageBox.Show("La compra ha sido cancelada", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
               
            }
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.facebook.com/profile.php?id=100008524755030");//Redireccionamos a este link
        }

        private void VentanaPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            //BOTON DE AÑADIR PRODUCTO
            if (e.KeyData == Keys.F1)
            {
                btnAgregar.Focus();
            }
            //BOTON DE BORRAR PRODUCTO
            if (e.KeyData == Keys.F3)
            {
                btnBorrrar.Focus();
            }
            //BOTON DE BUSCAR
            if (e.KeyData == Keys.F4)
            {
                btnBuscar.Focus();
            }
            //BOTON DE CANCELAR COMPRA
            if (e.KeyData == Keys.F9)
            {
                btnCancelarCompra.Focus();
            }
            //BOTON DE IMPRIMIR TICKETS
            if (e.KeyData == Keys.F11)
            {
                btnImprimir.Focus();
            }
            //BOTON DE REALIZAR COMPRA
            if (e.KeyData == Keys.F12)
            {
                btnCobrar.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            marcar.CargarTextos(txtBuscar, txtcodigobarras, txtNombreP, txtDescripcionP, txtContenidoP, txtPrecioP);
        }
    }
}
