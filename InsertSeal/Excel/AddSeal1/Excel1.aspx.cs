using System;


public partial class InsertSeal_Excel_AddSeal1_Excel1 : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        //设置服务器页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        //添加自定义按钮
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save", 1);
        PageOfficeCtrl1.AddCustomToolButton("加盖印章", "InsertSeal()", 2);
        PageOfficeCtrl1.AddCustomToolButton("删除印章", "DeleteSeal()", 21);
        PageOfficeCtrl1.AddCustomToolButton("验证印章", "VerifySeal()", 5);
        PageOfficeCtrl1.AddCustomToolButton("修改密码", "ChangePsw()", 0);
        //设置保存页面
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        //打开文件
        PageOfficeCtrl1.WebOpen("test.xls", PageOffice.OpenModeType.xlsNormalEdit, "张佚名");
    }
}