﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="HiddenRulars_Word" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>显示/隐藏Word文件中的标尺</title>
        <script type="text/javascript">
           //显示/隐藏标尺
            function Hidden() {
                document.getElementById("PageOfficeCtrl1").Document.ActiveWindow.ActivePane.DisplayRulers = 
                !document.getElementById("PageOfficeCtrl1").Document.ActiveWindow.ActivePane.DisplayRulers;
            } 
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style=" width:auto; height:700px;">
       <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
