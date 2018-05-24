using System;
using CapaDatos;
using System.Collections;
using MySql.Data.MySqlClient;

namespace CapaNegocios
{
    public class MetodoLogin : Conectar
    {
        public ArrayList LoginsAdmin(Usuarios objeus)
        {
            String comando = String.Format("SELECT idEmpleados FROM empleados WHERE usuario= '{0}' AND contraseña= '{1}' AND tipo='Administrador';", objeus.Us1, objeus.Contra1);
            MySqlCommand adapter = new MySqlCommand(comando, conexion());
            AbrirConexion();
            MySqlDataReader lectura;
            ArrayList log = new ArrayList();
            lectura = adapter.ExecuteReader();
            while (lectura.Read())
            {
                log.Add(lectura["idEmpleados"].ToString());
            }
            CerrarConexion();
            return log;
        }
        public ArrayList LoginsVendedor(Usuarios objeus)
        {
            String comando = String.Format("SELECT idEmpleados FROM empleados WHERE usuario= '{0}' AND contraseña= '{1}' AND tipo='Vendedor';", objeus.Us1, objeus.Contra1);
            MySqlCommand adapter = new MySqlCommand(comando, conexion());
            AbrirConexion();
            MySqlDataReader lectura;
            ArrayList log = new ArrayList();
            lectura = adapter.ExecuteReader();
            while (lectura.Read())
            {
                log.Add(lectura["idEmpleados"].ToString());
            }
            CerrarConexion();
            return log;
        }
    }
}
