using System;
using System.Data;
using MySql.Data.MySqlClient;
using CapaDatos;
using System.Windows.Forms;

namespace CapaNegocios
{
    public class ConsultaProductos : Conectar 
    {
        String sql;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public DataTable vistaProductos(String nombre)
        {
            DataTable consulta = new DataTable();
            try
            {
                sql = "SELECT CodigoBarras, nombre as NOMBRE, descripcion as DESCRIPCION, contenido as CONTENIDO,stock as STOCK,P_compra as COMPRA,P_venta as VENTA,fecha as LLEGADA,categoria as Categoria FROM productos, categoria WHERE nombre LIKE '%" + nombre + "%' AND idCategoria=FKCategoria";
                MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion());
                adp.Fill(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problemas al mostrar datos: "+ex);
            }
            return consulta;
        }

        public DataTable buscarProductos(String nombre) // BUSCA PRODUCTOS POR NOMBRE
        {
            DataTable consulta = new DataTable();
            try
            {
                sql = "SELECT idproductos as ID, nombre as NOMBRE, descripcion as DESCRIPCION, contenido as CONTENIDO, P_venta as COSTO,codigo as CODIGO FROM productos WHERE nombre LIKE '%" + nombre + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(sql.ToString(), conexion());
                adp.Fill(consulta);
            }
            catch (Exception)
            {

            }
            return consulta;
        }

        public void insertarTabla(String id, String nombre, String descripcion, String contenido, String stock, String compra, String venta, String fecha, ComboBox categoria)
        {
            sql = "INSERT INTO productos VALUES (" + id + ",'" + nombre + "','" + descripcion + "','" + contenido + "','" + stock + "'," + compra + "," + venta + ",'" + fecha + "'," + categoria.SelectedValue + ");";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion());
            DataTable consulta = new DataTable();
            adp.Fill(consulta);
        }
        public void editarTabla(String id, String nombre, String descripcion, String contenido, String stock, String compra, String venta, ComboBox categoria)
        {
            sql = "UPDATE productos SET codigobarras= " + id + ", nombre= '" + nombre + "', descripcion= '" + descripcion + "',contenido= '" + contenido + "',stock= " + stock + ",P_compra= " + compra + ",P_venta= " + venta + ",FKCategoria= " + categoria.SelectedValue + " WHERE codigobarras= " + id + ";";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion());
            DataTable consulta = new DataTable();
            adp.Fill(consulta);
        }
        public void eliminarTabla(String id) // ELIMINAR DATOS
        {
            sql = "DELETE FROM productos WHERE idProductos=" + id + ";";
            MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion());
            DataTable consulta = new DataTable();
            adp.Fill(consulta);
        }

        public void autoCompletar(TextBox cajaTexto) // AUTOCOMPLETAR TEXTBOX
        {
            try
            {
                conectar.Open();// Abrimos la conexion
                cmd = new MySqlCommand("Select nombre from productos", conectar);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cajaTexto.AutoCompleteCustomSource.Add(dr["nombre"].ToString());
                }
                //dr.Close(); Esto tambien sirve para cerrar la conexion
                conectar.Close();// Cerramos conexion
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo autocompletar el TextBox: " + ex.ToString());
            }
        }

        public void CargarTextos(TextBox id, TextBox codigo, TextBox nombre, TextBox descripcion, TextBox contenido, TextBox precio)
        {
            sql = "SELECT * FROM productos where CodigoBarras='" + id.Text + "';";
            MySqlCommand comando = new MySqlCommand(sql, conexion());
            AbrirConexion();
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    codigo.Text = leer["CodigoBarras"].ToString();
                    nombre.Text = leer["nombre"].ToString();
                    descripcion.Text = leer["descripcion"].ToString();
                    contenido.Text = leer["contenido"].ToString();
                    precio.Text = leer["P_venta"].ToString();
                }
                else
                {

                }
            }
            catch (Exception)
            {
            }
            CerrarConexion();
        }

        public void comboCategorias(ComboBox categorias)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM categoria",conexion());
            adp.Fill(ds,"categoria");
            categorias.DataSource = ds.Tables["categoria"];
            categorias.ValueMember = "idCategoria";
            categorias.DisplayMember = "categoria";
        }

        public void CargarVentasDia(TextBox ventas)
        {
            String sql = "SELECT sum(precio) as VentasTotales FROM ventas;";
            MySqlCommand comando = new MySqlCommand(sql, conexion());
            AbrirConexion();
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
                ventas.Text = leer["VentasTotales"].ToString();
            }
            CerrarConexion();
        }
    }
}
