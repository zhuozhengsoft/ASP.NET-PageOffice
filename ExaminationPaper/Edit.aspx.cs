using System;


public partial class ExaminationPaper_Edit : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        string id = Request.QueryString["id"];
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx?id=" + id;
        PageOfficeCtrl1.WebOpen("Openfile.aspx?id=" + id, PageOffice.OpenModeType.docNormalEdit, "someBody");
    }
}
