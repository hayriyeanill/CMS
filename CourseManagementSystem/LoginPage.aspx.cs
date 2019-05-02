using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text.RegularExpressions;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Abandon();
        lblErrorMessage.Visible = false;
    }

    protected void btnLogin_Click1(object sender, EventArgs e)
    {
        Regex r = new Regex(@"^[0-9]*$"); // userID must be numerical characters.
        if (!r.IsMatch(txtUserID.Text))
        {
            lblErrorMessage.Visible = true;
            txtUserID.Text = "";
        }
        else
        {
            using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;"))
            {
                try
                {
                    sqlConn.Open();
                    string query = "SELECT COUNT(1) FROM USERS WHERE user_id=@userid AND password=@password";
                    SqlCommand sqlCom = new SqlCommand(query, sqlConn);

                    sqlCom.Parameters.AddWithValue("@userid", txtUserID.Text.Trim());
                    sqlCom.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                    int count = Convert.ToInt32(sqlCom.ExecuteScalar()); // Count has to be 1 otherwise, user does not exist.
                    if (count == 1)
                    {
                        if (Session["userid"] == null)
                        {
                            Session.Add("userid", txtUserID.Text.Trim());
                        }
                        else
                        {
                            Session["userid"] = txtUserID.Text.Trim(); // to know which user signed in.
                        }   
                        Response.Redirect("HomePage.aspx?userID=" + Session["userid"]);
                    }
                    else
                    {
                        lblErrorMessage.Visible = true;
                        txtUserID.Text = "";
                    }
                    sqlConn.Close();
                }
                catch (Exception ex)
                {
                    Response.Write(ex.ToString());
                }
            }
        }
    }
}

// logout butonunda session.abandon kullanmayi unutma   