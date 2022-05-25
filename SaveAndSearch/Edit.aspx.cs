using System;
using System.Data.SQLite;
using System.Data;

public partial class SaveAndSearch_Edit : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    public string strKey = "";
    protected void Page_Load(object sender, EventArgs e)
    {
    PageOfficeCtrl1.ServerPage = Request.ApplicationPath+"poserver.aspx"; //设置服务器页面
        if (Request.QueryString["id"] != null && Request.QueryString["id"].ToString().Trim().Length > 0)
        {
            //strKey = Request.QueryString["key"].ToString().Trim();
            string id = Request.QueryString["id"].ToString().Trim();
            string strConn = "Data Source=" + Server.MapPath("/App_Data/SaveAndSearch.db");
            string sql = " select * from word where id= " + id;
            SQLiteConnection conn = new SQLiteConnection(strConn);
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            conn.Open();
            cmd.CommandType = CommandType.Text;
            SQLiteDataReader Reader = cmd.ExecuteReader();
            if (Reader.Read())
            {
                string fileName = "";
                if (Reader["FileName"] != null && Reader["FileName"].ToString().Length > 0)
                {
                    fileName = Reader["FileName"].ToString().Trim() + ".doc";
                }
                else
                {
                  Response.Write("<script>alert('未获得文件名');</script>");
                    return;
                }

                //添加自定义工具栏按钮
                PageOfficeCtrl1.AddCustomToolButton("保存", "Save()", 1);
                //设置保存页面
                PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx?id=" + id;
                //打开Word文档
                PageOfficeCtrl1.WebOpen(Server.MapPath("doc/") + fileName, PageOffice.OpenModeType.docNormalEdit, "张佚名");
            }
            conn.Close();
        }
        else
        {
            Response.Write("< script>alert('未获得文档的编号');</script>");
            return;
        }
    }
}
