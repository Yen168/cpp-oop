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
            string queryString = "SELECT Email FROM ExUser WHERE  BaruchID = '"+ a +"' AND PW = '"+ b+"'" ;
            string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Exchange.accdb;Jet OLEDB:Database Password=MyDbPassword;";

            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                OleDbDataReader reader;
                reader = command.ExecuteReader();

                // Always call Read before accessing data. 


                while (reader.Read())
                {
                    Response.Write(reader.GetValue(0) +"</BR>");
                    //Response.Write(i);
                 
                }
                // Always call Close when done reading.
                reader.Close();
                
                connection.Close();
            }

            // if (result > 0)
            //  Response.Redirect("result.aspx");
            //else
            //  Response.Redirect("regirster.aspx");

        }

        else {
            Response.Write("ERROR!!!Try Again!!!");
        }
    }
}