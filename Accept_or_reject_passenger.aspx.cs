using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Accept_or_reject_passenger : System.Web.UI.Page
{
    dboperation db = new dboperation();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from passenger_info where status='pending'";
            DataGrid1.DataSource = db.getdata(cmd);
            DataGrid1.DataBind();


            MultiView1.SetActiveView(View1);
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText= "update Passenger_info set status='Approved' where ID='"+Label1.Text+"'";
        db.execute(cmd);
        cmd.CommandText = "select * from passenger_info where status='pending'";
        DataGrid1.DataSource = db.getdata(cmd);
        DataGrid1.DataBind();
        
    }
    protected void DataGrid1_ItemCommand(object source, DataGridCommandEventArgs e)
    {
        TextBox1.Text = e.Item.Cells[0].Text;
        TextBox2.Text = e.Item.Cells[1].Text;
        TextBox3.Text = e.Item.Cells[2].Text;
        Label1.Text = e.Item.Cells[3].Text;
        MultiView1.SetActiveView(View2);

    }
    protected void DataGrid1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "delete from Passenger_info where ID='" + Label1.Text + "'";
        db.execute(cmd);
        cmd.CommandText = "select * from passenger_info where status='pending'";
        DataGrid1.DataSource = db.getdata(cmd);
        DataGrid1.DataBind();
        
    }
}