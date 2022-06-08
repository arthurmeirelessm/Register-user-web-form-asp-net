<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="register_user_web_form_asp_net.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .container {
            position: center;
            width: 450px;
            margin: 0 auto;
        }

            .container h1 {
                text-align: center
            }

          .campo {
            padding: 10px;
           }

            .campo input[type="text"] {
                float: right;
                width: 350px
            }

            .campo input[type="submit"] {
                float: right;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Registration</h1>
            <div class="campo">
                <asp:Label runat="server" AssociatedControlID="nameId">Name: </asp:Label>
                <asp:TextBox runat="server" ID="nameId"></asp:TextBox>
            </div>
            <div class="campo">
                <asp:Label runat="server" AssociatedControlID="emailId">Email: </asp:Label>
                <asp:TextBox runat="server" ID="emailId"></asp:TextBox>
            </div>
            <div class="campo">
                <asp:Label runat="server" AssociatedControlID="numberId">Number: </asp:Label>
                <asp:TextBox runat="server" ID="numberId"></asp:TextBox>
            </div>

            <div class="campo">
                <asp:Button ID="btnRegisterUser" runat="server" Text="Register"></asp:Button>
            </div>
            <br />

            <p>
                <asp:Literal runat="server" ID="registerMessage"></asp:Literal></p>
        </div>
    </form>
</body>
</html>
