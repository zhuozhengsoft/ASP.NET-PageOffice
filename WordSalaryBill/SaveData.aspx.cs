using System;
using System.Web.UI;
using System.Data.SQLite;
using PageOffice.WordReader;
using System.Data;

public partial class SaveData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        if (id != null && id.Length > 0)
        {
            string strConn = "Data Source=" + Server.MapPath("/App_Data/WordSalaryBill.db");
     
            string userName = "", deptName = "", salTotoal = "0", salDeduct = "0", salCount = "0", dateTime = "";
            //-----------  PageOffice 服务器端编程开始  -------------------//
            WordDocument doc = new WordDocument();
            userName = doc.OpenDataRegion("PO_UserName").Value;
            deptName = doc.OpenDataRegion("PO_DeptName").Value;
            salTotoal = doc.OpenDataRegion("PO_SalTotal").Value;
            salDeduct = doc.OpenDataRegion("PO_SalDeduct").Value;
            salCount = doc.OpenDataRegion("PO_SalCount").Value;
            dateTime = doc.OpenDataRegion("PO_DataTime").Value;

            string sql = "UPDATE Salary SET UserName='" + userName
                + "',DeptName='" + deptName + "',SalTotal='" + salTotoal
                + "',SalDeduct='" + salDeduct + "',SalCount='" + salCount
                + "',DataTime='" + dateTime + "' WHERE ID=" + id;

            SQLiteConnection conn = new SQLiteConnection(strConn);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);

            cmd.ExecuteNonQuery();
            conn.Close();

            //向客户端控件返回以上代码执行成功的消息。
            doc.CustomSaveResult = "ok";
            doc.Close();
        }
        else
        {
            Response.Write("<script>alert('未获得文件的ID，保存失败！');location.href='Default.aspx'</script>");
        }
    }
}
