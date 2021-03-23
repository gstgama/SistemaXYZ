<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroPessoas.aspx.cs" Inherits="WebUI.CadastroPessoas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>:: Cadastro de Pessoas</h3>

    <table>
        <tr>
            <td>Código:</td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server" Width="47px" OnTextChanged="txtCodigo_TextChanged"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
            </td>
        </tr>
        <tr>
            <td>Nome:</td>
            <td>
                <asp:TextBox ID="txtNome" runat="server" Width="228px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>E-mail:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="229px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Sexo:</td>
            <td>
                <asp:RadioButtonList ID="rblSexo" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">Masculino</asp:ListItem>
                    <asp:ListItem>Feminino</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Estado Civil</td>
            <td>
                <asp:DropDownList ID="ddlEstadosCivis" runat="server">
                    <asp:ListItem>Solteiro</asp:ListItem>
                    <asp:ListItem>Casado</asp:ListItem>
                    <asp:ListItem>Divorciado</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:CheckBox ID="chkRecebeEmail" runat="server" Text="Recebe E-mail" />
                <asp:CheckBox ID="chkRecebeSMS" runat="server" Text="Recebe SMS" />
            </td>
        </tr>  
    </table>

     <p>

         <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir" />

         <asp:Button ID="btnAtualizar" runat="server" OnClick="btnAtualizar_Click" Text="Atualizar" />

     </p>
    <p>

         <asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label>

     </p>  
</asp:Content>
