﻿using System;

public partial class SetTheme_Word : System.Web.UI.Page
{
    public PageOffice.PageOfficeCtrl PageOfficeCtrl1 = new PageOffice.PageOfficeCtrl();
    protected void Page_Load(object sender, EventArgs e)
    {
        //PageOffice组件的引用
        //首先确保已安装了pageoffice服务器端组件，且在项目中已添加了pageoffice文件夹，
        //在该文件夹中已存在posetup.exe和server.aspx服务器端页面，再在前台页面中引入PageOfficeCtrl控件

        //设置服务器页面
        PageOfficeCtrl1.ServerPage = Request.ApplicationPath + "poserver.aspx";
        //设置PageOfficeCtrl的Theme属性，该属性默认的主题类型是Office2007类型，ThemeType为枚举类型，用户可自行选择相应类型
        PageOfficeCtrl1.Theme = PageOffice.ThemeType.Office2010;
        //打开文件
        PageOfficeCtrl1.WebOpen(Server.MapPath("doc/test.doc"), PageOffice.OpenModeType.docNormalEdit, "张佚名");
    }
}
