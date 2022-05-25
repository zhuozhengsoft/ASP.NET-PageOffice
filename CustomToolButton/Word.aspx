<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="CustomToolButton_Word" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script type="text/javascript">
        function myTest() {
            document.getElementById("PageOfficeCtrl1").Alert("测试成功！");
        }
    </script>
    <form id="form1" runat="server">
    点击自定义工具栏中的“测试按钮”查看效果。<br />
    <img src="img/addButton.jpg" />
    <div style=" width:auto; height:700px;">
          <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
