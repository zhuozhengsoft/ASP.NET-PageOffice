using System;

public partial class OpenImage_Image : System.Web.UI.Page
{
    public PageOffice.PDFCtrl PDFCtrl1 = new PageOffice.PDFCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        // 按键说明：光标键、Home、End、PageUp、PageDown可用来移动或翻页；数字键盘+、-用来放大缩小；数字键盘/、*用来旋转页面。
        PDFCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PDFCtrl1.Theme = PageOffice.ThemeType.Office2007;
        //PDFCtrl1.TitlebarColor = Color.Green;
        //PDFCtrl1.JsFunction_AfterDocumentOpened = "AfterDocumentOpened()";
        PDFCtrl1.AddCustomToolButton("打印", "Print()", 6);
        PDFCtrl1.AddCustomToolButton("-", "", 0);
        PDFCtrl1.AddCustomToolButton("实际大小", "SetPageReal()", 16);
        PDFCtrl1.AddCustomToolButton("适合页面", "SetPageFit()", 17);
        PDFCtrl1.AddCustomToolButton("适合宽度", "SetPageWidth()", 18);
        PDFCtrl1.AddCustomToolButton("-", "", 0);
        PDFCtrl1.AddCustomToolButton("左转", "RotateLeft()", 12);
        PDFCtrl1.AddCustomToolButton("右转", "RotateRight()", 13);
        PDFCtrl1.AddCustomToolButton("-", "", 0);
        PDFCtrl1.AddCustomToolButton("放大", "ZoomIn()", 14);
        PDFCtrl1.AddCustomToolButton("缩小", "ZoomOut()", 15);
        PDFCtrl1.AddCustomToolButton("-", "", 0);
        PDFCtrl1.AddCustomToolButton("全屏", "SwitchFullScreen()", 4);
        PDFCtrl1.WebOpen("doc/test.jpg");
    }
}
