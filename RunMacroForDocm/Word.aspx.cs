using System;

public partial class RunMacroForDocm_Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOfficeCtrl1.Menubar = false;
        PageOfficeCtrl1.CustomToolbar = false;
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx"; //此行必须
        PageOfficeCtrl1.WebOpen("doc/test.docm" , PageOffice.OpenModeType.docNormalEdit, "张三");
    }
}