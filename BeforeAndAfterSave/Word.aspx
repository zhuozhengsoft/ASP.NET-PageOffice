﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="CustomToolButton_Word" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>文档保存前和保存后执行的事件</title>
</head>
<body>
    <script type="text/javascript">
        function BeforeDocumentSaved() {
            document.getElementById("PageOfficeCtrl1").Alert("BeforeDocumentSaved事件：文件就要开始保存了.");
            return true;
        }

        function AfterDocumentSaved(IsSaved) {
            if (IsSaved) {
                document.getElementById("PageOfficeCtrl1").Alert("AfterDocumentSaved事件：文件保存成功了.");
            }
        }
    </script>
    <form id="form1" runat="server">
    演示: 文档保存前和保存后执行的事件。 <br /><br />
    <div style=" width:auto; height:700px;">
       <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
