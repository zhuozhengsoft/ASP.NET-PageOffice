﻿using System;


public partial class WordResWord_Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        //PageOffice组件的引用
        //首先确保已安装了pageoffice服务器端组件，且在项目中已添加了pageoffice文件夹，
        //在该文件夹中已存在posetup.exe和server.aspx服务器端页面，再在前台页面中引入PageOfficeCtrl控件
        PageOffice.WordWriter.WordDocument worddoc = new PageOffice.WordWriter.WordDocument();
        //先在要插入word文件的位置手动插入书签,书签必须以“PO_”为前缀
        //给DataRegion赋值,值的形式为："[word]word文件路径[/word]"
        PageOffice.WordWriter.DataRegion data1 = worddoc.OpenDataRegion("PO_p1");
        data1.Value = "[image]doc/1.jpg[/image]";
        PageOffice.WordWriter.DataRegion data2 = worddoc.OpenDataRegion("PO_p2");
        data2.Value = "[word]doc/2.doc[/word]";
        PageOffice.WordWriter.DataRegion data3 = worddoc.OpenDataRegion("PO_p3");
        data3.Value = "[word]doc/3.doc[/word]";
        //设置服务器页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        string fileName = "test.doc";
        PageOfficeCtrl1.SetWriter(worddoc);
        PageOfficeCtrl1.Caption = "演示：后台编程插入图片到数据区域(专业版、企业版)";
        //打开文件
        PageOfficeCtrl1.WebOpen(Server.MapPath("doc/") + fileName, PageOffice.OpenModeType.docNormalEdit, "张佚名");
    }
}
