using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContentAssignment : System.Web.UI.Page
{
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        txtCourse.Text = ddlCourse.SelectedItem.Text;
        txtCourse.Enabled = false;
    }
    protected void btnAdd2_Click(object sender, EventArgs e)
    {
        txtAssignment.Text = ddlAssignment.SelectedItem.Text;
        txtAssignment.Enabled = false;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        //sqlConn.Open();
        //string query = "SELECT COURSE_ID,ASSIGNMENT_NO,CONTENT FROM ASSIGNMENTS where course_id=@courseid and assignment_no=@assignmentno";
        // SqlCommand sqlCom = new SqlCommand(query, sqlConn);
        //sqlCom.Parameters.AddWithValue("@courseid", txtCourse.Text.Trim());
        //sqlCom.Parameters.AddWithValue("@assignmentno", txtAssignment.Text.Trim());
        //int count = Convert.ToInt32(sqlCom.ExecuteScalar());
        
        //SqlDataReader dr;
        //dr = sqlCom.ExecuteReader();
        //while (dr.Read())
        //{

        //    lblContent.Text = dr["CONTENT"].ToString(); 

        //}
        //dr.Close();
        //sqlConn.Close();
        //sqlConn.Close();

    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        string query = "insert into ANSWERS (COURSE_ID,ASSIGNMENT_NO, ANSWER) values (@c,@a,@ans)";
        SqlCommand sqlCom = new SqlCommand(query, sqlConn);

        sqlCom.Parameters.AddWithValue("@c", txtCourse.Text);
        sqlCom.Parameters.AddWithValue("@a", txtAssignment.Text);
        sqlCom.Parameters.AddWithValue("@ans", txtAnswer.Text);

        sqlConn.Open();
        
        ltrlMessage.Text = "Succesfull";
        sqlCom.ExecuteNonQuery();
        sqlConn.Close();
    }
}
