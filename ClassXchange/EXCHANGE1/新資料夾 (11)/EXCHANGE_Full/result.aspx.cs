using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// data
using System.Data;
using System.Data.OleDb;


public partial class result : System.Web.UI.Page
{

    private string strConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Exchange.accdb;Jet OLEDB:Database Password=MyDbPassword;";


    protected void Enroll_Click(object sender, EventArgs e)
    {
        string status = Session["XStatus"].ToString();
        if (status == "2")
        {
            Response.Write("You've already successfully exchanged your course, you don't need to do it again.");
        }
        else if (status != "0")
        {
            Response.Write("You are already enrolled, you don't need to enroll again.");
        }
        else
        {
            OleDbConnection conn = null;
            OleDbCommand objCmd = null;
            conn = new OleDbConnection(strConnection);
            conn.ConnectionString = strConnection;

            conn.Open();

            String sql = "UPDATE ExUser SET XStatus = 1 WHERE BaruchID = '" + Session["BaruchID"].ToString() +"'";

            objCmd = new OleDbCommand(sql, conn);

            objCmd.ExecuteNonQuery(); // execute the command
            conn.Close();

            Session["XStatus"] = "1";

            CheckAndMakeExchange();

            Page.Response.Redirect(Page.Request.Url.ToString(), true); // refresh page
        }

    }

    protected void Unroll_Click(object sender, EventArgs e)
    {
        string status = Session["XStatus"].ToString();
        if (status == "2")
        {
            Response.Write("You've already successfully exchanged your course, you don't need to do it again.");
        }
        else if (status != "1")
        {
            Response.Write("You are not enrolled, so you can't use this function.");
        }
        else
        {
            OleDbConnection conn = null;
            OleDbCommand objCmd = null;
            conn = new OleDbConnection(strConnection);
            conn.ConnectionString = strConnection;

            conn.Open();

            String sql = "UPDATE ExUser SET XStatus = 0 WHERE BaruchID = '" + Session["BaruchID"].ToString() + "'";

            objCmd = new OleDbCommand(sql, conn);

            objCmd.ExecuteNonQuery(); // execute the command
            conn.Close();

            Session["XStatus"] = "0";

            Page.Response.Redirect(Page.Request.Url.ToString(), true); // refresh page
        }
    }


    public bool CheckAndMakeExchange()
    {
        string baruchID = Session["BaruchID"].ToString();
        string email = Session["Email"].ToString();
        string unneed = Session["UnNeedCode"].ToString();
        string need = Session["NeedCode"].ToString();

        string sql1 = "SELECT Email FROM ExUser WHERE NeedCode = '" + unneed + "' AND UnNeedCode = '" + need + "' AND XStatus = 1";

        bool success = false;
        string exchanger = null;
        using (OleDbConnection connection = new OleDbConnection(strConnection))
        {
            OleDbCommand command = new OleDbCommand(sql1, connection);
            connection.Open();
            OleDbDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                exchanger = reader["Email"].ToString();
                success = true;
                break;
            }
            reader.Close();
            connection.Close();

            if (exchanger != null)
            {
                connection.Open();

                string sql2 = "UPDATE ExUser SET ExBaruchEmail = '" + email + "', XStatus = 2 WHERE Email = '" + exchanger + "'";

                command = new OleDbCommand(sql2, connection);
                command.ExecuteNonQuery(); // execute the command

                string sql3 = "UPDATE ExUser SET ExBaruchEmail = '" + exchanger + "', XStatus = 2 WHERE BaruchID = '" + baruchID + "'";
                command = new OleDbCommand(sql3, connection);
                command.ExecuteNonQuery(); // execute the command

                connection.Close();


                Session["XStatus"] = "2";
                Session["ExBaruchEmail"] = exchanger;
            }
        }
        return success;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        Response.Redirect("Default.aspx");
    }
}