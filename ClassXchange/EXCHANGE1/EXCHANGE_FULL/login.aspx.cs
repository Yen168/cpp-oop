using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class login : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (TextBoxUID.Text != "" & TextBoxUPW.Text != "")
        {
            
            string a = TextBoxUID.Text, b = TextBoxUPW.Text;
            string queryString = "SELECT UnNeedCode,NeedCode FROM ExUser WHERE  BaruchID = '" + a + "' AND PW = '" + b + "'";
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
                    Response.Write(reader.GetValue(0) + "</BR>");
                    Label1.Text = reader.GetValue(0).ToString();
                    Response.Write(reader.GetValue(1) + "</BR>");
                    Label2.Text = reader.GetValue(1).ToString();
                    i++;
                }
                // Always call Close when done reading.

                if (i == 0)
                    Response.Write("User Not Found" + "</BR>");
                else
                {
                    Response.Write("User Found" + "</BR>");
                    // cookies by Yen-An Chen

                    HttpCookie myCookie = new HttpCookie("UserInfo");
                    
                    myCookie["UID"] = TextBoxUID.Text;
                    myCookie["PW"] = TextBoxUPW.Text;
                    myCookie["C1"] = Label1.Text;
                    myCookie["C2"] = Label2.Text;
                    Response.Cookies.Add(myCookie);

                    reader.Close();
                    connection.Close();
                   
                   Server.Transfer("result.aspx");
                }

                reader.Close();
                connection.Close();
            }
 
        }

        else
        {
            Response.Write("ERROR!!!Try Again!!!");
        }
    }
}