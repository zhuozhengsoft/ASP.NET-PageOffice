using System;
using System.Data;
using System.Data.SQLite;
using System.Text;

public partial class CreateWord_word_lists : System.Web.UI.Page
{
    string strSql = "";
    string newID = "1";
    string fileName = "";//磁盘上的文件名
    string FileSubject = "";//文件主题
    protected string strHtmls = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string connectionString = "Data Source=" + Server.MapPath("/App_Data/CreateWord.db");
        #region 显示文件列表
        string strSql = "select * from word order by ID desc ";

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
            StringBuilder strHtml = new StringBuilder();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                strHtml.Append("<tr onmouseover='onColor(this)' onmouseout='offColor(this)'>\n");
                strHtml.Append("<td><a href =\"javascript:POBrowser.openWindowModeless('OpenWord.aspx?filename=" + Server.UrlEncode(Server.UrlEncode( dt.Rows[i]["FileName"].ToString()))+ "&subject=" + Server.UrlEncode(Server.UrlEncode(dt.Rows[i]["Subject"].ToString()))+"','width=1200px;height=800px;');\">" + dt.Rows[i]["Subject"] + "</a></td>\n");
                if (dt.Rows[i]["SubmitTime"] != null && dt.Rows[i]["SubmitTime"].ToString().Trim().Length > 0)
                {
                    strHtml.Append("<td>" + DateTime.Parse(dt.Rows[i]["SubmitTime"].ToString()).ToString("yyyy-MM-dd") + "</td>\n");
                }
                else
                {
                    strHtml.Append("<td>&nbsp;</td>\n");
                }
                strHtml.Append(" </tr>\n");
            }

            strHtmls = strHtml.ToString();
        }
        #endregion

    }

    


    /// <summary>
    /// 插入一条文件记录到数据库中
    /// </summary>
    void Insert()
    {
        string connectionString = "Data Source=" + Server.MapPath("/App_Data/CreateWord.db");
        strSql = "select Max(ID) from word";
        SQLiteConnection conn = new SQLiteConnection(connectionString);
        SQLiteCommand cmd = new SQLiteCommand(strSql, conn);
        conn.Open();
        cmd.CommandType = CommandType.Text;
        SQLiteDataReader Reader = cmd.ExecuteReader();
        if (Reader.Read() && Reader[0].ToString().Trim().Length > 0)
        {
            newID = ((int)Reader[0] + 1).ToString();
        }
        Reader.Close();

        fileName = "aabb" + newID + ".doc";
        FileSubject = "请输入文档主题";
        if (Request.Form["FileSubject"] != "")
            FileSubject = Request.Form["FileSubject"];
        string strsql = "Insert into word(ID,FileName,Subject,SubmitTime) values(" + newID
            + ",'" + fileName + "','" + FileSubject + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
        cmd.CommandText = strsql;
        cmd.ExecuteNonQuery();
        conn.Close();
    }
}
