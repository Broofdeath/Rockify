using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
public class Usuario
{
    // Declarar los atributos de la clase
    // estos son los campos de la Base de datos

    private string nickName;
    private string name;
    private string email;
    private string pass;
    private Pais pais;

    // Constructor vacio de la clase usuario
    public Usuario(){}
    // Constructor con parametros
    public Usuario(string nickName, string name, string email, string pass, Pais pais) {
        this.nickName = nickName;
        this.name = name;
        this.email = email;
        this.pass = pass;
        this.pais = pais;
    }
    public string getNickName() {
        return nickName;
    }
    public void setNickName(string nickNameUser) {
        nickName = nickNameUser;
    }
    public string getName() {
        return name;
    }
    public void setName(string nameUser) {
        name = nameUser;
    }
    public string getEmail() {
        return email;
    }
    public void setEmail(string emailUser) {
        email = emailUser;
    }
    public string getPass() {
        return pass;
    }
    public void setPass(string passUser) {
        pass = passUser;
    }
    public Pais getPais() {
        return pais;
    }
    public void setPais(Pais paisUser) {
        pais = paisUser;
    }
    public Usuario insertUser(string nickName, string name, string email, string pass, Pais pais) {
        
        /* CODIGO PARA EJECUTAR PROCEDIMIENTO
			comandoSQL.CommandType = CommandType.StoredProcedure;
			comandoSQL.Parameters.Add(new MySqlParameter("nusuario", user.Text));
			comandoSQL.Parameters.Add(new MySqlParameter("npassword", pass.Text));
			comandoSQL.ExecutenNonQuery();
		*/
    }
}