using System;

public partial class InsertImageSetSize_Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {  
        PageOffice.WordWriter.WordDocument worddoc = new PageOffice.WordWriter.WordDocument();
        //先在要插入word文件的位置手动插入书签,书签必须以“PO_”为前缀
        //给DataRegion赋值,值的形式为："[word]word文件路径[/word]"
        PageOffice.WordWriter.DataRegion data1 = worddoc.OpenDataRegion("PO_p1");
        // [image]标签中的width和height属性的单位是：英磅
        data1.Value = "[image width=200.2 height=200]doc/1.jpg[/image]";

        //设置服务器页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        string fileName = "test.doc";
        PageOfficeCtrl1.SetWriter(worddoc);
        PageOfficeCtrl1.Caption = "演示：后台编程插入图片到数据区域,并设置图片大小(企业版)";
        //打开文件
        PageOfficeCtrl1.WebOpen(Server.MapPath("doc/") + fileName, PageOffice.OpenModeType.docNormalEdit, "张佚名");
    }
}