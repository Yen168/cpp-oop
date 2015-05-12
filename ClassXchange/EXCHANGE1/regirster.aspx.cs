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
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Submit_Click(object sender, EventArgs e)
    {
        OleDbConnection objConnection = null;
        OleDbCommand objCmd = null;
        String strConnection, strSQL;

        strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Documents and Settings\\Yen-an Chen\\My Documents\\Visual Studio 2010\\WebSites\\EXCHANGE\\Exchange.accdb;Jet OLEDB:Database Password=MyDbPassword;";

        objConnection = new OleDbConnection(strConnection);
        objConnection.ConnectionString = strConnection;

        objConnection.Open();

        // set the SQL string
        strSQL = "INSERT INTO ExUser (BaruchID , Email , PW ) VALUES ( '"+ TextBoxUID.Text +"' , '"+ TextBoxEM.Text +"' , '"+ TextBoxUPW.Text +"' )";

        // Create the Command and set its properties
        objCmd = new OleDbCommand(strSQL, objConnection);

        // execute the command
        objCmd.ExecuteNonQuery();
        objConnection.Close();
     
        Response.Redirect("Login.aspx");
       
        


    }
}