using System;

public partial class WordDisableRightWord_Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        // 设置PageOffice组件服务页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";

        PageOffice.WordWriter.WordDocument doc = new PageOffice.WordWriter.WordDocument();
        doc.DisableWindowRightClick = true; //禁止word鼠标右键
        //doc.DisableWindowDoubleClick = true;//禁止word鼠标双击
        PageOfficeCtrl1.SetWriter(doc);

        PageOfficeCtrl1.AddCustomToolButton("保存", "Save()", 1);
        // 设置保存文件页面
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        // 打开文档
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docNormalEdit, "Tom");
    }    
}
