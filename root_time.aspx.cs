using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Default4 : System.Web.UI.Page

{
    dboperation db = new dboperation();
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Root_info";
            DataTable dt = db.getdata(cmd); ;
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
      
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select max(Stop_no) from Root_Schedule";
        id = db.max_id(cmd);
        string rid = DropDownList1.SelectedValue.ToString();
        cmd.CommandText = "insert into Root_Schedule values('" + id + "','" + rid + "','" + TextBox1.Text + "')";
        db.execute(cmd);

}
    }