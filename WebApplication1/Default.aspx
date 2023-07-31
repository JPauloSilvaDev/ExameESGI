<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TesteAdmissao.Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!DOCTYPE html>
    <html>
    <head>
        <title>Login Page</title>
    </head>
    <body>
        <br />
        <style>
            body {
                margin-left: 600px;
                
            }

            /* Style the form container */
            .login-form {
                width: 300px;
                padding: 20px;
                border: 1px solid #ccc;
                border-radius: 5px;
            }

                /* Style form elements */
                .login-form label,
                .login-form input,
                .login-form button {
                    display: block;
                }

                .login-form label {
                    margin-bottom: 5px; 
                }

                .login-form input {
                    margin-left: 0px; 
                }

                .login-form button {
                    width: 100%;
                }
        </style>



        <div class="login-form">
            <h2>Login</h2>
            <div>
                <label for="txtUsername">Usuário:</label>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="txtPassword">Senha:</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <br />
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="Login_Click" />
                <br />
            </div>
            <asp:Label ID="Mensagem" runat="server"></asp:Label>
            <div>
            </div>
        </div>
    </body>
    </html>
</asp:Content>
