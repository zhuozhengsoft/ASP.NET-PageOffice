﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateTable.aspx.cs" Inherits="WordCreateTable_CreateTable" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Word中动态创建表格</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div style=" width:auto; height:700px;">
         <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </div>
    </form>
</body>
</html>
