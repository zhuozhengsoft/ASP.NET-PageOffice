using System;
using System.Data.SQLite;
using System.Data;

public partial class SaveAndSearch_SaveFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //定义FileSaver对象
        PageOffice.FileSaver fs = new PageOffice.FileSaver();
        if (Request.QueryString["id"] != null && Request.QueryString["id"].ToString().Trim().Length > 0)
        {
            string id = Request.QueryString["id"].ToString().Trim();
            string content = fs.DocumentText;
            string strConn = "Data Source=" + Server.MapPath("/App_Data/SaveAndSearch.db");
            string sql = " update word set Content = '" + content + "' where id= " + id;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

            //将文档内容保存到本地磁盘的Word文档中，fs.FileName指代Edit.aspx.cs页面中打开的Word文件名
            fs.SaveToFile(Server.MapPath("doc/") + fs.FileName);
            //设置保存返回值
            fs.CustomSaveResult = "ok";
        }
        else
        {
            //设置保存返回值
            fs.CustomSaveResult = "未获得文档编号ID";
        }
        //关闭FileSaver对象
        fs.Close();
    }
}
