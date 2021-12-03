<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RecuperacionRegistros.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            los registros de la tabla Categorias y todos los productos de la categoría seleccionada.
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Mostrar" runat="server" OnClick="Button1_Click" Text="Button" />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:GridView ID="GridView2" runat="server">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
