using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int i = 0;
        String str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Parking.accdb";
        OleDbConnection conn = new OleDbConnection(str);//str是连接字符串
        OleDbCommand cmd = new OleDbCommand();
        cmd.Connection = conn;
        string user = TextBox1.Text.Trim();
        string username = TextBox2.Text.Trim();
        string password = TextBox3.Text.Trim();
        String sqlstr = string.Format("insert into 用户(用户,用户名,密码) values('{0}','{1}','{2}')",user, username, password);
        //String insstr = string.Format("insert into 车位(车位号,用户,用户名) values('{0}','{1}','{2}')",i, user, username);
        cmd.CommandText = sqlstr;   //sqlstr是查询字符串（insert into语句）
        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            Response.Write(@"<script language='javascript'>alert('注册成功！');</script>");
            Image1.Visible = true;
            conn.Close();
        }
        catch (Exception ex)
        {
            Image2.Visible = true;
            Response.Write(@"<script language='javascript'>alert('注册失败！');</script>");

        }
    }
}