using System;
using System.Web.UI;
using PageOffice.WordWriter;
using System.Data.SQLite;
using System.Data;

public partial class WordSalaryBill_View : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        if (Request.QueryString["ID"] != null && Request.QueryString["ID"].Length > 0)
        {
            string id = Request.QueryString["ID"].Trim();
            string strConn = "Data Source=" + Server.MapPath("/App_Data/WordSalaryBill.db");
            string strSql = "select * from Salary where id =" + id + " order by ID";

            SQLiteConnection conn = new SQLiteConnection(strConn);
            SQLiteCommand cmd = new SQLiteCommand(strSql, conn);
            conn.Open();
            cmd.CommandType = CommandType.Text;
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                decimal result = 0;
                DateTime date = DateTime.Now;
                //创建WordDocment对象
                WordDocument doc = new WordDocument();
                //打开数据区域
                DataRegion datareg = doc.OpenDataRegion("PO_table");
                //打开Table
                PageOffice.WordWriter.Table table = datareg.OpenTable(1);
                ////给单元格赋值
                table.OpenCellRC(2, 1).Value = reader["ID"].ToString();
                table.OpenCellRC(2, 2).Value = reader["UserName"].ToString();
                table.OpenCellRC(2, 3).Value = reader["DeptName"].ToString();
                if (reader["SalTotal"] != null && decimal.TryParse(reader["SalTotal"].ToString(), out result))
                {
                    table.OpenCellRC(2, 4).Value = decimal.Parse(reader["SalTotal"].ToString()).ToString("c");
                }
                else
                {
                    table.OpenCellRC(2, 4).Value = "￥0.00";
                }

                if (reader["SalDeduct"] != null && decimal.TryParse(reader["SalDeduct"].ToString(), out result))
                {
                    table.OpenCellRC(2, 5).Value = int.Parse(reader["SalDeduct"].ToString()).ToString("c");
                }
                else
                {
                    table.OpenCellRC(2, 5).Value = "￥0.00";
                }

                if (reader["SalCount"] != null && decimal.TryParse(reader["SalCount"].ToString(), out result))
                {
                    table.OpenCellRC(2, 6).Value = int.Parse(reader["SalCount"].ToString()).ToString("c");
                }
                else
                {
                    table.OpenCellRC(2, 6).Value = "￥0.00";
                }

                if (reader["DataTime"] != null && DateTime.TryParse(reader["DataTime"].ToString(), out date))
                {
                    table.OpenCellRC(2, 7).Value = DateTime.Parse(reader["DataTime"].ToString()).ToString("yyyy-MM-dd");
                }
                else
                {
                    table.OpenCellRC(2, 7).Value = "";
                }

                PageOfficeCtrl1.SetWriter(doc);
            }
            else
            {
                Response.Write("<script>alert('未获得该员工的工资信息！');location.href='Default.aspx'</script>");
            }
            reader.Close();
            conn.Close();
        }
        else
        {
            Response.Write("<script>alert('未获得该工资信息的ID！');location.href='Default.aspx'</script>");
        }
        PageOfficeCtrl1.WebOpen("doc/template.doc", PageOffice.OpenModeType.docReadOnly, "someBody");
    }
}
