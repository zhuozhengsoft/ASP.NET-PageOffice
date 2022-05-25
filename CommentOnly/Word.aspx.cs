﻿using System;

public partial class CommentOnly_Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        // 设置PageOffice组件服务页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        // 设置保存文件页面
        PageOfficeCtrl1.SaveFilePage = "SaveFile.aspx";
        // 添加一个自定义工具条上的按钮，AddCustomToolButton的参数说明，详见开发帮助。
        PageOfficeCtrl1.AddCustomToolButton("保存", "Save", 1);
        PageOfficeCtrl1.AddCustomToolButton("插入批注", "newComment", 0);
        // 打开文档
        PageOfficeCtrl1.WebOpen("doc/test.doc", PageOffice.OpenModeType.docCommentOnly, "李斯");
    }
}
