using System;
using System.Collections.Generic;
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

        List<string> locations;  // buna ekle kurslari

        StringBuilder sb = new StringBuilder();

        sb.Append("<ul class=\"dropdown arrow - top\">");

        for (int i = 0; i < locations.Count; i++)
        {
            sb.Append("<li><a href= \"CoursePage.aspx\">" + "Deneme" + "</a></li>");
            // <li><a href="CoursePage.aspx"> SEN2022 </a></li>
            //session burda ayarlaman lazim
        }

        sb.Append("</ul>");

        litMarkup.Text = sb.ToString();
    }
}
