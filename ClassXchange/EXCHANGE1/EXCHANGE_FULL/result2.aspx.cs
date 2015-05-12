using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class result2 : System.Web.UI.Page
{
    string uid, pw, needclass, unneedclass, xstatue;

    string hideID(string ID) { // Cody by Yen-An Chen

        string tryHide = ID[0].ToString() + ID[1].ToString() + "******";

        return tryHide;
    }

    void CheckRequest() {

        string queryString = "SELECT Xstatue FROM ExUser WHERE  BaruchID = '" + uid + "' AND PW = '" + pw + "'";
        string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Exchange.accdb;Jet OLEDB:Database Password=MyDbPassword;";

        using (OleDbConnection connection = new OleDbConnection(strConnection))
        {
            OleDbCommand command = new OleDbCommand(queryString, connection);
            connection.Open();
            OleDbDataReader reader;
            reader = command.ExecuteReader();

            // Always call Read before accessing data. 

            int i = 0;

            while (reader.Read())
            {
                if (reader.GetValue(0).ToString() != "none")
                {
                    Response.Write("<B> You have received an Xchange request from " + hideID(reader.GetValue(0).ToString()) + "!!! </B> </BR></BR></BR>");
                    xstatue = reader.GetValue(0).ToString();
                    //Response.Write(xstatue);
                }
                else
                {

                    Response.Write("<B>You do not have any request yet!!!</B></BR></BR></BR>");
                }


                i++;
            }

            if (i == 0)
                Response.Write("Not Result, Try Next time!!!" + "</BR>");

            reader.Close();
            connection.Close();
        }
    
    
    }

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.Cookies["UserInfo"] != null)
        {
            uid = Request.Cookies["UserInfo"]["UID"];
            pw = Request.Cookies["UserInfo"]["PW"];
            unneedclass = Request.Cookies["UserInfo"]["C1"];
            needclass = Request.Cookies["UserInfo"]["C2"];
            
        }

        Response.Write("<B>Welcome to ClassXchange</B></BR></BR>Dear User <B>" + uid + "</B> </BR>");
        Response.Write("Your result of <B>" + unneedclass + "</B> Xchange for <B>" + needclass + "</B>: </BR></BR></BR>");
        CheckRequest();

        string queryString = "SELECT BaruchID,Email,Xstatue FROM ExUser WHERE  UnNeedCode = '" + needclass + "' AND NeedCode = '" + unneedclass + "'";
        string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Exchange.accdb;Jet OLEDB:Database Password=MyDbPassword;";

        using (OleDbConnection connection = new OleDbConnection(strConnection))
        {
            OleDbCommand command = new OleDbCommand(queryString, connection);
            connection.Open();
            OleDbDataReader reader;
            reader = command.ExecuteReader();

            // Always call Read before accessing data. 

            int i = 0;

            while (reader.Read())
            {
                if (reader.GetValue(2).ToString() == uid)
                {
                    Response.Write("Baruch ID: " + hideID(reader.GetValue(0).ToString())
                    + " ; Email: " + reader.GetValue(1) + "@baruchmail.cuny.edu"
                    + " ; <B> You have send Xchange request already!!! </B> </BR>");

                }

                // accept functuin
                
                else if (reader.GetValue(0).ToString() == xstatue)
                {
                    Response.Write("Baruch ID: " + hideID(reader.GetValue(0).ToString())
                    + " ; Email: " + reader.GetValue(1) + "@baruchmail.cuny.edu"
                    + " ; <B> <a href=\"accept.aspx\"> Accept the Xchange </a></B> </BR>");
                }
                
                 
                else if (reader.GetValue(2).ToString() != "none")
                {
                    Response.Write("Baruch ID: " + hideID(reader.GetValue(0).ToString())
                    + " ; Email: " + reader.GetValue(1) + "@baruchmail.cuny.edu"
                    + " ; <B> Others have Requested... </B> </BR>");
                
                }
                else {

                    Response.Write("Baruch ID: " + hideID(reader.GetValue(0).ToString())
                    + " ; Email: " + reader.GetValue(1) + "@baruchmail.cuny.edu"
                    + " ; <a href=\"request.aspx\"> Request an Xchange </a> </BR>");
                    

                }
               
                
                i++;
            }

            if(i==0)
                Response.Write("Not Result, Try Next time!!!" +"</BR>");

            reader.Close();
            connection.Close();
        }

        
        Response.Write("</BR>" + "</BR> See You Next Time!!!" + "</BR>  <B>ClassXchange</B></BR>");
    }


}