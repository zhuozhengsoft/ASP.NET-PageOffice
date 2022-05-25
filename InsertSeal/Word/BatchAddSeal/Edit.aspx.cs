using System;

public partial class InsertSeal_Word_BatchAddSeal__Edit : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        String id = Request.QueryString["id"].Trim();
        String filePath = "";
        if ("1".Equals(id))
        {
            filePath = Server.MapPath("doc/test1.doc");
        }
        if ("2".Equals(id))
        {
            filePath = Server.MapPath("doc/test2.doc");
        }
        if ("3".Equals(id))
        {
            filePath = Server.MapPath("doc/test3.doc");
        }
        if ("4".Equals(id))
        {
            filePath = Server.MapPath("doc/test4.doc");
        }
          // 设置PageOffice组件服务页面
         PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
          // 设置保存文件页面
         PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
          //添加自定义的保存按钮
         PageOfficeCtrl1.AddCustomToolButton("保存","Save()",1);
          // 打开文档
         PageOfficeCtrl1.WebOpen(filePath,PageOffice.OpenModeType.docNormalEdit,"Tom");
    }
}