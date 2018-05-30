using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Net;
public class Usuario{
    public string user;
    public string pass;
    public Usuario() { }
    public Usuario(string user, string pass){
        this.user = user;
        this.pass = pass;
    }
}
public class Login: Page{
    protected TextBox usuario,contraseña;
    protected Button miBoton;
    protected void Page_Load(){
        Response.Write("desde C# cambiando");

        // crear un objeto del tipo usuario
        Usuario objeto = new Usuario();

        // llamar los atributos de la clase de usuario
        objeto.user = usuario.Text;
        objeto.pass = contraseña.Text;
        Response.Write(objeto.user);
        Response.Write(objeto.pass);

        // variables para trabajar con los datos obtenidos del documento ASPX
        string userName = objeto.user;
        string userPass = objeto.pass;
       }
    private void miBoton_Click(object sender, System.EventArgs e) {
        Response.Write("boton apretado");
    }   
}
