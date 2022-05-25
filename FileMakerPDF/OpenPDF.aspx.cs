using System;

public partial class OpenPDF : System.Web.UI.Page
{
    public PageOffice.PDFCtrl PDFCtrl1 = new PageOffice.PDFCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        // 按键说明：光标键、Home、End、PageUp、PageDown可用来移动或翻页；数字键盘+、-用来放大缩小；数字键盘/、*用来旋转页面。
        PDFCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PDFCtrl1.Theme = PageOffice.ThemeType.Office2007;
        PDFCtrl1.AddCustomToolButton("打印", "PrintFile()", 6);
        PDFCtrl1.AddCustomToolButton("-", "", 0);
        PDFCtrl1.AddCustomToolButton("显示/隐藏书签", "SwitchBKMK()", 0);
        PDFCtrl1.AddCustomToolButton("实际大小", "SetPageReal()", 16);
        PDFCtrl1.AddCustomToolButton("适合页面", "SetPageFit()", 17);
        PDFCtrl1.AddCustomToolButton("适合宽度", "SetPageWidth()", 18);
        PDFCtrl1.AddCustomToolButton("-", "", 0);
        PDFCtrl1.AddCustomToolButton("首页", "FirstPage()", 8);
        PDFCtrl1.AddCustomToolButton("上一页", "PreviousPage()", 9);
        PDFCtrl1.AddCustomToolButton("下一页", "NextPage()", 10);
        PDFCtrl1.AddCustomToolButton("尾页", "LastPage()", 11);
        PDFCtrl1.AddCustomToolButton("-", "", 0);
        PDFCtrl1.AddCustomToolButton("向左旋转90度", "SetRotateLeft()", 12);
        PDFCtrl1.AddCustomToolButton("向右旋转90度", "SetRotateRight()", 13);
        //PDFCtrl1.AddCustomToolButton("-", "", 0);
        //PDFCtrl1.AddCustomToolButton("放大", "ZoomIn()", 14);
        //PDFCtrl1.AddCustomToolButton("缩小", "ZoomOut()", 15);
        //PDFCtrl1.AddCustomToolButton("-", "", 0);
        //PDFCtrl1.AddCustomToolButton("全屏", "SwitchFullScreen()", 4); 
        //PDFCtrl1.AllowCopy = false;
        PDFCtrl1.WebOpen("doc/template.pdf");
    }

}
