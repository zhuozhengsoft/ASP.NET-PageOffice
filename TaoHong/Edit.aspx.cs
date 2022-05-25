using System;

public partial class TaoHong_Edit : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        string fileName = "test.doc"; // 正文文件
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save", 1);
        PageOfficeCtrl1.AddCustomToolButton("全屏/还原", "IsFullScreen", 4);
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx"; //此行必须
        PageOfficeCtrl1.SaveFilePage = "Savefile.aspx?fileName=test.doc";
        PageOfficeCtrl1.WebOpen("doc/" + fileName, PageOffice.OpenModeType.docNormalEdit, "张三");
    }
}
