using System;

public partial class SendParameters_SendParameters : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        //PageOffice组件的引用
        //设置服务器页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.Caption = "演示：向保存页面传递参数，更新人员信息";
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save()",1);
        PageOfficeCtrl1.AddCustomToolButton("全屏", "SetFullScreen()", 4);
        //设置保存页
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx?id=1";//传递查询参数
        //打开文件
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docNormalEdit, "张佚名");
    }
}
