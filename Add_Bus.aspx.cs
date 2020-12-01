using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Add_Bus : System.Web.UI.Page
{
    dboperation db = new dboperation();
    int id;
    protected void Page_Load(object sender, EventArgs e)
    {


        //modify form as approve or reject bus
        if (!IsPostBack)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select ID,Source,Destination from Root_info";
            DropDownList1.DataSource = db.getdata(cmd);
            DropDownList1.DataTextField = "Source";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "select");

            DropDownList2.DataSource = db.getdata(cmd);
            DropDownList2.DataTextField = "Destination";
            DropDownList2.DataValueField = "ID";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, "select");

           
            cmd.CommandText = "select * from Root_info";
            DropDownList3.DataSource = db.getdata(cmd);
            DropDownList3.DataTextField = "Name";
            DropDownList3.DataValueField = "ID";
            DropDownList3.DataBind();
            //cmd.CommandText = "select * from Ownerinfo";
            //DropDownList4.DataSource = db.getdata(cmd);
            //DropDownList4.DataTextField = "Name";
            //DropDownList4.DataTextField = "ID";
            //DropDownList4.DataBind();
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select max(ID) from Bus_info";
        id = db.max_id(cmd);
        string rid = DropDownList3.SelectedValue.ToString();
        

        cmd.CommandText = "insert into Bus_info values('" + id + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + DropDownList1.SelectedItem.Text + "','" + DropDownList2.SelectedItem.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','pending','0','" + rid + "')";
        db.execute(cmd);
        Response.Write("<script>alert('Bus Added')</script>");

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
    
        DropDownList1.SelectedIndex = -1;
        DropDownList2.SelectedIndex = -1;

    }
    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        
    }
    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}