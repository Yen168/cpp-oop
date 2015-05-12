using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test1 : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie myCookie = new HttpCookie("UserSettings");
        myCookie["UID"] = TextBox1.Text;
        myCookie["PW"] = TextBox2.Text;
        Response.Cookies.Add(myCookie);
        Server.Transfer("result.aspx");

    }
}