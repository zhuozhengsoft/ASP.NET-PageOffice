using System;

public partial class WordDataTag2_DataTag : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {        
        //定义WordDocument对象
        PageOffice.WordWriter.WordDocument doc = new PageOffice.WordWriter.WordDocument();
        //定义DataTag对象
        PageOffice.WordWriter.DataTag deptTag = doc.OpenDataTag("{部门名}");
        deptTag.Value = "技术";

        PageOffice.WordWriter.DataTag userTag = doc.OpenDataTag("{姓名}");
        userTag.Value = "李志";

        PageOffice.WordWriter.DataTag dateTag = doc.OpenDataTag("【时间】");
        dateTag.Value = DateTime.Now.ToString("yyyy-MM-dd");

        PageOfficeCtrl1.SetWriter(doc);
        //设置服务器页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        //打开Word文件
        PageOfficeCtrl1.WebOpen("doc/test2.doc", PageOffice.OpenModeType.docNormalEdit, "张佚名");
    }
}
