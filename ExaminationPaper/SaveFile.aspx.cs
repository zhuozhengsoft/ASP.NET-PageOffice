using System;
using System.Data.SQLite;
using System.Data;

public partial class ExaminationPaper_SaveFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOffice.FileSaver fs = new PageOffice.FileSaver();
        string id = Request.QueryString["id"];
        if (id != null && id.Length > 0)
        {
            string strConn = "Data Source=" + Server.MapPath("/App_Data/ExaminationPaper.db");
            SQLiteConnection conn = new SQLiteConnection(strConn);
            byte[] aa = fs.FileBytes;
            SQLiteCommand cm = new SQLiteCommand();
            cm.Connection = conn;
            cm.CommandType = CommandType.Text;
            if (conn.State == 0) conn.Open();
            cm.CommandText = "UPDATE  Stream SET Word=@file WHERE ID=" + id;
            SQLiteParameter spFile = new SQLiteParameter("@file", System.Data.DbType.Binary);
            spFile.Value = aa;
            cm.Parameters.Add(spFile);
            cm.ExecuteNonQuery();
            conn.Close();

            //向客户端控件返回以上代码执行成功的消息。
            fs.CustomSaveResult = "ok";
        }
        else
        {
            Response.Write("<script>alert('未获得文件的ID，保存失败！');location.href='Default.aspx'</script>");
        }
        fs.Close();
    }
}
