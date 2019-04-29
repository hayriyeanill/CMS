using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage :  System.Web.UI.Page
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
            BulletedList1.Items.Add(Label1.Text);
        }

        
        dr.Close();
        sqlConn.Close();

        SqlConnection sqlConn2 = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        sqlConn2.Open();
        string query2 = "SELECT COURSES.COURSE_INSTRUCTOR,ASSIGNMENTS.COURSE_ID,ASSIGNMENTS.ASSIGNMENT_NO FROM COURSES, ASSIGNMENTS where COURSES.COURSE_ID = ASSIGNMENTS.COURSE_ID";
        SqlCommand sqlCom2 = new SqlCommand(query2, sqlConn2);
        SqlDataReader dr2;
        dr2 = sqlCom2.ExecuteReader();
        while (dr2.Read())
        {
            Label2.Text = dr2["COURSE_INSTRUCTOR"].ToString() + " added Assignment " + dr2["ASSIGNMENT_NO"].ToString() + " in " + dr2["COURSE_ID"].ToString();
            BulletedList2.Items.Add(Label2.Text);
        }
       
        dr2.Close();
        sqlConn2.Close();
    }

}
