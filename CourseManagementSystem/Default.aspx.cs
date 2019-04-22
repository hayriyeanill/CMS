using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string connectionString;
            SqlConnection cnn;

            connectionString = @"Data Source=(localdb)\CMS; Initial Catalog=CMS"; 
            cnn = new SqlConnection(connectionString);

            cnn.Open();
            Response.Write("db baglandi");
            cnn.Close();
        }
        catch (Exception ex)
        {
            Response.Write("error" + ex.ToString());
        }

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {

            /* string userId = txtUserID.Text;
             string password = txtPassword.Text;
             * if (txtUserID.Text == "12345" && txtPassword.Text == "123")
             {
                 Response.Redirect("Default2.aspx?userID=" + userId);
             }
             else
             {
                 Label1.Text = "Invalid Name or Password";
             }
             */
        }
        catch (Exception ex)
        {
            Response.Write("error" + ex.ToString());
        }
    }
}

