using System;

public partial class ConcurrencyCtrl_Word: System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        string userName = "somebody";
        string userId = Request.QueryString["userid"].ToString();
        if ("1" == userId)
        {
            userName = "张三";
        }
        else
        {
            userName = "李四";
        }
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        PageOfficeCtrl1.TimeSlice = 20; // 设置并发控制时间, 单位:分钟
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docRevisionOnly, userName);
    }

}
