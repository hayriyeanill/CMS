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

        SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        sqlConn.Open();
        //string query = "SELECT COURSES.COURSE_ID, COURSES.COURSE_INSTRUCTOR, ASSIGNMENTS.ASSIGNMENT_NO FROM COURSES, ASSIGNMENTS WHERE COURSES.COURSE_ID = ASSIGNMENTS.COURSE_ID AND COURSES.COURSE_ID='SEN3304' ";
        //string query = "SELECT COURSES.COURSE_ID, COURSES.COURSE_INSTRUCTOR, ASSIGNMENTS.ASSIGNMENT_NO FROM COURSES, ASSIGNMENTS WHERE COURSES.COURSE_ID = ASSIGNMENTS.COURSE_ID AND COURSES.COURSE_ID = 'SEN3006'";
        //string query = "SELECT COURSES.COURSE_ID, COURSES.COURSE_INSTRUCTOR, ASSIGNMENTS.ASSIGNMENT_NO FROM COURSES, ASSIGNMENTS WHERE COURSES.COURSE_ID = ASSIGNMENTS.COURSE_ID AND COURSES.COURSE_ID = 'SEN2212'";
        string query = "SELECT COURSES.COURSE_ID, COURSES.COURSE_INSTRUCTOR, RESOURCES.RESOURCE FROM COURSES, RESOURCES WHERE COURSES.COURSE_ID = RESOURCES.COURSE_ID and COURSES.COURSE_ID = 'MAT3012'";
        //string query = "SELECT COURSES.COURSE_ID, COURSES.COURSE_INSTRUCTOR, RESOURCES.RESOURCE FROM COURSES, RESOURCES WHERE COURSES.COURSE_ID = RESOURCES.COURSE_ID and COURSES.COURSE_ID = 'SEN2022'";
        //string query = "SELECT COURSES.COURSE_ID, COURSES.COURSE_INSTRUCTOR, RESOURCES.RESOURCE FROM COURSES, RESOURCES WHERE COURSES.COURSE_ID = RESOURCES.COURSE_ID and COURSES.COURSE_ID = 'SEN4551'";
        SqlCommand sqlCom = new SqlCommand(query, sqlConn);
      

        SqlDataReader dr;
        dr = sqlCom.ExecuteReader();
       


        while (dr.Read())
        {
            // DropDownList1.Items.Insert(0, new ListItem(DropDownList1.DataValueField = dr["COURSE_ID"].ToString(), "0"));
            // courses içinde seçilen derse göre dersin güncellemesi görülecektir.
            // Label1.Text = dr["COURSE_INSTRUCTOR"].ToString() + " added Assignment " +dr["ASSIGNMENT_NO"] + " in " + dr["COURSE_ID"].ToString();
            Label2.Text = dr["COURSE_INSTRUCTOR"].ToString() + " added grades in " + dr["COURSE_ID"];
            Label1.Text = dr["COURSE_INSTRUCTOR"].ToString() + " added " + dr["RESOURCE"] + " in " + dr["COURSE_ID"];
            
            BulletedList2.Items.Add(Label1.Text);
        }
        BulletedList2.Items.Add(Label2.Text);
        dr.Close();
        sqlConn.Close();
        
    }

        
    


}