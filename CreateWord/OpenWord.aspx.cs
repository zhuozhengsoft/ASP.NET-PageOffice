using System;

public partial class  CreateWord_OpenWord: System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    string fileName = "";
    string subject = "";
    protected void Page_Load(object sender, EventArgs e)
    {
       // Context.Response.Charset = "UTF8";
         fileName = Request.QueryString["filename"].Trim();
         subject = Request.QueryString["subject"];
        Literal_Subject.Text = Server.UrlDecode(subject);

        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save", 1);
        PageOfficeCtrl1.WebOpen(Server.MapPath("doc/") + fileName, PageOffice.OpenModeType.docNormalEdit, "somebody");
    }
}
