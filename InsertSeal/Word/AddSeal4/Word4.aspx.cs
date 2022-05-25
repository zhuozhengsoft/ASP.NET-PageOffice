using System;

public partial class InsertSeal_Word_AddSeal4_Word4 : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置服务器页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        //添加自定义按钮
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save", 1);
        PageOfficeCtrl1.AddCustomToolButton("添加印章位置", "InsertSealPos()", 2);
        //设置保存页面
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        //打开文件
        PageOfficeCtrl1.WebOpen("word4.doc", PageOffice.OpenModeType.docAdmin, "张佚名");
    }
}
