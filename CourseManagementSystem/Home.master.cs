using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        sqlConn.Open();

        string query = "SELECT STUDENTS.COURSE_ID FROM STUDENTS WHERE STUDENTS.USER_ID ='" + Session["userid"] + "'";
        SqlCommand sqlCom = new SqlCommand(query, sqlConn);

        SqlDataReader dr;
        dr = sqlCom.ExecuteReader(); // tablodan istedigimiz bilgileri cekiyoruz

        List<string> courses = new List<string>();
        while (dr.Read())
        {
            courses.Add(dr["COURSE_ID"].ToString());
        }

        StringBuilder sb = new StringBuilder();

        sb.Append("<ul class=\"dropdown arrow-top\">");

        for (int i = 0; i <courses.Count; i++) //location.count
        {

            sb.Append("<li><a href= \"CoursePage.aspx?courses=" + courses[i] + "\" >" + courses[i] + "</a></li>");
            //sb.Append("<li><a href= \"HomePage.aspx?userID=" + Session["userid"] + "/course=" + courses[i] + "\">" + courses[i] + "</a></li>");
            //sb.Append("<li><a onserverclick=\"logout_Click\" href= \"CoursePage.aspx?courses=" + courses[i] + "\" >" + courses[i] + "</a></li>");
        }
        sb.Append("</ul>");
        litMarkup.Text = sb.ToString();

        dr.Close();
        sqlConn.Close();

    }


}
