using System;

public partial class Simple_Word1 : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    string filePath = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        filePath = Server.MapPath("doc/test.doc");
        Literal_Info.Text = "filePath的值是：" + filePath;
        // 设置PageOffice组件服务页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        //添加自定义按钮
        PageOfficeCtrl1.AddCustomToolButton("保存", "SaveDocument()", 1);

        // 设置保存文件页面
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        // 打开文档
        PageOfficeCtrl1.WebOpen(filePath, PageOffice.OpenModeType.docNormalEdit, "Tom");
    }
}
