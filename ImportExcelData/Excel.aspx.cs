using System;

public partial class ImportExcelData_Excel : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        //定义Workbook对象
        PageOffice.ExcelWriter.Workbook workBook = new PageOffice.ExcelWriter.Workbook();
        //定义Sheet对象，"Sheet1"是打开的Excel表单的名称
        PageOffice.ExcelWriter.Sheet sheet = workBook.OpenSheet("Sheet1");
        PageOfficeCtrl1.SetWriter(workBook);

        //设置PageOffice组件服务器
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath+"poserver.aspx";
        //添加自定义按钮
        PageOfficeCtrl1.AddCustomToolButton("导入文件", "importData()", 5);
        PageOfficeCtrl1.AddCustomToolButton("提交数据", "submitData()", 1);
        //设置保存页面 
        PageOfficeCtrl1.SaveDataPage = "SaveData.aspx";

    }
}
