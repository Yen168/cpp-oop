<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            text-align: left;
            width: 104px;
            font-weight: bold;
        }
        .style3
        {
            width: 205px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <strong>User Login<br />
        </strong>
        <br />
        <br />
        <br />
        <table class="style1">
            <tr>
                <td class="style2">
                    User ID</td>
                <td class="style3" style="text-align: left">
                    <asp:TextBox ID="TextBoxUID" runat="server" Width="175px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    Password</td>
                <td class="style3" style="text-align: left">
                    <asp:TextBox ID="TextBoxUPW" runat="server" Width="175px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Login" />
        <br />
        <br />
    
    </div>
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <asp:Label ID="Label2" runat="server"></asp:Label>
    </form>
</body>
</html>
