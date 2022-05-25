using System;
using System.Data.SQLite;
public partial class Savedoc : System.Web.UI.Page
{
    protected string strErrHtml = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        // 在此处放置用户代码以初始化页面
        PageOffice.FileSaver fs = new PageOffice.FileSaver();

        string sID = Request.QueryString["id"];
        string connstring = "Data Source=" + Server.MapPath("/App_Data/DataBase.db");
        byte[] aa = fs.FileBytes;

        string sql = "UPDATE  Stream SET Word=@file WHERE ID=" + sID;

        using (SQLiteConnection conn = new SQLiteConnection(connstring))
        {
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
            {
                SQLiteParameter parameter = new SQLiteParameter("@file", System.Data.DbType.Binary);
                parameter.Value = aa;
                cmd.Parameters.Add(parameter);
                cmd.ExecuteNonQuery();
            }

        }

        fs.Close();
    }
}
