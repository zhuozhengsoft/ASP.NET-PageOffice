using System;


public partial class PDFSearch_PDF : System.Web.UI.Page
{
    public PageOffice.PDFCtrl PDFCtrl1 = new PageOffice.PDFCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PDFCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PDFCtrl1.Theme = PageOffice.ThemeType.Office2007;
        PDFCtrl1.AddCustomToolButton("搜索", "SearchText()", 0);
        PDFCtrl1.AddCustomToolButton("搜索下一个", "SearchTextNext()", 0);
        PDFCtrl1.AddCustomToolButton("搜索上一个", "SearchTextPrev()", 0);
        PDFCtrl1.AddCustomToolButton("实际大小", "SetPageReal()", 16);
        PDFCtrl1.AddCustomToolButton("适合页面", "SetPageFit()", 17);
        PDFCtrl1.AddCustomToolButton("适合宽度", "SetPageWidth()", 18);
        PDFCtrl1.WebOpen("doc/test.pdf");
    }    
}
