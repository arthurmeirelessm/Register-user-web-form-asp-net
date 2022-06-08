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

        .container  h1{
            text-align: center
        }

        .campo {
            padding: 10px;
        }

        .campo input[type="text"]{
            float: right;
            width: 350px
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Registration</h1>
            <div class="campo">
                <label for="textName">Name: </label>
                <input type="text" id="nameId" />
            </div>
            <div class="campo">
                <label for="emailId">Email: </label>
                <input type="text" id="emailId" />
            </div>
            <div class="campo">
                <label for="numberId">Number: </label>
                <input type="text" id="numberId" />
            </div>

            <div class="campo">
               <input type="submit" />
            </div>
        </div>
    </form>
</body>
</html>
