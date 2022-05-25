using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected string url = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        string strFilePath = Server.MapPath("doc/template.pdf");//服务器文件路径
        FileInfo fileInfo = new FileInfo(strFilePath);
        Response.Clear();
        Response.Charset = "utf-8";
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.AddHeader("Content-Disposition", "attachment; filename=template.pdf");
        Response.AddHeader("Content-Length", fileInfo.Length.ToString());
        Response.ContentType = "application/pdf";
        Response.WriteFile(fileInfo.FullName);
        Response.End();

    }
}
