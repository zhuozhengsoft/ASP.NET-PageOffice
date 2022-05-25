using System;

public partial class Stream : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx?id=1";
        PageOfficeCtrl1.AddCustomToolButton("保存","Save()",1);
        PageOfficeCtrl1.WebOpen("Openstream.aspx?id=1",PageOffice.OpenModeType.docRevisionOnly,"somebody");
    }
}
