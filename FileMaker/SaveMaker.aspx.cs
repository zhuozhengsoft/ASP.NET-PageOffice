﻿using System;

public partial class FileMaker_SaveMaker : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["id"];
        if (id != null && id.Length > 0)
        {
            //定义FileSaver对象
            PageOffice.FileSaver fs = new PageOffice.FileSaver();
            string fileName = "maker" + id + fs.FileExtName;
            //将Word文档保存到本地磁盘上
            fs.SaveToFile(Server.MapPath("doc/") + fileName);
            fs.Close();
        }
        else
        {
            Response.Write("<script>alert('未获得文件名称');</script>");
        }
    }
}
