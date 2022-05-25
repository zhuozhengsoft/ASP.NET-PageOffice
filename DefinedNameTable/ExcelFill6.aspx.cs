using System;

public partial class DefinedNameTable_ExcelFill6 : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置PageOfficeCtrl控件的服务页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.Caption = "简单的给Excel赋值";
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save()", 1);
        PageOfficeCtrl1.WebOpen("doc/test4.xls", PageOffice.OpenModeType.xlsNormalEdit, "操作人姓名");
    }
}
