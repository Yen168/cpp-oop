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

        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                             Server.MapPath(String.Empty) + "C:\\Documents and Settings\\Yen-an Chen\\My Documents\\Visual Studio 2010\\WebSites\\EXCHANGE\\Exchange.accdb;" +
                             "Jet OLEDB:Database Password=MyDbPassword;";

        string strSQL = "INSERT INTO ExUser (BaruchID , Email , PW ) VALUES ( 'KADHsdtreASU133' , 'Hafsfff@','TTT' )";

        OleDbConnection objConnection = new OleDbConnection(connStr);
        objConnection.ConnectionString = connStr;

        objConnection.Open();

        OleDbCommand objCmd = new OleDbCommand(strSQL, objConnection);

        // execute the command
        objCmd.ExecuteNonQuery();
        

        Response.Redirect("Login.aspx");
       
    }
}