<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OpenWord.aspx.cs" Inherits="OpenWord_OpenWord" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>在线打开Word文件</title>
</head>
<body>   
    <form id="form1" runat="server">
    <div style="width:auto; height: 700px;" >
         <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>
