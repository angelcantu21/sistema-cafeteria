using System;
using CapaDatos;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CapaNegocios
{
    public class Empleados : Conectar
    {
        String sql;

        public DataTable verEmpleados(String nombre)
        {
            DataTable consulta = new DataTable();
            try
            {
                sql = "SELECT idEmpleados as ID, nombre as NOMBRE, apellido as APELLIDO, edad as EDAD,estado as ESTADO,ciudad as CIUDAD,cp as CODIGO_POSTAL,direccion as DIRECCION,fecha_ingreso as FECHA_DE_INGRESO, telefono as TELEFONO,correo as CORREO,comentarios as COMENTARIOS, usuario as USUARIO, contraseña as CONTRASENA, tipo as TIPO_ACCESO FROM Empleados WHERE nombre LIKE '%" + nombre + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion());
                adp.Fill(consulta);
            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un error al mostrar registros de empleados"+"\nFavor de verificar la base de datos", "ERROR");
            }
            return consulta;
        }

        public DataTable verEmpleadosNumero(String id)
        {
            DataTable consulta = new DataTable();
            try
            {
                sql = "SELECT idEmpleados as ID, nombre as NOMBRE, apellido as APELLIDO, edad as EDAD,estado as ESTADO,ciudad as CIUDAD,cp as CODIGO_POSTAL,direccion as DIRECCION,fecha_ingreso as FECHA_DE_INGRESO, telefono as TELEFONO,correo as CORREO,comentarios as COMENTARIOS, usuario as USUARIO, contraseña as CONTRASENA, tipo as TIPO_ACCESO FROM Empleados WHERE idEmpleados LIKE '%" + id + "%'";
                MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion());
                adp.Fill(consulta);
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al mostrar registros de empleados" + "\nFavor de verificar la base de datos", "ERROR");
            } 
            return consulta;
        }

        public void insertarEmpleados(String id, String nombre, String apellido, String edad, String estado, String ciudad, String cp, String direccion, String fecha, String telefono, String correo, String comentarios, String usuario, String contraseña, String tipo)
        {
            try
            {
                sql = "INSERT INTO empleados VALUES (" + id + ",'" + nombre + "','" + apellido + "'," + edad + ",'" + estado + "','" + ciudad + "'," + cp + ",'" + direccion + "','" + fecha + "','" + telefono + "','" + correo + "','" + comentarios + "','" + usuario + "','" + contraseña + "','" + tipo + "');";
                MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion());
                DataTable consulta = new DataTable();
                adp.Fill(consulta);
                MessageBox.Show("Los datos han sido ingresados correctamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no han sido ingresados, hay un error en sus informacion o en la base de datos", "ERROR EN LA BASE DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void modificarEmpleados(String id, String nombre, String apellido, String edad, String estado, String ciudad, String cp, String direccion, String telefono, String correo, String comentarios, String usuario, String contraseña, String tipo, String idActual)
        {
            try
            {
                sql = "UPDATE Empleados SET idEmpleados=" + id + ", nombre='" + nombre + "', apellido='" + apellido + "', edad=" + edad + ", ciudad='" + ciudad + "', cp=" + cp + ", direccion='" + direccion + "', telefono='" + telefono + "', correo='" + correo + "', comentarios='" + comentarios + "', usuario='" + usuario + "', contraseña='" + contraseña + "', tipo='" + tipo + "' WHERE idEmpleados=" + idActual + ";";
                MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion());
                DataTable consulta = new DataTable();
                adp.Fill(consulta);
                MessageBox.Show("Los datos han sido modificados correctamente", "EXITO");
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no se han modificado", "ERROR");
            }
        }

        public void eliminarEmpleados(String id)
        {
            try
            {
                sql = "DELETE FROM empleados WHERE idEmpleados=" + id + ";";
                MySqlDataAdapter adp = new MySqlDataAdapter(sql, conexion());
                DataTable consulta = new DataTable();
                adp.Fill(consulta);
                MessageBox.Show("Los datos han sido eliminados correctamente", "EXITO");
            }
            catch (Exception)
            {
                MessageBox.Show("No se han eliminado los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarTextos(String id, TextBox nombre, TextBox apellido, TextBox edad)
        {
             sql = "SELECT * FROM empleados where idEmpleados=" + id + ";";
            MySqlCommand comando = new MySqlCommand(sql, conexion());
            AbrirConexion();
            try
            {
                MySqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    nombre.Text = leer["nombre"].ToString();
                    apellido.Text = leer["apellido"].ToString();
                    edad.Text = leer["edad"].ToString();
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
    }
}
