<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="InsertSeal_Word_BatchAddSeal__Edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
            function Save() {
                document.getElementById("PageOfficeCtrl1").WebSave();
            }
    </script>
</head>
<body>
    <a href="Default.aspx">返回列表页</a>
    <form id="form1" runat="server">
    <div  style="width:auto; height:900px;">
       <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>
