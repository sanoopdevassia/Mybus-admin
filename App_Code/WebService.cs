using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {
    dboperation db = new dboperation();
    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

  
    


    [WebMethod]
    public string login(string Username, string Password)
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from Login_page where User_Name='"+Username+"' and Password='"+Password+"'";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow dr in dt.Rows)
            {
                s += dr[0].ToString() + "#" + dr[3].ToString() ;

            }
            //s = dt.Rows[0][0].ToString() + "#" + dt.Rows[0][3].ToString();
        }
        else
        {
            s = "error";
        }
        return s;
    }

    [WebMethod]
    public string OwnerReg(string nam,string phno,string email,string psswd,string gender)
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select max(ID) from Login_page";
        int i = db.max_id(cmd);
        cmd.CommandText = "insert into Ownerinfo values ("+i+",'"+nam+"','"+phno+"','"+gender+"','"+email+"','"+psswd+"','pending')";

        SqlCommand cmd1 = new SqlCommand();
        cmd1.CommandText = "insert into Login_page values(" + i + ",'" + email + "','" + psswd + "','owner')";
        try
        {
            db.execute(cmd);
            db.execute(cmd1);
            s = "success";
        }
        catch
        {
            s = "error";
        }
        return s;
    }
    [WebMethod]
    public string passengerreg(string nam, string phno, string emal, string pswd)
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select max(ID)from Login_page";
        int i = db.max_id(cmd);
        cmd.CommandText = "insert into Passenger_info values("+i+",'" + nam + "','" + phno + "','" + emal + "','" + pswd + "','pending')";
        SqlCommand cmd1= new SqlCommand();
        cmd1.CommandText = "insert into Login_page values(" + i + ",'" + emal + "','" + pswd + "','passenger')";
        try
        {
            db.execute(cmd);
            db.execute(cmd1);
            s = "success";
        }
        catch
        {
            s = "error";
        }
        return s;
    }


    [WebMethod]
    public string timesche(string sid, string busid, string time,string dir)
    {

        string s = "";
       

        char[] sp = new char[] { '-' };

        string[] stid = sid.Split(sp);

        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "insert into bus_schedule values(" + stid[0] + ",'" + busid + "','" + time + "','" + dir + "')";
        try
        {
            db.execute(cmd);
            s = "success";
        }
        catch
        {
            s = "error";
        }
        return s;
    }


    [WebMethod]
    public string Busstatus( string busno, string statusbx)
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "update Bus_info set  Status='" + statusbx + "' where Bus_Number='" + busno + "'";
        try
        {
            db.execute(cmd);
            s = "success";
        }
        catch
        {
            s = "error";
        }
        return s;
    }
    [WebMethod]
    public string ChangeDetails(string busno, string chngbsnm)
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "update Bus_info set Bus_Name='" + chngbsnm + "' where Bus_Number='" + busno + "'";
        try
        {
            db.execute(cmd);
            s = "success";
        }
        catch
        {
            s = "error";
        }
        return s;
    }

    //[WebMethod]
    //public string update(string chngbsnm, string busno)
    //{
    //    string s = "";
    //    SqlCommand cmd = new SqlCommand();
    //    cmd.CommandText = "update Bus_info set Status='" + statusbx + "' where id='" + busno + "'";
    //    try
    //    {
    //        db.execute(cmd);
    //        s = "success";
    //    }
    //    catch
    //    {
    //        s = "error";
    //    }
    //    return s;
    //}
    [WebMethod]
    public string searchbus(string src, string dest, string stpnm)
    {
        string s="";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from Bus_info where Source='" + src + "' and Destinstion='" + dest + "' and stop='" + stpnm + "'";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow dr in dt.Rows)
            {
                s += dr[1].ToString() + "#" + dr[2].ToString() + "#" + dr[5].ToString() + "#" + dr[6].ToString() + "#" + dr[7].ToString() +"@";

            }
        }
        else
        {
            s = "error";
        }
        return s;
    }
    [WebMethod]
    public string stop(string src, string dest)
    {
        string s="";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select * from Bus_info where source='" + src + "' and Destinstion='" + dest + "'";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow dr in dt.Rows)
            {
                s += dr[1].ToString() + "#" + dr[2].ToString() + "#" + dr[3].ToString() + "#" + dr[4].ToString() + "#" + dr[5].ToString() + "#" + dr[6].ToString() + "#" + dr[7].ToString() + "@";

            }
        }

        else
        {
            s = "error";
        }
        return s;
    }
    [WebMethod]
    public string businfo(string Bus_Name, string Bus_Number, string Source, string Dest,string Stp,string STime,string oid,string Route)
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select max(ID) from Bus_info";
        int i = db.max_id(cmd);
        cmd.CommandText = "insert into Bus_info values ("+i+",'" + Bus_Name  + "','" + Bus_Number + "','" + Source+ "','" +Dest + "','pending','pending','Available','"+oid+"','"+Route+"')";

        //SqlCommand cmd1 = new SqlCommand();
        //cmd1.CommandText = "insert into Bus_Schedule values (" + i + ",'" + Bus_Name + "','" + Bus_Number + "','" + Source + "','" + Dest + "','pending','pending','Available','" + oid + "','" + Route + "')";

        try
        {
            db.execute(cmd);
            s = "success";
        }
        catch
        {
            s = "error";
        }
        return s;
    }


    //[WebMethod]
    //public String statusinfo(String bid, String status)
    //{
    //    string s = "";
    //    SqlCommand cmd = new SqlCommand();
    //    cmd.CommandText = "select * from statusinfo where bus_id=" + bid + "";
    //    DataTable dt = db.getdata(cmd);
    //    if (dt.Rows.Count > 0)
    //    {
    //        cmd.CommandText = "update statusinfo set status='" + status + "' where  bus_id=" + bid + " ";
    //        db.execute(cmd);
    //        s = "success";
    //    }
    //    else
    //    {
    //        cmd.CommandText = "insert into statusinfo values('" + bid + "','" + status + "')";
    //        db.execute(cmd);
    //        s = "success";
    //    }
    //    return s;
    //}

    [WebMethod]
    public string slct_source()
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select distinct Source from Bus_info";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow dr in dt.Rows)
            {
                s += dr[0].ToString() +  "@";

            }
        }
        else
        {
            s = "error";
        }
        return s;
    }
    [WebMethod]
    public string slct_Destination()
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select distinct Destinstion from Bus_info";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow dr in dt.Rows)
            {
                s += dr[0].ToString() + "@";

            }
        }
        else
        {
            s = "error";
        }
        return s;
    }
    [WebMethod]
    public string slct_Stop(string busno)
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select Stop_no,Stop from Root_Schedule where Root_ID in(select Root_ID from Bus_info where bus_number='"+busno+"')";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow dr in dt.Rows)
            {
                s += dr[0].ToString() + "-" + dr[1].ToString() + "@";

            }
        }
        else
        {
            s = "error";
        }
        return s;
    }



    [WebMethod]
    public string Time(string busno, string bussp, string time)
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "update Bus_info set Time='" +time + "',Stop='"+bussp+"' where Bus_Number='" + busno + "'";
        try
        {
            db.execute(cmd);
            s = "success";
        }
        catch
        {
            s = "error";
        }
        return s;
    }
    [WebMethod]
    public string slct_busno()
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select distinct Bus_Number from Bus_info";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow dr in dt.Rows)
            {
                s += dr[0].ToString() + "@";

            }
        }
        else
        {
            s = "error";
        }
        return s;
    }

    [WebMethod]
    public string slct_busno_OW(string owid)
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select distinct Bus_Number from Bus_info where oid = '"+owid+"'";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow dr in dt.Rows)
            {
                s += dr[0].ToString() + "@";

            }
        }
        else
        {
            s = "error";
        }
        return s;
    }
    [WebMethod]
    public string slct_name()
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select ID,Name from Root_info";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow dr in dt.Rows)
            {
                s += dr[0].ToString() + "-" + dr[1].ToString()+"@";

            }
        }
        else
        {
            s = "error";
        }
        return "select"+"@"+s;
    }


    [WebMethod]
    public string slct_direction(string busno)
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select *  from Root_info where id =(select root_id from bus_info where bus_number='" + busno + "')";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            DataRow dr = dt.Rows[0];
            s = dr[1].ToString() + "#" + dr[2].ToString();

        }
        return s;
    }
    [WebMethod]
    public string slct_dire(string busno)
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select *  from Root_info where id ='" + busno + "'";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            DataRow dr = dt.Rows[0];
            s = dr[1].ToString() + "#" + dr[2].ToString();

        }
        return s;
    }



    [WebMethod]
    public string slct_stop(string ID)
    {
        string s = "";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "select Stop_no,Stop from Root_Schedule where Root_id="+ID+"";
        DataTable dt = db.getdata(cmd);
        if (dt.Rows.Count > 0)
        {
            foreach (DataRow dr in dt.Rows)
            {
                s += dr[0].ToString() + "-" + dr[1].ToString() + "@";

            }
        }
        else
        {
            s = "error";
        }
        return "select"+"@"+ s;
    }
    [WebMethod]
    public string search(string id,string rid,string dir)
    {
        string s = "";
        char[] spp = new char[] { '-' };

        string[] rname = id.Split(spp);

        SqlCommand cmd = new SqlCommand();
        if (id == "")
        {
          //  cmd.CommandText = "SELECT   Bus_info.Bus_Name, Bus_info.Status, Bus_Schedule.Time, Root_Schedule.Stop FROM    Bus_info INNER JOIN   Bus_Schedule ON Bus_info.Bus_Number = Bus_Schedule.Bus_id INNER JOIN  Root_Schedule ON Bus_Schedule.Stop_id = Root_Schedule.Stop_no where Bus_info.Root_ID=" + rid + "";
        }
        else
        {
            //cmd.CommandText = "SELECT   Bus_info.Bus_Name, Bus_info.Status, Bus_Schedule.Time, Root_Schedule.Stop FROM    Bus_info INNER JOIN   Bus_Schedule ON Bus_info.Bus_Number = Bus_Schedule.Bus_id INNER JOIN  Root_Schedule ON Bus_Schedule.Stop_id = Root_Schedule.Stop_no where Bus_Schedule.Stop_id=" + id + "";


            cmd.CommandText = "select id,bus_name,status,bus_number from bus_info where root_id=" + rid;
            DataTable dtbus = db.getdata(cmd);

            foreach (DataRow dr in dtbus.Rows)
            {

                cmd.CommandText = "select * from bus_schedule where stop_id=" + rname[0] +" and bus_id='"+ dr[3].ToString() +"' and direction='"+ dir +"'" ;
                DataTable shed = db.getdata(cmd);
                foreach (DataRow drr in shed.Rows)
                {
                    s = s + dr[1].ToString() + "@" + rname[1] + "@" + drr[2].ToString() + "@" + dr[2].ToString() + "#";
                }
            }





        }






        // DataTable dt = db.getdata(cmd);
        //if (dt.Rows.Count > 0)
        //{
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        s += dr[0].ToString() + "#" + dr[1].ToString() +"#" +dr[2].ToString() +"#"+dr[3].ToString()+"@";

        //    }
        //}
        //else
        //{
        //    s = "error";
        //}
        return s;
    }
    // [WebMethod]
    //public string dest()
    //{
    //    string s = "";
    //    SqlCommand cmd = new SqlCommand();
    //    cmd.CommandText = "select Destination from Root_info";
    //    DataTable dt = db.getdata(cmd);
    //    if (dt.Rows.Count > 0)
    //    {
    //        foreach (DataRow drr in dt.Rows)
    //        {
    //            s = s + drr[0].ToString() + "#";
    //        }
    //    }


    //    return s;


    //}

}
