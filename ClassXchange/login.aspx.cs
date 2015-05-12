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

    public OleDbConnection getConnection()
    {
        return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath(String.Empty) + "\\Exchange.accdb;Jet OLEDB:Database Password=MyDbPassword;");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Code by Yen-An Chen & Zhenyu Chen
        if (TextBoxUID.Text != "" & TextBoxUPW.Text != "")
        {
            Boolean found = false; 
            string a = TextBoxUID.Text, b = TextBoxUPW.Text;
            string queryString = "SELECT * FROM ExUser WHERE  BaruchID = '" + a + "' AND PW = '" + b + "'";
 
            using (OleDbConnection connection = getConnection())
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader;
                reader = command.ExecuteReader();

                // Always call Read before accessing data. 
                while (reader.Read()) {
                    Response.Write(reader["Email"] + "</BR>"); 
                    //Response.Write(i); Error Check.

                    Session["BaruchID"] = reader["BaruchID"];
                    Session["Email"] = reader["Email"];
                    Session["UnNeedCode"] = reader["UnNeedCode"];
                    Session["NeedCode"] = reader["NeedCode"];
                    Session["ExBaruchEmail"] = reader["ExBaruchEmail"];
                    Session["XStatus"] = reader["XStatus"];

                    found = true;
                    break;
                }
                // Always call Close when done reading. 
                reader.Close();

                if (!found)
                    Response.Write("User Not Found, please register." + "</BR>");

                connection.Close();
            }


            if (found)
                Response.Redirect("result.aspx");
            else
                Response.Redirect("regirster.aspx");

        }

        else
        {
            Response.Write("ERROR!!!Try Again!!!");
        }
    }

    protected void GoBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}