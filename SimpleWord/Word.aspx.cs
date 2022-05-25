using System;
public partial class SimpleWord_Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        // 设置PageOffice组件服务页面
        /**
         * 如果访问项目的时候浏览器地址栏中的地址都不带后缀（例如"http://localhost:3306/Samples/Deafult"），则这里给ServerPage赋值的时候也不能带后缀，
         * 直接就是“ PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "/pageoffice/server";”，否则会报“error：0”的错误
         */
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "/poserver.aspx";
        //添加自定义按钮
        PageOfficeCtrl1.AddCustomToolButton("保存", "SaveDocument()", 1);
        PageOfficeCtrl1.AddCustomToolButton("另存到本地", "SaveAs()", 1);
        PageOfficeCtrl1.AddCustomToolButton("打印设置", "PrintSet()", 0);
        PageOfficeCtrl1.AddCustomToolButton("打印", "PrintFile()", 6);
        PageOfficeCtrl1.AddCustomToolButton("全屏/还原", "IsFullScreen()", 4);
        PageOfficeCtrl1.AddCustomToolButton("-", "", 0);
        PageOfficeCtrl1.AddCustomToolButton("关闭", "Close()", 21);

        PageOfficeCtrl1.FileTitle = "test";//设置另存为本地的文件名称
        // 设置保存文件页面
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        // 打开文档
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docNormalEdit, "Tom");
    }
}
