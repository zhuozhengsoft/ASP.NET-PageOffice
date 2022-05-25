using System;

public partial class DataTagEdit_Default : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOffice.WordWriter.WordDocument doc = new PageOffice.WordWriter.WordDocument();
        doc.Template.DefineDataTag("{ 甲方 }");
        doc.Template.DefineDataTag("{ 乙方 }");
        doc.Template.DefineDataTag("{ 担保人 }");
        doc.Template.DefineDataTag("【 合同日期 】");
        doc.Template.DefineDataTag("【 合同编号 】");
        PageOfficeCtrl1.SetWriter(doc);

        PageOfficeCtrl1.AddCustomToolButton("保存", "Save()", 1);
        PageOfficeCtrl1.AddCustomToolButton("定义数据标签", "ShowDefineDataTags()", 20);
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        PageOfficeCtrl1.Theme = PageOffice.ThemeType.Office2007;
        PageOfficeCtrl1.BorderStyle = PageOffice.BorderStyleType.BorderThin;       
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docNormalEdit, "zhangsan");
    }
}
