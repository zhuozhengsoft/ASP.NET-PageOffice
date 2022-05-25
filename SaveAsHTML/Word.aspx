<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="SaveAsHtml_Word" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Word文件另存为HTML</title>
    <script type="text/javascript">
        function saveAsHTML() {
            document.getElementById("PageOfficeCtrl1").WebSaveAsHTML();
            document.getElementById("PageOfficeCtrl1").Alert("HTML格式的文件已经保存到服务器上。");
            window.open("doc/test.htm" + "?r=" + Math.random());
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style=" width:1000px; height:800px;">
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>
