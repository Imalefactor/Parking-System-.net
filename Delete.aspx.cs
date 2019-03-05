using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;


public partial class Delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = TextBox1.Text;
        string Conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Parking.accdb";
        string sqlstr = string.Format("DELETE * FROM 用户 where 用户='{0}'",username);
        OleDbConnection conn = new OleDbConnection(Conn);
        OleDbCommand cmd = new OleDbCommand();
        cmd.CommandText = sqlstr;
        cmd.Connection = conn;
        conn.Open();
        cmd.ExecuteNonQuery();
        Image1.Visible = false;
        Response.Write("<script>alert('删除成功！');</script>");
        conn.Close();
    }
}