﻿using System;
using System.Text;
using System.Data.SQLite;
using System.Data;

public partial class SaveAndSearch_FileManage : System.Web.UI.Page
{
    protected string strHtmls = "";
  
    protected void Page_Load(object sender, EventArgs e)
    {
        #region 显示文件列表
        string strSql = "select * from word order by ID desc ";
        GetFileList(strSql, "");
        #endregion
    }
    /// <summary>
    /// 搜索文档
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string key = "";
        if (Request.Form["Input_KeyWord"] != null && Request.Form["Input_KeyWord"].ToString().Trim().Length > 0)
        {
            key = Request.Form["Input_KeyWord"].ToString().Trim();
        }
        else
        {
            Response.Write("<script>alert('请先输入关键字');</script>");
            return;
        }
        string strSql = "select * from word  where Content like '%" + key + "%' order by ID desc";
        GetFileList(strSql,key);
    }

    /// <summary>
    /// 获得文件列表
    /// </summary>
    /// <param name="strSql">sql语句</param>
    private void GetFileList(string strSql, string strKey)
    {
        string connectionString = "Data Source=" + Server.MapPath("/App_Data/SaveAndSearch.db");
        StringBuilder strHtml = new StringBuilder();
        DataSet ds = new DataSet();
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
        {
            try
            {
                connection.Open();
                SQLiteDataAdapter command = new SQLiteDataAdapter(strSql, connection);
                command.Fill(ds, "ds");
                connection.Close();
            }
            catch (System.Data.SQLite.SQLiteException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        if (ds != null && ds.Tables[0].Rows.Count > 0)
        {
            DataTable dt = ds.Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strHtml.Append("<tr onmouseover='onColor(this)' onmouseout='offColor(this)'>\n");
                strHtml.Append("<td>" + dt.Rows[i]["FileName"] + "</td>\n");
                strHtml.Append("<td style='text-align:center;'><a style=' color:#00217d;' href='javascript:POBrowser.openWindowModeless(\"Edit.aspx?ID=" + dt.Rows[i]["ID"] +"\",\"width=1200px;height=800px;\",\"" + Server.UrlEncode(strKey) + "\");' >编辑</a></td>\n");
                strHtml.Append(" </tr>\n");
            }
        }
        else
        {
            strHtml.Append("<tr>\r\n");
            strHtml.Append("<td colspan='2' style='width:100%; text-align:center;'>对不起，没有搜索到相应的数据。\r\n");
            strHtml.Append("</td></tr>\r\n");
        }
        strHtmls = strHtml.ToString();
    }
}
