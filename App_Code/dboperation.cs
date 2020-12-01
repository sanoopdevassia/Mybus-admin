using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for dboperation
/// </summary>
public class dboperation
{
    SqlConnection con = new SqlConnection(@"Data Source=.\MSSQLSERVER2012;AttachDbFilename=C:\inetpub\wwwroot\MyBus\App_Data\MyBus.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");



	public dboperation()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public void execute(SqlCommand cmd)
    {
        cmd.Connection = con;
        try
        {
            con.Open();
            cmd.ExecuteNonQuery();

        }
        catch (Exception e)
        {
            e.ToString();
        }
        finally
        {
            con.Close();
        }
    }
    public DataTable getdata(SqlCommand cmd)
    {
        cmd.Connection = con;
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds.Tables[0];
    }
    public int max_id(SqlCommand cmd)
    {
        cmd.Connection = con;
        int i;
        try
        {
            con.Open();
            i = Convert.ToInt32(cmd.ExecuteScalar()) + 1;


        }
        catch { i = 1;
        
        }
        con.Close();
        return i;
    }


}
