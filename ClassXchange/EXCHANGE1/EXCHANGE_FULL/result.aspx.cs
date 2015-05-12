using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class result : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        string uid, pw, needclass, unneedclass;


        if (Request.Cookies["UserInfo"] != null)// update result by Zhenyu Chen & Yen-An Chen
        {
            uid = Request.Cookies["UserInfo"]["UID"];
            pw = Request.Cookies["UserInfo"]["PW"];
            unneedclass = Request.Cookies["UserInfo"]["C1"];
            needclass = Request.Cookies["UserInfo"]["C2"];
            Response.Write("Logining...");
        }
        
        Response.Redirect("result2.aspx");
    }

    
}