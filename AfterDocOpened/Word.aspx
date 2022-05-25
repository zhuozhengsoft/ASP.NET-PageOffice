<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="CustomToolButton_Word" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script type="text/javascript">
        function AfterDocumentOpened() {
            // 打开文件的时候，给word中当前光标位置赋值一个文本值
            document.getElementById("PageOfficeCtrl1").Document.Application.Selection.Range.Text = "文件打开了";
        }
    </script>
    <form id="form1" runat="server">
    Word中的"<span style=" color:Red;"> 文件打开了</span>" 是在文档打开的事件中用程序添加进去的。<br /><br />
    <div style=" width:auto; height:700px;">
         <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
