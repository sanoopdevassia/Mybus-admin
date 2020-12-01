using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Root : System.Web.UI.Page
 
{
    dboperation db=new dboperation();
    int id;
    protected void Page_Load(object sender, EventArgs e)
        
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select max(ID) from Root_info";
        id = db.max_id(cmd);
        cmd.CommandText = "insert into Root_info values('"+id+"','" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','"+TextBox4.Text+"')";
        db.execute(cmd);
        Response.Write("<script>alert('Root Added')</script>");
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";

    }
}