<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word2.aspx.cs" Inherits="POBrowserTopic_Word2" %>

<!DOCTYPE html>
<html>
  <head>
   <title>获取index.jsp页面传递过来的参数</title>
</head>
<body>
    <script type="text/javascript">
        function Save() {
            document.getElementById("PageOfficeCtrl1").WebSave();
        }		  
    </script>
	     
	(1)获取index.aspx用session传递过来的userName的值：<br />
	&nbsp;&nbsp;&nbsp;代码：userName = Session["userName"].ToString();<br />
	&nbsp;&nbsp;&nbsp;输出：UserName=<%=userName %><br /><br />
		
	(2)获取index.aspx用？传递过来的id的值：<br />
	&nbsp;&nbsp;&nbsp;代码： id = Request.QueryString["id"];<br />
	&nbsp;&nbsp;&nbsp;输出：id=<%=id %><br />
 
    <form id="form1" runat="server" >
    <div style=" width:auto; height:700px;">
              <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
    </div>
    </form>
</body>
</html>