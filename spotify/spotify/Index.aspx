<%@ Page Language="C#" Src="prueba.aspx.cs" Inherits="Login"%>
<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<meta charset="utf-8" />
</head>
<body>
    <h1>Pagina principal</h1>
    <form action="?" runat="server" method="post">
        <fieldset>
            <legend>Formulario</legend>
            <asp:Label Text="usuario" runat="server"></asp:Label>
            <asp:TextBox id="usuario" runat="server"></asp:TextBox>
            <asp:Label Text="contrasenha" runat="server"></asp:Label>
            <asp:TextBox ID="contraseña" runat="server"></asp:TextBox>
            <asp:Button ID="miBoton" runat="server" text="Pres Me"/>
        </fieldset>
    </form>
        
</body>
</html>
