using System;


public partial class CreateWord_CreateWord : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.SaveFilePage = "SaveNewFile.aspx";
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save()", 1);
        PageOfficeCtrl1.JsFunction_BeforeDocumentSaved = "BeforeDocumentSaved()";
        //创建文件
        PageOfficeCtrl1.WebCreateNew("somebody", PageOffice.DocumentVersion.Word2003);//可创建不同版本的word文件
    }
}
