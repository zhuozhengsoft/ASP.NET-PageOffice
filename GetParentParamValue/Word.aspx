<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word.aspx.cs" Inherits="GetParentParamValue_Word" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
<title>父页面给子页面传递参数</title>
    <script type="text/javascript">
    function AfterDocumentOpened(){
        //使用getArgument()方法获取openWindowModeless()的第三个参数的值
        var userName=window.external.UserParams;  
        document.getElementById("userName").value=userName;
     }
    </script>  
</head>
<body>
    <div>
    <font color="red">父页面传递过来的参数:</font><input type="text" id="userName" name="userName"/>
    </div>
   <form id="form1" runat="server">
    <div style=" width:auto; height:700px;">
       <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>  
    </div>
    </form>
</body>
</html>

