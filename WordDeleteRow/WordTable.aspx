<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WordTable.aspx.cs" Inherits="WordDeleteRow_WordTable" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>删除Word中table中指定单元格所在行</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="color:Red">删除了table中坐标为(2,1)的单元格所在行，请在<%=FilePath%>路径下查看原模板文档。</div>
    <div style=" width:auto; height:700px;">
       <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%> 
    </div>
    </form>
</body>
</html>
