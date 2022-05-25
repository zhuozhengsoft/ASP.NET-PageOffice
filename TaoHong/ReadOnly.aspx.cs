using System;

public partial class TaoHont_ReadOnly : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        string fileName = "zhengshi.doc";//正式发文文件

        PageOfficeCtrl1.AddCustomToolButton("另存到本地", "ShowDialog(0)", 5);
        PageOfficeCtrl1.AddCustomToolButton("页面设置", "ShowDialog(1)", 0);
        PageOfficeCtrl1.AddCustomToolButton("打印", "ShowDialog(2)", 6);
        PageOfficeCtrl1.AddCustomToolButton("全屏/还原", "IsFullScreen()", 4);
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx"; //此行必须
        PageOfficeCtrl1.WebOpen("doc/" + fileName, PageOffice.OpenModeType.docReadOnly, "张三");
    }
}
