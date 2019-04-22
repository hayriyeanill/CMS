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
        if (IsPostBack)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["RegiConnectionString"].ConnectionString);
            conn.Open();
            string checkuser = "select count(*) from RegisterDataBase where StudentName='" + txtUserID.Text + "'";
            SqlCommand cmd = new SqlCommand(checkuser, conn);
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (temp == 1)
            {
                Response.Write("Student Already Exist");
            }

            conn.Close();
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {

            string connectionString;
            SqlConnection cnn;
            connectionString = @"Data Source=DESKTOP-281SDJK\LOCALDB#794B4843;Initial Catalog=CMS"; // Database'i kendi bilgilerine göre değiştir.
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            Console.WriteLine("oldu");
            cnn.Close();


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

