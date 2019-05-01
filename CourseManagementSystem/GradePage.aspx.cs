using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class GradePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        sqlConn.Open();
        string query = "SELECT EXAM, GRADE FROM GRADES WHERE USER_ID='" + Session["userid"] + "' AND COURSE_ID='"+ Session["courses"] +"'";
        SqlDataAdapter sqlD = new SqlDataAdapter(query, sqlConn);
        DataTable dtb1 = new DataTable();
        sqlD.Fill(dtb1);
        GridView1.DataSource = dtb1;
        GridView1.DataBind();

        sqlConn.Close();
    }
}