using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Addtime_admin : System.Web.UI.Page
{
    dboperation db = new dboperation();
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        if (!IsPostBack)
        {
            cmd.CommandText = "select ID,Bus_Number from Bus_info where Status='pending'";
            DropDownList1.DataSource = db.getdata(cmd);
            DropDownList1.DataTextField = "Bus_Number";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0,"Select");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into Bus_Schedule values(" + DropDownList2.SelectedValue + ",'" + DropDownList1.SelectedItem.Text + "','" + TextBox1.Text + "','pending')";
        db.execute(cmd);
        TextBox1.Text = "";

        Response.Write("<script>alert('Time Saved')</script>");
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "select Root_ID from Bus_info where ID=" + DropDownList1.SelectedValue;
        DataTable dt = db.getdata(cmd);

        if (dt.Rows.Count > 0)
        {
            cmd.CommandText = "select Stop,Stop_no from Root_Schedule where Root_id=" + dt.Rows[0][0].ToString(); ;
            DropDownList2.DataSource = db.getdata(cmd);
            DropDownList2.DataTextField = "Stop";
            DropDownList2.DataValueField = "Stop_no";
            DropDownList2.DataBind();
        }
    }
}