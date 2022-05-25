<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word3.aspx.cs" Inherits="POBrowserTopic_Word3" %>

<!DOCTYPE html>
<html>
  <head>
   <title>主页面传递参数到子页面</title>
       <script type="text/javascript">
          function Save() {
              document.getElementById("PageOfficeCtrl1").WebSave();
               window.external.close();
        }
         </script>
</head>
<body>
              获取index.aspx中第一个文本框中的值：<br />
			  代码：txt=Session["txt"];<br />
			  输出：<%=txt %><br /><br />
    <form id="form1" runat="server" >
    <div style=" width:auto; height:700px;">
         <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>