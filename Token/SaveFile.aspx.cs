using System;

public partial class Token_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //获取token值 //获取token值
        string mytoken = Request.Headers["Authorization"].ToString();
        Response.ContentType="text/plain";
        Response.Write(mytoken);
        PageOffice.FileSaver fs = new PageOffice.FileSaver();
        fs.SaveToFile(Server.MapPath("doc/") + fs.FileName);
        fs.ShowPage(300, 300);
        fs.Close();
    }
}