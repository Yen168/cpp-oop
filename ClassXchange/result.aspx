<%@ Page Language="C#" AutoEventWireup="true" CodeFile="result.aspx.cs" Inherits="result" %>

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
            width: 203px;
            font-weight: bold;
            height: 30px;
        }
        .style3
        {
            width: 496px;
            height: 30px;
        }
        .style9
        {
            height: 30px;
        }
        </style>
</head>
<%
    if (Session["Email"] == null)
    {
        Response.Redirect("Default.aspx");
        return;
    }
%>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        Welcome, 
        <strong>
        <%
            Response.Write(Session["Email"]);
        %>!!
        <br />
        </strong>
    
    </div>
    <table class="style1">
        <tr>
            <td class="style7">
                UnNeeded Course Code: 
            </td>
            <td class="style3">
            <strong>
                <%
                    Response.Write(Session["UnNeedCode"]);
                %>
            </strong>
            <td>
        </tr>
        <tr>
            <td class="style7">
                Needed Course Code: 
            </td>
            <td class="style3">
            <strong>
                <%
                    Response.Write(Session["NeedCode"]);
                %>
            </strong>
            <td>
        </tr>
        <tr>
            <td class="style7">
                Exchange Statue:
            </td>
            <td class="style3">
            <strong>
                <%
                    string status = Session["XStatus"].ToString();
                    if (status == "1")
                    {
                        Response.Write("Currently enrolled, in processing...");
                    }
                    else if (status == "2")
                    {
                        Response.Write("Successfully exchanged with person with email: " + Session["ExBaruchEmail"]);
                    }
                    else
                    {
                        Response.Write("Currently not doing anything, would you like to enroll to process now?");
                    }
                %>
            </strong>
            <td class="style9">
        </tr>
                <tr>
            <td class="style2">
                    </td>
            <td class="style3">
                <asp:Button ID="Enroll" runat="server" onclick="Enroll_Click" Text="Enroll" 
                    style="height: 26px" />
                <asp:Button ID="UnEnroll" runat="server" onclick="Unroll_Click" Text="UnEnroll" 
                    style="height: 26px" />
            </td>
            <td class="style9">
           </td>
        </tr>
    </table>
    <div style="margin-left: 520px">
        <asp:Button ID="Button1" runat="server" Text="Logout" onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>
