using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication1
{
    public partial class LoginChild1 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from tbl_Emp where Empid=@Eid and Password=@pwd", con);
            adp.SelectCommand.Parameters.AddWithValue("@Eid", txteid.Text);
            adp.SelectCommand.Parameters.AddWithValue("@pwd", txtpwd.Text);
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            string name = "";
            string type = "";
            if(ds.Tables["E"].Rows.Count==1)
            {
                name = ds.Tables["E"].Rows[0][1].ToString();
                type = ds.Tables["E"].Rows[0][3].ToString();
            }
            if (type == "Admin")
            {
                Response.Cookies["name"].Value = name;
                Response.Redirect("Admin.aspx");
            }

            else
            {
                Response.Cookies["name"].Value = name;
                Response.Redirect("Associate.aspx");
            }
        }
    }
}