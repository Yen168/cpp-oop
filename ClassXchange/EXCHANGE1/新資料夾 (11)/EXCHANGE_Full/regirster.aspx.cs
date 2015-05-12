using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// data
using System.Data;
using System.Data.OleDb;


public partial class regirster : System.Web.UI.Page
{
    private string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Exchange.accdb;Jet OLEDB:Database Password=MyDbPassword;";

    public int CheckText(string id, string email, string code1,string code2) 
    {
        // Code by Yen-An Chen & Zhenyu Chen

        if (id.Length != 8 || !Char.IsLetter(id, 0) || !Char.IsLetter(id, 1)) // string length has to be 8 char, and first two chars have to be letters!!!
        {
            Response.Write("Error!! Your ID is wrong, you are not a Baruch Student!!!");
            return 1;
        }
        else {
            //Response.Write("ID CHECK PASSED" + "</BR>");
        }

        // check email addresss
        if (!email.ToLowerInvariant().EndsWith("@baruchmail.cuny.edu"))
        {

            Response.Write("Error!! You did not enter a vailed Baruch Email!!");
            return 1;

        }
        
        // code1 length have to be 4
        if (code1.Length != 4) {

            Response.Write("Error!! Double check your Class Code!!!");
            return 1;
        
        }

        // code2 length have to be 4
         if (code2.Length != 4) {

            Response.Write("Error!! Double check your Exchange Class Code!!!");
            return 1;
        
        }

         // code1 and code2 cant be same
         if (code1 == code2)
         {
             Response.Write("Error!! Class Codes can not be the same!!!");
            return 1;
        
        }
            
        return 0;
    }

    public int CheckID(string id) {

        // Code by Yen-An Chen
        
        string queryString = "SELECT ID FROM ExUser WHERE  BaruchID = '" + id + "'";

        using (OleDbConnection connection = new OleDbConnection(strConnection))
        {
            OleDbCommand command = new OleDbCommand(queryString, connection);
            connection.Open();
            OleDbDataReader reader;
            reader = command.ExecuteReader();

            int i = 0;

            while (reader.Read())
            {
                Response.Write("USER EXISTED!!!" + "</BR>");
                i++;
                //Response.Write("i: "+ i + "</BR>");
            }
            
            reader.Close();
            connection.Close();
            
            return i;
        }
    }

    public int CheckEmail(string email)
    {

        // Code by Zhenyu Chen

        string queryString = "SELECT ID FROM ExUser WHERE  Email = '" + email + "'";

        using (OleDbConnection connection = new OleDbConnection(strConnection))
        {
            OleDbCommand command = new OleDbCommand(queryString, connection);
            connection.Open();
            OleDbDataReader reader;
            reader = command.ExecuteReader();

            int i = 0;

            while (reader.Read())
            {
                Response.Write("This email is already registered! </BR>");
                i++;
                break;
            }

            reader.Close();
            connection.Close();

            return i;
        }
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        int checkvalue = CheckText(TextBoxID.Text, TextBoxEM.Text, TextBoxCode1.Text, TextBoxCode2.Text);
        int checkid = CheckID(TextBoxID.Text);
        int checkemail = CheckEmail(TextBoxEM.Text);

        if (checkvalue == 0 && checkid == 0 && checkemail == 0)
        {

            OleDbConnection objConnection = null;
            OleDbCommand objCmd = null;
            String strSQL;

            objConnection = new OleDbConnection(strConnection);
            objConnection.ConnectionString = strConnection;

            objConnection.Open();

            // set the SQL string
            strSQL = "INSERT INTO ExUser (BaruchID , Email , PW , UnNeedCode , NeedCode) VALUES ( '" + TextBoxID.Text + "' , '" + TextBoxEM.Text + "' , '" + TextBoxPW.Text + "' , '" + TextBoxCode1.Text + "' , '" + TextBoxCode2.Text + "')";

            // Create the Command and set its properties
            objCmd = new OleDbCommand(strSQL, objConnection);

            // execute the command
            objCmd.ExecuteNonQuery();


            objConnection.Close();

            Response.Redirect("Login.aspx");
        
        
        }

    }
}