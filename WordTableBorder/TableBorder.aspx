<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TableBorder.aspx.cs" Inherits="WordTableBorder_WordTableBorder" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>设置表格的边框样式和字体样式</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style=" width:auto; height:700px;">
       <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
