using System;

public partial class WordTextBox_TextBoxFill : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {        
        PageOffice.WordWriter.WordDocument wordDoc = new PageOffice.WordWriter.WordDocument();
        wordDoc.OpenDataRegion("PO_company").Value = "北京幻想科技有限公司";
        wordDoc.OpenDataRegion("PO_logo").Value = "[image]doc/logo.gif[/image]";
        wordDoc.OpenDataRegion("PO_dr1").Value = "左边的文本:xxxx";

        PageOfficeCtrl1.SetWriter(wordDoc);// 注意不要忘记此代码，如果缺少此句代码，不会赋值成功。
        //设置服务器页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docNormalEdit, "文档操作人姓名");
    }
}
