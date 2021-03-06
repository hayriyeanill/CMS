﻿using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContentAssignment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string asgNo = Request.QueryString["assignmentNo"];
        Session["assignmentNo"] = asgNo;
        // Response.Write(Session["assignmentNo"]);

        SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        string query = "SELECT CONTENT_A, ASSIGNMENT_NO FROM ASSIGNMENT where COURSE_ID='" + Session["courses"] + "' and ASSIGNMENT_NO='" + Session["assignmentNo"] + "'";

        SqlCommand sqlCom = new SqlCommand(query, sqlConn);
        SqlDataReader sdr;
        sqlConn.Open();

        sdr = sqlCom.ExecuteReader();

        StringBuilder content = new StringBuilder();

        while (sdr.Read())
        {
            lblAssignmentNo.Text = "Assignment: " + sdr["ASSIGNMENT_NO"];
            content.Append("<p>" + sdr["CONTENT_A"].ToString() + "</p>");
        }

        litContent.Text = content.ToString();
        sqlConn.Close();

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        string query = "insert into ANSWERS (COURSE_ID,ASSIGNMENT_NO, ANSWER) values (@c,@a,@ans)";
        SqlCommand sqlCom = new SqlCommand(query, sqlConn);

       sqlCom.Parameters.AddWithValue("@c", Session["courses"]);
       sqlCom.Parameters.AddWithValue("@a", Session["assignmentNo"]);
       sqlCom.Parameters.AddWithValue("@ans", txtAnswer.Text);

        sqlConn.Open();
        
        ltrlMessage.Text = "Successful";
        sqlCom.ExecuteNonQuery();
        sqlConn.Close();
    }



   
}
