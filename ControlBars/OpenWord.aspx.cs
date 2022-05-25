using System;

public partial class ControlBars_OpenWord : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOfficeCtrl1.Titlebar = false; //隐藏标题栏
        PageOfficeCtrl1.Menubar = false; //隐藏菜单栏
        PageOfficeCtrl1.OfficeToolbars = false; //隐藏Office工具栏
        PageOfficeCtrl1.CustomToolbar = false; //隐藏自定义工具栏
        //设置服务器页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        //打开文件
        PageOfficeCtrl1.WebOpen("doc/template.doc", PageOffice.OpenModeType.docReadOnly, "张佚名");
    }
}
