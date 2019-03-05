using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class information : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String Conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|Parking.accdb";
        OleDbConnection conn = new OleDbConnection(Conn);
        conn.Open();
        OleDbCommand comm = conn.CreateCommand();
        string sqlstr = string.Format("SELECT * FROM 车位");
        comm.CommandText = sqlstr;
        OleDbDataReader reader = comm.ExecuteReader();
        Label2.Text = "<table class=table cellspacing=0 align=center>";   //表格标记class=table width=100%  border=1

        while (reader.Read())
        {
            Label2.Text = Label2.Text + "<tr>";
            Label2.Text = Label2.Text + "<td>" + "车位号：" + reader["车位号"].ToString() + "</td>";
            Label2.Text = Label2.Text + "<td>" + "用户：" + reader["用户"].ToString() + "</td>";
            Label2.Text = Label2.Text + "<td>" + "车辆：" + reader["车辆"].ToString() + "</td>";
            Label2.Text = Label2.Text + "<td>" + "车牌：" + reader["车牌"].ToString() + "</td>";
            Label2.Text = Label2.Text + "<td>" + "停车时间：" + reader["停车时间"].ToString() + "</td>";
            Label2.Text = Label2.Text + "<td>" + "用户名：" + reader["用户名"].ToString() + "</td>";
            Label2.Text = Label2.Text + "</tr>";
            Label2.Text = Label2.Text + "</br>";
        }
        Label2.Text = Label2.Text + "</table>";
        conn.Close();
    }
    
}