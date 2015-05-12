using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                             Server.MapPath(String.Empty) + "\\Exchange.accdb;" +
                             "Jet OLEDB:Database Password=MyDbPassword;";

        // sql database to execute on the database
        string sql = "SELECT * FROM ExUser";

        // using an adapter, fill data table
        OleDbDataAdapter adap = new OleDbDataAdapter(sql, connStr);
        DataTable data = new DataTable(); // the data table to hold info
        adap.Fill(data);

        for (int i = 0; i < data.Rows.Count; i++)
        {
            string BaruchID = data.Rows[i]["BaruchID"].ToString();
            string Email = data.Rows[i]["Email"].ToString();
            string PW = data.Rows[i]["PW"].ToString();

            Response.Write("BaruchID: " + BaruchID + " BaruchEMAIL: " +
                           Email + " PW: " +
                           PW + "</BR>");

        }

    }
}