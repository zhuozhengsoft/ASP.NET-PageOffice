using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SQLite;
using System.Data;

public partial class Openstream : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string docID = Request.QueryString["id"];
        string connstring = "Data Source=" + Server.MapPath("/App_Data/DataBase.db");
        SQLiteConnection conn = new SQLiteConnection(connstring);
        conn.Open();
        string sql = "select Word,ID from stream where ID=" + docID;
        SQLiteCommand cmd = new SQLiteCommand(sql, conn);

        cmd.CommandType = CommandType.Text;
        SQLiteDataReader reader;

        reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            long num = reader.GetBytes(0, 0, null, 0, Int32.MaxValue);
            Byte[] b = new Byte[num];
            reader.GetBytes(0, 0, b, 0, b.Length);
            Response.ContentType = "Application/msword"; //其他文件格式换成相应类型即可 application/x-excel, application/ms-powerpoint, application/pdf 
            Response.AddHeader("Content-Disposition", "attachment; filename=down.doc");//其他文件格式换成相应类型的filename
            Response.AddHeader("Content-Length", num.ToString());
            this.Response.Clear();
            System.IO.Stream fs = this.Response.OutputStream;
            fs.Write(b, 0, b.Length);
            fs.Close();

        }
        reader.Close();
        conn.Close();
        Response.Flush();
        Response.End();
    }
}
