using System;

public partial class Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        // 设置PageOffice组件服务页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.OfficeToolbars = false;
        //PageOfficeCtrl1.Menubar = false; // 隐藏菜单栏
        PageOfficeCtrl1.JsFunction_AfterDocumentOpened = "AfterDocumentOpened";
        PageOfficeCtrl1.AllowCopy = false;  // 禁止拷贝
        // 打开文档
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docReadOnly, "Tom");
    }
}
