using System;
public partial class DefinedNameTable_ExcelFill : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOffice.ExcelWriter.Workbook wk = new PageOffice.ExcelWriter.Workbook();
        PageOffice.ExcelWriter.Sheet sheet = wk.OpenSheet("Sheet1");
        PageOffice.ExcelWriter.Table table = sheet.OpenTableByDefinedName("report", 10, 5, false);
        table.DataFields[0].Value = "轮胎";
        table.DataFields[1].Value = "100";
        table.DataFields[2].Value = "120";
        table.DataFields[3].Value = "500";
        table.DataFields[4].Value = "120%";
        table.NextRow();
        table.Close();
        PageOfficeCtrl1.SetWriter(wk);// 注意不要忘记此代码，如果缺少此句代码，不会赋值成功。

        //设置PageOfficeCtrl控件的服务页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.Caption = "给Excel文档中定义名称的单元格赋值";
        PageOfficeCtrl1.SaveDataPage = "SaveData.aspx";
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save()", 1);
        PageOfficeCtrl1.WebOpen("doc/test.xls", PageOffice.OpenModeType.xlsSubmitForm, "操作人姓名");
    }
}
