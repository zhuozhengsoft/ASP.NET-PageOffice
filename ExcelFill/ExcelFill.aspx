<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ExcelFill.aspx.cs" Inherits="ExcelFill_ExcelFill" %>

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
    <form id="form1" runat="server">
    第4行的数据是使用后台程序填充进去的，请查看ExcelFill.aspx.cs的代码。
    <div style="width: auto; height: 700px;">
          <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
