using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ServervariablesEx1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["S"] == null)
                Session["S"] = 1;
            else
                Session["S"] = (int)Session["S"] + 1;
            if (Application["A"] == null)
                Application["A"] = 1;
            else
                Application["A"] = (int)Application["A"] + 1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Session["S"].ToString();
            TextBox2.Text = Application["A"].ToString();
        }
    }
}