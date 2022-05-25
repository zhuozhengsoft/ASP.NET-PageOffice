﻿using System;
public partial class WordHandDraw_Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save()", 1);
        PageOfficeCtrl1.AddCustomToolButton("开始手写", "StartHandDraw()", 5);
        PageOfficeCtrl1.AddCustomToolButton("设置线宽", "SetPenWidth()", 5); 
        PageOfficeCtrl1.AddCustomToolButton("设置颜色","SetPenColor()",5);
        PageOfficeCtrl1.AddCustomToolButton("设置笔型","SetPenType()",5);
        PageOfficeCtrl1.AddCustomToolButton("设置缩放","SetPenZoom()",5);
        PageOfficeCtrl1.AddCustomToolButton("访问手写集", "GetHandDrawList()", 6);
        string fileName = "template.doc";
        PageOfficeCtrl1.WebOpen(Server.MapPath("doc/")+fileName,PageOffice.OpenModeType.docRevisionOnly,"somebody");
    }
}
