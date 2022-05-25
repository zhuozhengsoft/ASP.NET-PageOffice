using System;
using System.Data.SQLite;
using System.Data;
using PageOffice.WordWriter;

public partial class WordSalaryBill_Compose : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["ids"] == null || Request.QueryString["ids"] == "")
        {
            return;
        }
        string idlist = Request.QueryString["ids"].Trim();
        //从数据库中读取数据
        string strConn = "Data Source=" + Server.MapPath("/App_Data/WordSalaryBill.db");
        string strSql = "select * from Salary where ID in(" + idlist + ") order by ID";
        SQLiteConnection conn = new SQLiteConnection(strConn);
        SQLiteDataAdapter cmd = new SQLiteDataAdapter(strSql, conn);
        DataSet ds = new DataSet();
        conn.Open();
        cmd.Fill(ds, "ds");

        WordDocument doc = new WordDocument();
        if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count > 0)
        {
            DataTable dt = ds.Tables[0];
            DataRegion[] data = new DataRegion[ds.Tables[0].Rows.Count];
            PageOffice.WordWriter.Table[] table = new PageOffice.WordWriter.Table[ds.Tables[0].Rows.Count];
           for (int i = 0; i < dt.Rows.Count; i++)
            {
                data[i] = doc.CreateDataRegion("reg" + i.ToString(), DataRegionInsertType.Before, "[End]");
                data[i].Value = "[word]doc/template.doc[/word]";

                table[i] = data[i].OpenTable(1);
                table[i].OpenCellRC(2, 1).Value = dt.Rows[i]["ID"].ToString();

                //给单元格赋值
                table[i].OpenCellRC(2, 2).Value = dt.Rows[i]["UserName"].ToString();
                table[i].OpenCellRC(2, 3).Value = dt.Rows[i]["DeptName"].ToString();
                decimal result = 0;
                DateTime date = DateTime.Now;
                if (dt.Rows[i]["SalTotal"] != null && decimal.TryParse(dt.Rows[i]["SalTotal"].ToString(), out result))
                {
                    table[i].OpenCellRC(2, 4).Value = decimal.Parse(dt.Rows[i]["SalTotal"].ToString()).ToString("c");
                }
                else
                {
                    table[i].OpenCellRC(2, 4).Value = "￥0.00";
                }

                if (dt.Rows[i]["SalDeduct"] != null && decimal.TryParse(dt.Rows[i]["SalDeduct"].ToString(), out result))
                {
                    table[i].OpenCellRC(2, 5).Value = int.Parse(dt.Rows[i]["SalDeduct"].ToString()).ToString("c");
                }
                else
                {
                    table[i].OpenCellRC(2, 5).Value = "￥0.00";
                }

                if (dt.Rows[i]["SalCount"] != null && decimal.TryParse(dt.Rows[i]["SalCount"].ToString(), out result))
                {
                    table[i].OpenCellRC(2, 6).Value = int.Parse(dt.Rows[i]["SalCount"].ToString()).ToString("c");
                }
                else
                {
                    table[i].OpenCellRC(2, 6).Value = "￥0.00";
                }

                if (dt.Rows[i]["DataTime"] != null && DateTime.TryParse(dt.Rows[i]["DataTime"].ToString(), out date))
                {
                    table[i].OpenCellRC(2, 7).Value = DateTime.Parse(dt.Rows[i]["DataTime"].ToString()).ToString("yyyy-MM-dd");
                }
                else
                {
                    table[i].OpenCellRC(2, 7).Value = "";
                }
            }
        }
        conn.Close();

        // 设置PageOffice组件服务页面
        PageOfficeCtrl1.SetWriter(doc);
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.Caption = "生成工资条";
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docAdmin, "somebody");
    }
}
