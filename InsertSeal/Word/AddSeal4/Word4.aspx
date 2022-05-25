<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Word4.aspx.cs" Inherits="InsertSeal_Word_AddSeal4_Word4" %>

<!DOCTYPE html>
<html>
	<head>
		<title>4.编辑模版 - 在模版中添加盖章位置</title>
		<meta http-equiv="pragma" content="no-cache">
		<meta http-equiv="cache-control" content="no-cache">
		<meta http-equiv="expires" content="0">
		<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
		<meta http-equiv="description" content="This is my page">
	</head>
	<body>
		<br />
			<script type="text/javascript">
			    function Save() {
			        document.getElementById("PageOfficeCtrl1").WebSave();

			    }

			    function InsertSealPos() {
			        try {
			            document.getElementById("PageOfficeCtrl1").ZoomSeal.AddSealPosition();
			        } catch (e) { };
			    }
			</script>
	 <form id="form1" runat="server">
       <div style="width:auto; height: 700px;" >
        <%=PageOfficeCtrl1.GetHtmlCode("PageOfficeCtrl1")%>
       </div>
    </form>
	</body>

</html>
