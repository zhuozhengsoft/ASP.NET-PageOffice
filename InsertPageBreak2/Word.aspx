﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="InsertPageBreak2_Word" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>使用服务器端的方法给当前word文档插入分页符</title>
</head>
<body>
    <script type="text/javascript">
        function Save(){
            document.getElementById("PageOfficeCtrl1").WebSave();
            if(document.getElementById("PageOfficeCtrl1").CustomSaveResult=="ok"){
            alert("保存成功！请在/Samples4/InsertPageBreak2/doc目录下查看合并后的新文档\"test3.doc\"。");
            }
        }
    </script>
    <form id="form1" runat="server">
    <div style=" width:auto; height:700px;">
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>
