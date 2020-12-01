using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class log_in : System.Web.UI.Page
{
    dboperation db = new dboperation();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from Login_page where User_Name='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "' ";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        { 
         string type=dt.Rows[0][3].ToString();
         if (type == "admin")
         {
             Response.Redirect("A_home.aspx");
         }
        
        }
        else
        {
            Response.Write("<script>alert('Incorrect User Name and Password')</script>");
        }
        
    }
}