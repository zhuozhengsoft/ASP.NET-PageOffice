﻿using System;

public partial class InsertPageBreak_Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        // 设置PageOffice组件服务页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";

        // 添加一个自定义工具条上的按钮，AddCustomToolButton的参数说明，详见开发帮助。
        PageOfficeCtrl1.AddCustomToolButton("插入分页符", " InsertPageBreak()", 1);

        // 打开文档
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docNormalEdit, "Tom");
    }
}
