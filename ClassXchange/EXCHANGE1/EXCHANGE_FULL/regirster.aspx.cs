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

    public int CheckText(string id,string code1,string code2) 
    {
        // Code by Yen-An Chen & Zhenyu Chen

        if (id.Length != 8) // string length has to be 8 char!
        {
            Response.Write("ERROR <1>!!! You are not Baruch Student!!!");
            return 1;
        }
        else {

            // first two chars have to be letters!!!
            if (Char.IsLetter(id, 0) && Char.IsLetter(id, 1))
                Response.Write("ID CHECK PASSED" + "</BR>");

            else {
                Response.Write("ERROR <2>!!! You are not Baruch Student!!!");
                return 1;
            }
        
        }
        
        // code1 length have to be 4
        if (code1.Length != 4) {

            Response.Write("ERROR <3>!!! Double check your Class Code!!!");
            return 1;
        
        }

        // code2 length have to be 4
         if (code2.Length != 4) {

            Response.Write("ERROR <4>!!! Double check your Class Code!!!");
            return 1;
        
        }

         // code1 and code2 cant be same
         if (code1 == code2)
         {
             Response.Write("ERROR <5>!!! Class Codes can not be the same!!!");
            return 1;
        
        }
            
        return 0;
    }

    public int CheckID(string id) {

        // Code by Yen-An Chen
        
        string queryString = "SELECT ID FROM ExUser WHERE  BaruchID = '" + id + "'";
        string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Exchange.accdb;Jet OLEDB:Database Password=MyDbPassword;";

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

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        int checkvalue = CheckText(TextBoxID.Text, TextBoxCode1.Text, TextBoxCode2.Text);
        int checkid = CheckID(TextBoxID.Text);

        if ((checkvalue == 0) && (checkid == 0)) {

            OleDbConnection objConnection = null;
            OleDbCommand objCmd = null;
            String strConnection, strSQL;

            strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Exchange.accdb;Jet OLEDB:Database Password=MyDbPassword;";

            objConnection = new OleDbConnection(strConnection);
            objConnection.ConnectionString = strConnection;

            objConnection.Open();

            // set the SQL string
            strSQL = "INSERT INTO ExUser (BaruchID , Email , PW , UnNeedCode , NeedCode , XStatue) VALUES ( '" + TextBoxID.Text + "' , '" + TextBoxEM.Text + "' , '" + TextBoxPW.Text + "' , '" + TextBoxCode1.Text + "' , '" + TextBoxCode2.Text + "' , 'none' )";

            // Create the Command and set its properties
            objCmd = new OleDbCommand(strSQL, objConnection);

            // execute the command
            objCmd.ExecuteNonQuery();
            objConnection.Close();

            //Server.Transfer("Login.aspx");
            Response.Redirect("login.aspx");
        
        
        }

    }
}