using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;
using System.Data;
using System.Text;

public partial class ExaminationPaper_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strConn = "Data Source=" + Server.MapPath("/App_Data/ExaminationPaper.db");
        string strSql = "select * from stream ";
        StringBuilder strHtmls = new StringBuilder();

        SQLiteConnection conn = new SQLiteConnection(strConn);
        SQLiteCommand cmd = new SQLiteCommand(strSql, conn);
        conn.Open();
        cmd.CommandType = CommandType.Text;
        SQLiteDataReader Reader = cmd.ExecuteReader();

        strHtmls.Append("<tr  style='background-color:#FEE;'>");
        strHtmls.Append("<td width='10%' >选择</td>");
        strHtmls.Append("<td width='30%' >题库编号</td>");
        strHtmls.Append("<td width='60%' >操作</td>");
        strHtmls.Append("</tr>");
        if (Reader.Read())
        {
            string pID = Reader["ID"].ToString().Trim();
            strHtmls.Append("<tr  style='background-color:white;'>");
            strHtmls.Append("<td><input id='check" + pID + "'  type='checkbox' /></td>");
            strHtmls.Append("<td>选择题-" + pID + "</td>");
            strHtmls.Append("<td><a href='javascript:POBrowser.openWindowModeless(\"Edit.aspx?id=" + pID + "\" ,\"width=1200px;height=800px;\");'>编辑</a></td>");
            strHtmls.Append("</tr>");
            while (Reader.Read())
            {
                pID = Reader["ID"].ToString().Trim();
                strHtmls.Append("<tr  style='background-color:white;'>");
                strHtmls.Append("<td><input id='check" + pID + "'  type='checkbox' /></td>");
                strHtmls.Append("<td>选择题-" + pID + "</td>");
                strHtmls.Append("<td><a href='javascript:POBrowser.openWindowModeless(\"Edit.aspx?id=" + pID + "\" ,\"width=1200px;height=800px;\");'>编辑</a></td>");
                strHtmls.Append("</tr>");
            }
        }
        else
        {
            strHtmls.Append("<tr>\r\n");
            strHtmls.Append("<td colspan='3' width='100%' height='100' align='center'>对不起，暂时没有可以操作的数据。\r\n");
            strHtmls.Append("</td></tr>\r\n");
        }
        LiteralGrid.Text = strHtmls.ToString();
        Reader.Close();
        conn.Close();
    }
}
