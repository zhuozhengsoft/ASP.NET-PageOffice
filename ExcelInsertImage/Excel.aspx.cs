using System;

public partial class ExcelInsertImage_Excel : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOffice.ExcelWriter.Workbook worbBook = new PageOffice.ExcelWriter.Workbook();
        PageOffice.ExcelWriter.Sheet Sheetl = worbBook.OpenSheet("Sheet1");
        PageOffice.ExcelWriter.Cell cell1 = Sheetl.OpenCell("A1");
        cell1.Value = "[image]image/logo.jpg[/image]";
        // 设置PageOffice组件服务页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        // 设置保存文件页面
        // PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        PageOfficeCtrl1.SetWriter(worbBook);
        // 打开文档
        PageOfficeCtrl1.WebOpen("doc/test.xls", PageOffice.OpenModeType.xlsNormalEdit, "Tom");
    }
}
