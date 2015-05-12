<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            margin-left: 130px;
            margin-right: 0px;
        }
        .style3
        {
            font-size: x-large;
        }
        .auto-style1 {
            width: 319px;
            text-align: center;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            text-align: justify;
        }
        .userContent
        {
            text-align: center;
        }
    </style>
</head>
<body style="text-align: center">
    <form id="form1" runat="server">
    <div>
    
        <strong><span class="style3">
        <br />
        Welcome to ClassXchange<br />
        </span><br class="style3" />
        <br />
        <table class="style1">
            <tr>
                <td class="auto-style1">
                    <strong>New User??? </strong></td>
                <td class="auto-style2">
                    Already Have an Account!!!</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <br />
                    <a href="regirster.aspx">Register</a><br />
                    <br />
                </td>
                <td class="auto-style2">
                    <br />
                    <a href="Login.aspx">Login</a><br />
                </td>
            </tr>
        </table>
        <br />
        <br />
        <span class="st">Choice is a right, not a privilege.<br />
        <br />
        <br />
        </span>
    <h5 class="auto-style2" data-ft="{&quot;type&quot;:1,&quot;tn&quot;:&quot;K&quot;}"><span class="messageBody" data-ft="{&quot;type&quot;:3,&quot;tn&quot;:&quot;K&quot;}"><span class="userContent">Imagine yourself sitting in front of a computer, waiting for the clock ticking until it reaches time for you to register next semester&#39;s classes. </span></span></h5>
    <h5 class="auto-style2" data-ft="{&quot;type&quot;:1,&quot;tn&quot;:&quot;K&quot;}">
        <span class="messageBody" data-ft="{&quot;type&quot;:3,&quot;tn&quot;:&quot;K&quot;}">
        <span class="userContent">Then as you enter each of your class code quickly and carefully and press &quot;submit&quot;, all you see on the screen is terrifying red words saying the classes are closed. </span></span></h5>
    <h5 class="auto-style2" data-ft="{&quot;type&quot;:1,&quot;tn&quot;:&quot;K&quot;}"><span class="messageBody" data-ft="{&quot;type&quot;:3,&quot;tn&quot;:&quot;K&quot;}"><span class="userContent">Regretting and unsatisfying, you have to register the classes you don&#39;t need. </span></span></h5>
    <h5 class="auto-style2" data-ft="{&quot;type&quot;:1,&quot;tn&quot;:&quot;K&quot;}">
        <span class="messageBody" data-ft="{&quot;type&quot;:3,&quot;tn&quot;:&quot;K&quot;}">
        <span class="userContent">To solve this problem that has been sticking with us since the first semester of our freshman year, our team developed a program that allows students to exchange classes with one another. </span></span></h5>
    <h5 class="auto-style2" data-ft="{&quot;type&quot;:1,&quot;tn&quot;:&quot;K&quot;}">
        <span class="messageBody" data-ft="{&quot;type&quot;:3,&quot;tn&quot;:&quot;K&quot;}">
        <span class="userContent">To simplify the process, we assume that one pair of students can satisfy each other&#39;s need internally. </span></span></h5>
    <h5 class="auto-style2" data-ft="{&quot;type&quot;:1,&quot;tn&quot;:&quot;K&quot;}"><span class="messageBody" data-ft="{&quot;type&quot;:3,&quot;tn&quot;:&quot;K&quot;}"><span class="userContent">That is to say, if student A needs class 0001 and has class 0002 unwanted, he/she can exchange with student B who exactly needs 0002 and can give up 0001 in return. </span></span></h5>
    <h5 class="auto-style2" data-ft="{&quot;type&quot;:1,&quot;tn&quot;:&quot;K&quot;}"><span class="messageBody" data-ft="{&quot;type&quot;:3,&quot;tn&quot;:&quot;K&quot;}"><span class="userContent">For this program, we plan to use C# language 
        for this website and Access as database.</span></span></h5>
        <br />
        </strong>
    
    </div>
    </form>
    </body>
</html>
