<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="_05HolaMundoASPNET.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>HolaMundoAASPNET</title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

</head>
<body>
    <form id="formSaludar" runat="server">
        <asp:Label ID="lblNombre" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        
        <asp:Label ID="lblError" runat="server"></asp:Label>
        
        <p>
            <asp:Button ID="btnSaludar" runat="server" Text="Saludar" OnClick="btnSaludar_Click" />
        </p>
        <asp:Label ID="lblSaludo" runat="server" Font-Size="30pt" ForeColor="#FF3300"></asp:Label>
    </form>
</body>
</html>
