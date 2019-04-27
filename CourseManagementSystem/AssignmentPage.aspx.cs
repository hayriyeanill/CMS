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

        SqlConnection sqlConn = new SqlConnection(@"Data Source=(localdb)\CMS; Initial Catalog=CMS; integrated Security=True;");
        sqlConn.Open();
        string query = "SELECT ASSIGNMENT_NO FROM ASSIGNMENTS";


        SqlCommand sqlCom = new SqlCommand(query, sqlConn);

        SqlDataReader dr;
        dr = sqlCom.ExecuteReader();
        while (dr.Read())
        {
           
            Label1.Text = "Assignment " +  dr["ASSIGNMENT_NO"].ToString() + " open";
            BulletedList1.Items.Add(Label1.Text);
            
           
            

            

        }

        dr.Close();

        sqlConn.Close();
    }
}







    

