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
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + 
                              Server.MapPath(String.Empty) + "\\Products.accdb;" + 
                              "Jet OLEDB:Database Password=MyDbPassword;";
            
            // sql database to execute on the database
            string sql = "SELECT * FROM Products";

            // using an adapter, fill data table
            OleDbDataAdapter adap = new OleDbDataAdapter(sql, connStr);
            DataTable data = new DataTable(); // the data table to hold info
            adap.Fill(data);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                string productName = data.Rows[i]["ProductName"].ToString();
                string productDesc = data.Rows[i]["ProductDesc"].ToString();
                string productPrice = data.Rows[i]["ProductPrice"].ToString();

                Response.Write("$" + productPrice + " - <B>" + 
                               productName + "</B><BR/>" + 
                               productDesc + "<BR/><BR/>");
                
            }
            
                
            
        %>


    </div>
    </form>
</body>
</html>
