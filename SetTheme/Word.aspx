﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="SetTheme_Word" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>演示：修改Word文档的主题样式</title>
    <style>
        html, body
        {
            height: 100%;
        }
        .main
        {
            height: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-size: 12px; line-height: 20px; border-bottom: dotted 1px #ccc; border-top: dotted 1px #ccc;
        padding: 5px;">
        操作：在后台代码里设置PageOfficeCtrl的Theme属性。<br />
        关键代码：<span style="background-color:Yellow;">PageOfficeCtrl1.Theme = PageOffice.ThemeType.Office2010;//ThemeType为枚举类型，当前是Office2010风格。</span>
    </div>
    <div style="height: 600px; width: auto;">
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>
