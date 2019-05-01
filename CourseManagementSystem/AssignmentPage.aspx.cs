using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class AssignmentPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // Response.Write(Session["userid"] + " " + Session["courses"]);
        //Session["COURSE_ID"]
        SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        sqlConn.Open();
         string query = "SELECT ASSIGNMENT_NO FROM ASSIGNMENTS WHERE COURSE_ID='" + Session["courses"] + "'";
       // string query = "SELECT ASSIGNMENT_NO FROM ASSIGNMENTS WHERE COURSE_ID='SEN2212'";
       // string query = "SELECT ASSIGNMENT_NO FROM ASSIGNMENTS WHERE COURSE_ID='SEN3006'";


        SqlCommand sqlCom = new SqlCommand(query, sqlConn);

        SqlDataReader dr;
        dr = sqlCom.ExecuteReader();
       
        while (dr.Read())
        {
         
            Label1.Text = "Assignment " +  dr["ASSIGNMENT_NO"].ToString() + " open";
            ListItem item = new ListItem(Label1.Text, "~/ContentAssignment.aspx"); // duzeltilecek
            BulletedList1.Items.Add(item);
        }
    
        dr.Close();

        sqlConn.Close();
    }
}







    

