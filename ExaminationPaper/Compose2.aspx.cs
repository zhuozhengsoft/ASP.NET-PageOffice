using System;
using System.Data.SQLite;
using System.Data;
using PageOffice.WordWriter;

public partial class ExaminationPaper_Compose2 : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        int num = 1;//试题编号
        if (Request.QueryString["ids"].Equals(null) || Request.QueryString["ids"].Equals(""))
        {
            return;
        }
        string idlist = Request.QueryString["ids"].Trim();
        string[] ids = idlist.Split(',');//将idlist按照","截取后存到ids数组中，然后遍历数组用js插入文件即可
        string strConn = "Data Source=" + Server.MapPath("/App_Data/ExaminationPaper.db");
        string strSql = "select * from stream ";

        SQLiteConnection conn = new SQLiteConnection(strConn);
        SQLiteCommand cmd = new SQLiteCommand(strSql, conn);
        conn.Open();
        cmd.CommandType = CommandType.Text;
        SQLiteDataReader reader = cmd.ExecuteReader();

        //int id = 0;//记录ID
        string temp = "PO_begin";//新添加的数据区域名称
        WordDocument doc = new WordDocument();      
          for (int i = 0; i < ids.Length; i++) { 
               DataRegion dataNum = doc.CreateDataRegion("PO_"+num,DataRegionInsertType.After, temp);
               dataNum.Value = num + ".\t";
               DataRegion dataReg = doc.CreateDataRegion("PO_begin" + (i+ 1), DataRegionInsertType.After, "PO_" + num);
               dataReg.Value = "[word]Openfile.aspx?id=" + ids[i] + "[/word]";
            num++;
            temp = "PO_begin" + (i + 1);
        }

        // 设置PageOffice组件服务页面
        PageOfficeCtrl1.SetWriter(doc);
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.Caption = "生成试卷";
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docReadOnly, "somebody");
    }
}
