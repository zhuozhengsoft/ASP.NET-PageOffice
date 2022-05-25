using System;
using System.Data.SQLite;
using System.Data;

public partial class CreateWord_SaveNewFile : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        PageOffice.FileSaver fs = new PageOffice.FileSaver();
        string subject = fs.GetFormField("FileSubject");
        string newFileName = Insert(subject);//向数据库插入文件记录并获取返回的文件名 
        fs.SaveToFile(Server.MapPath("doc/") + newFileName);
        fs.Close();
    }
    /// <summary>
    /// 插入一条文件记录到数据库中
    /// </summary>
    string Insert(string subject)
    {
        string connectionString = "Data Source=" + Server.MapPath("/App_Data/CreateWord.db");
        string newID = "0";
        string strSql = "select Max(ID) from word";
        SQLiteConnection conn = new SQLiteConnection(connectionString);
        SQLiteCommand cmd = new SQLiteCommand(strSql, conn);
        conn.Open();
        cmd.CommandType = CommandType.Text;
        SQLiteDataReader Reader = cmd.ExecuteReader();
        if (Reader.Read() && Reader[0].ToString().Trim().Length > 0)
        {
            newID = (Convert.ToInt32(Reader[0]) + 1).ToString();
        }
        Reader.Close();
        string fileName = "aabb" + newID + ".doc";
        string strsql = "Insert into word(ID,FileName,Subject,SubmitTime) values(" + newID
            + ",'" + fileName + "','" + subject + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
        cmd.CommandText = strsql;
        cmd.ExecuteNonQuery();
        conn.Close();
        return fileName;
    }
}
