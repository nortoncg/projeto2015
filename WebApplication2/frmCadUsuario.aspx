<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadUsuario.aspx.cs" Inherits="WebApplication2.frmCadUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Label ID="Label3" runat="server" Text="Cadastro do Usuário"></asp:Label>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Nome do Usuario: "></asp:Label><asp:TextBox ID="txtNomeusuario" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Senha: "></asp:Label><asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
        <br />
        <br />
         <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" />
        <asp:Button ID="btnAlterar" runat="server" Text="Alterar" />
        <asp:Button ID="btnExcluir" runat="server" Text="Excluir" />
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
        <br />
        <asp:Label ID="lblMensagem" runat="server" Visible="False"></asp:Label>
    </div>
       
    </form>
</body>
</html>
