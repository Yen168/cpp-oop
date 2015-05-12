<%@ Page Language="C#" AutoEventWireup="true" CodeFile="regirster.aspx.cs" Inherits="regirster" %>

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
            text-align: right;
            width: 127px;
            font-weight: bold;
        }
        .style3
        {
            width: 496px;
        }
        .style4
        {
            text-align: right;
            width: 127px;
            font-weight: bold;
            height: 29px;
        }
        .style5
        {
            width: 496px;
            height: 29px;
        }
        .style6
        {
            height: 29px;
        }
        .style7
        {
            color: #3333CC;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <strong>New User Regirstration<br />
        </strong>
    
    </div>
    <table class="style1">
        <tr>
            <td class="style2">
                Baruch ID</td>
            <td class="style3">
                <asp:TextBox ID="TextBoxID" runat="server" Width="200px"></asp:TextBox>
                (ex. AD123456)</td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBoxID" ErrorMessage="Please Enter Your Baurch ID" 
                    ForeColor="Red" style="font-weight: 700"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                Baruch E-mail</td>
            <td class="style5">
                <asp:TextBox ID="TextBoxEM" runat="server" Width="200px"></asp:TextBox>
                (ex. first.last@baruchmail.cuny.edu)</td>
            <td class="style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBoxEM" ErrorMessage="Please Enter Your Baruch E-mail" 
                    ForeColor="Red" style="font-weight: 700"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Password</td>
            <td class="style3">
                <asp:TextBox ID="TextBoxPW" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="TextBoxPW" ErrorMessage="Please Enter Your Password" 
                    ForeColor="Red" style="font-weight: 700"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Repeat Password</td>
            <td class="style3">
                <asp:TextBox ID="TextBoxRPW" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="TextBoxRPW" ErrorMessage="Please Enter Your Password Again" 
                    ForeColor="Red" style="font-weight: 700"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="TextBoxPW" ControlToValidate="TextBoxRPW" 
                    ErrorMessage="Password do not match" ForeColor="Red" style="font-weight: 700"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Class Code</td>
            <td class="style3">
                <asp:TextBox ID="TextBoxCode1" runat="server"></asp:TextBox>
&nbsp;<span class="style7"><strong> Xchange for</strong></span>&nbsp;
                <asp:TextBox ID="TextBoxCode2" runat="server"></asp:TextBox>
            </td>
            <td>
                Please Enter Class Codes (ex. 1234 to exchange 4321)</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="Submit" runat="server" onclick="Submit_Click" Text="Submit" 
                    style="height: 26px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </form>
</body>
</html>
