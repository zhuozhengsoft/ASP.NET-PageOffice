﻿using System;

public partial class ExcelRibbonCtrl_Excel : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        // 设置PageOffice组件服务页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        PageOfficeCtrl1.RibbonBar.SetTabVisible("TabHome", true);//开始
        PageOfficeCtrl1.RibbonBar.SetTabVisible("TabFormulas", false);//公式
        PageOfficeCtrl1.RibbonBar.SetTabVisible("TabInsert", false);//插入
        PageOfficeCtrl1.RibbonBar.SetTabVisible("TabData", false);//数据
        PageOfficeCtrl1.RibbonBar.SetTabVisible("TabReview", false);//审阅
        PageOfficeCtrl1.RibbonBar.SetTabVisible("TabView", false);//视图
        PageOfficeCtrl1.RibbonBar.SetTabVisible("TabPageLayoutExcel", false);//页面布局
        PageOfficeCtrl1.RibbonBar.SetSharedVisible("FileSave", false);//office自带的保存按钮

        //分组
        PageOfficeCtrl1.RibbonBar.SetGroupVisible("GroupClipboard", false);//剪贴板
        PageOfficeCtrl1.AddCustomToolButton("保存", "SaveFile()", 1);
        // 打开文档
        PageOfficeCtrl1.WebOpen("doc/test.xls", PageOffice.OpenModeType.xlsNormalEdit, "Tom");
    }
}
