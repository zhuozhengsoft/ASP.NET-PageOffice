﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Compose2.aspx.cs" Inherits="ExaminationPaper_Compose2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <a href="#"  onclick="window.external.close();">返回列表页</a>
    <form id="form1" runat="server">
    <div style="width: 100%; height: 700px;">
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
