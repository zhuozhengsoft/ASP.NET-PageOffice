using System;

public partial class InsertSeal_Word_BatchAddSeal_AddSeal : System.Web.UI.Page
{
    public PageOffice.FileMakerCtrl FileMakerCtrl1 = new PageOffice.FileMakerCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        String id = Request.QueryString["id"].Trim();
        String filePath = "";
        if ("1".Equals(id))
        {
            filePath = Server.MapPath("doc/test1.doc");
        }
        if ("2".Equals(id))
        {
            filePath = Server.MapPath("doc/test2.doc");
        }
        if ("3".Equals(id))
        {
            filePath = Server.MapPath("doc/test3.doc");
        }
        if ("4".Equals(id))
        {
            filePath = Server.MapPath("doc/test4.doc");
        }
        Console.Write(filePath);
        //设置服务器页面
        FileMakerCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        FileMakerCtrl1.SaveFilePage = "SaveFile.aspx";
        FileMakerCtrl1.JsFunction_OnProgressComplete="OnProgressComplete()";
        FileMakerCtrl1.JsFunction_AfterDocumentOpened = "AfterDocumentOpened()";
        FileMakerCtrl1.FillDocument(filePath, PageOffice.DocumentOpenType.Word);
    }
}