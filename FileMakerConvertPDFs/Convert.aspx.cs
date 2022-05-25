﻿using System;

public partial class FileMakerConvertPDFs_Convert : System.Web.UI.Page
{
    public PageOffice.FileMakerCtrl FileMakerCtrl1 = new PageOffice.FileMakerCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        String id = Request.QueryString["id"].Trim();
        String filePath = "";
        if ("1".Equals(id))
        {
            filePath = Server.MapPath("doc/PageOffice产品简介.doc");
        }
        if ("2".Equals(id))
        {
            filePath = Server.MapPath("doc/Pageoffice客户端安装步骤.doc");
        }
        if ("3".Equals(id))
        {
            filePath = Server.MapPath("doc/PageOffice的应用领域.doc");
        }
        if ("4".Equals(id))
        {
            filePath = Server.MapPath("doc/PageOffice产品对客户端环境要求.doc");
        }
        Console.Write(filePath);
        //设置服务器页面
        FileMakerCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        FileMakerCtrl1.SaveFilePage = "SaveFile.aspx";
        FileMakerCtrl1.JsFunction_OnProgressComplete="OnProgressComplete()";
        FileMakerCtrl1.FillDocumentAsPDF(filePath, PageOffice.DocumentOpenType.Word,"aa.pdf");
    }
}