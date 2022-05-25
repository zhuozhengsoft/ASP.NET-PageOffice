using System;

public partial class FileMakerSingle_FileMakerSingle : System.Web.UI.Page
{
    public PageOffice.FileMakerCtrl FileMakerCtrl1 = new PageOffice.FileMakerCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOffice.WordWriter.WordDocument doc = new PageOffice.WordWriter.WordDocument();
        //禁用右击事件
        doc.DisableWindowRightClick = true;
        //给数据区域赋值，即把数据填充到模板中相应的位置
        doc.OpenDataRegion("PO_company").Value = "北京卓正志远软件有限公司";

        FileMakerCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        FileMakerCtrl1.SaveFilePage = "Savemaker.aspx";
        FileMakerCtrl1.SetWriter(doc);
        FileMakerCtrl1.JsFunction_OnProgressComplete = "OnProgressComplete()";
        FileMakerCtrl1.FileTitle = "newfilename.doc";
        FileMakerCtrl1.FillDocument(Server.MapPath("doc/template.doc"), PageOffice.DocumentOpenType.Word);
    }
}
