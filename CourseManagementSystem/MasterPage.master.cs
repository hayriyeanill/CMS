using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
         string courses = Request.QueryString["courses"];
         Session["courses"] = courses;

        string userid = Request.QueryString["userid"];
        Session["userid"] = userid;

        StringBuilder menu = new StringBuilder();
        menu.Append("<a href=\"AssignmentPage.aspx?userid=" + Session["userid"] +"&courses=" + Session["courses"] + "\">Assigments</a><br/><br/>" +
                    "<a href=\"GradePage.aspx?userid=" + Session["userid"] + "&courses=" + Session["courses"] + "\">Grades</a><br/><br/>" +
                    "<a href=\"ResourcesPage.aspx?userid=" + Session["userid"] + "&courses=" + Session["courses"] + "\">Resources</a><br/><br/>");
        litMenu.Text = menu.ToString();
    }
}
