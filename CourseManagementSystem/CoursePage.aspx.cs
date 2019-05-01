using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CoursePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string courses = Request.QueryString["courses"];
        Session["courses"] = courses;

        // Assignments query
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        sqlConn.Open();

        string query = "SELECT COURSES.COURSE_ID, COURSES.COURSE_INSTRUCTOR, ASSIGNMENTS.ASSIGNMENT_NO FROM COURSES, ASSIGNMENTS WHERE COURSES.COURSE_ID = ASSIGNMENTS.COURSE_ID AND COURSES.COURSE_ID='" + Session["courses"] + "' ";
        SqlCommand sqlCom = new SqlCommand(query, sqlConn);
        SqlDataReader dr;
        dr = sqlCom.ExecuteReader();

        while (dr.Read())
        {

            Label1.Text = dr["COURSE_INSTRUCTOR"].ToString() + " added Assignment" + dr["ASSIGNMENT_NO"].ToString() + " in " + dr["COURSE_ID"].ToString();
            BulletedList2.Items.Add(Label1.Text);

        }
        dr.Close();
        sqlConn.Close();
       
        // Resource query
        SqlConnection sqlConn2 = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        sqlConn2.Open();
        string query2 = "SELECT COURSES.COURSE_ID, COURSES.COURSE_INSTRUCTOR,RESOURCES.RESOURCE FROM COURSES, RESOURCES WHERE COURSES.COURSE_ID = RESOURCES.COURSE_ID AND COURSES.COURSE_ID='" + Session["courses"] + "' ";

        SqlCommand sqlCom2 = new SqlCommand(query2, sqlConn2);
        SqlDataReader dr2;
        dr2 = sqlCom2.ExecuteReader();

        while (dr2.Read())
        {          
            Label2.Text = dr2["COURSE_INSTRUCTOR"].ToString() + " added " + dr2["RESOURCE"] + " in " + dr2["COURSE_ID"];
            BulletedList2.Items.Add(Label2.Text);
        }
        dr2.Close();
        sqlConn2.Close();

        // Grades query
        SqlConnection sqlConn3 = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        sqlConn3.Open();
        string query3 = "SELECT COURSE_ID, EXAM, GRADE FROM GRADES WHERE USER_ID='" + Session["userid"] +"' AND COURSE_ID='"  + Session["courses"] + "' ";

        SqlCommand sqlCom3 = new SqlCommand(query3, sqlConn3);
        SqlDataReader dr3;
        dr3 = sqlCom3.ExecuteReader();

        while (dr3.Read())
        {
            Label3.Text = dr3["EXAM"].ToString() + " result added in " + dr3["COURSE_ID"];
             BulletedList2.Items.Add(Label3.Text);
        }
        dr3.Close();
        sqlConn3.Close();
    }
}