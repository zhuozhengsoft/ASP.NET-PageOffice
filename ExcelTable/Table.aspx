﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Table.aspx.cs" Inherits="ExcelTable_Table" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    此表格中的数据是使用后台程序填充进去的，请查看Table.aspx.cs的代码，使用的OpenTable的方法，可以实现行增长，还可以循环使用原模板Table区域（B4:F13）单元格样式。
    <div style="width: 1000px; height: 700px;">
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
