using System;

public partial class WordCompare_Compare : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {

        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        // Create custom toolbar
        PageOfficeCtrl1.AddCustomToolButton("显示A文档", "ShowFile1View()", 0);
        PageOfficeCtrl1.AddCustomToolButton("显示B文档", "ShowFile2View()", 0);
        PageOfficeCtrl1.AddCustomToolButton("显示比较结果", "ShowCompareView()", 0);

        PageOfficeCtrl1.WordCompare("doc/aaa1.doc", "doc/aaa2.doc", PageOffice.OpenModeType.docAdmin, "Tom");
    }
}
