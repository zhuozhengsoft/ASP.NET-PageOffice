﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OpenWord.aspx.cs" Inherits="ControlBars_OpenWord" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>控制标题栏、菜单栏、自定工具栏和Office工具栏的隐藏和显示</title>
    <script type="text/javascript">

    </script>
</head>
<body>
    隐藏了标题栏、菜单栏、自定工具栏和Office工具栏的效果，每个栏都是可以单独的控制是否隐藏。
    <form id="form1" runat="server">
    <div style="width:auto; height: 700px;" >
         <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
