using System;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class Conectar
    {
        public MySqlConnection conectar;
        String cadenaconex;

        public MySqlConnection conexion()
        {
            cadenaconex = "Server = localhost; Uid = root; Password = ''; Database = CafeBETA; Port= 3306";
            conectar = new MySqlConnection(cadenaconex);
            return conectar;
        }
        public void AbrirConexion()
        {
            conectar.Open();
        }
        public void CerrarConexion()
        {
            conectar.Close();
        }
    }
}
