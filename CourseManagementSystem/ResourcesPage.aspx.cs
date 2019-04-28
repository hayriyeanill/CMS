using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ResourcesPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        sqlConn.Open();
        string query = "SELECT COURSE_ID, COURSE_INSTRUCTOR, RESOURCE FROM RESOURCES";
        SqlCommand sqlCom = new SqlCommand(query, sqlConn);

        SqlDataReader dr;
        dr = sqlCom.ExecuteReader();

        while (dr.Read())
        {
            Label1.Text = dr["COURSE_INSTRUCTOR"].ToString() + " added " + dr["RESOURCE"] + " in " + dr["COURSE_ID"];
            BulletedList2.Items.Add(Label1.Text);
        }

        BulletedList2.Items.Add(Label1.Text);
        dr.Close();
        sqlConn.Close();
    }
}