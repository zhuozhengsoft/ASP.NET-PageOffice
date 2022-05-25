using System;

public partial class Default : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOffice.WordWriter.WordDocument doc = new PageOffice.WordWriter.WordDocument();
        doc.Template.DefineDataRegion("Name", "[ 姓名 ]");
        doc.Template.DefineDataRegion("Address", "[ 地址 ]");
        doc.Template.DefineDataRegion("Tel", "[ 电话 ]");
        doc.Template.DefineDataRegion("Phone", "[ 手机 ]");
        doc.Template.DefineDataRegion("Sex", "[ 性别 ]");
        doc.Template.DefineDataRegion("Age", "[ 年龄 ]");
        doc.Template.DefineDataRegion("Email", "[ 邮箱 ]");
        doc.Template.DefineDataRegion("QQNo", "[ QQ号 ]");
        doc.Template.DefineDataRegion("MSNNo", "[ MSN号 ]");

        PageOfficeCtrl1.AddCustomToolButton("保存", "Save()", 1);
        PageOfficeCtrl1.AddCustomToolButton("定义数据区域", "ShowDefineDataRegions()", 3);
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        PageOfficeCtrl1.Theme = PageOffice.ThemeType.Office2007;
        PageOfficeCtrl1.BorderStyle = PageOffice.BorderStyleType.BorderThin;
        PageOfficeCtrl1.SetWriter(doc);
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docNormalEdit, "zhangsan");
    }
}
