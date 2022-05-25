using System;
using PageOffice.WordWriter;

public partial class TaoHong_TaoHong : System.Web.UI.Page
{
    public string mb = "";
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx"; //此行必须                                                                               //将套红后的文件名称命名为zhengshi.doc
        PageOfficeCtrl1.SaveFilePage="SaveFile.aspx?fileName=zhengshi.doc";
        mb = Request.QueryString["mb"];
        string fileName= "";//获取选择的模版名称

        //首次加载时，加载“正文文件”：test.doc
        if (mb== null || mb== "")
        {
             fileName = "test.doc";

        }
        else {   
            //套红模板时，复制模板文件为“正式发文文件”（zhengshi.doc），填充数据和“正文文件”到“正式发文文件”
            fileName = Request.QueryString["mb"];
            //给正式发文的文件填充数据
            WordDocument doc = new WordDocument();
            DataRegion copies = doc.OpenDataRegion("PO_Copies");
            copies.Value = "6";
            DataRegion docNum = doc.OpenDataRegion("PO_DocNum");
            docNum.Value = "001";
            DataRegion issueDate = doc.OpenDataRegion("PO_IssueDate");
            issueDate.Value = "2013-5-30";
            DataRegion issueDept = doc.OpenDataRegion("PO_IssueDept");
            issueDept.Value = "开发部";
            DataRegion sTextS = doc.OpenDataRegion("PO_STextS");
            sTextS.Value = "[word]doc/test.doc[/word]"; // 把正文文件插入到正式文件中
            DataRegion sTitle = doc.OpenDataRegion("PO_sTitle");
            sTitle.Value = "北京某公司文件";
            DataRegion topicWords = doc.OpenDataRegion("PO_TopicWords");
            topicWords.Value = "Pageoffice、 套红";
            PageOfficeCtrl1.SetWriter(doc);     
        }
        PageOfficeCtrl1.WebOpen("doc/" + fileName, PageOffice.OpenModeType.docNormalEdit, "张三");
    }
 
}
