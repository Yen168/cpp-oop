<%@ Page Language="C#" AutoEventWireup="true" %>

<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.OleDb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <%
            // connection string so that we know 
            // from which database to extract the information
           // string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + 
                              Server.MapPath(String.Empty) + "\\Products.accdb;" + 
                              "Jet OLEDB:Database Password=MyDbPassword;";
    

             OleDbConnection objConnection = null;
    OleDbCommand objCmd = null; 
    String strConnection, strSQL;

    strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;";
    strConnection += @"Data Source="+MapPath("Products.accdb");
     
    // Create and open the connection object
    objConnection = new OleDbConnection(strConnection);
    objConnection.ConnectionString = strConnection;

    objConnection.Open();
    
    // set the SQL string
    strSQL = "INSERT INTO Products (ProductName , ProductDesc ) " +
    "VALUES ( 'Beth' , 'Hart' )";

    // Create the Command and set its properties
    objCmd = new OleDbCommand(strSQL, objConnection);
    
    // execute the command
    objCmd.ExecuteNonQuery();

    lblStatus.Text = "Command run";
            
                
            
        %>


    </div>
    </form>
</body>
</html>
