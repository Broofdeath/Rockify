using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using System.Reflection;
public class Conexion
{
    MySqlConnection conexion;
    static string ip = "127.0.0.1";
    static string port = "3306";
    static string database = "hola";
    static string Uid = "root";
    static string Pwd = "leyton995";
    static string con = "Server='" + ip + "';Port='" + port + "';Database='" + database + "';Uid='" + Uid + "';Pwd='" + Pwd + "'";
    public static void Main() {
        Conexion conexion = new MySqlConnection(con);
        conexion.Open();
    }
}