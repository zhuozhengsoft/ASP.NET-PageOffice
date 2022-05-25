<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word2.aspx.cs" Inherits="InsertSeal_Word_AddSeal2_Word2" %>

<!DOCTYPE html>
<html>
	<head>
		<title>2.无需用户名、密码盖章</title>
		<meta http-equiv="pragma" content="no-cache">
		<meta http-equiv="cache-control" content="no-cache">
		<meta http-equiv="expires" content="0">
		<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
		<meta http-equiv="description" content="This is my page">
	</head>
	<body>
			<script type="text/javascript">
			    function Save() {
			        document.getElementById("PageOfficeCtrl1").WebSave();
			    }

			    function InsertSeal() {
			        try {
			            document.getElementById("PageOfficeCtrl1").ZoomSeal.AddSeal("李志");
			        } catch (e) { }
			    }
			</script>
	 <form id="form1" runat="server">
       <div style="width:auto; height: 700px;" >
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
       </div>
    </form>
	</body>

</html>
