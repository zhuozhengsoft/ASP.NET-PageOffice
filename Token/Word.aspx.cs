using System;

public partial class Token_Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    public string mytoken="";
    protected void Page_Load(object sender, EventArgs e)
    {
        //获取token值
        mytoken = Request.Headers["Authorization"].ToString();
        //设置服务器页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx"; //此行必须
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save()", 1);
        PageOfficeCtrl1.AddCustomToolButton("打印", "PrintFile()", 6);
        PageOfficeCtrl1.AddCustomToolButton("全屏/还原", "IsFullScreen()", 4);
        PageOfficeCtrl1.AddCustomToolButton("关闭", "CloseFile()", 21);
        //设置保存页面
        PageOfficeCtrl1.SaveFilePage="SaveFile.aspx";
        //打开Word文档
        PageOfficeCtrl1.WebOpen("doc/test.doc",PageOffice.OpenModeType.docNormalEdit, "张佚名");
    }
}