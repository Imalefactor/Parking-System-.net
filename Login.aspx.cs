using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Application.Lock();
        Application["PageClick"] = (int)Application["PageClick"] + 1;
        Application.UnLock();
        string s1 = string.Format("页面单击数：{0}<br/>", Application["PageClick"]);
        string s2 = string.Format("用户访问数：{0}<br/>", Application["UserVisit"]);
        Label1.Text = s1;
        Label2.Text = s2;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = Request["username"];
        string password = Request["password"];
        string str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Parking.accdb";
        String sqlstr = string.Format("select 用户 from 用户 where 用户名='{0}' and 密码='{1}'", username, password);
        OleDbConnection conn = new OleDbConnection(str);
        OleDbDataAdapter oda = new OleDbDataAdapter(sqlstr, conn);
        DataTable dt = new DataTable();
        oda.Fill(dt);
        if (dt.Rows.Count != 0)
        {
            Response.Redirect("userpage.aspx?user=" + dt.Rows[0][0].ToString() + "&id=" + username);
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "提示", "alert('用户名或密码错误！')", true);
        }
        if (username == "baixiongru" && password == "bxr1996")
        {
            Response.Redirect("~/admin.aspx");
        }
    }
}
