using System;

public partial class FileMakerSingle_FileMakerSingle : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "/poserver.aspx";
        PageOfficeCtrl1.CustomToolbar = false;
        // 打开文档
        PageOfficeCtrl1.WebOpen("doc/maker.doc", PageOffice.OpenModeType.docNormalEdit, "Tom");
    }
}
