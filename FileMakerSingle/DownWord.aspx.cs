using System;
using System.IO;

public partial class FileMakerSingle_FileMakerSingle : System.Web.UI.Page
{
    public PageOffice.FileMakerCtrl FileMakerCtrl1 = new PageOffice.FileMakerCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {

        string strFilePath = Server.MapPath("doc/maker.doc");//服务器文件路径
        FileInfo fileInfo = new FileInfo(strFilePath);
        Response.Clear();
        Response.Charset = "utf-8";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.AddHeader("Content-Disposition", "attachment; filename=maker.doc");
        Response.AddHeader("Content-Length", fileInfo.Length.ToString());
        Response.ContentType = "application/msword";
        Response.WriteFile(fileInfo.FullName);
        Response.End();

    }
}
