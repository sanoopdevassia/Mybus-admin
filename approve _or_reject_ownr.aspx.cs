using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class approve__or_reject_ownr : System.Web.UI.Page
{
    dboperation db = new dboperation();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MultiView1.SetActiveView(View1);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Ownerinfo";
            DataGrid1.DataSource = db.getdata(cmd);
            DataGrid1.DataBind();
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from ownerinfo where ID='" + TextBox1.Text + "'";
       
        db.execute(cmd);

        Response.Write("<script>alert('Rejected')</script>");

        MultiView1.SetActiveView(View1);

        cmd.CommandText = "select * from Ownerinfo";
        DataGrid1.DataSource = db.getdata(cmd);
        DataGrid1.DataBind();
    }
    protected void DataGrid1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        TextBox1.Text = e.Item.Cells[0].Text;
        TextBox2.Text = e.Item.Cells[1].Text;
        TextBox3.Text = e.Item.Cells[2].Text;
        TextBox4.Text = e.Item.Cells[3].Text;
        TextBox5.Text = e.Item.Cells[4].Text;
        TextBox6.Text = e.Item.Cells[6].Text;
        MultiView1.SetActiveView(View2);



    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "update Ownerinfo set Status='Accept' where ID='"+TextBox1.Text+"'";
        db.execute(cmd);

        Response.Write("<script>alert('Accept')</script>");

        MultiView1.SetActiveView(View1);
        
        cmd.CommandText = "select * from Ownerinfo";
        DataGrid1.DataSource = db.getdata(cmd);
        DataGrid1.DataBind();
    }
}