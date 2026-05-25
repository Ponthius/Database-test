<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Database_test.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div
            <asp:Label ID="name" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="nameTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="email" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="password" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" />

            <asp:Label ID="registerStatus" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
