using System;


public partial class TitleText_Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        //PageOffice组件的引用
        //首先确保已安装了pageoffice服务器端组件，且在项目中已添加了pageoffice文件夹，
        //在该文件夹中已存在posetup.exe和server.aspx服务器端页面，再在前台页面中引入PageOfficeCtrl控件

        //设置服务器页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        //设置PageOfficeCtrl的Caption属性，显示标题栏内容
        PageOfficeCtrl1.Caption = "这是由PageOfficeCtrl的Caption属性控制的，可以设置成你想显示的标题栏内容";
        string fileName = "test.doc";
        //打开文件
        PageOfficeCtrl1.WebOpen(Server.MapPath("doc/") + fileName, PageOffice.OpenModeType.docReadOnly, "张佚名");
    }
}
