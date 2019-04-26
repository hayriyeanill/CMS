using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblErrorMessage.Visible = false;
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        using (SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;"))
        {
            try {
            sqlConn.Open();
            string query = "SELECT COUNT(1) FROM USERS WHERE user_id=@userid AND password=@password";
            SqlCommand sqlCom = new SqlCommand(query, sqlConn);

            sqlCom.Parameters.AddWithValue("@userid", txtUserID.Text.Trim());
            sqlCom.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

            int count = Convert.ToInt32(sqlCom.ExecuteScalar()); // 1 gelmesi gerekiyor diger turlu kullanici yok demektir.
                if (count == 1)
                {
                    Session["userid"] = txtUserID.Text.Trim(); // kullaniciyi bilmek icin
                    Response.Redirect("HomePage.aspx?userID=" + Session["userid"]);
                }
                else
                {
                    lblErrorMessage.Visible = true;
                }
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }
        } 
    }
}

