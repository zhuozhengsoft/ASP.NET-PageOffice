<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OpenWord.aspx.cs" Inherits="ReadOnly_OpenWord" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>在线打开Word文件</title>
</head>
<body>
    <script type="text/javascript">
        function AfterDocumentOpened() {
            document.getElementById("PageOfficeCtrl1").SetEnableFileCommand(4, false);  //禁止另存
            document.getElementById("PageOfficeCtrl1").SetEnableFileCommand(5, false);  //禁止打印
            document.getElementById("PageOfficeCtrl1").SetEnableFileCommand(6, false);  //禁止页面设置
            document.getElementById("PageOfficeCtrl1").SetEnableFileCommand(8, false);  //禁止打印预览
        }
    </script>
    <form id="form1" runat="server">
    <div style="width:auto; height: 700px;" >
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>
