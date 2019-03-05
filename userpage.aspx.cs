using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class userpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string str = Request.QueryString["user"];
            Label1.Text = str + "您好，欢迎使用自助停车系统！";
            Label2.Text = "";

        }
        string ID = Request.QueryString["id"];
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        
        string ID = Request.QueryString["id"];
        String Conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Parking.accdb";
        OleDbConnection conn = new OleDbConnection(Conn);
        conn.Open();
        OleDbCommand comm = conn.CreateCommand();
        string sqlstr = string.Format("SELECT 车位号 FROM 车位 WHERE 用户名='{0}'", ID);
        //string insstr = string.Format("UPDATE 车位 SET 车位 = '{0}' WHERE 用户名='{1}'", i, ID);
        comm.CommandText = sqlstr;
        OleDbDataReader reader = comm.ExecuteReader();
        
        while(reader.Read())
        {
            int i = 4;
            string S1 = reader["车位号"].ToString();
            int S2 = Convert.ToInt32(S1);
            if (S2 != 0)
            {
                
                Image1.Visible = true;
                Page.RegisterStartupScript("msg", "<script>alert('您的车已在车库中！请点击自助取车！！')</script>");
                //Response.Write("<script>alert('您的车已在车库中！请点击自助取车！！');</script>");
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "提示", "alert('您的车已在车库中！请点击自助取车！')", true);
            }
            if(S2 == 0)
            {

                Conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Parking.accdb";
                conn = new OleDbConnection(Conn);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string insstr = string.Format("UPDATE 车位 SET 车位号 = '{0}' WHERE 用户名='{1}'" , i, ID);
                cmd.CommandText = insstr;
                try
                {
                    Label2.Text = "停车成功！";
                    Image1.Visible = true;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Page.RegisterStartupScript("msg", "<script>alert('停车成功！您的车位在'S2'车位！')</script>");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Image1.Visible = false;
                    Page.RegisterStartupScript("msg", "<script>alert('停车失败！')</script>");
                }

                //Response.Write("<script>alert('停车成功！您的车位在'S2'车位！');</script>");
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "提示", "alert('停车成功！您的车位在''')", true);
                }
            i++;
        }
        conn.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string ID = Request.QueryString["id"];
        String Conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Parking.accdb";
        OleDbConnection conn = new OleDbConnection(Conn);
        conn.Open();
        OleDbCommand comm = conn.CreateCommand();
        string sqlstr = string.Format("SELECT 车位号 FROM 车位 WHERE 用户名='{0}'", ID);
        //string insstr = string.Format("UPDATE 车位 SET 车位 = '{0}' WHERE 用户名='{1}'", i, ID);
        comm.CommandText = sqlstr;
        OleDbDataReader reader = comm.ExecuteReader();
        while (reader.Read())
        {
            string S5 = reader["车位号"].ToString();
            int S6 = Convert.ToInt32(S5);
            if (S6 != 0)
            {
                Label2.Text = "您的车停在" + S6 + "车位！";
            }
            else
            {
                Label2.Text = "您的车还不在任何车位！";
            }
            //Page.RegisterStartupScript("msg", "<script>alert('您的停在'S6'车位！')</script>");
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        string ID = Request.QueryString["id"];
        String Conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Parking.accdb";
        OleDbConnection conn = new OleDbConnection(Conn);
        conn.Open();
        OleDbCommand comm = conn.CreateCommand();
        string sqlstr = string.Format("SELECT 车位号 FROM 车位 WHERE 用户名='{0}'", ID);
        comm.CommandText = sqlstr;
        OleDbDataReader reader = comm.ExecuteReader();
        while (reader.Read())
        {
            string S3 = reader["车位号"].ToString();
            int S4 = Convert.ToInt32(S3);
            if (S4 != 0)
            {
                Conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Parking.accdb";
                conn = new OleDbConnection(Conn);
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                string insstr = string.Format("UPDATE 车位 SET 车位号 = '0' WHERE 用户名='{0}'",ID);
                cmd.CommandText = insstr;
                try
                {
                    Label2.Text = "取车成功！";
                    Image1.Visible = false;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('取车成功！');</script>");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Page.RegisterStartupScript("msg", "<script>alert('取车失败！')</script>");
                }
                //Page.RegisterStartupScript("msg", "<script>alert('取车成功！您的停在'S3'车位')</script>");
                //Response.Write("<script>alert('取车成功！您的停在'S3'车位！');</script>");
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "提示", "alert('取车成功！您的停在'S3'车位！')", true);

            }
            if (S4 == 0)
            {
                Image1.Visible = false;
                Page.RegisterStartupScript("msg", "<script>alert('您还没有车停在任何车位！')</script>");
                //Response.Write("<script>alert('您还没有车停在任何车位！');</script>");
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "提示", "alert('您还没有车停在任何车位！')", true);
            }
        }
        conn.Close();
    }
}